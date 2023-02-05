using DataBase_Exam_Zoo.Models;
using DataBase_Exam_Zoo.Repositories;
using DataBase_Exam_Zoo.Service;
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
    public partial class Form3_EmployeeAnimalAdder : Form
    {
        public Form3_EmployeeAnimalAdder()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_EmployeeAnimalAdder_Load(object sender, EventArgs e)
        {
            using (var context = new ZooDbContext())
            {
                foreach (var employee in context.Employees)
                {
                    BoxOfEmployees.Items.Add($"{employee.Name}  _{employee.Position}    ID_{employee.EmployeeId}");
                    BoxOfEmployees.Text = $"{employee.Name}";
                }
                foreach (var department in context.Departments)
                {
                    ListOfDepartments.Items.Add($"ID_{department.DepartmentId}_  '{department.Name}'");
                }
                foreach (var animal in context.Animals)
                {
                    BoxOfAnimals.Items.Add($"{animal.Name}  _{animal.Type}    ID_{animal.AnimalId}");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmpAnimAdder_Click(object sender, EventArgs e)
        {
            if (ListOfDepartments.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Select The Department!");
                return;
            }
            else if(BoxOfEmployees.CheckedItems.Count == 0 && BoxOfAnimals.CheckedItems.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Select Any Employees or Animals to Add!");
                return;
            }
            EmployeeAnimalAdder employeeAnimalAdder = new EmployeeAnimalAdder();
            List<Object> listOfCheckedEmployees = new List<Object>();
            foreach (var item in BoxOfEmployees.CheckedItems)
            {
                listOfCheckedEmployees.Add(item);
            }

            List<Object> listOfCheckedAnimals = new List<Object>();
            foreach (var item in BoxOfAnimals.CheckedItems)
            {
                listOfCheckedAnimals.Add(item);
            }
            try
            {
                employeeAnimalAdder.AddEmployeeOrAnimal(ListOfDepartments.Text, listOfCheckedAnimals, listOfCheckedEmployees);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show($"Employee is already in the selected department");
                return;
            }
            System.Windows.Forms.MessageBox.Show($"Entities successfully added");
            this.Close();
        }
    }
}
