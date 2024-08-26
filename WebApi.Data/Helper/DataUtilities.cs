using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MVC.Data.Helpers
{
    public class DataUtilities
    {

        private readonly MVCApplicationDbContext _context;

        public DataUtilities(MVCApplicationDbContext context)
        {
            _context = context;
        }
                
       // public static string[] SortTypes = { "ASC", "DESC" };

  
    }
}
