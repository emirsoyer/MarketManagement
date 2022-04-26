using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase.Interfaces
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Product GetProductById(int productId);
        void DeleteProduct(int productId);
        IEnumerable<Product> GetProductByCategoryId(int categoryId);
    }
}
