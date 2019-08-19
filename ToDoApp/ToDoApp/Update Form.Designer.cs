namespace ToDoApp
{
    partial class Update_Form
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
            this.goBackBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // goBackBtn
            // 
            this.goBackBtn.Location = new System.Drawing.Point(12, 12);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(25, 25);
            this.goBackBtn.TabIndex = 8;
            this.goBackBtn.Text = "<";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 70);
            this.textBox1.MaxLength = 350;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 50);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_Click);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "hh:mm:ss";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(362, 138);
            this.timePicker.MaximumSize = new System.Drawing.Size(74, 25);
            this.timePicker.MinimumSize = new System.Drawing.Size(74, 25);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(74, 25);
            this.timePicker.TabIndex = 11;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(137, 192);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(299, 36);
            this.UpdateBtn.TabIndex = 12;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // datePicker
            // 
            this.datePicker.AllowDrop = true;
            this.datePicker.Checked = false;
            this.datePicker.CustomFormat = "yyyy-mm-dd";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(137, 138);
            this.datePicker.MaximumSize = new System.Drawing.Size(219, 25);
            this.datePicker.MinimumSize = new System.Drawing.Size(219, 25);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowUpDown = true;
            this.datePicker.Size = new System.Drawing.Size(219, 25);
            this.datePicker.TabIndex = 10;
            this.datePicker.Value = new System.DateTime(2019, 6, 19, 0, 0, 0, 0);
            // 
            // Update_Form
            // 
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.goBackBtn);
            this.Name = "Update_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo List";
            this.Load += new System.EventHandler(this.Update_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}