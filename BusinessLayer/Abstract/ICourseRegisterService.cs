using Edukator.BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICourseRegisterService:IGenericService<CourseRegister>
    {
        List<CourseRegister> TCourseRegisterWithCoursesAndUsers();
        public List<CourseRegister> TCourseRegisterListWithCourseByUser(int id);
    }
}
