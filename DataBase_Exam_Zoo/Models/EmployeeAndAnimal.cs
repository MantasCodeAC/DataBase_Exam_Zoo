using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Exam_Zoo.Models
{
    public class EmployeeAndAnimal
    {
        public Guid EmployeeId { get; set; }
        public Guid AnimalId { get; set; }
        public Employee Employee { get; set; }
        public Animal Animal { get; set; }
    }
}
