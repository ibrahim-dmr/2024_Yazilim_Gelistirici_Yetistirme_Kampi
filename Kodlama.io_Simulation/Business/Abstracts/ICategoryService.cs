using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Simulation.Business.Abstracts;

public interface ICategoryService
{
    List<Category> GetAllCategories();
    Category GetCategoryById(int id);
    void AddCategory(Category category);
    void UpdateCategory(Category category);
    void DeleteCategory(Category category);
}
