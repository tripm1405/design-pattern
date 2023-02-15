using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByCotton
{
    public partial class InvoiceDetail : Form
    {
        public InvoiceDetail()
        {
            InitializeComponent();
        }

        private void InvoiceDetail_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query =
                "SELECT id.code, p.name, id.amount, id.price, (id.amount * id.price) AS total " +
                "FROM InvoiceDetail id " +
                "JOIN Product p ON p.code = id.product " +
                "WHERE invoice = @invoice ";

            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@invoice", Global.invoiceID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "InvoiceDetail");
            dataGridView.DataSource = ds.Tables["InvoiceDetail"].DefaultView;

            cn.Close();

            dataGridView.Columns[0].HeaderText = "Mã";
            dataGridView.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView.Columns[2].HeaderText = "Số lượng";
            dataGridView.Columns[3].HeaderText = "Đơn giá";
            dataGridView.Columns[4].HeaderText = "Tổng giá";
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            (new Invoice()).Show();
            this.Hide();
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

        private void invoiceHistoryButton_Click(object sender, EventArgs e)
        {
            (new InvoiceHistory()).Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                int code = int.Parse(row.Cells[0].Value.ToString());
                int amount = int.Parse(row.Cells[2].Value.ToString());
                int total = amount * int.Parse(row.Cells[3].Value.ToString());

                (new RefundAdd(code, amount, total)).Show();
            }
        }
    }
}
