using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Exam_Zoo.Models
{
    public class EmployeeAndDepartment
    {
        public Guid EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public Employee Employee { get; set; }
        public Department Department { get; set; }
    }
}
