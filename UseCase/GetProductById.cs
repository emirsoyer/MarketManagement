using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Interfaces;

namespace UseCase
{
    public class GetProductById : IGetProductById
    {
        private readonly IProductRepo productRepo;

        public GetProductById(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }
        public Product Execute(int productId)
        {
            return productRepo.GetProductById(productId);
        }
    }
}
