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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPassword = oldPasswordTextBox.Text;
                string newPassword = newPasswordTextBox.Text;
                string rePassword = rePasswordTextBox.Text;

                Validation valid = new Validation();

                Boolean flag = true;

                flag &= valid.checkSpace(oldPassword);
                if (flag == false)
                {
                    MessageBox.Show("Hãy nhập mật khẩu cũ!");
                    return;
                }

                flag &= valid.checkSpace(newPassword);
                if (flag == false)
                {
                    MessageBox.Show("Hãy nhập mật khẩu mới!");
                    return;
                }
                flag &= valid.checkLength(newPassword);
                if (flag == false)
                {
                    MessageBox.Show("Mật khẩu có độ dài quá ngắn!");
                    return;
                }
                flag &= valid.checkSpace(rePassword);
                if (flag == false)
                {
                    MessageBox.Show("Hãy nhập mật khẩu mới xác nhận!");
                    return;
                }


                if (!newPassword.Equals(rePassword))
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!");
                    return;
                }

                string query;
                SqlCommand cmd;

                SqlConnection cn = new SqlConnection(Global.DATABASE);
                cn.Open();

                query =
                    "SELECT * " +
                    "FROM Account " +
                    "WHERE username = @username " +
                    "AND password = @oldPassword";

                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@username", Global.account.username);
                cmd.Parameters.AddWithValue("@oldPassword", oldPassword);
                SqlDataReader r = cmd.ExecuteReader();

                if (!r.Read())
                {
                    MessageBox.Show("MẬT KHẨU CŨ KHÔNG CHÍNH XÁC");
                    return;
                }
                r.Close();

                query =
                    "UPDATE Account " +
                    "SET password = @newPassword " +
                    "WHERE username = @username";

                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.Parameters.AddWithValue("@username", Global.account.username);
                cmd.ExecuteReader().Close(); ;

                cn.Close();

                MessageBox.Show("ĐỔI MẬT KHẨU THÀNH CÔNG!");

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

                Logger.GetInstance().write(ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void oldPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
