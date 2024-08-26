
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MVC.Domain;
using Microsoft.EntityFrameworkCore;

namespace MVC.Data.Interface
{
    public interface IProductDatabase
    {
        Task<List<Products>> GetProductsAsync();
    }
}
