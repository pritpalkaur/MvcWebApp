using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Business;
using MVC.Business.Interface;
using MVC.Domain;
using MVC.Data;
using MVC.Data.Interface;

namespace MVC.Business.Implementations
{
    public class ProductBusiness : IProductBusiness 
    {
        private readonly IProductDatabase _IProductDatabase;

        public ProductBusiness(IProductDatabase IProductDatabase)
        {
            _IProductDatabase = IProductDatabase;
        }

        public async Task<List<Products>> GetProductsAsync()
        {
            return await _IProductDatabase.GetProductsAsync();
        }

        public Task<List<Products>> AddProductAsync(Products products)
        {
            return _IProductDatabase.AddProductAsync(products);
        }

    }
}
