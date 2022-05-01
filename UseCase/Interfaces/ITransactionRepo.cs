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
        public IEnumerable<Transaction> GetTransactions();
        public IEnumerable<Transaction> GetByDate(DateTime date);
        public void SaveTransaction(string sellerName, int productId, double price, int quantity);
    }
}
