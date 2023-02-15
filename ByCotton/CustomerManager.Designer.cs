namespace ByCotton
{
    partial class CustomerManager
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
            this.warehouseButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.turnoverButton = new System.Windows.Forms.Button();
            this.refundButton = new System.Windows.Forms.Button();
            this.invoiceHítoryButton = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(675, 37);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.warehouseButton);
            this.flowLayoutPanel2.Controls.Add(this.customerButton);
            this.flowLayoutPanel2.Controls.Add(this.turnoverButton);
            this.flowLayoutPanel2.Controls.Add(this.refundButton);
            this.flowLayoutPanel2.Controls.Add(this.invoiceHítoryButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(588, 37);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // warehouseButton
            // 
            this.warehouseButton.BackColor = System.Drawing.Color.Gray;
            this.warehouseButton.FlatAppearance.BorderSize = 0;
            this.warehouseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.warehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warehouseButton.ForeColor = System.Drawing.Color.White;
            this.warehouseButton.Location = new System.Drawing.Point(2, 2);
            this.warehouseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.warehouseButton.Name = "warehouseButton";
            this.warehouseButton.Size = new System.Drawing.Size(56, 32);
            this.warehouseButton.TabIndex = 17;
            this.warehouseButton.Text = "KHO";
            this.warehouseButton.UseVisualStyleBackColor = false;
            this.warehouseButton.Click += new System.EventHandler(this.warehouseButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.ForeColor = System.Drawing.Color.White;
            this.customerButton.Location = new System.Drawing.Point(62, 2);
            this.customerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(94, 32);
            this.customerButton.TabIndex = 18;
            this.customerButton.Text = "KHÁCH HÀNG";
            this.customerButton.UseVisualStyleBackColor = false;
            // 
            // turnoverButton
            // 
            this.turnoverButton.BackColor = System.Drawing.Color.Gray;
            this.turnoverButton.FlatAppearance.BorderSize = 0;
            this.turnoverButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.turnoverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnoverButton.ForeColor = System.Drawing.Color.White;
            this.turnoverButton.Location = new System.Drawing.Point(160, 2);
            this.turnoverButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.turnoverButton.Name = "turnoverButton";
            this.turnoverButton.Size = new System.Drawing.Size(94, 32);
            this.turnoverButton.TabIndex = 19;
            this.turnoverButton.Text = "DOANH THU";
            this.turnoverButton.UseVisualStyleBackColor = false;
            this.turnoverButton.Click += new System.EventHandler(this.turnoverButton_Click);
            // 
            // refundButton
            // 
            this.refundButton.BackColor = System.Drawing.Color.Gray;
            this.refundButton.FlatAppearance.BorderSize = 0;
            this.refundButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refundButton.ForeColor = System.Drawing.Color.White;
            this.refundButton.Location = new System.Drawing.Point(258, 2);
            this.refundButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refundButton.Name = "refundButton";
            this.refundButton.Size = new System.Drawing.Size(94, 32);
            this.refundButton.TabIndex = 20;
            this.refundButton.Text = "TRẢ HÀNG";
            this.refundButton.UseVisualStyleBackColor = false;
            this.refundButton.Click += new System.EventHandler(this.refundButton_Click);
            // 
            // invoiceHítoryButton
            // 
            this.invoiceHítoryButton.BackColor = System.Drawing.Color.Gray;
            this.invoiceHítoryButton.FlatAppearance.BorderSize = 0;
            this.invoiceHítoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.invoiceHítoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoiceHítoryButton.ForeColor = System.Drawing.Color.White;
            this.invoiceHítoryButton.Location = new System.Drawing.Point(356, 2);
            this.invoiceHítoryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invoiceHítoryButton.Name = "invoiceHítoryButton";
            this.invoiceHítoryButton.Size = new System.Drawing.Size(131, 32);
            this.invoiceHítoryButton.TabIndex = 22;
            this.invoiceHítoryButton.Text = "LỊCH SỬ HÓA ĐƠN";
            this.invoiceHítoryButton.UseVisualStyleBackColor = false;
            this.invoiceHítoryButton.Click += new System.EventHandler(this.invoiceHítoryButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.logoutButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(588, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(85, 37);
            this.flowLayoutPanel3.TabIndex = 21;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Gray;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(2, 2);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(82, 32);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "ĐĂNG XUẤT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(9, 50);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(657, 306);
            this.dataGridView.TabIndex = 21;
            // 
            // CustomerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 366);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerManager";
            this.Text = "CustomerManager";
            this.Load += new System.EventHandler(this.CustomerManager_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button warehouseButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button turnoverButton;
        private System.Windows.Forms.Button refundButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button invoiceHítoryButton;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}