﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategory(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);

    }
}
