using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizGameAPI.Repositories
{
    public interface IRepository<T>
    {
        Task<IQueryable<T>> GetAsync();
        Task<T?> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteAllAsync(IEnumerable<T> entities);
    }
}