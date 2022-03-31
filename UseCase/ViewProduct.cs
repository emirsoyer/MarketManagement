using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Interfaces;

namespace UseCase
{
    public class ViewProduct : IViewProducts
    {
        private readonly IProductRepo productRepo;

        public ViewProduct (IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }

        public IEnumerable<Product> Execute()
        {
            return productRepo.GetProducts();
        }

    }
}
