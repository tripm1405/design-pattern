using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ByCotton
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            loadData();

            invoiceDataGridView.CellValueChanged += new DataGridViewCellEventHandler(invoiceDataGridView_CellValueChanged);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }

        private void loadData()
        {
            string query = 
                "SELECT code, name, amount, price " +
                "FROM Product " +
                "WHERE amount > 0";
            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();

            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Product");
            productsDataGridView.DataSource = ds.Tables["Product"].DefaultView;

            cn.Close();

            productsDataGridView.Columns[0].HeaderText = "Mã";
            productsDataGridView.Columns[1].HeaderText = "Tên";
            productsDataGridView.Columns[2].HeaderText = "Số lượng";
            productsDataGridView.Columns[3].HeaderText = "Giá";
        }

        private void refundButton_Click(object sender, EventArgs e)
        {
            (new Refund()).Show();
            this.Hide();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            (new Customer()).Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int selectedRowCount = productsDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount <= 0)
            {
                return;
            }

            DataGridViewRow clone;
            int rowID;
            DataGridViewRow row;
            bool iscontain;
            for (int i = 0; i < selectedRowCount; i++)
            {
                clone = productsDataGridView.SelectedRows[i];

                iscontain = true;
                for (int j = 0; j < invoiceDataGridView.Rows.Count; j++)
                {
                    row = invoiceDataGridView.Rows[j];
                    if (int.Parse(clone.Cells[0].Value.ToString()) == int.Parse(invoiceDataGridView.Rows[j].Cells[0].Value.ToString()))
                    {
                        iscontain = false;
                        break;
                    }
                }

                if (iscontain)
                {
                    rowID = invoiceDataGridView.Rows.Add(new string[] {
                        clone.Cells[0].Value.ToString(),
                        clone.Cells[1].Value.ToString(),
                        "1",
                        clone.Cells[3].Value.ToString()
                    });

                    invoiceDataGridView.Rows[rowID].Cells[2].ReadOnly = false;
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int selectedRowCount = invoiceDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount <= 0)
            {
                return;
            }

            for (int i = selectedRowCount - 1; i >= 0; i--)
            {
                invoiceDataGridView.Rows.RemoveAt(i);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            invoiceDataGridView.Rows.Clear();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int rowCount = invoiceDataGridView.Rows.Count;

            if ( !(rowCount > 0) )
            {
                MessageBox.Show("HÓA ĐƠN CHƯA CÓ SẢN PHẨM!");
                return;
            }

            string phone = phoneTextBox.Text.Trim();

            if ( !(phone.Length > 0) )
            {
                MessageBox.Show("CHƯA NHẬP SỐ ĐIỆN THOẠI!");
                return;
            }

            SqlDataReader r;
            SqlCommand cmd;
            string query;

            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();

            query =
                "SELECT * " +
                "FROM Customer " + 
                "WHERE phone = @phone";

            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@phone", phone);

            r = cmd.ExecuteReader();
            if ( !r.Read() )
            {
                r.Close();

                query =
                    "INSERT INTO Customer (phone) VALUES " +
                    "(@phone)";

                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@phone", phone);

                cmd.ExecuteReader().Close();
            }
            r.Close();

            query =
                "SELECT COUNT(*) " +
                "FROM Invoice";

            cmd = new SqlCommand(query, cn);

            r = cmd.ExecuteReader();
            r.Read();
            string invoice = (r.GetInt32(0) + 1).ToString();
            r.Close();

            query =
                "INSERT INTO Invoice (code, customer, create_at) VALUES " +
                "(@code, @customer, GETDATE())";

            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@code", invoice);
            cmd.Parameters.AddWithValue("@customer", phone);
            cmd.ExecuteReader().Close();

            DataGridViewRow row;
            for (int i = 0; i < rowCount; i++)
            {
                row = invoiceDataGridView.Rows[i];

                query =
                    "INSERT INTO InvoiceDetail(invoice, product, amount, price, refund) VALUES " +
                    "(@invoice, @product, @amount, @price, NULL)";

                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@invoice", invoice);
                cmd.Parameters.AddWithValue("@product", row.Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@amount", int.Parse(row.Cells[2].Value.ToString()));
                cmd.Parameters.AddWithValue("@price", int.Parse(row.Cells[3].Value.ToString()));
                cmd.ExecuteReader().Close();
            }

            cn.Close();

            MessageBox.Show("GHI HÓA ĐƠN THÀNH CÔNG!");

            invoiceDataGridView.Rows.Clear();
        }

        private void invoiceHistoryButton_Click(object sender, EventArgs e)
        {
            (new InvoiceHistory()).Show();
            this.Hide();
        }

        private void invoiceDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int codeCurr = int.Parse(invoiceDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            int amountCurr = int.Parse(invoiceDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());

            DataGridViewRow row;
            int amount;
            for (int i = 0; i < productsDataGridView.Rows.Count; i++)
            {
                row = productsDataGridView.Rows[i];

                if (int.Parse(row.Cells[0].Value.ToString()) == codeCurr)
                {
                    amount = int.Parse(row.Cells[2].Value.ToString());
                    if (amount < amountCurr) {
                        invoiceDataGridView.Rows[e.RowIndex].Cells[2].Value = amount;
                    }
                    return;
                }
            }
        }
    }
}
