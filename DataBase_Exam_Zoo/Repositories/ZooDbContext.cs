using DataBase_Exam_Zoo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Exam_Zoo.Repositories
{
    public class ZooDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=DESKTOP-7KTVRKI\SQLEXPRESS;Initial Catalog=Exam_ZooDB;Integrated Security=True;"+
                "MultipleActiveResultSets=True");
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeAndAnimal> EmployeeAndAnimals { get; set; }
        public DbSet<EmployeeAndDepartment> EmployeeAndDepartments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeAndAnimal>().HasKey(x => new
            {
                x.EmployeeId,
                x.AnimalId
            });
            modelBuilder.Entity<Employee>().HasMany(x => x.EmployeeAndAnimal).WithOne(x => x.Employee).HasForeignKey(x => x.EmployeeId);
            modelBuilder.Entity<Animal>().HasMany(x => x.EmployeeAndAnimal).WithOne(x => x.Animal).HasForeignKey(x => x.AnimalId);

            modelBuilder.Entity<EmployeeAndDepartment>().HasKey(x => new
            {
                x.EmployeeId,
                x.DepartmentId
            });
            modelBuilder.Entity<Employee>().HasMany(x => x.EmployeeAndDepartments).WithOne(x => x.Employee).HasForeignKey(x => x.EmployeeId);
            modelBuilder.Entity<Department>().HasMany(x => x.EmployeeAndDepartments).WithOne(x => x.Department).HasForeignKey(x => x.DepartmentId);
        }
    }
}
