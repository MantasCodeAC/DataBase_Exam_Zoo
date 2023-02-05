using DataBase_Exam_Zoo.Models;
using DataBase_Exam_Zoo.Repositories;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Exam_Zoo.Service
{
    public class DepartmentCreator
    {
        public void CreateNewDepartment (string txtNameDepartment, List<Object> boxOfAnimalsChecked, List<Object> boxOfEmployeesChecked)
        {           
            using (var context = new ZooDbContext())
            {
                Department createdDepartment = new Department(txtNameDepartment.ToString());

                List<Animal> animals = new List<Animal>();
                if (boxOfAnimalsChecked.Count > 0)
                {
                    foreach (var item in boxOfAnimalsChecked)
                    {
                        string checkedItem = item.ToString();
                        var listOfWords = checkedItem.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                        .Where(x => x.Length > 1).ToList();

                        Animal selectedAnimal = context.Animals.
                            First(x => x.AnimalId.ToString() == listOfWords[2]);
                        animals.Add(selectedAnimal);

                    }
                    createdDepartment.Animals = animals;
                }               

                List<EmployeeAndDepartment> employeeAndDepartments = new List<EmployeeAndDepartment>();
                if (boxOfEmployeesChecked.Count > 0)
                {
                    foreach (var item in boxOfEmployeesChecked)
                    {
                        string checkedItem = item.ToString();
                        var listOfWords = checkedItem.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries)
                        .Where(x => x.Length > 1).ToList();

                        Employee selectedEmployee = context.Employees.
                            First(x => x.EmployeeId.ToString() == listOfWords[2]);

                        EmployeeAndDepartment employeeAndDepartment = new EmployeeAndDepartment();
                        employeeAndDepartment.Employee = selectedEmployee;
                        employeeAndDepartment.Department = createdDepartment;
                        employeeAndDepartments.Add(employeeAndDepartment);
                    }
                    createdDepartment.EmployeeAndDepartments = employeeAndDepartments;
                }  
                context.Update(createdDepartment);
                context.SaveChanges();
            }
        }
    }
}
