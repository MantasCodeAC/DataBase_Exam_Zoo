using DataBase_Exam_Zoo.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Exam_Zoo.Models
{
    public class Animal
    {
        public Guid AnimalId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int DepartmentId { get; set; } = 2;
        public List<EmployeeAndAnimal> EmployeeAndAnimal { get; set; }
        public Animal(string name, string type)
        {
            Guid AnimalId = Guid.NewGuid();
            Name = name;
            Type = type;
            EmployeeAndAnimal = new List<EmployeeAndAnimal>();
        }

    }
}
