﻿using MyShop.Data.Repositories.Interfaces;
using MyShop.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Data.Repositories.Implementations
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category> 
        {
            new Category{CategoryId=1, CategoryName="Fruit pies", Description="All-fruity pies"},
            new Category{CategoryId=2, CategoryName="Seasonal pies", Description="Cheesy all the way"},
            new Category{CategoryId=3, CategoryName="Fruit pies", Description="Get in the mood for a seasonal pie"}

        };
    }
}
