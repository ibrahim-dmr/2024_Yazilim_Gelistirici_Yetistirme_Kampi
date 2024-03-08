using Kodlama.io.Entities;
using Kodlama.io_Simulation.Business.Abstracts;
using Kodlama.io_Simulation.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Simulation.Business.Concretes;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _instructorDal;
    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void AddInstructor(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void DeleteInstructor(Instructor ınstructor)
    {
        _instructorDal.Delete(ınstructor);
    }

    public List<Instructor> GetAllInstructors()
    {
        return _instructorDal.GetAll();
    }

    public Instructor GetInstructorById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateInstructor(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }
}
