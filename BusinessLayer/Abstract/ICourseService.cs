using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICourseService:IGenericService<Course>
    {
        List<Course> TgetCourseWithCategory();
        List<Course> TgetCourseWithByCategory();
        public List<Course> TGetLast5Course();
    }
}
