using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDotNetCoreProject_Moin.Models 
{
    public interface ISpecialCourseRepository
    {
        SpecialCourse GetCourse(int id);

        IEnumerable<SpecialCourse> GetAll();

        SpecialCourse Add(SpecialCourse course);
        SpecialCourse Update(SpecialCourse course);
        SpecialCourse Delete(int id);
    }
}
