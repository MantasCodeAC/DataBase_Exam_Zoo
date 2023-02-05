using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Exam_Zoo.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Responsibilities { get; set; }
        public List<EmployeeAndDepartment> EmployeeAndDepartments { get; set; }
        public List<EmployeeAndAnimal> EmployeeAndAnimal { get; set; }
        public Employee(string name, string position, string responsibilities)
        {
            EmployeeId = Guid.NewGuid();
            Name = name;
            Position = position;
            Responsibilities = responsibilities;
            List<EmployeeAndAnimal> EmployeeAndAnimal = new List<EmployeeAndAnimal>();
            List<EmployeeAndDepartment> EmployeeAndDepartments = new List<EmployeeAndDepartment>();
        }
    }
}
