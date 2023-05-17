using DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfCourseDal : GenericRepositories<Course>, ICourseDal
    {
        public List<Course> getCoursesWithByCategory()
        {
            Context context = new Context();
            return context.Courses.Include(x=>x.Category).ToList();
        }

        public List<Course> getCoursesWithCategory()
        {
           Context context = new Context();
            return context.Courses.Include(x=>x.Category).ToList();
        }

        public List<Course> GetLast5Course()
        {
            using var context = new Context();
            return context.Courses.OrderByDescending(x=>x.CourseID).Take(5).ToList();
        }
    }
}
