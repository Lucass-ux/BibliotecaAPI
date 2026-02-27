using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Interfaces;

internal interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    T PostAsync(T entity);
    T UpdateAsync(T entity);
    T DeleteAsync(int id);
}
