using DataBase_Exam_Zoo.Models;
using DataBase_Exam_Zoo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Exam_Zoo.Service.Interfaces
{
    public interface IHaveDepartmentID
    {
        Department giveDepartmentID(string departmentText, ZooDbContext context);
    }
}
