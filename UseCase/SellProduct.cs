using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Interfaces;

namespace UseCase
{
    public class SellProduct : ISellProduct
    {
        private readonly IProductRepo _productRepo;

        public SellProduct(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public void Execute(int productId, int quantityToSell)
        {
            var product = _productRepo.GetProductById(productId);
            if (product == null) return;

            product.Quantity -= quantityToSell;
            _productRepo.UpdateProduct(product);
        }
    }
}
