using Edumaq.Service.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

using Edumaq.Repository.Interfaces;
using Edumaq.DataAccess.Models;
using System.Linq.Expressions;

namespace Edumaq.Service
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class,IBaseEntity
    {
        protected IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public Task<TEntity> Create(TEntity entity)
        {
            return _repository.Create(entity);
        }

        public Task Delete(long id)
        {
            return _repository.Delete(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<TEntity> GetById(long id)
        {
            return _repository.GetById(id);
        }

        public Task Update(long id, TEntity entity)
        {
            return _repository.Update(id,entity);
        }

        public bool IsExists(Expression<Func<TEntity, bool>> expr)
        {
            return _repository.IsExists(expr);
        }
    }
}
