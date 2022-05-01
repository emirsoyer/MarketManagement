using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using UseCase.Interfaces;

namespace InMemoryStorage
{
    public class TransactionInMemoryRepo: ITransactionRepo
    {
        private List<Transaction> transactions;
        public TransactionInMemoryRepo()
        {
            transactions = new List<Transaction>();
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return transactions;
        }

        public IEnumerable<Transaction> GetByDate(DateTime date)
        {
            return transactions.Where(x => x.TimeStamp.Date == date.Date);
        }

        public void SaveTransaction(string sellerName, int productId, double price, int quantity)
        {
            int transactionId = 0;
            if (transactions != null && transactions.Count > 0)
            {
                int maxId = transactions.Max(x => x.TransactionId);
                transactionId = maxId + 1;
            }
            else
            {
                transactionId = 1;
            }
            transactions.Add(new Transaction
            {
                TransactionId = transactionId,
                ProductId = productId,
                Price = price,
                Quantity = quantity,
                TimeStamp = DateTime.Now,
                SellerName = sellerName
            });
        }
    }
}
