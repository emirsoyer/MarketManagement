using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Interfaces;

namespace UseCase
{
    public class LogTransaction : ILogTransaction
    {
        private readonly ITransactionRepo _transactionRepo;
        private readonly IGetProductById _getProductById;

        public LogTransaction(ITransactionRepo transactionRepo, IGetProductById getProductById)
        {
            _transactionRepo = transactionRepo;
            _getProductById = getProductById;
        }
        public void Execute(string sellerName, int productId, int quantity)
        {
            var product = _getProductById.Execute(productId);
            _transactionRepo.SaveTransaction(sellerName, productId,  product.Price.Value, quantity);
        }
    }
}
