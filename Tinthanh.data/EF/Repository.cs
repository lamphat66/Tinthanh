﻿using Microsoft.EntityFrameworkCore;

using Tinthanh.App.Tiepnhan;

namespace Tinthanh.Data.EF
{
    public class Repository<TEntity> : IRepository<TEntity> 
        where TEntity:class
    {
        private readonly TinthanhDBContext _context;
        public Repository(TinthanhDBContext context) 
        {
            _context = context;
        }
        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
           return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public IQueryable<TEntity> GetQueryable()
        {
           return _context.Set<TEntity>();
        }

        public void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public Task SaveChangeAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}
