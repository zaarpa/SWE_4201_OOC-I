using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ResultProcessingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"D:\Academics\OOC Lab\SWE4201MarkSheet.csv")) 
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    int attendance;
                    int quiz1;
                    int quiz2;
                    int quiz3;
                    int quiz4;
                    int mid;
                    int final;
                    int viva;
                    if (values[2] == "")
                    {
                        attendance = 0;

                    }
                    else
                    {
                        attendance = Convert.ToInt32(values[2]);
                    }
                    if (values[3] == "")
                    {
                        quiz1 = 0;

                    }
                    else
                    {
                        quiz1 = Convert.ToInt32(values[3]);
                    }
                    if (values[4] == "")
                    {
                        quiz2 = 0;

                    }
                    else
                    {
                        quiz2 = Convert.ToInt32(values[4]);
                    }
                    if (values[5] == "")
                    {
                        quiz3 = 0;

                    }
                    else
                    {
                        quiz3 = Convert.ToInt32(values[5]);
                    }
                    if (values[6] == "")
                    {
                        quiz4 = 0;

                    }
                    else
                    {
                        quiz4 = Convert.ToInt32(values[6]);
                    }
                    if (values[7] == "")
                    {
                        mid = 0;

                    }
                    else
                    {
                        mid = Convert.ToInt32(values[7]);
                    }
                    if (values[8] == "")
                    {
                        final = 0;

                    }
                    else
                    {
                        final = Convert.ToInt32(values[8]);
                    }
                    if (values[9] == "")
                    {
                        viva = 0;

                    }
                    else
                    {
                        viva = Convert.ToInt32(values[9]);
                    }

                    Student dummy_student = new Student(values[0], values[1], attendance, quiz1, quiz2, quiz3, quiz4, mid, final, viva);
                    dummy_student.total = attendance + quiz1 + quiz2 + quiz3 + mid + final + viva;
                    dummy_student.percentage = (dummy_student.total / 3);
                    dummy_student.percentage = (dummy_student.total / 3);
                    if (dummy_student.percentage >= 80)
                    {
                        dummy_student.grade = "A+";
                    }
                    else if (dummy_student.percentage < 80 && dummy_student.percentage > 75)
                    {
                        dummy_student.grade = "A";
                    }
                    else if (dummy_student.percentage < 75 && dummy_student.percentage > 70)
                    {
                        dummy_student.grade = "A-";
                    }
                    else if (dummy_student.percentage < 70 && dummy_student.percentage > 65)
                    {
                        dummy_student.grade = "B+";
                    }
                    else if (dummy_student.percentage < 65 && dummy_student.percentage > 60)
                    {
                        dummy_student.grade = "B";
                    }
                    else if (dummy_student.percentage < 60 && dummy_student.percentage > 55)
                    {
                        dummy_student.grade = "C";
                    }
                    else if (dummy_student.percentage < 55 && dummy_student.percentage > 50)
                    {
                        dummy_student.grade = "D";
                    }
                    else
                    {
                        dummy_student.grade = "F";
                    }
                    RPS.students.Add(dummy_student);
                    showInfoList.Items.Add(dummy_student.studentID);
                    showInfoList.Items.Add(dummy_student.name);
                    showInfoList.Items.Add(dummy_student.grade);
                    showInfoList.Items.Add(dummy_student.percentage);





                }
            }
        }

        private void searchByIDOnClick(object sender, EventArgs e)
        {
            string id = searchByIDTextBox.Text;
            for (int i = 0; i < RPS.students.Count; i++)
            {
                if (id == RPS.students[i].studentID)
                {
                    attendanceLabel.Text = "Attendance : " + RPS.students[i].attendance;
                    quiz1Label.Text = "Quiz 1: " + RPS.students[i].quiz1;
                    quiz2Label.Text = "Quiz 2: " + RPS.students[i].quiz2;
                    quiz3Label.Text = "Quiz 3: " + RPS.students[i].quiz3;
                    quiz4Label.Text = "Quiz 4: " + RPS.students[i].quiz4;
                    int total = RPS.students[i].quiz1 + RPS.students[i].quiz2 + RPS.students[i].quiz3;
                    quizTotallabel.Text = "Quiz Total : " + total;
                    midLabel.Text = "Mid : " + RPS.students[i].mid;
                    finalLabel.Text = "Final : " + RPS.students[i].final;
                    vivaLabel.Text = "Viva : " + RPS.students[i].viva;
                    totalMarksLabel.Text = "Total : " + RPS.students[i].total;
                    percentageLabel.Text = "Percentage : " + RPS.students[i].percentage;
                    gradeLabel.Text = "Grade: " + RPS.students[i].grade;
                    break;
                }
            }

        }
    }
}
