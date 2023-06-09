﻿using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> TgetCourseWithCategory()
        {
           
            return _courseDal.getCoursesWithCategory();
        }

        public void TDelete(Course t)
        {
           _courseDal.Delete(t);
        }

        public Course TGetByID(int id)
        {
            return _courseDal.GetByID(id);
        }

        public List<Course> TGetList()
        {
            return _courseDal.GetList();
        }

        public void TInsert(Course t)
        {
            _courseDal.Insert(t);
        }

        public void TUpdate(Course t)
        {
            _courseDal.Update(t);
        }

        public List<Course> TgetCourseWithByCategory()
        {
            return _courseDal.getCoursesWithByCategory();
        }

        public List<Course> TGetLast5Course()
        {
            return _courseDal.GetLast5Course();
        }
    }
}
