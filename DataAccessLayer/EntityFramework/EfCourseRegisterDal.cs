using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCourseRegisterDal : GenericRepositories<CourseRegister>, ICourseRegisterDal
    {
        public List<CourseRegister> CourseRegisterListWithCourseByUser(int id)
        {
            using var context = new Context();
            var values = context.CourseRegisters.Where(y=>y.AppUserID==id).Include(x=>x.Course).ToList();
            return values;
        }

        public List<CourseRegister> CourseRegisterWithCoursesAndUsers()
        {
           Context context = new Context();
            var values = context.CourseRegisters.Include(x=>x.Course).Include(y=>y.AppUser).ToList();
            return values;
        }
    }
}
