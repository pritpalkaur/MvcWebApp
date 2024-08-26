 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Domain;
using Microsoft.EntityFrameworkCore;
using MVC.Data.Interface;

namespace MVC.Data.Implementations
{
       public class ProductDatabase : IProductDatabase
        {
            private readonly MVCApplicationDbContext _context;
            public ProductDatabase(MVCApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<Products>> GetProductsAsync()
            {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
                var result = await _context.Products.ToListAsync();
                return result;
            }

        }
 }

