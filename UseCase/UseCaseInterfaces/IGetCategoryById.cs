using Business;

namespace UseCase
{
    public interface IGetCategoryById
    {
        Category Execute(int categoryId);
    }
}