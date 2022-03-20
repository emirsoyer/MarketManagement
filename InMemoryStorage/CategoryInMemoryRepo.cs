using Business;
using System;
using System.Collections.Generic;
using UseCase.Interfaces;

namespace InMemoryStorage
{
    public class CategoryInMemoryRepo : ICategoryRepo
    {
        private List<Category> categories;
        public CategoryInMemoryRepo()
        {
            categories = new List<Category>()
            {
                new Category{CategoryId = 1, CategoryName = "Electronics", CategoryDescription = "Eletronic Devices"},
                new Category{CategoryId = 2, CategoryName = "Furniture", CategoryDescription = "House Furnitures" },
                new Category{CategoryId = 3, CategoryName = "Mobile", CategoryDescription = "Mobile Devices"},
                new Category{CategoryId = 4, CategoryName = "OEM", CategoryDescription = "Computer Parts"}
            };
        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}
