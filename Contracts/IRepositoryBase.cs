﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool tracking);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool tracking);
        Task<T> InsertAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
