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
    public partial class Form5_AnimalCreator : Form,IHaveDepartmentID
    {
        public Form5_AnimalCreator()
        {
            InitializeComponent();
        }

        private void Form5_AnimalCreator_Load(object sender, EventArgs e)
        {
            using (var context = new ZooDbContext())
            {
                foreach (var employee in context.Employees)
                {
                    BoxOfEmployees.Items.Add($"{employee.Name}  _{employee.Position}    ID_{employee.EmployeeId}");
                }
                foreach (var department in context.Departments)
                {
                    ListOfDepartments.Items.Add($"ID_{department.DepartmentId}_  '{department.Name}'");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AnimalNameBox.Text == "" || AnimalTypeBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please fill all the empty blanks!");
                return;
            }
            if (ListOfDepartments.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Select The Department!");
                return;
            }
            using (var context = new ZooDbContext())
            {
                Animal createdAnimal = new Animal(AnimalNameBox.Text, AnimalTypeBox.Text);
                Department selectedDepartment = giveDepartmentID(ListOfDepartments.Text, context);

                createdAnimal.DepartmentId = selectedDepartment.DepartmentId;
                if (BoxOfEmployees.CheckedItems.Count > 0)
                {
                    List<EmployeeAndAnimal> employeesAndAnimals = new List<EmployeeAndAnimal>();
                    foreach (var item in BoxOfEmployees.CheckedItems)
                    {
                        string checkedItem = item.ToString();
                        var listOfWords = checkedItem.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                        .Where(x => x.Length > 1).ToList();

                        Employee selectedEmployee = context.Employees.
                            First(x => x.EmployeeId.ToString() == listOfWords[2]);

                        EmployeeAndAnimal employeeAndAnimal = new EmployeeAndAnimal();
                        employeeAndAnimal.Employee = selectedEmployee;
                        employeeAndAnimal.Animal = createdAnimal;
                        employeesAndAnimals.Add(employeeAndAnimal);
                    }
                    createdAnimal.EmployeeAndAnimal = employeesAndAnimals;
                }
                context.Add(createdAnimal);
                context.SaveChanges();
            }
            System.Windows.Forms.MessageBox.Show("Animal Created and Entities Added successfully");
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
