﻿using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly RepositoryContext _repositoryContext;

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext ??
                throw new ArgumentNullException(nameof(repositoryContext));
        }

        public async virtual Task<T> InsertAsync(T entity)
        {
            await _repositoryContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public virtual void Delete(T entity) => 
                                        _repositoryContext.Set<T>().Remove(entity);

        public virtual IQueryable<T> FindAll(bool tracking) =>
                                        !tracking ? _repositoryContext.Set<T>().AsNoTracking():
                                        _repositoryContext.Set<T>();

        public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool tracking) =>
                                        !tracking ?
                                        _repositoryContext.Set<T>().
                                                Where(expression).AsNoTracking() :
                                        _repositoryContext.Set<T>().
                                                Where(expression);

        public virtual void Update(T entity) =>
            _repositoryContext.Entry(entity).State = EntityState.Modified;
    }
}