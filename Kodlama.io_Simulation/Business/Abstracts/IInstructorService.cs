using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Simulation.Business.Abstracts;

public interface IInstructorService
{
    List<Instructor> GetAllInstructors();
    Instructor GetInstructorById(int id);
    void AddInstructor(Instructor instructor);
    void UpdateInstructor(Instructor instructor);
    void DeleteInstructor(Instructor ınstructor);
}
