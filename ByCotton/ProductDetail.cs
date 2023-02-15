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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ByCotton
{
    public partial class ProductDetail : Form
    {
        public string code;
        public string name;
        public string image;
        public int price;
        public ProductDetail(string code)
        {
            InitializeComponent();

            try
            {
                this.code = code;
                string query =
                    "SELECT name, image, amount, price " +
                    "FROM Product " +
                    "WHERE code = @code";

                SqlConnection cn = new SqlConnection(Global.DATABASE);
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@code", code);
                SqlDataReader r = cmd.ExecuteReader();

                if (!r.Read())
                {
                    MessageBox.Show(code);
                    return;
                }

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                int amount = r.GetInt32(2);
                this.name = r.GetString(0);
                this.price = r.GetInt32(3);
                this.image = r.GetString(1);
                numericUpDown.Maximum = amount;

                codeLabel.Text = code;
                nameLabel.Text = this.name;
                pictureBox.Image = Image.FromFile(Global.IMAGE_PATH + this.image);
                amountLabel.Text = amount.ToString();
                priceLabel.Text = this.price.ToString();
                totalLabel.Text = this.price.ToString();

                r.Close();
                cn.Close();

                if (Global.cart.ContainsKey(code))
                {
                    numericUpDown.Value = (int)Global.cart[code].amount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

                Logger.GetInstance().write(ex);
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalLabel.Text = (numericUpDown.Value * this.price).ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Global.cart.ContainsKey(this.code))
            {
                Global.cart[this.code].amount = (int) numericUpDown.Value;
            }
            else
            {
                Product product = new Product();
                product.name = this.name;
                product.amount = (int) numericUpDown.Value;
                product.price = this.price;
                product.image = this.image;

                Global.cart.Add(this.code, product);
            }

            MessageBox.Show(
                "THÊM SẢN PHẨM THÀNH CÔNG!\n" +
                "QUÝ KHÁCH CÓ THỂ TRUY CẬP GIỎ HÀNG ĐỂ THANH TOÁN SẢN PHẨM!");
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

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
