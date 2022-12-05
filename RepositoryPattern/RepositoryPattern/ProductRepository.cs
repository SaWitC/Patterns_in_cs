using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace RepositoryPattern
{
    public class ProductRepository
    {
        private readonly DbContext _context;
        public ProductRepository( DbContext context)
        {
            _context = context;
        }
        //Create
        public async Task<EntityEntry<ProductModel>> CreateAsync(ProductModel model)
        {
            model.Id = Guid.NewGuid().ToString();
            var entity = await _context.Products.AddAsync(model);
            await _context.SaveChangesAsync();
            return entity;
        }
        //get 
        public async Task<ProductModel> GetByIdAsync(string id)
        {
            var entity = await _context.Products.FirstOrDefaultAsync(x=>x.Id==id);
            return entity;
        }
        //delete
        public async Task<int> DeleteAsync(string id)
        {
            var entity = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            _context.Products.Remove(entity);
            return await _context.SaveChangesAsync();
        }
        //update
        public async Task<ProductModel> Update(ProductModel model,string id)
        {
            var entity = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            ProductModel updatedEntity = null;
            if (entity != null)
            {
                model.Id=entity.Id;
                updatedEntity= _context.Products.Update(model).Entity;
            }
            await _context.SaveChangesAsync();
            return updatedEntity;
        }
    }
}
