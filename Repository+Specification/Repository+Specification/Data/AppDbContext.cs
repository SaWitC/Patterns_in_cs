using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repository_Specification.Models;

namespace Repository_Specification.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() : base()
        {

        }

        public DbSet<OrderModel> Orders;
        public DbSet<ItemMode> Items;

    }
}
