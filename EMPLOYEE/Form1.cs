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

namespace EMPLOYEE
{
    public partial class Form1 : Form
    {
        List<Employee> newEmployeeList = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"D:\Academics\OOC Lab\employees.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');


                    Employee newEmployee = new Employee();
                    newEmployee.employeeId = values[0];
                    newEmployee.firstName = values[1] + " ";
                    newEmployee.lastName = values[2];
                    newEmployee.hiringDate = values[5];
                    newEmployee.salary = values[7];
                    newEmployee.emailAddress = values[3];

                    newEmployeeList.Add(newEmployee);
                    string showEmp = values[1] + " " + values[2] + "\t\t" + values[0];
                    newEmployeeListBox.Items.Add(showEmp);


                }
            }
        }

        public class Employee
        {
            public string employeeId;
            public string firstName;
            public string lastName;
            public string emailAddress;
            public string hiringDate;
            public string salary;
        }
        private void searchOnClick(object sender, EventArgs e)
        {
            string inputId = searchIDTextBox.Text;
            string name = "";
            string salary = "";
            string hiringDate = "";
            string emailAddress = "";

            for (int i = 0; i < newEmployeeList.Count; i++)
            {
                if (newEmployeeList[i].employeeId == inputId)
                {
                    name = newEmployeeList[i].firstName + " " + newEmployeeList[i].lastName;
                    salary = newEmployeeList[i].salary;
                    hiringDate = newEmployeeList[i].hiringDate;
                    emailAddress = newEmployeeList[i].emailAddress;
                    nameLabel.Text = "Name : " + newEmployeeList[i].firstName + newEmployeeList[i].lastName;
                    idLabel.Text = "ID : " + newEmployeeList[i].employeeId;
                    addressLabel.Text = "Email Address: " + newEmployeeList[i].emailAddress;
                    hiringDateLabel.Text = "Hiring Date : " + newEmployeeList[i].hiringDate;
                    salaryLabel.Text = "Salary : " + newEmployeeList[i].salary;
                    break;
                }
            }
            string path = @"D:\Academics\OOC LAB\MyTest.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {



                    string log = hiringDate + " " + inputId + " " + name + " " + salary + " " + emailAddress;
                    sw.WriteLine(log);




                }
            }
            else if (File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    string log = hiringDate + " " + inputId + " " + name + " " + salary + " " + emailAddress;
                    sw.WriteLine(log);

                }
            }

        }
    }
}
