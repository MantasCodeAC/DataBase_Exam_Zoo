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
    public partial class Form6_AnimalTransfer : Form, IHaveDepartmentID
    {
        public Form6_AnimalTransfer()
        {
            InitializeComponent();
        }

        private void Form6_AnimalTransfer_Load(object sender, EventArgs e)
        {
            using (var context = new ZooDbContext())
            {
                foreach (var employee in context.Employees)
                {
                    BoxOfEmployees.Items.Add($"{employee.Name}  _{employee.Position}    ID_{employee.EmployeeId}");                   
                }
                foreach (var department in context.Departments)
                {
                    BoxOfDepartments.Items.Add($"ID_{department.DepartmentId}_  '{department.Name}'");
                }
                foreach (var animal in context.Animals)
                {
                    BoxOfAnimals.Items.Add($"{animal.Name}  _{animal.Type}    ID_{animal.AnimalId}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BoxOfAnimals.Text == "" || BoxOfDepartments.Text == "" || BoxOfEmployees.CheckedItems.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Please Fill all the blanks!");
                return;
            }           
            using (var context = new ZooDbContext())
            {
                Department selectedDepartment = giveDepartmentID(BoxOfDepartments.Text, context);
                var checkedAnimal = BoxOfAnimals.Text.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                        .Where(x => x.Length > 1).ToList();
                Animal selectedAnimal = context.Animals.
                            First(x => x.AnimalId.ToString() == checkedAnimal[2]);
                foreach (var employeeAndAnimal in context.EmployeeAndAnimals)
                {
                    if(employeeAndAnimal.AnimalId == selectedAnimal.AnimalId)
                    {
                        context.Remove(employeeAndAnimal);
                    }
                }
                List<EmployeeAndAnimal> employeeAndAnimals = new List<EmployeeAndAnimal>();
                if (BoxOfEmployees.CheckedItems.Count > 0)
                {
                    foreach (var item in BoxOfEmployees.CheckedItems)
                    {
                        string checkedItem = item.ToString();
                        var listOfWords = checkedItem.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                        .Where(x => x.Length > 1).ToList();
                        Employee selectedEmployee = context.Employees.
                            First(x => x.EmployeeId.ToString() == listOfWords[2]);
                        EmployeeAndAnimal employeeAndAnimal = new EmployeeAndAnimal();
                        employeeAndAnimal.Employee = selectedEmployee;
                        employeeAndAnimal.Animal = selectedAnimal;
                        employeeAndAnimals.Add(employeeAndAnimal);
                    }
                    selectedAnimal.EmployeeAndAnimal = employeeAndAnimals;
                }
                if(selectedAnimal.DepartmentId != selectedDepartment.DepartmentId)
                {
                    selectedAnimal.DepartmentId = selectedDepartment.DepartmentId;
                    context.Update(selectedAnimal);
                    context.SaveChanges();
                    System.Windows.Forms.MessageBox.Show($"{selectedAnimal.Name} successfully transfered to {selectedDepartment.Name}");
                    this.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show($"{selectedAnimal.Name} is already in {selectedDepartment.Name}");
                    return;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
