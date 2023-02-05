using DataBase_Exam_Zoo.Models;
using DataBase_Exam_Zoo.Repositories;
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
    public partial class Form9_EmployeeShowerByAnimal : Form
    {
        public Form9_EmployeeShowerByAnimal()
        {
            InitializeComponent();
        }

        private void ListOfEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfEmployees.Items.Clear();
            if (ListOfAnimals.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Select The Animal!");
                return;
            }
            using(var context = new ZooDbContext())
            {
                List<string> idOfAnimal = ListOfAnimals.Text
                                .Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                                .Where(x => x.Length >= 1).ToList();
                Animal selectedAnimal = context.Animals.First(x => x.AnimalId.ToString() == idOfAnimal[2]);
                
                ListOfEmployees.Items.Add($"Employees by the selected animal ({selectedAnimal.Name}):");
                ListOfEmployees.Items.Add("__________________________________________");
                foreach (var employee in context.Employees)
                {
                    foreach (var employeeAndAnimal in context.EmployeeAndAnimals)
                    {
                        if (employeeAndAnimal.AnimalId == selectedAnimal.AnimalId &&
                            employeeAndAnimal.EmployeeId == employee.EmployeeId)
                        {
                            ListOfEmployees.Items.Add($"{employee.Name} __ {employee.Position} __ {employee.EmployeeId}");
                        }
                    }
                }
            }
        }

        private void ListOfDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form9_EmployeeShowerByAnimal_Load(object sender, EventArgs e)
        {
            using (var context = new ZooDbContext())
            {
                foreach (var animal in context.Animals)
                {
                    ListOfAnimals.Items.Add($"{animal.Name}    _{animal.Type}    _{animal.AnimalId}");
                }
            }
        }
    }
}
