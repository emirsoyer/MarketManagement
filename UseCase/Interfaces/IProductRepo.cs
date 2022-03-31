﻿using Business;
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
    }
}