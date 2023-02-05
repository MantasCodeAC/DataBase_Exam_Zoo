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
    public partial class Form7_AnimalsShower : Form, IHaveDepartmentID
    {
        public Form7_AnimalsShower()
        {
            InitializeComponent();
        }

        private void Form7_AnimalsShower_Load(object sender, EventArgs e)
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
            ListOfAnimals.Items.Clear();
            if (ListOfDepartments.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Select The Department!");
                return;
            }
            using (var context = new ZooDbContext())
            {
                Department selectedDepartment = giveDepartmentID(ListOfDepartments.Text, context);               
                ListOfAnimals.Items.Add($"Animals of the {selectedDepartment.Name}:");
                ListOfAnimals.Items.Add("__________________________________________");
                foreach (var animal in context.Animals)
                {
                    if(animal.DepartmentId == selectedDepartment.DepartmentId)
                    {
                        ListOfAnimals.Items.Add($"{animal.Name} __ {animal.Type} __ {animal.AnimalId}");
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
