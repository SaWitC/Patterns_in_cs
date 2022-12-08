using CQRS_Mediator.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Mediator.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext():base()
        {
                
        }

        public DbSet<ObjectModel> Objects;
    }
}
