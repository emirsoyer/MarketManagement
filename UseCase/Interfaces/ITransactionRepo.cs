using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace UseCase.Interfaces
{
    public interface ITransactionRepo
    {
        public IEnumerable<Transaction> GetTransactions(string sellerName);
        public IEnumerable<Transaction> GetByDate(string sellerName, DateTime date);
        public void SaveTransaction(string sellerName, int productId, string productName, double price, int beforeQuantity ,int soldQuantity);

    }
}
