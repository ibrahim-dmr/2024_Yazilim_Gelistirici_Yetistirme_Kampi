using Kodlama.io.DataAccess.Abstract;
using Kodlama.io.Entities;
using Kodlama.io_Simulation.Business.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Simulation.Business.Concretes;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAllCourse()
    {
        return _courseDal.GetAll();
    }


    public void AddCourse(Course course)
    {
        _courseDal.Add(course);
    }


    public void UpdateCourse(Course course)
    {
        _courseDal.Update(course);
    }
    public void DeleteCourse(Course course)
    {
        _courseDal.Delete(course);
    }

    public Course GetCourseByID(int id)
    {
        return _courseDal.GetById(id);
    }
}
