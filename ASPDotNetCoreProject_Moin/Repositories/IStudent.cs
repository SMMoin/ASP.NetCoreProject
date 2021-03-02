using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ASPDotNetCoreProject_Moin.Models;

namespace ASPDotNetCoreProject_Moin.Repositories
{
    public interface IStudent
    {
        Student GetStudent(int id);

        IEnumerable<Student> GetAll();

        Student Add(Student student);
        Student Update(Student student);
        Student Delete(int  id); 
    }
}
