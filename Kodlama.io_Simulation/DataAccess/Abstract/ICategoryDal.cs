using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Simulation.DataAccess.Abstract;

public interface ICategoryDal
{
    List<Category> GetAll();
    Category GetById(Course id);
    void Add(Category category);
    void Update(Category category); 
    void Delete(Category category);

}
