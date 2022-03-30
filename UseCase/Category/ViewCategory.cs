using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Interfaces;

namespace UseCase
{
    public class ViewCategory : IViewCategory
    {
        private readonly ICategoryRepo categoryRepo;

        public ViewCategory(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }
        public IEnumerable<Category> Execute()
        {
            return categoryRepo.GetCategories();
        }
    }
}
