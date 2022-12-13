using DI_REpository_UnitOfWork.Data;
using DI_REpository_UnitOfWork.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DI_REpository_UnitOfWork.Repositories
{
    public interface IUserRepository
    {
        Task<EntityEntry<UserModel>> CrateAsync(UserModel model);
    }

    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<EntityEntry<UserModel>> CrateAsync(UserModel model)
        {
            var res = await _context.AddAsync(model);
            await _context.SaveChangesAsync();
            return res;
        }

        //etc
    }
}
