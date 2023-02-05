using DataBase_Exam_Zoo.Models;
using DataBase_Exam_Zoo.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataBase_Exam_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, DataBase_Exam_Zoo!");
            Department birdsDepartment = new Department("Department Of The Birds");

            Employee employee1 = new Employee("Mantas", "Zoo Director",
                "Responsible for the institution's operation and plans for future development.");
            Employee employee2 = new Employee("Jonas", "Keeper/Aquarist",
                "Provides daily care to the institution's animals");
            Employee employee3 = new Employee("Petras", "Veterinarian",
                "Responsible for the healthcare program for the animal collection");

            Animal animal1 = new Animal("Parrot", "Bird");         
            Animal animal2 = new Animal("Iguana", "Lizzard");
            Animal animal3 = new Animal("White-Head Eagle", "Bird");
            


            ZooDbContext zooDbContext = new ZooDbContext();
            Department temporary = zooDbContext.Departments.First(x => x.Name == "Temporary department");
            EmployeeAndAnimal employeeAndAnimal1 = new EmployeeAndAnimal();
            employeeAndAnimal1.Animal = animal1;
            
            employeeAndAnimal1.Employee = employee1;

            EmployeeAndAnimal employeeAndAnimal2 = new EmployeeAndAnimal();
            employeeAndAnimal2.Animal = animal2;
            
            employeeAndAnimal2.Employee = employee1;

            EmployeeAndAnimal employeeAndAnimal3 = new EmployeeAndAnimal();
            employeeAndAnimal3.Animal = animal3;
            
            employeeAndAnimal3.Employee = employee1;

            EmployeeAndAnimal employeeAndAnimal4 = new EmployeeAndAnimal();
            employeeAndAnimal4.Animal = animal2;
            employeeAndAnimal4.Employee = employee3;


            Animal animal4 = new Animal("Owl", "Bird");
            Animal animal5 = new Animal("Penguin", "Bird");
   
            
            using (var context = new ZooDbContext())
            {
                context.Employees.Remove(context.Employees.First(x=>x.Name=="Darius1"));
                Console.WriteLine("Removed");

                context.SaveChanges();
            }
            
        }
    }
}