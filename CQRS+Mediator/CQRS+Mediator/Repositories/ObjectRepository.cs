using CQRS_Mediator.Data;
using CQRS_Mediator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CQRS_Mediator.Repositories
{
    public class ObjectRepository
    {
        private readonly AppDbContext _context;

        public ObjectRepository(AppDbContext context)
        {
            _context=context;
        }

        public async Task<EntityEntry<ObjectModel>> CreateASync(ObjectModel model)
        {
            var res = await _context.Objects.AddAsync(model);
            await _context.SaveChangesAsync();
            return res;
        }

        public async Task<int> DeleteByIdAsync(string id)
        {
            var entity = await _context.Objects.FirstOrDefaultAsync(x=>x.Id==id);
            if (entity != null)
            {
                _context.Objects.Remove(entity);
                return await _context.SaveChangesAsync();
            }

            return 0;
        }

        public async Task<ObjectModel> GetByIdAsync(string id)
        {
            return await _context.Objects.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(string id,ObjectModel model)
        {
            var entity = _context.Objects.FirstOrDefaultAsync(x => x.Id == id);
            if (entity != null)
            {
                model.Id = id;
                _context.Update(model);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
