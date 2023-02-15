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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            loadData();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }

        private void loadData()
        {
            try
            {
                string query =
                    "SELECT code, name, image " +
                    "FROM Product " +
                    "WHERE amount > 0";

                SqlConnection cn = new SqlConnection(Global.DATABASE);
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataReader r = cmd.ExecuteReader();

                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(200, 200);
                listView.LargeImageList = imageList;
                while (r.Read())
                {
                    string code = r.GetInt32(0).ToString();

                    imageList.Images.Add(code, Image.FromFile(Global.IMAGE_PATH + r.GetString(2)));

                    ListViewItem listViewItem0 = listView.Items.Add(new ListViewItem(r.GetString(1)));
                    listViewItem0.ImageKey = code;
                }

                r.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

                Logger.GetInstance().write(ex);
            }
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

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            (new ProductDetail(listView.SelectedItems[0].ImageKey)).Show();
            this.Hide();
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            (new invoiceHistoryCus()).Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
