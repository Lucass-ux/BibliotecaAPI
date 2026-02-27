using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Interfaces;

internal interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> PostAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(int id);
}
