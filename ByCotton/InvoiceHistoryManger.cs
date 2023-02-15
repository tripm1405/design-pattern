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
    public partial class InvoiceHistoryManger : Form
    {
        public InvoiceHistoryManger()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("error");

                Logger.GetInstance().write(ex);
            }
        }

        private void warehouseButton_Click(object sender, EventArgs e)
        {
            (new Warehouse()).Show();
            this.Hide();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            (new CustomerManager()).Show();
            this.Hide();
        }

        private void turnoverButton_Click(object sender, EventArgs e)
        {
            (new Turnover()).Show();
            this.Hide();
        }

        private void refundButton_Click(object sender, EventArgs e)
        {
            (new RefundManager()).Show();
            this.Hide();
        }

        private void InvoiceHistoryManger_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }
    }
}
