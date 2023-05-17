using Edukator.DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICourseRegisterDal:IGenericDal<CourseRegister>
    {
        List<CourseRegister> CourseRegisterWithCoursesAndUsers();
        List<CourseRegister> CourseRegisterListWithCourseByUser(int id);
    }
}
