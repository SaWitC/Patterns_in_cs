using DI_REpository_UnitOfWork.Repositories;
using Microsoft.IdentityModel.Tokens;

namespace DI_REpository_UnitOfWork.Data
{
    public interface IUnitOfWork:IDisposable
    {
        IOrderRepository _orderRepository { get; }
        IUserRepository _userRepository { get; }
        Task<int> SaveChangesAsync();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IOrderRepository _orderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    return new OrderRepository(_context);
                }
                return _orderRepository;
            }
        }
        public IUserRepository _userRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    return new UserRepository(_context);
                }
                return _userRepository;
            }
        }

        public UnitOfWork(AppDbContext context)
        {
                _context =context;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
