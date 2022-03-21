namespace Banking_System
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
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.accountNoTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.accTypeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameeTextbox = new System.Windows.Forms.TextBox();
            this.createAccountComboBox = new System.Windows.Forms.ComboBox();
            this.actionCombobox = new System.Windows.Forms.ComboBox();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkAccNoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.showTransactionListbox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(106, 32);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameTextbox.TabIndex = 0;
            // 
            // accountNoTextBox
            // 
            this.accountNoTextBox.Location = new System.Drawing.Point(356, 72);
            this.accountNoTextBox.Name = "accountNoTextBox";
            this.accountNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountNoTextBox.TabIndex = 3;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(106, 69);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(26, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(25, 72);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(64, 13);
            this.contactLabel.TabIndex = 7;
            this.contactLabel.Text = "Contact No:";
            // 
            // accTypeLabel
            // 
            this.accTypeLabel.AutoSize = true;
            this.accTypeLabel.Location = new System.Drawing.Point(26, 113);
            this.accTypeLabel.Name = "accTypeLabel";
            this.accTypeLabel.Size = new System.Drawing.Size(77, 13);
            this.accTypeLabel.TabIndex = 8;
            this.accTypeLabel.Text = "Account Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Account No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Account Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Action:";
            // 
            // nameeTextbox
            // 
            this.nameeTextbox.Location = new System.Drawing.Point(356, 32);
            this.nameeTextbox.Name = "nameeTextbox";
            this.nameeTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameeTextbox.TabIndex = 13;
            // 
            // createAccountComboBox
            // 
            this.createAccountComboBox.FormattingEnabled = true;
            this.createAccountComboBox.Items.AddRange(new object[] {
            "SAVINGS",
            "LOAN",
            "CURRENT"});
            this.createAccountComboBox.Location = new System.Drawing.Point(109, 109);
            this.createAccountComboBox.Name = "createAccountComboBox";
            this.createAccountComboBox.Size = new System.Drawing.Size(121, 21);
            this.createAccountComboBox.TabIndex = 14;
            // 
            // actionCombobox
            // 
            this.actionCombobox.FormattingEnabled = true;
            this.actionCombobox.Items.AddRange(new object[] {
            "DEPOSIT",
            "WITHDRAW",
            "LOAN"});
            this.actionCombobox.Location = new System.Drawing.Point(356, 148);
            this.actionCombobox.Name = "actionCombobox";
            this.actionCombobox.Size = new System.Drawing.Size(121, 21);
            this.actionCombobox.TabIndex = 15;
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Items.AddRange(new object[] {
            "SAVINGS",
            "LOAN",
            "CURRENT"});
            this.accountTypeComboBox.Location = new System.Drawing.Point(356, 110);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.accountTypeComboBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Account No:";
            // 
            // checkAccNoTextBox
            // 
            this.checkAccNoTextBox.Location = new System.Drawing.Point(604, 35);
            this.checkAccNoTextBox.Name = "checkAccNoTextBox";
            this.checkAccNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.checkAccNoTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createAccountOnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Transaction";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.transactionOnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(604, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Account Information";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.accountInfoOnClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(604, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Transaction History";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // showTransactionListbox
            // 
            this.showTransactionListbox.FormattingEnabled = true;
            this.showTransactionListbox.Location = new System.Drawing.Point(534, 148);
            this.showTransactionListbox.Name = "showTransactionListbox";
            this.showTransactionListbox.Size = new System.Drawing.Size(225, 251);
            this.showTransactionListbox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "Amount:\r\n\r\n";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(356, 184);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showTransactionListbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkAccNoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.accountTypeComboBox);
            this.Controls.Add(this.actionCombobox);
            this.Controls.Add(this.createAccountComboBox);
            this.Controls.Add(this.nameeTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accTypeLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.accountNoTextBox);
            this.Controls.Add(this.nameTextbox);
            this.Name = "Form1";
            this.Text = "BANKING SYSTEM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox accountNoTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label accTypeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameeTextbox;
        private System.Windows.Forms.ComboBox createAccountComboBox;
        private System.Windows.Forms.ComboBox actionCombobox;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox checkAccNoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox showTransactionListbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amountTextBox;
    }
}

