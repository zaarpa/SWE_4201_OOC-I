namespace EMPLOYEE
{
    partial class Form1
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
            this.newEmployeeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.hiringDateLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newEmployeeListBox
            // 
            this.newEmployeeListBox.FormattingEnabled = true;
            this.newEmployeeListBox.Location = new System.Drawing.Point(30, 51);
            this.newEmployeeListBox.Name = "newEmployeeListBox";
            this.newEmployeeListBox.Size = new System.Drawing.Size(314, 368);
            this.newEmployeeListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee ID:";
            // 
            // searchIDTextBox
            // 
            this.searchIDTextBox.Location = new System.Drawing.Point(477, 42);
            this.searchIDTextBox.Name = "searchIDTextBox";
            this.searchIDTextBox.Size = new System.Drawing.Size(167, 20);
            this.searchIDTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchOnClick);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(447, 146);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(450, 182);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID:";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(450, 288);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(39, 13);
            this.salaryLabel.TabIndex = 8;
            this.salaryLabel.Text = "Salary:";
            // 
            // hiringDateLabel
            // 
            this.hiringDateLabel.AutoSize = true;
            this.hiringDateLabel.Location = new System.Drawing.Point(450, 252);
            this.hiringDateLabel.Name = "hiringDateLabel";
            this.hiringDateLabel.Size = new System.Drawing.Size(63, 13);
            this.hiringDateLabel.TabIndex = 9;
            this.hiringDateLabel.Text = "Hiring Date:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(450, 216);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(76, 13);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Email Address:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.hiringDateLabel);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newEmployeeListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox newEmployeeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchIDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label hiringDateLabel;
        private System.Windows.Forms.Label addressLabel;
    }
}

