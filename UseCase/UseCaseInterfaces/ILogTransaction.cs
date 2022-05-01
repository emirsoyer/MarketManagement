namespace UseCase
{
    public interface ILogTransaction
    {
        void Execute(string sellerName, int productId, int quantity);
    }
}