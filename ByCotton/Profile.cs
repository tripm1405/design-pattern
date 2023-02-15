using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByCotton
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Home()).Show();
            this.Hide();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            (new Cart()).Show();
            this.Hide();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            (new ChangePassword()).Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = Global.account.username;
            nameLabel.Text = Global.account.name;
            genderLabel.Text = (bool) Global.account.gender ? "Nam" : "Nữ";
            emailLabel.Text = Global.account.email;
            addressLabel.Text = Global.account.address;
            phoneLabel.Text = Global.account.phone;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            (new ProfileEdit()).Show();
            this.Hide();
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            (new invoiceHistoryCus()).Show();
            this.Hide();
        }
    }
}
