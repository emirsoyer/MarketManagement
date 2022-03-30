using Business;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.CategoryName.Equals(category.CategoryName, StringComparison.OrdinalIgnoreCase))) return;

            if (categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = +maxId; //maxId + 1
            }
            else
            {
                category.CategoryId = 1;
            }

            categories.Add(category);
        }
        public void UpdateCategory(Category category)
        {
            var updateCategory = GetCategoryById(category.CategoryId);
            if (updateCategory != null)
            {
                updateCategory.CategoryName = category.CategoryName;
                updateCategory.CategoryDescription = category.CategoryDescription;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId)); 
        }
    }
}
