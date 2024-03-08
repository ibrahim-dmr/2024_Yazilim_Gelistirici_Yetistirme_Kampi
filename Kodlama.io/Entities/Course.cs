using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Entities
{
    public class Course 
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }


 

        public void GenerateDescription(string newDescripton)
        {
            Description = newDescripton;
        }
    }
}
