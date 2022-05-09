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

        public IEnumerable<Transaction> GetTransactions(string sellerName)
        {
            if (string.IsNullOrWhiteSpace(sellerName))
            {
                return transactions;
            }
            else
            {
                return transactions.Where(x =>
                    string.Equals(x.SellerName, sellerName, StringComparison.OrdinalIgnoreCase));
            }
            
        }

        public IEnumerable<Transaction> GetByDate(string sellerName ,DateTime date)
        {
            if (string.IsNullOrWhiteSpace(sellerName))
            {
                return transactions.Where(x => x.TimeStamp.Date == date.Date);
            }
            else
            {
                return transactions.Where(x =>
                    string.Equals(x.SellerName, sellerName, StringComparison.OrdinalIgnoreCase) && x.TimeStamp.Date == date.Date);
            }
        }

        public void SaveTransaction(string sellerName, int productId, string productName, double price, int beforeQuantity ,int soldQuantity)
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
                ProductName = productName,
                Price = price,
                BeforeQuantity = beforeQuantity,
                SoldQuantity = soldQuantity,
                TimeStamp = DateTime.Now,
                SellerName = sellerName
            });
        }
    }
}
