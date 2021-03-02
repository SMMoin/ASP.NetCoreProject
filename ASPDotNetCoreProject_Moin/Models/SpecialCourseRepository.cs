using ASPDotNetCoreProject_Moin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDotNetCoreProject_Moin.Models 
{
    public class SpecialCourseRepository:ISpecialCourseRepository
    {
        private readonly ApplicationDbContext db;
        public SpecialCourseRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public SpecialCourse Add(SpecialCourse course)
        {
            db.Courses.Add(course);
            db.SaveChanges();

            return course;
        }
      
        public SpecialCourse Delete(int id)
        {
            SpecialCourse course = db.Courses.Find(id);
            if (course != null)
            {
                db.Courses.Remove(course);
                db.SaveChanges();
            }
            return course;
        }

        public IEnumerable<SpecialCourse> GetAll()
        {
            return db.Courses;
        }

        public SpecialCourse GetCourse(int id)
        {
            return db.Courses.Where(x => x.CourseID == id).SingleOrDefault();
        }

        public SpecialCourse Update(SpecialCourse course)
        {
            db.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return course;
        }
    }
}
