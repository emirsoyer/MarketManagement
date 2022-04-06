using Business;

namespace UseCase
{
    public interface IGetProductById
    {
        Product Execute(int productId);
    }
}