using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Interfaces;

namespace UseCase
{
    public class EditCategory : IEditCategory
    {
        private readonly ICategoryRepo categoryRepo;

        public EditCategory(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public void Execute(Category category)
        {
            categoryRepo.UpdateCategory(category);
        }
    }
}
