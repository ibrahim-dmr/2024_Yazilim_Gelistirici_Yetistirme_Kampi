using Kodlama.io.DataAccess.Abstract;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business
{
    public class CourseManager
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public void AddCourse(Course course)
        {
            _courseDal.Add(course);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }

        public void DeleteCourse(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> GetFreeCourses()
        {
            return _courseDal.GetAll().Where(c => c.Price == 0).ToList();
        }
    }
}
