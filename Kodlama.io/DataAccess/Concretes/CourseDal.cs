using Kodlama.io.DataAccess.Abstract;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "Senior Yazılım Geliştirici Yetiştirme Kampı";
            course1.Description = ".NET";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "2024 Yazılım Geliştirici Yetiştirme Kampı";
            course2.Description = "C#";
            course2.Price = 0;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "2023 Yazılım Geliştirici Yetiştirme Kampı";
            course3.Description = "Python & Selenium";
            course3.Price = 0;

            Course course4 = new Course();
            course4.Id = 4;
            course4.Name = "2022 Yazılım Geliştirici Yetiştirme Kampı";
            course4.Description = "JAVA";
            course4.Price = 0;

            Course course5 = new Course();
            course5.Id = 5;
            course5.Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
            course5.Description = "1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
            course5.Price = 0;

            Course course6 = new Course();
            course6.Id = 6;
            course6.Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + React)";
            course6.Description = "2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
            course6.Price = 0;

            Course course7 = new Course();
            course7.Id = 7;
            course7.Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + Angular)";
            course7.Description = "2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.";
            course7.Price = 0;

            Course course8 = new Course();
            course8.Id = 8;
            course8.Name = "Programlamaya Giriş İçin Temel Kurs";
            course8.Description = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.";
            course8.Price = 0;

            courses = new List<Course> { course1, course2, course3, course4, course5, course6, course7, course8 };
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetById(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }
        
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Update(Course course)
        {
            var existingCourse = courses.FirstOrDefault(c =>c.Id == course.Id);
            if(existingCourse != null)
            {
                existingCourse.Name = course.Name;
                existingCourse.Description = course.Description;
                existingCourse.Price = course.Price;
            }
        }

        public void Delete(int id)
        {
            var courseToDelete = courses.FirstOrDefault(c => c.Id==id);
            if(courseToDelete != null)
            {
                courses.Remove(courseToDelete);
            }
        }

        public void Delete(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
