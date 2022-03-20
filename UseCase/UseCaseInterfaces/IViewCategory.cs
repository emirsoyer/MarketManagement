using Business;
using System.Collections.Generic;

namespace UseCase
{
    public interface IViewCategory
    {
        IEnumerable<Category> Execute();
    }
}