using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using UseCase.Interfaces;

namespace UseCase
{
    public class GetTransactionList : IGetTransactionList
    {
        private readonly ITransactionRepo _transactionRepo;

        public GetTransactionList(ITransactionRepo transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }
        public IEnumerable<Transaction> Execute(string sellerName, DateTime startDate, DateTime endDate)
        {
            return _transactionRepo.GetByDateRange(sellerName, startDate, endDate);
        }
    }
}
