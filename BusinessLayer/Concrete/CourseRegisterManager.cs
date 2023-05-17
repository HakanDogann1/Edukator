using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CourseRegisterManager : ICourseRegisterService
    {
        private readonly ICourseRegisterDal _courseRegisterDal;

        public CourseRegisterManager(ICourseRegisterDal courseRegisterDal)
        {
            _courseRegisterDal = courseRegisterDal;
        }

        public List<CourseRegister> TCourseRegisterListWithCourseByUser(int id)
        {
            return _courseRegisterDal.CourseRegisterListWithCourseByUser(id);
        }

        public List<CourseRegister> TCourseRegisterWithCoursesAndUsers()
        {
            return _courseRegisterDal.CourseRegisterWithCoursesAndUsers();
        }

        public void TDelete(CourseRegister t)
        {
            _courseRegisterDal.Delete(t);
        }

        public CourseRegister TGetByID(int id)
        {
            return _courseRegisterDal.GetByID(id);
        }

        public List<CourseRegister> TGetList()
        {
           return _courseRegisterDal.GetList();
        }

        public void TInsert(CourseRegister t)
        {
            _courseRegisterDal.Insert(t);
        }

        public void TUpdate(CourseRegister t)
        {
            _courseRegisterDal.Update(t);
        }
    }
}
