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
    public partial class CustomerManager : Form
    {
        public CustomerManager()
        {
            InitializeComponent();
        }

        private void loadData()
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

        private void warehouseButton_Click(object sender, EventArgs e)
        {
            (new Warehouse()).Show();
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

        private void invoiceHítoryButton_Click(object sender, EventArgs e)
        {
            (new InvoiceHistoryManger()).Show();
            this.Hide();
        }

        private void CustomerManager_Load(object sender, EventArgs e)
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
