using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Interfaces;

namespace UseCase
{
    public class AddProduct : IAddProduct
    {
        private readonly IProductRepo productRepo;

        public AddProduct (IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }
        public void Execute(Product product)
        {
            productRepo.AddProduct(product);
        }
    }
}
