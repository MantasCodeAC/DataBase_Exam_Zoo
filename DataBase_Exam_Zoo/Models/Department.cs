using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Exam_Zoo.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public List<EmployeeAndDepartment> EmployeeAndDepartments { get; set; }
        public List<Animal> Animals { get; set; }
        public Department(string name)
        {           
            Name = name;
            List<EmployeeAndDepartment> EmployeeAndDepartments = new List<EmployeeAndDepartment>();
            List<Animal> Animals = new List<Animal>();
        }
    }
}
