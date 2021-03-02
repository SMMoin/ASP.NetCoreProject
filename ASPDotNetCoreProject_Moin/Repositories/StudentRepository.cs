using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ASPDotNetCoreProject_Moin.Data;
using ASPDotNetCoreProject_Moin.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNetCoreProject_Moin.Repositories
{
    public class StudentRepository : IStudent
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public Student Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student Delete(int id)
        {
            Student student = _context.Students.Find(id);
            if(student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }

            return student;
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students;
        }

        public Student GetStudent(int id)
        {
            return _context.Students.Where(s => s.StudentID == id).SingleOrDefault();
        }

        public Student Update(Student student)
        {
            if(student != null)
            {
                _context.Entry(student).State = EntityState.Modified;
                _context.SaveChanges();
            }
            
            return student;
        }
    }
}
