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
    public partial class InvoiceHistory : Form
    {
        public InvoiceHistory()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            string INVOICE_DETAIL =
                "SELECT invoice, SUM(amount*price) AS price " +
                "FROM InvoiceDetail " + 
                "GROUP BY invoice";

            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();

            string query =
                "SELECT I.code, I.customer, ID.price, I.create_at " +
                "FROM Invoice I " +
                "JOIN ( " +
                    INVOICE_DETAIL +
                ") ID ON ID.invoice = I.code";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Account");
            dataGridView.DataSource = ds.Tables["Account"].DefaultView;

            cn.Close();

            dataGridView.Columns[0].HeaderText = "Mã";
            dataGridView.Columns[1].HeaderText = "Khách hàng";
            dataGridView.Columns[2].HeaderText = "Tổng tiền";
            dataGridView.Columns[3].HeaderText = "Ngày tạo";
        }

        private void InvoiceHistory_Load(object sender, EventArgs e)
        {
            loadData();
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

                Global.invoiceID = int.Parse(row.Cells[0].Value.ToString());
                (new InvoiceDetail()).Show();
                this.Hide();
            }
        }
    }
}
