using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_Dependencies;

namespace LEARNING_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        LMS lms = new LMS();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addTeacherOnCLick(object sender, EventArgs e)
        {
            string name = teacherNameTextbox.Text;
            string type = teacherTypeComboBox.Text;
            if (type == "Lecturer")
            {
                LECTURER dummy_lecturer = new LECTURER(name);
                lms.lecturers.Add(dummy_lecturer);
                courseTeacherComboBox.Items.Add(name);
                teacherListComboBox.Items.Add(name);
                MessageBox.Show("Lecturer Added.");
            }
            else
            {
                PROFESSOR dummy_professor = new PROFESSOR(name);
                lms.professors.Add(dummy_professor);
                courseTeacherComboBox.Items.Add(name);
                teacherListComboBox.Items.Add(name);
                MessageBox.Show("Professor Added.");
            }

        }

        private void addCourseOnClick(object sender, EventArgs e)
        {
            string code = courseCodeTextbox.Text;
            string type = courseTypeComboBox.Text;
            string title = courseTitleTextbox.Text;
            string semester = semesterCourseComboBox.Text;
            double credit = 0;
            string teacher = courseTeacherComboBox.Text;
            if (type == "lab")
            {
                credit = 1.5;
            }
            else
            {
                credit = 3;
            }
            COURSE dummy_course = new COURSE(title, type, teacher, semester, code, credit);
            for (int i = 0; i < lms.lecturers.Count || i < lms.professors.Count; i++)
            {
                if (i< lms.lecturers.Count && teacher == lms.lecturers[i].entityName)
                {
                    lms.lecturers[i].courses.Add(dummy_course);

                    break;
                }
                else if (i< lms.professors.Count && teacher == lms.professors[i].entityName)
                {
                    lms.professors[i].courses.Add(dummy_course);
                    break;
                }
            }
            lms.availablecourses.Add(dummy_course);
            studentCourseComboBox.Items.Add(title);
            MessageBox.Show("Course Added.");
        }

        private void addStudentOnCLick(object sender, EventArgs e)
        {

            string name = studentNameTextbox.Text;
            string semester = studentSemesterComboBox.Text;
            string course = studentCourseComboBox.Text;
            int flag = 0;

            for (int i = 0; i < lms.students.Count; i++)
            {
                if (lms.students[i].entityName == name)
                {
                    for (int j = 0; j < lms.availablecourses.Count; j++)
                    {
                        if (course == lms.availablecourses[j].courseTitle && semester == lms.availablecourses[j].courseSemester)
                        {

                            lms.students[i].courses.Add(lms.availablecourses[j]);
                            flag = 1;
                            break;
                        }
                    }
                }



            
            }
            if (flag == 0)
            {
                STUDENT dummy_student = new STUDENT(name);
                for (int j = 0; j < lms.availablecourses.Count; j++)
                {
                    if (course == lms.availablecourses[j].courseTitle && semester == lms.availablecourses[j].courseSemester)
                    {

                        dummy_student.courses.Add(lms.availablecourses[j]);
                        flag = 1;
                        break;
                    }
                }
                lms.students.Add(dummy_student);
                studentListComboBox.Items.Add(name);
            }
            MessageBox.Show("Student Added.");

        }

        private void showStudentInfoOnCLick(object sender, EventArgs e)
        {
            showStudentListBox.Items.Clear();
            string name = studentListComboBox.Text;
            for (int i = 0; i < lms.students.Count; i++)
            {
                if (name == lms.students[i].entityName)
                {
                    showStudentListBox.Items.Add(lms.students[i].showInfo());
                    for (int j = 0; j < lms.students[i].courses.Count; j++)
                    {
                        string temp = lms.students[i].courses[j].courseCode + "\t" + lms.students[i].courses[j].courseType + "\t" + lms.students[i].courses[j].courseTitle + lms.students[i].courses[j].courseSemester;
                        showStudentListBox.Items.Add(temp);
                    }
                    break;
                }

            }
        }

        private void showTeacherInfoOnClick(object sender, EventArgs e)
        {
            showTeacherListBox.Items.Clear();
            string name = teacherListComboBox.Text;
            for (int i = 0; i < lms.lecturers.Count || i < lms.professors.Count; i++)
            {
                if (name == lms.lecturers[i].entityName)
                {
                    showTeacherListBox.Items.Add(lms.lecturers[i].showInfo());
                    for (int j = 0; j < lms.lecturers[i].courses.Count; j++)
                    {
                        string temp = lms.lecturers[i].courses[j].courseCode + "\t" + lms.lecturers[i].courses[j].courseType + "\t" + lms.lecturers[i].courses[j].courseTitle + "\t" + lms.lecturers[i].courses[j].courseSemester;
                        showTeacherListBox.Items.Add(temp);
                    }
                    break;
                }
                else if (name == lms.professors[i].entityName)
                {
                    showTeacherListBox.Items.Add(lms.professors[i].showInfo());
                    for (int j = 0; j < lms.professors[i].courses.Count; j++)
                    {
                        string temp = lms.professors[i].courses[j].courseCode + "\t" + lms.professors[i].courses[j].courseType + "\t" + lms.professors[i].courses[j].courseTitle + "\t" + lms.professors[i].courses[j].courseSemester;
                        showTeacherListBox.Items.Add(temp);
                    }
                    break;

                }
            }
        }
    }
}


