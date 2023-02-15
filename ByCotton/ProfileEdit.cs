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
    public partial class ProfileEdit : Form
    {
        public ProfileEdit()
        {
            InitializeComponent();
        }

        private void ProfileEdit_Load(object sender, EventArgs e)
        {
            setData();
        }

        private void setData()
        {
            nameTextBox.Text = Global.account.name;
            (((bool)Global.account.gender) ? maleRadioButton: femaleRadioButton).Checked = true;
            emailTextBox.Text = Global.account.email;
            addressTextBox.Text = Global.account.address;
            phoneTextBox.Text = Global.account.phone;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            setData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            Nullable<bool> gender = null;
            foreach (RadioButton rdo in genderGroupBox.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    gender = rdo.Text.Equals("NAM");
                    break;
                }
            }
            string address = addressTextBox.Text;
            string phone = phoneTextBox.Text;

            if (password.Equals("") ||
                name.Equals("") ||
                email.Equals("") ||
                gender == null ||
                address.Equals("") ||
                phone.Equals(""))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }

            string query;
            SqlCommand cmd;
            SqlDataReader r;

            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();

            query =
                "SELECT * " +
                "FROM Account " +
                "WHERE username = @username " +
                "AND password = @password";

            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@username", Global.account.username);
            cmd.Parameters.AddWithValue("@password", password);
            r = cmd.ExecuteReader();

            if (!r.Read())
            {
                MessageBox.Show("MẬT KHẨU KHÔNG CHÍNH XÁC");
                return;
            }
            r.Close();

            query =
                "SELECT * " +
                "FROM Customer " +
                "WHERE phone = @phone";

            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@phone", phone);
            r = cmd.ExecuteReader();

            if (!r.Read())
            {
                r.Close();
                query =
                    "UPDATE Customer " +
                    "SET account = NULL " +
                    "WHERE phone = @phone";

                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.ExecuteReader().Close();

                query =
                    "INSERT INTO Customer (phone, account) VALUES " +
                    "(@phone, @account)";

                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@account", Global.account.username);
                cmd.ExecuteReader().Close();
            }
            r.Close();

            query =
                "UPDATE Account " +
                "SET email = @email, name = @name, gender = @gender, address = @address " +
                "WHERE username = @username";

            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@username", Global.account.username);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.ExecuteReader().Close();

            cn.Close();

            Global.account.name = name;
            Global.account.email = email;
            Global.account.gender = gender;
            Global.account.address = address;
            Global.account.phone = phone;

            MessageBox.Show("CHỈNH SỬA THÀNH CÔNG!");

            (new Profile()).Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            (new Profile()).Show();
            this.Hide();
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
