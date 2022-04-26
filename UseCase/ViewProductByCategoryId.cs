using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using UseCase.Interfaces;

namespace UseCase
{
    public class ViewProductByCategoryId : IViewProductByCategoryId
    {
        private readonly IProductRepo _productRepo;

        public ViewProductByCategoryId(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public IEnumerable<Product> Execute(int categoryId)
        {
            return _productRepo.GetProductByCategoryId(categoryId);
        }
    }

    
}
