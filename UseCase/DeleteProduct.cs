using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Interfaces;

namespace UseCase
{
    public class DeleteProduct : IDeleteProduct
    {
        private readonly IProductRepo productRepo;

        public DeleteProduct(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }
        public void Execute(int productId)
        {
            productRepo.DeleteProduct(productId);
        }
    }
}
