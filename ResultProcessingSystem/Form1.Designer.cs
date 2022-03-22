namespace ResultProcessingSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.showInfoList = new System.Windows.Forms.ListBox();
            this.searchByIDTextBox = new System.Windows.Forms.TextBox();
            this.searchByIDLabel = new System.Windows.Forms.Label();
            this.searchByIDButton = new System.Windows.Forms.Button();
            this.attendanceLabel = new System.Windows.Forms.Label();
            this.quiz1Label = new System.Windows.Forms.Label();
            this.quiz2Label = new System.Windows.Forms.Label();
            this.quiz3Label = new System.Windows.Forms.Label();
            this.quiz4Label = new System.Windows.Forms.Label();
            this.quizTotallabel = new System.Windows.Forms.Label();
            this.midLabel = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.vivaLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.totalMarksLabel = new System.Windows.Forms.Label();
            this.preparedByLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IUT Result Processing System";
            // 
            // showInfoList
            // 
            this.showInfoList.FormattingEnabled = true;
            this.showInfoList.Items.AddRange(new object[] {
            "            Course Name: Object Oriented Concepts I                   "});
            this.showInfoList.Location = new System.Drawing.Point(25, 52);
            this.showInfoList.Name = "showInfoList";
            this.showInfoList.Size = new System.Drawing.Size(271, 342);
            this.showInfoList.TabIndex = 1;
            // 
            // searchByIDTextBox
            // 
            this.searchByIDTextBox.Location = new System.Drawing.Point(483, 55);
            this.searchByIDTextBox.Name = "searchByIDTextBox";
            this.searchByIDTextBox.Size = new System.Drawing.Size(146, 20);
            this.searchByIDTextBox.TabIndex = 2;
            // 
            // searchByIDLabel
            // 
            this.searchByIDLabel.AutoSize = true;
            this.searchByIDLabel.Location = new System.Drawing.Point(398, 58);
            this.searchByIDLabel.Name = "searchByIDLabel";
            this.searchByIDLabel.Size = new System.Drawing.Size(61, 13);
            this.searchByIDLabel.TabIndex = 3;
            this.searchByIDLabel.Text = "Student ID:";
            // 
            // searchByIDButton
            // 
            this.searchByIDButton.Location = new System.Drawing.Point(518, 92);
            this.searchByIDButton.Name = "searchByIDButton";
            this.searchByIDButton.Size = new System.Drawing.Size(87, 23);
            this.searchByIDButton.TabIndex = 4;
            this.searchByIDButton.Text = "Search By ID";
            this.searchByIDButton.UseVisualStyleBackColor = true;
            this.searchByIDButton.Click += new System.EventHandler(this.searchByIDOnClick);
            // 
            // attendanceLabel
            // 
            this.attendanceLabel.AutoSize = true;
            this.attendanceLabel.Location = new System.Drawing.Point(341, 123);
            this.attendanceLabel.Name = "attendanceLabel";
            this.attendanceLabel.Size = new System.Drawing.Size(68, 13);
            this.attendanceLabel.TabIndex = 5;
            this.attendanceLabel.Text = "Attendance: ";
            // 
            // quiz1Label
            // 
            this.quiz1Label.AutoSize = true;
            this.quiz1Label.Location = new System.Drawing.Point(345, 153);
            this.quiz1Label.Name = "quiz1Label";
            this.quiz1Label.Size = new System.Drawing.Size(40, 13);
            this.quiz1Label.TabIndex = 6;
            this.quiz1Label.Text = "Quiz 1:";
            // 
            // quiz2Label
            // 
            this.quiz2Label.AutoSize = true;
            this.quiz2Label.Location = new System.Drawing.Point(345, 178);
            this.quiz2Label.Name = "quiz2Label";
            this.quiz2Label.Size = new System.Drawing.Size(40, 13);
            this.quiz2Label.TabIndex = 7;
            this.quiz2Label.Text = "Quiz 2:";
            // 
            // quiz3Label
            // 
            this.quiz3Label.AutoSize = true;
            this.quiz3Label.Location = new System.Drawing.Point(345, 204);
            this.quiz3Label.Name = "quiz3Label";
            this.quiz3Label.Size = new System.Drawing.Size(40, 13);
            this.quiz3Label.TabIndex = 8;
            this.quiz3Label.Text = "Quiz 3:";
            // 
            // quiz4Label
            // 
            this.quiz4Label.AutoSize = true;
            this.quiz4Label.Location = new System.Drawing.Point(345, 230);
            this.quiz4Label.Name = "quiz4Label";
            this.quiz4Label.Size = new System.Drawing.Size(40, 13);
            this.quiz4Label.TabIndex = 9;
            this.quiz4Label.Text = "Quiz 4:";
            // 
            // quizTotallabel
            // 
            this.quizTotallabel.AutoSize = true;
            this.quizTotallabel.Location = new System.Drawing.Point(353, 252);
            this.quizTotallabel.Name = "quizTotallabel";
            this.quizTotallabel.Size = new System.Drawing.Size(97, 13);
            this.quizTotallabel.TabIndex = 10;
            this.quizTotallabel.Text = "Quiz Total (Best 3):";
            // 
            // midLabel
            // 
            this.midLabel.AutoSize = true;
            this.midLabel.Location = new System.Drawing.Point(353, 276);
            this.midLabel.Name = "midLabel";
            this.midLabel.Size = new System.Drawing.Size(27, 13);
            this.midLabel.TabIndex = 11;
            this.midLabel.Text = "Mid:";
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Location = new System.Drawing.Point(353, 298);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(32, 13);
            this.finalLabel.TabIndex = 12;
            this.finalLabel.Text = "Final:";
            // 
            // vivaLabel
            // 
            this.vivaLabel.AutoSize = true;
            this.vivaLabel.Location = new System.Drawing.Point(353, 323);
            this.vivaLabel.Name = "vivaLabel";
            this.vivaLabel.Size = new System.Drawing.Size(31, 13);
            this.vivaLabel.TabIndex = 13;
            this.vivaLabel.Text = "Viva:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(356, 393);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(39, 13);
            this.gradeLabel.TabIndex = 14;
            this.gradeLabel.Text = "Grade:";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new System.Drawing.Point(353, 364);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(65, 13);
            this.percentageLabel.TabIndex = 15;
            this.percentageLabel.Text = "Percentage:";
            // 
            // totalMarksLabel
            // 
            this.totalMarksLabel.AutoSize = true;
            this.totalMarksLabel.Location = new System.Drawing.Point(345, 351);
            this.totalMarksLabel.Name = "totalMarksLabel";
            this.totalMarksLabel.Size = new System.Drawing.Size(91, 13);
            this.totalMarksLabel.TabIndex = 16;
            this.totalMarksLabel.Text = "Total (out of 300):";
            // 
            // preparedByLabel
            // 
            this.preparedByLabel.AutoSize = true;
            this.preparedByLabel.Location = new System.Drawing.Point(600, 381);
            this.preparedByLabel.Name = "preparedByLabel";
            this.preparedByLabel.Size = new System.Drawing.Size(68, 13);
            this.preparedByLabel.TabIndex = 17;
            this.preparedByLabel.Text = "Prepared By:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.preparedByLabel);
            this.Controls.Add(this.totalMarksLabel);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.vivaLabel);
            this.Controls.Add(this.finalLabel);
            this.Controls.Add(this.midLabel);
            this.Controls.Add(this.quizTotallabel);
            this.Controls.Add(this.quiz4Label);
            this.Controls.Add(this.quiz3Label);
            this.Controls.Add(this.quiz2Label);
            this.Controls.Add(this.quiz1Label);
            this.Controls.Add(this.attendanceLabel);
            this.Controls.Add(this.searchByIDButton);
            this.Controls.Add(this.searchByIDLabel);
            this.Controls.Add(this.searchByIDTextBox);
            this.Controls.Add(this.showInfoList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox showInfoList;
        private System.Windows.Forms.TextBox searchByIDTextBox;
        private System.Windows.Forms.Label searchByIDLabel;
        private System.Windows.Forms.Button searchByIDButton;
        private System.Windows.Forms.Label attendanceLabel;
        private System.Windows.Forms.Label quiz1Label;
        private System.Windows.Forms.Label quiz2Label;
        private System.Windows.Forms.Label quiz3Label;
        private System.Windows.Forms.Label quiz4Label;
        private System.Windows.Forms.Label quizTotallabel;
        private System.Windows.Forms.Label midLabel;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Label vivaLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Label totalMarksLabel;
        private System.Windows.Forms.Label preparedByLabel;
    }
}

