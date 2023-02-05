using DataBase_Exam_Zoo.Models;
using DataBase_Exam_Zoo.Repositories;
using DataBase_Exam_Zoo.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Exam_Zoo_WindowsForm
{
    public partial class Form2_DepartmentCreator : Form
    {
        public Form2_DepartmentCreator()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_DepartmentCreator_Load(object sender, EventArgs e)
        {
            using (var context = new ZooDbContext())
            {
                foreach (var employee in context.Employees)
                {                   
                    BoxOfEmployees.Items.Add($"{employee.Name}  _{employee.Position}    ID_{employee.EmployeeId}");
                    BoxOfEmployees.Text = $"{employee.Name}";
                }
                foreach(var department in context.Departments)
                {
                    listBox1.Items.Add($"ID-{department.DepartmentId}  '{department.Name}'");
                }
                foreach (var animal in context.Animals)
                {
                    BoxOfAnimals.Items.Add($"{animal.Name}  _{animal.Type}    ID_{animal.AnimalId}");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNameDepartment.Text.ToString() == "")
            {
                System.Windows.Forms.MessageBox.Show("Add The Name Of The Department!");
                return;
            }
            DepartmentCreator departmentCreator = new DepartmentCreator();           
            List<Object> listOfCheckedEmployees = new List<Object>();
            foreach (var item in BoxOfEmployees.CheckedItems)
            {
                listOfCheckedEmployees.Add(item);
            }
            List<Object> listOfCheckedAnimals = new List<Object>();
            foreach(var item in BoxOfAnimals.CheckedItems)
            {
                listOfCheckedAnimals.Add(item);
            }

            departmentCreator.CreateNewDepartment(txtNameDepartment.Text, listOfCheckedAnimals, listOfCheckedEmployees);
            System.Windows.Forms.MessageBox.Show("Department created and Entities Succesfully added");
                       
            BoxOfAnimals.Items.Clear();
            BoxOfEmployees.Items.Clear();
            listBox1.Items.Clear();
            txtNameDepartment.Clear();
            Form2_DepartmentCreator_Load(sender, e);            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
