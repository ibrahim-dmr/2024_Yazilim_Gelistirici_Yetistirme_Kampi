using Kodlama.io.Entities;
using Kodlama.io_Simulation.Business.Abstracts;
using Kodlama.io_Simulation.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Simulation.Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public List<Category> GetAllCategories()
    {
        return _categoryDal.GetAll();
    }
    public void AddCategory(Category category)
    {
        _categoryDal.Add(category);
    }

    public void DeleteCategory(Category category)
    {
        _categoryDal.Delete(category);
    }


    public Category GetCategoryById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateCategory(Category category)
    {
        _categoryDal.Update(category);
    }
}
