using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataBase_Exam_Zoo_WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase_Exam_Zoo.Models;
using DataBase_Exam_Zoo.Repositories;

namespace DataBase_Exam_Zoo_WindowsForm.Tests
{
    [TestClass()]
    public class Form5_AnimalCreatorTests
    {
        [TestMethod()]
        public void giveDepartmentIDTest()
        {
            using(var context = new ZooDbContext())
            {
                // Arrange
                Department selectedDepartment = context.Departments.First(x => x.DepartmentId == 1);

                // Act
                Form5_AnimalCreator form = new Form5_AnimalCreator();
                Department departmentToTest = form.giveDepartmentID("ID_1_ 'Department Of The Birds'", context);

                // Assert
                Assert.AreEqual(selectedDepartment.Name, departmentToTest.Name);
            }
        }
    }
}