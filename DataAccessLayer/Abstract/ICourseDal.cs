using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface ICourseDal:IGenericDal<Course>
    {
        List<Course> getCoursesWithCategory();
        List<Course> getCoursesWithByCategory();
        List<Course> GetLast5Course();
    }
}
