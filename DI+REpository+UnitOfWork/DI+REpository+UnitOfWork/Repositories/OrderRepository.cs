using DI_REpository_UnitOfWork.Data;
using DI_REpository_UnitOfWork.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DI_REpository_UnitOfWork.Repositories
{
    public interface IOrderRepository
    {
        Task<EntityEntry<OrderModel>> CrateAsync(OrderModel model);
    }

    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;
        public OrderRepository(AppDbContext context)
        {
                _context =context;
        }

        public async Task<EntityEntry<OrderModel>> CrateAsync(OrderModel model)
        {
            var res = await _context.AddAsync(model);
            await _context.SaveChangesAsync();
            return res;
        }

        //etc
    }
}
