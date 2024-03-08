using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Simulation.Business.Abstracts;

public interface ICourseService
{
    List<Course> GetAllCourse();
    Course GetCourseByID(int id);
    void AddCourse(Course course);
    void UpdateCourse(Course course);
    void DeleteCourse(Course course);
}
