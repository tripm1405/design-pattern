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
    public partial class InvoiceDetailCus : Form
    {
        public InvoiceDetailCus()
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

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            (new invoiceHistoryCus()).Show();
            this.Hide();
        }

        private void InvoiceDetailCus_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query =
                "SELECT id.code, p.name, id.amount, id.price, (id.amount * id.price) AS total " +
                "FROM InvoiceDetail id " +
                "JOIN Product p ON p.code = id.product " +
                "WHERE invoice = @invoice";

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
            dataGridView.Columns[4].HeaderText = "Tổng tiền";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }
    }
}
