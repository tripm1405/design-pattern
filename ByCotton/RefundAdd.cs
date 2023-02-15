using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ByCotton
{
    public partial class RefundAdd : Form
    {
        public int code;
        public RefundAdd(int code, int amount, int total)
        {
            InitializeComponent();

            amountNumericUpDown.Value = amount;
            priceNumericUpDown.Value = total;
            amountNumericUpDown.Maximum = amount;
            amountNumericUpDown.Minimum = 1;
            this.code = code;
        }

        private void RefundAdd_Load(object sender, EventArgs e)
        {
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string query;
            SqlConnection cn = new SqlConnection(Global.DATABASE);
            SqlCommand cmd;

            query =
                "INSERT INTO Refund (amount, price, create_at) VALUES " +
                "(@amount, @price, GETDATE())";
            cn.Open();
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@amount", amountNumericUpDown.Value);
            cmd.Parameters.AddWithValue("@price", priceNumericUpDown.Value);
            cmd.ExecuteReader().Close();

            query =
                "SELECT code " +
                "FROM Refund " +
                "ORDER BY code DESC";
            cmd = new SqlCommand(query, cn);
            SqlDataReader r = cmd.ExecuteReader();
            r.Read();

            int refund = r.GetInt32(0);

            r.Close();

            query =
                "UPDATE InvoiceDetail " +
                "SET refund = @refund " +
                "WHERE code = @code";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@refund", refund);
            cmd.ExecuteReader().Close();

            cn.Close();

            MessageBox.Show("TRẢ HÀNG THÀNH CÔNG!");
            this.Hide();
        }
    }
}
