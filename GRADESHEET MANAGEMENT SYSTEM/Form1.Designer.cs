namespace LabAssignment
{
    partial class GradesApp
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
            this.StudentInformation = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.studentidTextBox = new System.Windows.Forms.TextBox();
            this.studentidLabel = new System.Windows.Forms.Label();
            this.semesterTextBox = new System.Windows.Forms.TextBox();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.calculategradeTextBox = new System.Windows.Forms.Button();
            this.MarksBOX = new System.Windows.Forms.Label();
            this.midTextBox = new System.Windows.Forms.TextBox();
            this.attendedclassesTextBox = new System.Windows.Forms.TextBox();
            this.finalTextBox = new System.Windows.Forms.TextBox();
            this.quizITextBox = new System.Windows.Forms.TextBox();
            this.quizIIITextBox = new System.Windows.Forms.TextBox();
            this.quizIITextBox = new System.Windows.Forms.TextBox();
            this.quizIVTextBox = new System.Windows.Forms.TextBox();
            this.attendedclassesLabel = new System.Windows.Forms.Label();
            this.midLabel = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.quizILabel = new System.Windows.Forms.Label();
            this.quizIILabel = new System.Windows.Forms.Label();
            this.quizIIILabel = new System.Windows.Forms.Label();
            this.quizIVLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.attendanceLabel = new System.Windows.Forms.Label();
            this.midmarksLabel = new System.Windows.Forms.Label();
            this.quizLabel = new System.Windows.Forms.Label();
            this.finalmarksLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentInformation
            // 
            this.StudentInformation.AutoSize = true;
            this.StudentInformation.Cursor = System.Windows.Forms.Cursors.Default;
            this.StudentInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInformation.ForeColor = System.Drawing.Color.LightGray;
            this.StudentInformation.Location = new System.Drawing.Point(12, 9);
            this.StudentInformation.Name = "StudentInformation";
            this.StudentInformation.Size = new System.Drawing.Size(224, 25);
            this.StudentInformation.TabIndex = 0;
            this.StudentInformation.Text = "Student Information ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(106, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(162, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.nameLabel.Location = new System.Drawing.Point(39, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name ";
            this.nameLabel.Click += new System.EventHandler(this.Name_Click);
            // 
            // studentidTextBox
            // 
            this.studentidTextBox.Location = new System.Drawing.Point(106, 98);
            this.studentidTextBox.Name = "studentidTextBox";
            this.studentidTextBox.Size = new System.Drawing.Size(162, 20);
            this.studentidTextBox.TabIndex = 3;
            // 
            // studentidLabel
            // 
            this.studentidLabel.AutoSize = true;
            this.studentidLabel.ForeColor = System.Drawing.Color.LightGray;
            this.studentidLabel.Location = new System.Drawing.Point(19, 101);
            this.studentidLabel.Name = "studentidLabel";
            this.studentidLabel.Size = new System.Drawing.Size(58, 13);
            this.studentidLabel.TabIndex = 4;
            this.studentidLabel.Text = "Student ID";
            // 
            // semesterTextBox
            // 
            this.semesterTextBox.Location = new System.Drawing.Point(106, 141);
            this.semesterTextBox.Name = "semesterTextBox";
            this.semesterTextBox.Size = new System.Drawing.Size(162, 20);
            this.semesterTextBox.TabIndex = 5;
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.ForeColor = System.Drawing.Color.LightGray;
            this.semesterLabel.Location = new System.Drawing.Point(26, 141);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(51, 13);
            this.semesterLabel.TabIndex = 6;
            this.semesterLabel.Text = "Semester";
            this.semesterLabel.Click += new System.EventHandler(this.Semester_Click);
            // 
            // calculategradeTextBox
            // 
            this.calculategradeTextBox.BackColor = System.Drawing.Color.DimGray;
            this.calculategradeTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calculategradeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculategradeTextBox.ForeColor = System.Drawing.Color.Yellow;
            this.calculategradeTextBox.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calculategradeTextBox.Location = new System.Drawing.Point(389, 81);
            this.calculategradeTextBox.Name = "calculategradeTextBox";
            this.calculategradeTextBox.Size = new System.Drawing.Size(103, 59);
            this.calculategradeTextBox.TabIndex = 7;
            this.calculategradeTextBox.Text = "Calculate \r\nGrade";
            this.calculategradeTextBox.UseVisualStyleBackColor = false;
            this.calculategradeTextBox.Click += new System.EventHandler(this.CalculateGrade_Click);
            // 
            // MarksBOX
            // 
            this.MarksBOX.AutoSize = true;
            this.MarksBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarksBOX.ForeColor = System.Drawing.Color.LightGray;
            this.MarksBOX.Location = new System.Drawing.Point(15, 179);
            this.MarksBOX.Name = "MarksBOX";
            this.MarksBOX.Size = new System.Drawing.Size(278, 25);
            this.MarksBOX.TabIndex = 8;
            this.MarksBOX.Text = "SWE 4201 OOC - I Marks";
            // 
            // midTextBox
            // 
            this.midTextBox.Location = new System.Drawing.Point(106, 271);
            this.midTextBox.Name = "midTextBox";
            this.midTextBox.Size = new System.Drawing.Size(162, 20);
            this.midTextBox.TabIndex = 9;
            this.midTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // attendedclassesTextBox
            // 
            this.attendedclassesTextBox.Location = new System.Drawing.Point(106, 223);
            this.attendedclassesTextBox.Name = "attendedclassesTextBox";
            this.attendedclassesTextBox.Size = new System.Drawing.Size(162, 20);
            this.attendedclassesTextBox.TabIndex = 10;
            // 
            // finalTextBox
            // 
            this.finalTextBox.ForeColor = System.Drawing.Color.Black;
            this.finalTextBox.Location = new System.Drawing.Point(106, 319);
            this.finalTextBox.Name = "finalTextBox";
            this.finalTextBox.Size = new System.Drawing.Size(162, 20);
            this.finalTextBox.TabIndex = 11;
            this.finalTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // quizITextBox
            // 
            this.quizITextBox.Location = new System.Drawing.Point(367, 223);
            this.quizITextBox.Name = "quizITextBox";
            this.quizITextBox.Size = new System.Drawing.Size(162, 20);
            this.quizITextBox.TabIndex = 12;
            // 
            // quizIIITextBox
            // 
            this.quizIIITextBox.Location = new System.Drawing.Point(367, 315);
            this.quizIIITextBox.Name = "quizIIITextBox";
            this.quizIIITextBox.Size = new System.Drawing.Size(162, 20);
            this.quizIIITextBox.TabIndex = 13;
            // 
            // quizIITextBox
            // 
            this.quizIITextBox.Location = new System.Drawing.Point(367, 267);
            this.quizIITextBox.Name = "quizIITextBox";
            this.quizIITextBox.Size = new System.Drawing.Size(162, 20);
            this.quizIITextBox.TabIndex = 14;
            // 
            // quizIVTextBox
            // 
            this.quizIVTextBox.Location = new System.Drawing.Point(367, 363);
            this.quizIVTextBox.Name = "quizIVTextBox";
            this.quizIVTextBox.Size = new System.Drawing.Size(162, 20);
            this.quizIVTextBox.TabIndex = 15;
            // 
            // attendedclassesLabel
            // 
            this.attendedclassesLabel.AutoSize = true;
            this.attendedclassesLabel.ForeColor = System.Drawing.Color.LightGray;
            this.attendedclassesLabel.Location = new System.Drawing.Point(5, 223);
            this.attendedclassesLabel.Name = "attendedclassesLabel";
            this.attendedclassesLabel.Size = new System.Drawing.Size(95, 26);
            this.attendedclassesLabel.TabIndex = 16;
            this.attendedclassesLabel.Text = "No. of attended \r\nclasses (Out of 28)";
            // 
            // midLabel
            // 
            this.midLabel.AutoSize = true;
            this.midLabel.ForeColor = System.Drawing.Color.LightGray;
            this.midLabel.Location = new System.Drawing.Point(19, 274);
            this.midLabel.Name = "midLabel";
            this.midLabel.Size = new System.Drawing.Size(77, 13);
            this.midLabel.TabIndex = 17;
            this.midLabel.Text = "Mid (Out of 75)";
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.ForeColor = System.Drawing.Color.LightGray;
            this.finalLabel.Location = new System.Drawing.Point(8, 322);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(88, 13);
            this.finalLabel.TabIndex = 18;
            this.finalLabel.Text = "Final (Out of 150)";
            // 
            // quizILabel
            // 
            this.quizILabel.AutoSize = true;
            this.quizILabel.ForeColor = System.Drawing.Color.LightGray;
            this.quizILabel.Location = new System.Drawing.Point(274, 226);
            this.quizILabel.Name = "quizILabel";
            this.quizILabel.Size = new System.Drawing.Size(87, 13);
            this.quizILabel.TabIndex = 19;
            this.quizILabel.Text = "Quiz I (Out of 15)";
            // 
            // quizIILabel
            // 
            this.quizIILabel.AutoSize = true;
            this.quizIILabel.ForeColor = System.Drawing.Color.LightGray;
            this.quizIILabel.Location = new System.Drawing.Point(274, 271);
            this.quizIILabel.Name = "quizIILabel";
            this.quizIILabel.Size = new System.Drawing.Size(90, 13);
            this.quizIILabel.TabIndex = 20;
            this.quizIILabel.Text = "Quiz II (Out of 15)";
            this.quizIILabel.Click += new System.EventHandler(this.QuizIIBOX_Click);
            // 
            // quizIIILabel
            // 
            this.quizIIILabel.AutoSize = true;
            this.quizIIILabel.ForeColor = System.Drawing.Color.LightGray;
            this.quizIIILabel.Location = new System.Drawing.Point(271, 318);
            this.quizIIILabel.Name = "quizIIILabel";
            this.quizIIILabel.Size = new System.Drawing.Size(93, 13);
            this.quizIIILabel.TabIndex = 21;
            this.quizIIILabel.Text = "Quiz III (Out of 15)";
            this.quizIIILabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // quizIVLabel
            // 
            this.quizIVLabel.AutoSize = true;
            this.quizIVLabel.ForeColor = System.Drawing.Color.LightGray;
            this.quizIVLabel.Location = new System.Drawing.Point(271, 366);
            this.quizIVLabel.Name = "quizIVLabel";
            this.quizIVLabel.Size = new System.Drawing.Size(94, 13);
            this.quizIVLabel.TabIndex = 22;
            this.quizIVLabel.Text = "Quiz IV (Out of 15)";
            this.quizIVLabel.Click += new System.EventHandler(this.QuizIVBOX_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(566, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 5);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(554, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(549, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(5, 350);
            this.label3.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(573, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Obtained Marks";
            // 
            // attendanceLabel
            // 
            this.attendanceLabel.AutoSize = true;
            this.attendanceLabel.ForeColor = System.Drawing.Color.LightGray;
            this.attendanceLabel.Location = new System.Drawing.Point(575, 60);
            this.attendanceLabel.Name = "attendanceLabel";
            this.attendanceLabel.Size = new System.Drawing.Size(65, 13);
            this.attendanceLabel.TabIndex = 27;
            this.attendanceLabel.Text = "Attendance:";
            this.attendanceLabel.Click += new System.EventHandler(this.attendanceLabel_Click);
            // 
            // midmarksLabel
            // 
            this.midmarksLabel.AutoSize = true;
            this.midmarksLabel.ForeColor = System.Drawing.Color.LightGray;
            this.midmarksLabel.Location = new System.Drawing.Point(613, 81);
            this.midmarksLabel.Name = "midmarksLabel";
            this.midmarksLabel.Size = new System.Drawing.Size(27, 13);
            this.midmarksLabel.TabIndex = 28;
            this.midmarksLabel.Text = "Mid:";
            // 
            // quizLabel
            // 
            this.quizLabel.AutoSize = true;
            this.quizLabel.ForeColor = System.Drawing.Color.LightGray;
            this.quizLabel.Location = new System.Drawing.Point(609, 105);
            this.quizLabel.Name = "quizLabel";
            this.quizLabel.Size = new System.Drawing.Size(31, 13);
            this.quizLabel.TabIndex = 29;
            this.quizLabel.Text = "Quiz:";
            // 
            // finalmarksLabel
            // 
            this.finalmarksLabel.AutoSize = true;
            this.finalmarksLabel.ForeColor = System.Drawing.Color.LightGray;
            this.finalmarksLabel.Location = new System.Drawing.Point(608, 127);
            this.finalmarksLabel.Name = "finalmarksLabel";
            this.finalmarksLabel.Size = new System.Drawing.Size(32, 13);
            this.finalmarksLabel.TabIndex = 30;
            this.finalmarksLabel.Text = "Final:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.LightGray;
            this.totalLabel.Location = new System.Drawing.Point(604, 179);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(47, 16);
            this.totalLabel.TabIndex = 31;
            this.totalLabel.Text = "Total:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.ForeColor = System.Drawing.Color.Gold;
            this.gradeLabel.Location = new System.Drawing.Point(573, 248);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(83, 25);
            this.gradeLabel.TabIndex = 32;
            this.gradeLabel.Text = "Grade:";
            // 
            // GradesApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.finalmarksLabel);
            this.Controls.Add(this.quizLabel);
            this.Controls.Add(this.midmarksLabel);
            this.Controls.Add(this.attendanceLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quizIVLabel);
            this.Controls.Add(this.quizIIILabel);
            this.Controls.Add(this.quizIILabel);
            this.Controls.Add(this.quizILabel);
            this.Controls.Add(this.finalLabel);
            this.Controls.Add(this.midLabel);
            this.Controls.Add(this.attendedclassesLabel);
            this.Controls.Add(this.quizIVTextBox);
            this.Controls.Add(this.quizIITextBox);
            this.Controls.Add(this.quizIIITextBox);
            this.Controls.Add(this.quizITextBox);
            this.Controls.Add(this.finalTextBox);
            this.Controls.Add(this.attendedclassesTextBox);
            this.Controls.Add(this.midTextBox);
            this.Controls.Add(this.MarksBOX);
            this.Controls.Add(this.calculategradeTextBox);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.semesterTextBox);
            this.Controls.Add(this.studentidLabel);
            this.Controls.Add(this.studentidTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.StudentInformation);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "GradesApp";
            this.Text = "GradesApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentInformation;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox studentidTextBox;
        private System.Windows.Forms.Label studentidLabel;
        private System.Windows.Forms.TextBox semesterTextBox;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Button calculategradeTextBox;
        private System.Windows.Forms.Label MarksBOX;
        private System.Windows.Forms.TextBox midTextBox;
        private System.Windows.Forms.TextBox attendedclassesTextBox;
        private System.Windows.Forms.TextBox finalTextBox;
        private System.Windows.Forms.TextBox quizITextBox;
        private System.Windows.Forms.TextBox quizIIITextBox;
        private System.Windows.Forms.TextBox quizIITextBox;
        private System.Windows.Forms.TextBox quizIVTextBox;
        private System.Windows.Forms.Label attendedclassesLabel;
        private System.Windows.Forms.Label midLabel;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Label quizILabel;
        private System.Windows.Forms.Label quizIILabel;
        private System.Windows.Forms.Label quizIIILabel;
        private System.Windows.Forms.Label quizIVLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label attendanceLabel;
        private System.Windows.Forms.Label midmarksLabel;
        private System.Windows.Forms.Label quizLabel;
        private System.Windows.Forms.Label finalmarksLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label gradeLabel;
    }
}

