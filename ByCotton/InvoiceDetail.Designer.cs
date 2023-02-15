namespace ByCotton
{
    partial class InvoiceDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.invoiceButton = new System.Windows.Forms.Button();
            this.refundButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.invoiceHistoryButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(900, 46);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.invoiceButton);
            this.flowLayoutPanel2.Controls.Add(this.refundButton);
            this.flowLayoutPanel2.Controls.Add(this.customerButton);
            this.flowLayoutPanel2.Controls.Add(this.invoiceHistoryButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(784, 46);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // invoiceButton
            // 
            this.invoiceButton.BackColor = System.Drawing.Color.Gray;
            this.invoiceButton.FlatAppearance.BorderSize = 0;
            this.invoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoiceButton.ForeColor = System.Drawing.Color.White;
            this.invoiceButton.Location = new System.Drawing.Point(3, 3);
            this.invoiceButton.Name = "invoiceButton";
            this.invoiceButton.Size = new System.Drawing.Size(103, 40);
            this.invoiceButton.TabIndex = 17;
            this.invoiceButton.Text = "HÓA ĐƠN";
            this.invoiceButton.UseVisualStyleBackColor = false;
            this.invoiceButton.Click += new System.EventHandler(this.invoiceButton_Click);
            // 
            // refundButton
            // 
            this.refundButton.BackColor = System.Drawing.Color.Gray;
            this.refundButton.FlatAppearance.BorderSize = 0;
            this.refundButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refundButton.ForeColor = System.Drawing.Color.White;
            this.refundButton.Location = new System.Drawing.Point(112, 3);
            this.refundButton.Name = "refundButton";
            this.refundButton.Size = new System.Drawing.Size(126, 40);
            this.refundButton.TabIndex = 18;
            this.refundButton.Text = "TRẢ HÀNG";
            this.refundButton.UseVisualStyleBackColor = false;
            this.refundButton.Click += new System.EventHandler(this.refundButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.BackColor = System.Drawing.Color.Gray;
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.ForeColor = System.Drawing.Color.White;
            this.customerButton.Location = new System.Drawing.Point(244, 3);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(126, 40);
            this.customerButton.TabIndex = 19;
            this.customerButton.Text = "KHÁCH HÀNG";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // invoiceHistoryButton
            // 
            this.invoiceHistoryButton.BackColor = System.Drawing.Color.Gray;
            this.invoiceHistoryButton.FlatAppearance.BorderSize = 0;
            this.invoiceHistoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.invoiceHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoiceHistoryButton.ForeColor = System.Drawing.Color.White;
            this.invoiceHistoryButton.Location = new System.Drawing.Point(376, 3);
            this.invoiceHistoryButton.Name = "invoiceHistoryButton";
            this.invoiceHistoryButton.Size = new System.Drawing.Size(176, 40);
            this.invoiceHistoryButton.TabIndex = 31;
            this.invoiceHistoryButton.Text = "LỊCH SỬ HÓA ĐƠN";
            this.invoiceHistoryButton.UseVisualStyleBackColor = false;
            this.invoiceHistoryButton.Click += new System.EventHandler(this.invoiceHistoryButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.logoutButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(784, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(113, 46);
            this.flowLayoutPanel3.TabIndex = 21;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Gray;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(3, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(109, 40);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "ĐĂNG XUẤT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 59);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(876, 379);
            this.dataGridView.TabIndex = 25;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "InvoiceDetail";
            this.Text = "InvoiceDetail";
            this.Load += new System.EventHandler(this.InvoiceDetail_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button invoiceButton;
        private System.Windows.Forms.Button refundButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button invoiceHistoryButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}