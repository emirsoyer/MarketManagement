using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Interfaces;

namespace UseCase
{
    public class GetCategoryById : IGetCategoryById
    {
        private readonly ICategoryRepo categoryRepo;

        public GetCategoryById(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }
        public Category Execute(int categoryId)
        {
            return categoryRepo.GetCategoryById(categoryId);
        }
    }
}
