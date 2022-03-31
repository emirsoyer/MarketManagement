using Business;
using System.Collections.Generic;

namespace UseCase
{
    public interface IViewProducts
    {
        IEnumerable<Product> Execute();
    }
}