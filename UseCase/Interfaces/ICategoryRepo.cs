using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase.Interfaces
{
    public interface ICategoryRepo
    {
        public IEnumerable<Category> GetCategories();
    }
}
