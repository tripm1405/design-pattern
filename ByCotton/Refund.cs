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
    public partial class Refund : Form
    {
        public Refund()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            try
            {
                SqlConnection cn = new SqlConnection(Global.DATABASE);
                cn.Open();

                string query =
                    "SELECT I.invoice, P.name, R.amount, R.price, R.create_at " +
                    "FROM Refund R " +
                    "JOIN InvoiceDetail I ON I.refund = R.code " +
                    "JOIN Product P ON P.code = I.product";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Refund");
                dataGridView.DataSource = ds.Tables["Refund"].DefaultView;

                cn.Close();

                dataGridView.Columns[0].HeaderText = "Mã";
                dataGridView.Columns[1].HeaderText = "Tên sản phẩm";
                dataGridView.Columns[2].HeaderText = "Số lượng";
                dataGridView.Columns[3].HeaderText = "Tổng tiền";
                dataGridView.Columns[4].HeaderText = "Ngày tạo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

                Logger.GetInstance().write(ex);
            }
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            (new Invoice()).Show();
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

        private void Refund_Load(object sender, EventArgs e)
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
