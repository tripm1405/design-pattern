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
    public partial class invoiceHistoryCus : Form
    {
        public invoiceHistoryCus()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            (new Home()).Show();
            this.Hide();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            (new Cart()).Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            (new Profile()).Show();
            this.Hide();
        }

        private void invoiceHistoryCus_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string INVOICE_DETAIL =
                "SELECT invoice, SUM(amount*price) AS price " +
                "FROM InvoiceDetail " +
                "GROUP BY invoice";

            string query =
                "SELECT I.code, I.customer, ID.price, I.create_at " +
                "FROM Invoice I " +
                "JOIN ( " +
                    INVOICE_DETAIL +
                ") ID ON ID.invoice = I.code " +
                "WHERE customer = @customer";

            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@customer", Global.account.phone);
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

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];

                Global.invoiceID = int.Parse(row.Cells[0].Value.ToString());
                (new InvoiceDetailCus()).Show();
                this.Hide();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }
    }
}
