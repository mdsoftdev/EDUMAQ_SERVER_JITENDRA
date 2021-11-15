using System;
using System.Threading.Tasks;
using System.Linq;
using Edumaq.Repository.Interfaces;
using Edumaq.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Edumaq.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class, IBaseEntity
    {
        private readonly EdumaqDBContext _dbContext;

        public RepositoryBase(EdumaqDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return _dbContext.Set<TEntity>().AsNoTracking();
            }
            catch (Exception ex) {
                return null; 
            }
            
        }

        public async Task<TEntity> GetById(long id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex) {
                string msg = ex.Message;
            }

            return entity;
        }
        public async Task Update(long id, TEntity entity)
        {
            _dbContext.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task Delete(long id)
        {
            var entity = _dbContext.Set<TEntity>().Find(id);
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public bool IsExists(Expression<Func<TEntity, bool>> expr)
        {
            return _dbContext.Set<TEntity>().Any(expr);
        }

    }
}
