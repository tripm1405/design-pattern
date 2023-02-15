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
    public partial class Turnover : Form
    {
        public Turnover()
        {
            InitializeComponent();
        }

        private string get_total_d(string d)
        {

            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();

            string query = "SELECT * FROM dbo.turnover_d(@d)";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@d", d);
            SqlDataReader r = cmd.ExecuteReader();
            r.Read();

            string result = r.GetInt32(0).ToString();

            r.Close();

            cn.Close();

            return result;
        }

        private string get_total_s(string s, string e)
        { 
            SqlConnection cn = new SqlConnection(Global.DATABASE);
            cn.Open();

            string query = "SELECT * FROM dbo.turnover_s(@s, @e)";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@s", s);
            cmd.Parameters.AddWithValue("@e", e);
            SqlDataReader r = cmd.ExecuteReader();
            r.Read();

            string result = r.GetInt32(0).ToString();

            r.Close();

            cn.Close();

            return result;
        }

        private void warehouseButton_Click(object sender, EventArgs e)
        {
            (new Warehouse()).Show();
            this.Hide();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            (new CustomerManager()).Show();
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

        private void yearLabel_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            yearLabel.Text = get_total_s(dateTime.ToString("yyyy") + "/01/01", dateTime.ToString("yyyy/MM/dd"));

            monthDateTimePicker.Value = dateTime.AddMonths(-1);
            monthlabel.Text = get_total_s(dateTime.AddMonths(-1).ToString("yyyy/MM") + "/01", dateTime.ToString("yyyy/MM") + "/01");

            dayLabel.Text = get_total_d(dateTime.AddDays(-1).ToString("yyyy/MM/dd"));

            day1Label.Text = dateTime.AddDays(-1).ToString("dd/MM/yyyy");
            day1ValueLabel.Text = get_total_d(dateTime.AddDays(-1).ToString("yyyy/MM/dd"));

            day2Label.Text = dateTime.AddDays(-2).ToString("dd/MM/yyyy");
            day2ValueLabel.Text = get_total_d(dateTime.AddDays(-2).ToString("yyyy/MM/dd"));

            day3Label.Text = dateTime.AddDays(-3).ToString("dd/MM/yyyy");
            day3ValueLabel.Text = get_total_d(dateTime.AddDays(-3).ToString("yyyy/MM/dd"));

            day4Label.Text = dateTime.AddDays(-4).ToString("dd/MM/yyyy");
            day4ValueLabel.Text = get_total_d(dateTime.AddDays(-4).ToString("yyyy/MM/dd"));

            day5Label.Text = dateTime.AddDays(-5).ToString("dd/MM/yyyy");
            day5ValueLabel.Text = get_total_d(dateTime.AddDays(-5).ToString("yyyy/MM/dd"));

            day6Label.Text = dateTime.AddDays(-6).ToString("dd/MM/yyyy");
            day6ValueLabel.Text = get_total_d(dateTime.AddDays(-6).ToString("yyyy/MM/dd"));

            day7Label.Text = dateTime.AddDays(-7).ToString("dd/MM/yyyy");
            day7ValueLabel.Text = get_total_d(dateTime.AddDays(-7).ToString("yyyy/MM/dd"));
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Global.account = null;
            (new Login()).Show();
            this.Hide();
        }

        private void yearDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = yearDateTimePicker.Value;
            yearLabel.Text = get_total_s(dateTime.ToString("yyyy") + "/01/01", dateTime.ToString("yyyy/MM/dd"));
        }

        private void monthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = monthDateTimePicker.Value;
            monthlabel.Text = get_total_s(dateTime.ToString("yyyy/MM") + "/01", dateTime.AddMonths(1).ToString("yyyy/MM") + "/01");
        }

        private void dayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = dayDateTimePicker.Value;
            dayLabel.Text = get_total_s(dateTime.ToString("yyyy/MM/dd"), dateTime.AddDays(1).ToString("yyyy/MM/dd"));
        }
    }
}
