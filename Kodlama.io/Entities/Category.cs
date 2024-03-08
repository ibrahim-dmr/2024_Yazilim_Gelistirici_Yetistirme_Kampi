using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Entities
{
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Category(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }
        public void updateName(string newName)
        {
            Name = newName;
        }
    }
}

   
