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
    public partial class Form8_EmployeeShower : Form, IHaveDepartmentID
    {
        public Form8_EmployeeShower()
        {
            InitializeComponent();
        }

        private void Form8_EmployeeShower_Load(object sender, EventArgs e)
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
            ListOfEmployees.Items.Clear();
            if (ListOfDepartments.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Select The Department!");
                return;
            }
            using (var context = new ZooDbContext())
            {
                Department selectedDepartment = giveDepartmentID(ListOfDepartments.Text, context);
                ListOfEmployees.Items.Add($"Employees of the {selectedDepartment.Name}:");
                ListOfEmployees.Items.Add("__________________________________________");
                foreach (var employee in context.Employees)
                {
                    foreach (var employeeAndDepartment in context.EmployeeAndDepartments)
                    {
                        if (employeeAndDepartment.DepartmentId == selectedDepartment.DepartmentId && 
                            employeeAndDepartment.EmployeeId == employee.EmployeeId)
                        {
                            ListOfEmployees.Items.Add($"{employee.Name} __ {employee.Position} __ {employee.EmployeeId}");
                        }
                    }
                }
            }
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
