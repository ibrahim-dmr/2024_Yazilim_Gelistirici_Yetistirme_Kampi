using Kodlama.io.DataAccess.Abstract;
using Kodlama.io.Entities;
using Kodlama.io_Simulation.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> _categories;
    public CategoryDal()
    {
        _categories = [new Category { Id = 1, Name = "Programlama"}];
    }

    public void Add(Category category)
    {
        _categories.Add(category);
    }


    public void Delete(Category category)
    {
        _categories.Remove(category);
    }

    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Category GetById(Course id)
    {
        throw new NotImplementedException();
    }

    public void Update(Category category)
    {
        throw new NotImplementedException();
    }
}
