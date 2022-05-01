namespace UseCase
{
    public interface ISellProduct
    {
        void Execute(int productId, int quantityToSell);
    }
}