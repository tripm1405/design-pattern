using System.Windows.Forms;

namespace ByCotton
{
    partial class Warehouse
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.clearProductButton = new System.Windows.Forms.Button();
            this.doneProductButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.warehouseButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.turnoverButton = new System.Windows.Forms.Button();
            this.refundButton = new System.Windows.Forms.Button();
            this.invoiceHítoryButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.imageButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
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
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Green;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(25, 75);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(105, 28);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "SỬA SP";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(25, 109);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowHeadersWidth = 51;
            this.productsDataGridView.RowTemplate.Height = 24;
            this.productsDataGridView.Size = new System.Drawing.Size(531, 340);
            this.productsDataGridView.TabIndex = 3;
            // 
            // clearProductButton
            // 
            this.clearProductButton.BackColor = System.Drawing.Color.Green;
            this.clearProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clearProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.clearProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearProductButton.ForeColor = System.Drawing.Color.White;
            this.clearProductButton.Location = new System.Drawing.Point(691, 421);
            this.clearProductButton.Name = "clearProductButton";
            this.clearProductButton.Size = new System.Drawing.Size(95, 28);
            this.clearProductButton.TabIndex = 15;
            this.clearProductButton.Text = "ĐẶT LẠI";
            this.clearProductButton.UseVisualStyleBackColor = false;
            this.clearProductButton.Click += new System.EventHandler(this.clearProductButton_Click);
            // 
            // doneProductButton
            // 
            this.doneProductButton.BackColor = System.Drawing.Color.Green;
            this.doneProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.doneProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.doneProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneProductButton.ForeColor = System.Drawing.Color.White;
            this.doneProductButton.Location = new System.Drawing.Point(792, 421);
            this.doneProductButton.Name = "doneProductButton";
            this.doneProductButton.Size = new System.Drawing.Size(96, 28);
            this.doneProductButton.TabIndex = 14;
            this.doneProductButton.Text = "THÊM SP";
            this.doneProductButton.UseVisualStyleBackColor = false;
            this.doneProductButton.Click += new System.EventHandler(this.doneProductButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "GIÁ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "SỐ LƯỢNG:";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceNumericUpDown.Location = new System.Drawing.Point(691, 383);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(197, 22);
            this.priceNumericUpDown.TabIndex = 11;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(691, 346);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(197, 22);
            this.amountNumericUpDown.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(691, 308);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(197, 22);
            this.nameTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "TÊN:";
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.Color.Red;
            this.deleteProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductButton.ForeColor = System.Drawing.Color.White;
            this.deleteProductButton.Location = new System.Drawing.Point(136, 75);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(105, 28);
            this.deleteProductButton.TabIndex = 16;
            this.deleteProductButton.Text = "XÓA SP";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // warehouseButton
            // 
            this.warehouseButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.warehouseButton.FlatAppearance.BorderSize = 0;
            this.warehouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warehouseButton.ForeColor = System.Drawing.Color.White;
            this.warehouseButton.Location = new System.Drawing.Point(3, 3);
            this.warehouseButton.Name = "warehouseButton";
            this.warehouseButton.Size = new System.Drawing.Size(75, 40);
            this.warehouseButton.TabIndex = 17;
            this.warehouseButton.Text = "KHO";
            this.warehouseButton.UseVisualStyleBackColor = false;
            // 
            // customerButton
            // 
            this.customerButton.BackColor = System.Drawing.Color.Gray;
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.ForeColor = System.Drawing.Color.White;
            this.customerButton.Location = new System.Drawing.Point(84, 3);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(126, 40);
            this.customerButton.TabIndex = 18;
            this.customerButton.Text = "KHÁCH HÀNG";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
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
            this.flowLayoutPanel1.TabIndex = 19;
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(784, 46);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // turnoverButton
            // 
            this.turnoverButton.BackColor = System.Drawing.Color.Gray;
            this.turnoverButton.FlatAppearance.BorderSize = 0;
            this.turnoverButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.turnoverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnoverButton.ForeColor = System.Drawing.Color.White;
            this.turnoverButton.Location = new System.Drawing.Point(216, 3);
            this.turnoverButton.Name = "turnoverButton";
            this.turnoverButton.Size = new System.Drawing.Size(126, 40);
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
            this.refundButton.Location = new System.Drawing.Point(348, 3);
            this.refundButton.Name = "refundButton";
            this.refundButton.Size = new System.Drawing.Size(126, 40);
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
            this.invoiceHítoryButton.Location = new System.Drawing.Point(480, 3);
            this.invoiceHítoryButton.Name = "invoiceHítoryButton";
            this.invoiceHítoryButton.Size = new System.Drawing.Size(175, 40);
            this.invoiceHítoryButton.TabIndex = 21;
            this.invoiceHítoryButton.Text = "LỊCH SỬ HÓA ĐƠN";
            this.invoiceHítoryButton.UseVisualStyleBackColor = false;
            this.invoiceHítoryButton.Click += new System.EventHandler(this.invoiceHítoryButton_Click);
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
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(691, 109);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // imageButton
            // 
            this.imageButton.BackColor = System.Drawing.Color.Green;
            this.imageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.imageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.imageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageButton.ForeColor = System.Drawing.Color.White;
            this.imageButton.Location = new System.Drawing.Point(691, 265);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(150, 28);
            this.imageButton.TabIndex = 21;
            this.imageButton.Text = "CHỌN ẢNH";
            this.imageButton.UseVisualStyleBackColor = false;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 464);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.clearProductButton);
            this.Controls.Add(this.doneProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.editButton);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.Shown += new System.EventHandler(this.Warehouse_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private Button clearProductButton;
        private Button doneProductButton;
        private Label label3;
        private Label label2;
        private NumericUpDown priceNumericUpDown;
        private NumericUpDown amountNumericUpDown;
        private TextBox nameTextBox;
        private Label label1;
        private Button deleteProductButton;
        private Button warehouseButton;
        private Button customerButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button turnoverButton;
        private Button refundButton;
        private Button invoiceHítoryButton;
        private PictureBox pictureBox;
        private Button imageButton;
        private OpenFileDialog openFileDialog;
    }
}