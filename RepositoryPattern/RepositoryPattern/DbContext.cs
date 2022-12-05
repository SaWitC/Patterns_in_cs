using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern
{
    public class DbContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext()
        {
                
        }

        public DbSet<ProductModel> Products;
    }
}
