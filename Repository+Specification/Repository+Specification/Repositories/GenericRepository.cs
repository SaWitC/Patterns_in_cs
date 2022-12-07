using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repository_Specification.Data;
using Repository_Specification.Models;
using Repository_Specification.Specifications;

namespace Repository_Specification.Repositories
{
    public class GenericRepository<T>:RepositoryBase<T> where T: class,IHasId
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context):base(context)
        {
            _context = context;
        }

        public IEnumerable<T> GetOrdersByPage(int page, int size)
        {
            var specification = new GetByPageSpecification<T>(page, size);//specification 
            return SpecificationEvaluator.Default.GetQuery(_context.Set<T>().AsNoTracking(),specification);
        }

        public async Task<EntityEntry<T>> CreateAsync(T model)
        {
            var entity =await _context.Set<T>().AddAsync(model);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> Delete(string id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(o=>o.Id==id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public Task<T> GetByIdAsync(string id)
        {
            return _context.Set<T>().FirstOrDefaultAsync(o=>o.Id==id);
        }
    }
}
