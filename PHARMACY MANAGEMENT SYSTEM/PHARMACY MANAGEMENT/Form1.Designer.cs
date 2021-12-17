namespace PHARMACY_MANAGEMENT_SYSTEM
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
            this.medicineNameTextBox = new System.Windows.Forms.TextBox();
            this.medicineQuantityTextBox = new System.Windows.Forms.TextBox();
            this.soldMedicineQuantityTextBox = new System.Windows.Forms.TextBox();
            this.soldMedicineSellPriceTextBox = new System.Windows.Forms.TextBox();
            this.soldMedicineNameTextBox = new System.Windows.Forms.TextBox();
            this.medicineBuyPriceTextBox = new System.Windows.Forms.TextBox();
            this.medicineNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.medicineQuantityLabel = new System.Windows.Forms.Label();
            this.soldMedicineNameLabel = new System.Windows.Forms.Label();
            this.medicineIDLabel = new System.Windows.Forms.Label();
            this.addMedicineLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.soldMedicineQuantityLabel = new System.Windows.Forms.Label();
            this.soldMedicineSellPriceLabel = new System.Windows.Forms.Label();
            this.addMedicineButton = new System.Windows.Forms.Button();
            this.sellMedicineButton = new System.Windows.Forms.Button();
            this.showStockListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkStockMedicineNameLabel = new System.Windows.Forms.Label();
            this.stockMedicineNameTextBox = new System.Windows.Forms.TextBox();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentACBalanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // medicineNameTextBox
            // 
            this.medicineNameTextBox.Location = new System.Drawing.Point(76, 46);
            this.medicineNameTextBox.Name = "medicineNameTextBox";
            this.medicineNameTextBox.Size = new System.Drawing.Size(144, 20);
            this.medicineNameTextBox.TabIndex = 0;
            // 
            // medicineQuantityTextBox
            // 
            this.medicineQuantityTextBox.Location = new System.Drawing.Point(76, 85);
            this.medicineQuantityTextBox.Name = "medicineQuantityTextBox";
            this.medicineQuantityTextBox.Size = new System.Drawing.Size(144, 20);
            this.medicineQuantityTextBox.TabIndex = 2;
            // 
            // soldMedicineQuantityTextBox
            // 
            this.soldMedicineQuantityTextBox.Location = new System.Drawing.Point(341, 88);
            this.soldMedicineQuantityTextBox.Name = "soldMedicineQuantityTextBox";
            this.soldMedicineQuantityTextBox.Size = new System.Drawing.Size(138, 20);
            this.soldMedicineQuantityTextBox.TabIndex = 5;
            // 
            // soldMedicineSellPriceTextBox
            // 
            this.soldMedicineSellPriceTextBox.Location = new System.Drawing.Point(341, 132);
            this.soldMedicineSellPriceTextBox.Name = "soldMedicineSellPriceTextBox";
            this.soldMedicineSellPriceTextBox.Size = new System.Drawing.Size(138, 20);
            this.soldMedicineSellPriceTextBox.TabIndex = 6;
            // 
            // soldMedicineNameTextBox
            // 
            this.soldMedicineNameTextBox.Location = new System.Drawing.Point(341, 43);
            this.soldMedicineNameTextBox.Name = "soldMedicineNameTextBox";
            this.soldMedicineNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.soldMedicineNameTextBox.TabIndex = 7;
            // 
            // medicineBuyPriceTextBox
            // 
            this.medicineBuyPriceTextBox.Location = new System.Drawing.Point(76, 128);
            this.medicineBuyPriceTextBox.Name = "medicineBuyPriceTextBox";
            this.medicineBuyPriceTextBox.Size = new System.Drawing.Size(144, 20);
            this.medicineBuyPriceTextBox.TabIndex = 8;
            this.medicineBuyPriceTextBox.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // medicineNameLabel
            // 
            this.medicineNameLabel.AutoSize = true;
            this.medicineNameLabel.Location = new System.Drawing.Point(12, 49);
            this.medicineNameLabel.Name = "medicineNameLabel";
            this.medicineNameLabel.Size = new System.Drawing.Size(41, 13);
            this.medicineNameLabel.TabIndex = 9;
            this.medicineNameLabel.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // medicineQuantityLabel
            // 
            this.medicineQuantityLabel.AutoSize = true;
            this.medicineQuantityLabel.Location = new System.Drawing.Point(12, 132);
            this.medicineQuantityLabel.Name = "medicineQuantityLabel";
            this.medicineQuantityLabel.Size = new System.Drawing.Size(55, 13);
            this.medicineQuantityLabel.TabIndex = 11;
            this.medicineQuantityLabel.Text = "Buy Price:";
            // 
            // soldMedicineNameLabel
            // 
            this.soldMedicineNameLabel.AutoSize = true;
            this.soldMedicineNameLabel.Location = new System.Drawing.Point(278, 46);
            this.soldMedicineNameLabel.Name = "soldMedicineNameLabel";
            this.soldMedicineNameLabel.Size = new System.Drawing.Size(41, 13);
            this.soldMedicineNameLabel.TabIndex = 12;
            this.soldMedicineNameLabel.Text = "Name: ";
            this.soldMedicineNameLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // medicineIDLabel
            // 
            this.medicineIDLabel.AutoSize = true;
            this.medicineIDLabel.Location = new System.Drawing.Point(12, 88);
            this.medicineIDLabel.Name = "medicineIDLabel";
            this.medicineIDLabel.Size = new System.Drawing.Size(52, 13);
            this.medicineIDLabel.TabIndex = 13;
            this.medicineIDLabel.Text = "Quantity: ";
            // 
            // addMedicineLabel
            // 
            this.addMedicineLabel.AutoSize = true;
            this.addMedicineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedicineLabel.Location = new System.Drawing.Point(12, 9);
            this.addMedicineLabel.Name = "addMedicineLabel";
            this.addMedicineLabel.Size = new System.Drawing.Size(167, 25);
            this.addMedicineLabel.TabIndex = 14;
            this.addMedicineLabel.Text = "Stock Update: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sell Item: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 17;
            // 
            // soldMedicineQuantityLabel
            // 
            this.soldMedicineQuantityLabel.AutoSize = true;
            this.soldMedicineQuantityLabel.Location = new System.Drawing.Point(278, 88);
            this.soldMedicineQuantityLabel.Name = "soldMedicineQuantityLabel";
            this.soldMedicineQuantityLabel.Size = new System.Drawing.Size(52, 13);
            this.soldMedicineQuantityLabel.TabIndex = 18;
            this.soldMedicineQuantityLabel.Text = "Quantity: ";
            // 
            // soldMedicineSellPriceLabel
            // 
            this.soldMedicineSellPriceLabel.AutoSize = true;
            this.soldMedicineSellPriceLabel.Location = new System.Drawing.Point(278, 135);
            this.soldMedicineSellPriceLabel.Name = "soldMedicineSellPriceLabel";
            this.soldMedicineSellPriceLabel.Size = new System.Drawing.Size(54, 13);
            this.soldMedicineSellPriceLabel.TabIndex = 22;
            this.soldMedicineSellPriceLabel.Text = "Sell Price:";
            // 
            // addMedicineButton
            // 
            this.addMedicineButton.Location = new System.Drawing.Point(56, 202);
            this.addMedicineButton.Name = "addMedicineButton";
            this.addMedicineButton.Size = new System.Drawing.Size(123, 62);
            this.addMedicineButton.TabIndex = 23;
            this.addMedicineButton.Text = "Add Medicine";
            this.addMedicineButton.UseVisualStyleBackColor = true;
            this.addMedicineButton.Click += new System.EventHandler(this.addMedicineOnClick);
            // 
            // sellMedicineButton
            // 
            this.sellMedicineButton.Location = new System.Drawing.Point(328, 200);
            this.sellMedicineButton.Name = "sellMedicineButton";
            this.sellMedicineButton.Size = new System.Drawing.Size(127, 66);
            this.sellMedicineButton.TabIndex = 24;
            this.sellMedicineButton.Text = "Sell Medicine";
            this.sellMedicineButton.UseVisualStyleBackColor = true;
            this.sellMedicineButton.Click += new System.EventHandler(this.sellMedicineOnClick);
            // 
            // showStockListBox
            // 
            this.showStockListBox.FormattingEnabled = true;
            this.showStockListBox.Items.AddRange(new object[] {
            "Show Current Stock:"});
            this.showStockListBox.Location = new System.Drawing.Point(749, 43);
            this.showStockListBox.Name = "showStockListBox";
            this.showStockListBox.Size = new System.Drawing.Size(246, 147);
            this.showStockListBox.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 80);
            this.button1.TabIndex = 26;
            this.button1.Text = "Click To See \r\nCurrent Stock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.seeCurrentStockOnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 50);
            this.button2.TabIndex = 27;
            this.button2.Text = "Click To See Current Account Balance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.seeCurrentBalanceOnClick);
            // 
            // checkStockMedicineNameLabel
            // 
            this.checkStockMedicineNameLabel.AutoSize = true;
            this.checkStockMedicineNameLabel.Location = new System.Drawing.Point(549, 46);
            this.checkStockMedicineNameLabel.Name = "checkStockMedicineNameLabel";
            this.checkStockMedicineNameLabel.Size = new System.Drawing.Size(41, 13);
            this.checkStockMedicineNameLabel.TabIndex = 28;
            this.checkStockMedicineNameLabel.Text = "Name: ";
            // 
            // stockMedicineNameTextBox
            // 
            this.stockMedicineNameTextBox.Location = new System.Drawing.Point(617, 43);
            this.stockMedicineNameTextBox.Name = "stockMedicineNameTextBox";
            this.stockMedicineNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockMedicineNameTextBox.TabIndex = 30;
            // 
            // currentBalanceLabel
            // 
            this.currentBalanceLabel.AutoSize = true;
            this.currentBalanceLabel.Location = new System.Drawing.Point(757, 297);
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            this.currentBalanceLabel.Size = new System.Drawing.Size(35, 13);
            this.currentBalanceLabel.TabIndex = 32;
            this.currentBalanceLabel.Text = "BDT: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Show Stock: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CurrentACBalanceLabel
            // 
            this.CurrentACBalanceLabel.AutoSize = true;
            this.CurrentACBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentACBalanceLabel.Location = new System.Drawing.Point(538, 236);
            this.CurrentACBalanceLabel.Name = "CurrentACBalanceLabel";
            this.CurrentACBalanceLabel.Size = new System.Drawing.Size(189, 25);
            this.CurrentACBalanceLabel.TabIndex = 34;
            this.CurrentACBalanceLabel.Text = "Current Balance:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.CurrentACBalanceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentBalanceLabel);
            this.Controls.Add(this.stockMedicineNameTextBox);
            this.Controls.Add(this.checkStockMedicineNameLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showStockListBox);
            this.Controls.Add(this.sellMedicineButton);
            this.Controls.Add(this.addMedicineButton);
            this.Controls.Add(this.soldMedicineSellPriceLabel);
            this.Controls.Add(this.soldMedicineQuantityLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addMedicineLabel);
            this.Controls.Add(this.medicineIDLabel);
            this.Controls.Add(this.soldMedicineNameLabel);
            this.Controls.Add(this.medicineQuantityLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medicineNameLabel);
            this.Controls.Add(this.medicineBuyPriceTextBox);
            this.Controls.Add(this.soldMedicineNameTextBox);
            this.Controls.Add(this.soldMedicineSellPriceTextBox);
            this.Controls.Add(this.soldMedicineQuantityTextBox);
            this.Controls.Add(this.medicineQuantityTextBox);
            this.Controls.Add(this.medicineNameTextBox);
            this.Name = "Form1";
            this.Text = "Pharmacy Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox medicineNameTextBox;
        private System.Windows.Forms.TextBox medicineQuantityTextBox;
        private System.Windows.Forms.TextBox soldMedicineQuantityTextBox;
        private System.Windows.Forms.TextBox soldMedicineSellPriceTextBox;
        private System.Windows.Forms.TextBox soldMedicineNameTextBox;
        private System.Windows.Forms.TextBox medicineBuyPriceTextBox;
        private System.Windows.Forms.Label medicineNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label medicineQuantityLabel;
        private System.Windows.Forms.Label soldMedicineNameLabel;
        private System.Windows.Forms.Label medicineIDLabel;
        private System.Windows.Forms.Label addMedicineLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label soldMedicineQuantityLabel;
        private System.Windows.Forms.Label soldMedicineSellPriceLabel;
        private System.Windows.Forms.Button addMedicineButton;
        private System.Windows.Forms.Button sellMedicineButton;
        private System.Windows.Forms.ListBox showStockListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label checkStockMedicineNameLabel;
        private System.Windows.Forms.TextBox stockMedicineNameTextBox;
        private System.Windows.Forms.Label currentBalanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentACBalanceLabel;
    }
}

