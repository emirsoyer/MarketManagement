using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCase.Interfaces;

namespace InMemoryStorage
{
    public class ProductInMemoryRepo : IProductRepo
    {

        private List<Product> products;
        
        public ProductInMemoryRepo()
        {
            products = new List<Product>()
            {
                new Product {ProductId = 1, ProductName = "Calculator", CategoryId = 1, Price = 10, Quantity = 30},
                new Product {ProductId = 2, ProductName = "TV Unit", CategoryId = 2, Price = 65, Quantity = 5},
                new Product {ProductId = 3, ProductName = "iPhone", CategoryId = 3, Price = 600, Quantity = 15},
                new Product {ProductId = 4, ProductName = "Graphics Card", CategoryId = 4, Price = 400, Quantity = 10},
                new Product {ProductId = 5, ProductName = "Intel CPU", CategoryId = 4, Price = 265, Quantity = 10},
                new Product {ProductId = 6, ProductName = "Microwave", CategoryId = 4, Price = 270, Quantity = 20}
            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.ProductName.Equals(product.ProductName, StringComparison.OrdinalIgnoreCase))) return;

            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = +maxId; //maxId + 1
            }
            else
            {
                product.ProductId = 1;
            }

            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
            var updateProduct = GetProductById(product.ProductId);
            if(updateProduct != null)
            {
                updateProduct.ProductName = product.ProductName;
                updateProduct.CategoryId = product.CategoryId;
                updateProduct.Quantity = product.Quantity;
                updateProduct.Price = product.Price;               
            }
        }
        public Product GetProductById(int productId)
        {
            return products?.FirstOrDefault(x => x.ProductId == productId);
        }

        public void DeleteProduct(int productId)
        {
            var productRemove = GetProductById(productId);
            if(productRemove != null)
            {
                products.Remove(productRemove);
            }
        }

        public IEnumerable<Product> GetProductByCategoryId(int categoryId)
        {
            return products.Where(x => x.CategoryId == categoryId);
        }
    }
}
