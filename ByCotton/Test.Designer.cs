namespace ByCotton
{
    partial class Test
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
            this.button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.yearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.monthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.testButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Green;
            this.button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(12, 12);
            this.button.Margin = new System.Windows.Forms.Padding(0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 24);
            this.button.TabIndex = 0;
            this.button.Text = "CLICK";
            this.button.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(192, 161);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panel1.Size = new System.Drawing.Size(264, 15);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(8, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 15);
            this.textBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(588, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(588, 218);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(90, 23);
            this.uploadButton.TabIndex = 3;
            this.uploadButton.Text = "UPLOAD";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(698, 218);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(90, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(9, 425);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(44, 16);
            this.pathLabel.TabIndex = 5;
            this.pathLabel.Text = "PATH";
            // 
            // yearDateTimePicker
            // 
            this.yearDateTimePicker.Checked = false;
            this.yearDateTimePicker.CustomFormat = "yyyy";
            this.yearDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearDateTimePicker.Location = new System.Drawing.Point(12, 258);
            this.yearDateTimePicker.Name = "yearDateTimePicker";
            this.yearDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.yearDateTimePicker.TabIndex = 6;
            // 
            // monthDateTimePicker
            // 
            this.monthDateTimePicker.CustomFormat = "MM/yyyy";
            this.monthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthDateTimePicker.Location = new System.Drawing.Point(12, 286);
            this.monthDateTimePicker.Name = "monthDateTimePicker";
            this.monthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.monthDateTimePicker.TabIndex = 7;
            // 
            // dayDateTimePicker
            // 
            this.dayDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dayDateTimePicker.Location = new System.Drawing.Point(13, 315);
            this.dayDateTimePicker.Name = "dayDateTimePicker";
            this.dayDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dayDateTimePicker.TabIndex = 8;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(13, 344);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 9;
            this.testButton.Text = "CLICK";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.dayDateTimePicker);
            this.Controls.Add(this.monthDateTimePicker);
            this.Controls.Add(this.yearDateTimePicker);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.DateTimePicker yearDateTimePicker;
        private System.Windows.Forms.DateTimePicker monthDateTimePicker;
        private System.Windows.Forms.DateTimePicker dayDateTimePicker;
        private System.Windows.Forms.Button testButton;
    }
}