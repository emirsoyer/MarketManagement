using System.Collections.Generic;
using Business;

namespace UseCase
{
    public interface IGetTransaction
    {
        IEnumerable<Transaction> Execute(string sellerName);
    }
}