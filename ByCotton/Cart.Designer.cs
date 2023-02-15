namespace ByCotton
{
    partial class Cart
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
            this.homeButton = new System.Windows.Forms.Button();
            this.cartButton = new System.Windows.Forms.Button();
            this.prodileButton = new System.Windows.Forms.Button();
            this.invoiceButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.codeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
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
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.homeButton);
            this.flowLayoutPanel2.Controls.Add(this.cartButton);
            this.flowLayoutPanel2.Controls.Add(this.prodileButton);
            this.flowLayoutPanel2.Controls.Add(this.invoiceButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(784, 46);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Gray;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(126, 40);
            this.homeButton.TabIndex = 18;
            this.homeButton.Text = "SẢN PHẨM";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cartButton.FlatAppearance.BorderSize = 0;
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.ForeColor = System.Drawing.Color.White;
            this.cartButton.Location = new System.Drawing.Point(135, 3);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(103, 40);
            this.cartButton.TabIndex = 17;
            this.cartButton.Text = "GIỎ HÀNG";
            this.cartButton.UseVisualStyleBackColor = false;
            // 
            // prodileButton
            // 
            this.prodileButton.BackColor = System.Drawing.Color.Gray;
            this.prodileButton.FlatAppearance.BorderSize = 0;
            this.prodileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prodileButton.ForeColor = System.Drawing.Color.White;
            this.prodileButton.Location = new System.Drawing.Point(244, 3);
            this.prodileButton.Name = "prodileButton";
            this.prodileButton.Size = new System.Drawing.Size(126, 40);
            this.prodileButton.TabIndex = 19;
            this.prodileButton.Text = "TÀI KHOẢN";
            this.prodileButton.UseVisualStyleBackColor = false;
            this.prodileButton.Click += new System.EventHandler(this.prodileButton_Click);
            // 
            // invoiceButton
            // 
            this.invoiceButton.BackColor = System.Drawing.Color.Gray;
            this.invoiceButton.FlatAppearance.BorderSize = 0;
            this.invoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invoiceButton.ForeColor = System.Drawing.Color.White;
            this.invoiceButton.Location = new System.Drawing.Point(376, 3);
            this.invoiceButton.Name = "invoiceButton";
            this.invoiceButton.Size = new System.Drawing.Size(103, 40);
            this.invoiceButton.TabIndex = 22;
            this.invoiceButton.Text = "HÓA ĐƠN";
            this.invoiceButton.UseVisualStyleBackColor = false;
            this.invoiceButton.Click += new System.EventHandler(this.invoiceButton_Click);
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
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeColumnHeader,
            this.nameColumnHeader,
            this.amountColumnHeader,
            this.priceColumnHeader});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 60);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(876, 303);
            this.listView.TabIndex = 24;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // codeColumnHeader
            // 
            this.codeColumnHeader.Tag = "";
            this.codeColumnHeader.Text = "Mã";
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Tên";
            this.nameColumnHeader.Width = 180;
            // 
            // amountColumnHeader
            // 
            this.amountColumnHeader.Text = "Số lượng";
            this.amountColumnHeader.Width = 120;
            // 
            // priceColumnHeader
            // 
            this.priceColumnHeader.Text = "Giá";
            this.priceColumnHeader.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "TỔNG:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(70, 377);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(51, 16);
            this.totalLabel.TabIndex = 26;
            this.totalLabel.Text = "TOTAL";
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.Green;
            this.orderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.orderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Location = new System.Drawing.Point(12, 405);
            this.orderButton.Margin = new System.Windows.Forms.Padding(0);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(226, 24);
            this.orderButton.TabIndex = 27;
            this.orderButton.Text = "ĐẶT HÀNG VỚI TIỀN MĂT";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(319, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 24);
            this.button1.TabIndex = 28;
            this.button1.Text = "ĐẶT HÀNG VỚI VÍ ĐIỆN TỬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(645, 405);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 24);
            this.button2.TabIndex = 29;
            this.button2.Text = "ĐẶT HÀNG VỚI NGÂN HÀNG";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Cart";
            this.Text = "W";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button prodileButton;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader codeColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader amountColumnHeader;
        private System.Windows.Forms.ColumnHeader priceColumnHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button invoiceButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}