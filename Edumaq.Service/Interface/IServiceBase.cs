﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Edumaq.Service.Interface
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(long id);

        Task<TEntity> Create(TEntity entity);

        Task Update(long id, TEntity entity);

        Task Delete(long id);
        bool IsExists(Expression<Func<TEntity, bool>> expr);
    }
}
