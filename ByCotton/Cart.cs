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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ByCotton
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            (new Home()).Show(); 
            this.Hide();
        }

        private void prodileButton_Click(object sender, EventArgs e)
        {
            (new Profile()).Show();
            this.Hide();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            int total = 0;
            foreach (KeyValuePair<string, Product> kvp in Global.cart)
            {
                Product product = kvp.Value;
                listView.Items.Add(new ListViewItem(new string[] {
                    kvp.Key,
                    product.name,
                    product.amount.ToString(),
                    product.price.ToString() }));
                total += product.price * product.amount;
            }
            totalLabel.Text = total.ToString();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            (new ProductDetail(listView.SelectedItems[0].SubItems[0].Text)).Show();
            this.Hide();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            order();
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            (new invoiceHistoryCus()).Show();
            this.Hide();
        }

        private void order()
        {
            SqlCommand cmd;
            string query;

            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();

            query =
                "SELECT COUNT(*) " +
                "FROM Invoice";

            cmd = new SqlCommand(query, cn);

            SqlDataReader r = cmd.ExecuteReader();
            r.Read();
            string invoice = (r.GetInt32(0) + 1).ToString();
            r.Close();

            query =
                "INSERT INTO Invoice (code, customer, create_at) VALUES " +
                "(@code, @customer, GETDATE())";

            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@code", invoice);
            cmd.Parameters.AddWithValue("@customer", Global.account.phone);
            cmd.ExecuteReader().Close();

            foreach (ListViewItem item in listView.Items)
            {
                query =
                    "INSERT INTO InvoiceDetail(invoice, product, amount, price, refund) VALUES " +
                    "(@invoice, @product, @amount, @price, NULL)";

                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@invoice", invoice);
                cmd.Parameters.AddWithValue("@product", item.SubItems[0].Text);
                cmd.Parameters.AddWithValue("@amount", int.Parse(item.SubItems[2].Text));
                cmd.Parameters.AddWithValue("@price", int.Parse(item.SubItems[3].Text));
                cmd.ExecuteReader().Close();
            }

            cn.Close();

            Global.cart.Clear();
            MessageBox.Show("ĐẶT HÀNG THÀNH CÔNG!\nSẢN PHẨM SẼ ĐƯỢC CHUYỂN TỚI TRONG VÒNG 3 NGÀY!");
            (new Home()).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order();
        }
    }
}
