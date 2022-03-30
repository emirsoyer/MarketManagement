using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Interfaces;

namespace UseCase
{
    public class DeleteCategory : IDeleteCategory
    {
        private readonly ICategoryRepo categoryRepo;

        public DeleteCategory(ICategoryRepo categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }
        public void Delete(int categoryId)
        {
            categoryRepo.DeleteCategory(categoryId);
        }
    }
}
