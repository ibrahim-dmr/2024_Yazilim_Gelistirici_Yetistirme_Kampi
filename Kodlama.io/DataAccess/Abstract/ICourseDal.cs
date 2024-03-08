﻿using Kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Abstract
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        Course GetById(int id);
        void Add(Course course);
        void Update (Course course);    
        void Delete(Course course); 
    }


}
