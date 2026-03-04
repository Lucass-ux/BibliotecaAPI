using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Biblioteca.Domain.Interfaces;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(Expression<Func<T,bool>> predicate);
    Task<T?> AddAsync(T entity);
    T Update(T entity);
    T Delete(T entity);
}
