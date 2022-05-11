using Business;
using System;
using System.Collections.Generic;

namespace UseCase
{
    public interface IGetTransactionList
    {
        IEnumerable<Transaction> Execute(string sellerName, DateTime startDate, DateTime endDate);
    }
}