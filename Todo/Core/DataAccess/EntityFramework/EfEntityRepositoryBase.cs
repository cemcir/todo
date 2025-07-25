using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext
    {
        protected readonly TContext _context;

        public EfEntityRepositoryBase(TContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            entity.CreatedAt = DateTime.Now;
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        //public async Task AddAsync(TEntity entity)
        //{
        //    entity.CreatedAt = DateTime.Now;
        //    await _context.Set<TEntity>().AddAsync(entity);
        //    await _context.SaveChangesAsync();
        //}

        public void AddRange(List<TEntity> entities)
        {
            DateTime date = DateTime.Now;
            for(int i = 0; i<entities.Count; i++)
            {
                entities[i].CreatedAt = date;
            }

            _context.Set<TEntity>().AddRange(entities);
            _context.SaveChanges();
        }

        public void Delete(Expression<Func<TEntity,bool>> filter)
        {
            var entity = _context.Set<TEntity>().SingleOrDefault(filter);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _context.SaveChanges();
            }
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _context.Set<TEntity>().ToList()
                : _context.Set<TEntity>().Where(filter).ToList();
        }

        public int TotalRecord(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                   ? _context.Set<TEntity>().Count()
                   : _context.Set<TEntity>().Where(filter).Count();
        }

        public void Update(TEntity entity)
        {
            entity.UpdatedAt = DateTime.Now;
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
