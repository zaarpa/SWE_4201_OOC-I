using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPLOYEEMANAGEMNET
{ 
    public partial class UniversityManagementSystem : Form
        
    {
        List<STUDENT>students = new List<STUDENT>();
        List<TEACHER>teachers = new List<TEACHER>();
        List<ADMIN>admins = new List<ADMIN>();
        public UniversityManagementSystem()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeachersInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void SalaryLabel_Click(object sender, EventArgs e)
        {

        }

        private void Show3Button_Click(object sender, EventArgs e)
        {

        }

        private void StudentClearOnClick(object sender, EventArgs e)
        {
            StudentIDTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
            DepartmentTextBox.Text = String.Empty;
            SemesterTextBox.Text = String.Empty;

            MessageBox.Show("Cleared Successfully!");
        }

        private void TeacherClearOnClick(object sender, EventArgs e)
        {
            TeachersIDTextBox.Text=String.Empty;
            TeachersNameTextBox.Text = String.Empty;
            TeachersDepartmentTextBox.Text = String.Empty;
            DesignationTextBox.Text = String.Empty;
            SalaryTextBox.Text = String.Empty;  

            MessageBox.Show("Cleared Successfully!");
        }

        private void AdminClearOnClick(object sender, EventArgs e)
        {
            EmployeeIDTextBox.Text = String.Empty;
            EmployeeNameTextBox.Text = String.Empty;
            EmployeeDesignationTextBox.Text = String.Empty;
            EmployeeSalaryTextBox.Text = String.Empty;

            MessageBox.Show("Cleared Successfully!");
        }

        private void StudentSaveOnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(StudentIDTextBox.Text);    
            string name = NameTextBox.Text;
            string department = DepartmentTextBox.Text;
            string semester = SemesterTextBox.Text;

            STUDENT dummy_stu = new STUDENT();
            dummy_stu.studentid = id;
            dummy_stu.studentname = name; 
            dummy_stu.studentdepartment = department;
            dummy_stu.studentsemester = semester;

            students.Add(dummy_stu);
            MessageBox.Show("Saved Successfully.");
        }

        private void TeacherSaveOnClick(object sender, EventArgs e)
        {
            int teacherid = Convert.ToInt32(TeachersIDTextBox.Text); 
            string teachername = TeachersNameTextBox.Text; 
            string teachersdepartment = TeachersDepartmentTextBox.Text;
            string teacherdesignation = DesignationTextBox.Text;
            int teachersalary = Convert.ToInt32(SalaryTextBox.Text);

            TEACHER dummy_teacher = new TEACHER();
            dummy_teacher.teacherid = teacherid;
            dummy_teacher.teachername = teachername;
            dummy_teacher.teacherdepartment = teachersdepartment;
            dummy_teacher.teacherdesignation = teacherdesignation;
            dummy_teacher.teachersalary = teachersalary;

            teachers.Add(dummy_teacher);
            MessageBox.Show("Saved Successfully.");
        }

        private void AdminSaveOnClick(object sender, EventArgs e)
        {
            int adminid = Convert.ToInt32(EmployeeIDTextBox);
            string adminname = EmployeeNameTextBox.Text;
            string admindesignation = EmployeeDesignationTextBox.Text;
            int adminsalary = Convert.ToInt32(EmployeeSalaryTextBox.Text);

            ADMIN dummy_admin = new ADMIN();
            dummy_admin.adminid = adminid;
            dummy_admin.adminname = adminname;
            dummy_admin.admindesignation = admindesignation;
            dummy_admin.adminsalary = adminsalary;

            admins.Add(dummy_admin);
            MessageBox.Show("Saved Successfully.");
        }

        private void StudentsListShowOnClick(object sender, EventArgs e)
        {
            StudentListBox.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                StudentListBox.Items.Add(students[i].getStudentinfo());
            }
        }

        private void TeachersListShowOnClick(object sender, EventArgs e)
        {
            TeachersListBox.Items.Clear();
            for (int i = 0; i < teachers.Count; i++)
            {
                TeachersListBox.Items.Add(teachers[i].getTeacherinfo());
            }
        }

        private void AdminsListShowOnClick(object sender, EventArgs e)
        {
            AdminListBox.Items.Clear();
            for (int i = 0; i < admins.Count; i++)
            {
                AdminListBox.Items.Add(admins[i].getAdmininfo());
            }
        }
    }
    }
