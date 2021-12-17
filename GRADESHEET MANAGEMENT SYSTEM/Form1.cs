using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAssignment
{
    public partial class GradesApp : Form
    {
        public GradesApp()
        {
            InitializeComponent();
        }

        private void Semester_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void QuizIIBOX_Click(object sender, EventArgs e)
        {

        }

        private void QuizIVBOX_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void CalculateGrade_Click(object sender, EventArgs e)
        {
            int attendance = Convert.ToInt32(attendedclassesTextBox.Text);
            double attendanceCalc = Convert.ToDouble(attendance);
            double attendancePercant = (attendanceCalc/28.0) * 30.0;
            double quizI = Convert.ToDouble(quizITextBox.Text);
            double quizII = Convert.ToDouble(quizIITextBox.Text);
            double quizIII = Convert.ToDouble (quizIIITextBox.Text);
            double quizIV = Convert.ToDouble(quizIVTextBox.Text);
            double [] quizarr = { quizI, quizII, quizIII, quizIV };
            Array.Sort(quizarr);
            double quiztotal = 0; 
            for(int i = 1; i< quizarr.Length; i++)
            {
                quiztotal += quizarr[i]; 
            }
            double midmarks = Convert.ToDouble(midTextBox.Text);
            double finalmarks = Convert.ToDouble(finalTextBox.Text);
            attendanceLabel.Text = "Attendance: " + Math.Round(attendancePercant, 2) + "/30";
            midmarksLabel.Text = "Mid: " + midmarks + "/75";
            quizLabel.Text = "Quiz: " + quiztotal + "/45";
            finalmarksLabel.Text = "Final: " + finalmarks + "/150";
            double total = attendancePercant + midmarks + quiztotal + finalmarks; 
            totalLabel.Text = "Total: " + Math.Round(total,2) + "/300";
            double finalresult = (total / 300.00) * 100.00; 
            string grade;
            if(finalresult >= 80.00)
            {
                grade = "A+";
            }
            else if(finalresult >=75.0 && finalresult <= 79.0)
            {
                grade = "A"; 
            }
            else if (finalresult >= 70.0 && finalresult <= 74.0)
            {
                grade = "A-";
            }
            else if (finalresult >= 65.0 && finalresult <= 69.0)
            {
                grade = "B+";
            }
            else if (finalresult >= 60.0 && finalresult <= 64.0)
            {
                grade = "B";
            }
            else if (finalresult >= 55.0 && finalresult <= 59.0)
            {
                grade = "B-";
            }
            else if (finalresult >= 50.0 && finalresult <= 54.0)
            {
                grade = "C+";
            }
            else if (finalresult >= 45.0 && finalresult <= 49.0)
            {
                grade = "C";
            }
            else if (finalresult >= 40.0 && finalresult <= 44.0)
            {
                grade = "D";
            }
            else 
            {
                grade = "F";
            }
            string name = nameTextBox.Text;
            gradeLabel.Text = "Grade: " + grade + "\n" + name + " obtained " + Math.Round(finalresult, 2) + "% marks";
            if (nameTextBox.Text == "" || studentidTextBox.Text == "" || semesterTextBox.Text == "" || attendedclassesTextBox.Text == "" || midTextBox.Text == "" || finalTextBox.Text == "" || quizITextBox.Text == "" || quizIITextBox.Text == "" || quizIIITextBox.Text == "" || quizIVTextBox.Text == "")
            {
                MessageBox.Show("Please fill up the required fields.");
            }
        }

        private void attendanceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
