using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using UseCase.Interfaces;

namespace UseCase
{
    public class GetTransaction : IGetTransaction
    {
        private readonly ITransactionRepo _transactionRepo;

        public GetTransaction(ITransactionRepo transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }
        public IEnumerable<Transaction> Execute(string sellerName)
        {
            return _transactionRepo.GetByDate(sellerName, DateTime.Now);
        }
    }
}
