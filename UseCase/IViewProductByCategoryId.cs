using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace UseCase
{
    public interface IViewProductByCategoryId
    {
        IEnumerable<Product> Execute(int categoryId);
    }
}
