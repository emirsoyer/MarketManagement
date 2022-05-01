namespace UseCase
{
    public interface ISellProduct
    {
        void Execute(string sellerName, int productId, int quantityToSell);
    }
}