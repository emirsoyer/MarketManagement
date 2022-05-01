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
        private readonly ILogTransaction _logTransaction;

        public SellProduct(IProductRepo productRepo, ILogTransaction logTransaction)
        {
            _productRepo = productRepo;
            _logTransaction = logTransaction;
        }
        public void Execute(string sellerName, int productId, int quantityToSell)
        {
            var product = _productRepo.GetProductById(productId);
            if (product == null) return;

            product.Quantity -= quantityToSell;
            _productRepo.UpdateProduct(product);
            _logTransaction.Execute(sellerName, productId, quantityToSell);
        }
    }
}
