using Microsoft.EntityFrameworkCore;

namespace DI_REpository_UnitOfWork.Data
{
    public class AppDbContext:DbContext
    { 
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
