using Kodlama.io.Entities;
using Kodlama.io_Simulation.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Simulation.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;

    public InstructorDal()
    {
        _instructors = new List<Instructor>();

        Instructor instructor1 = new Instructor();
        instructor1.Id = 1;
        instructor1.FirstName = "Engin";
        instructor1.LastName = "Demiroğ";

        Instructor instructor2 = new Instructor();
        instructor2.Id = 2;
        instructor2.FirstName = "Halit Enes";
        instructor2.LastName = "Kalaycı";
    }

    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _instructors.Remove(instructor);
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public Instructor GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Instructor instructor)
    {
        throw new NotImplementedException();
    }
}
