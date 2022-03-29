using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Interfaces;

namespace UseCase
{
    public class AddCategory : IAddCategory
    {
        private readonly ICategoryRepo categoryRepo;

        public AddCategory(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public void Execute(Category category)
        {
            categoryRepo.AddCategory(category);
        }
    }
}
