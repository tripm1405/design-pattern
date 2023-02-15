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
    public partial class Customer : Form
    {
        public Customer()
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
                    "SELECT C.phone, A.username, A.email, A.name, A.address " +
                    "FROM Account A " +
                    "RIGHT JOIN Customer C ON C.account = A.username";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Account");
                dataGridView.DataSource = ds.Tables["Account"].DefaultView;

                cn.Close();

                dataGridView.Columns[0].HeaderText = "Số điện thoại";
                dataGridView.Columns[1].HeaderText = "Tài khoản";
                dataGridView.Columns[2].HeaderText = "Email";
                dataGridView.Columns[3].HeaderText = "Tên";
                dataGridView.Columns[4].HeaderText = "Địa chỉ";
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

        private void refundButton_Click(object sender, EventArgs e)
        {
            (new Refund()).Show();
            this.Hide();
        }

        private void invoiceHistoryButton_Click(object sender, EventArgs e)
        {
            (new InvoiceHistory()).Show();
            this.Hide();
        }

        private void Customer_Load(object sender, EventArgs e)
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
