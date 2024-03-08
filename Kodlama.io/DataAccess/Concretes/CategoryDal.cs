using Kodlama.io.DataAccess.Abstract;
using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concretes
{
    public class CategoryDal   
    {
        List<Category> categories;
        public CategoryDal()
        {
            Category category1 = new Category(1, "Tümü");
            category1.Id = 1;
            category1.Name = "Tümü";

            Category category2 = new Category(2, "Programlama");
            category2.Id = 2;
            category2.Name = "Programlama";
        }
    }
}
