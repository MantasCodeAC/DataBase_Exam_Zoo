using DataBase_Exam_Zoo.Models;
using DataBase_Exam_Zoo.Repositories;
using DataBase_Exam_Zoo.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Exam_Zoo_WindowsForm
{
    public partial class Form4_EmployeeCreator : Form, IHaveDepartmentID
    {
        public Form4_EmployeeCreator()
        {
            InitializeComponent();
        }

        private void Form4_EmployeeCreator_Load(object sender, EventArgs e)
        {
            using (var context = new ZooDbContext())
            {              
                foreach (var department in context.Departments)
                {
                    ListOfDepartments.Items.Add($"ID_{department.DepartmentId}_  '{department.Name}'");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (employeeNameBox.Text == ""||employeePositionBox.Text==""||employeeResponsibilitiesBox.Text=="")
            {
                System.Windows.Forms.MessageBox.Show("Please fill all the empty blanks!");
                return;
            }
            if(ListOfDepartments.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Select The Department!");
                return;
            }
            using(var context = new ZooDbContext())
            {
                Employee createdEmployee = new Employee(employeeNameBox.Text, employeePositionBox.Text, employeeResponsibilitiesBox.Text);
                Department selectedDepartment = giveDepartmentID(ListOfDepartments.Text, context);

                EmployeeAndDepartment employeeAndDepartment = new EmployeeAndDepartment();
                employeeAndDepartment.Department = selectedDepartment;
                employeeAndDepartment.Employee = createdEmployee;                
                context.Add(createdEmployee);
                context.Add(employeeAndDepartment);
                context.SaveChanges();               
            }
            System.Windows.Forms.MessageBox.Show("Employee Created and Added to Department successfully");
            this.Close();
        }
        public Department giveDepartmentID(string departmentText, ZooDbContext context)
        {
            List<string> idOfDepartment = departmentText
                                .Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                                .Where(x => x.Length >= 1).ToList();
            Department selectedDepartment = context.Departments.First(x => x.DepartmentId.ToString() == idOfDepartment[1]);
            return selectedDepartment;
        }
    }
}
