using Microsoft.EntityFrameworkCore;
using QuizGameAPI.data;
using QuizGameAPI.Repositories;

namespace QuizGame.Data.Repositories;

public class Repository<T>(QuizGameContext context) : IRepository<T> where T : class
{
  private readonly QuizGameContext _context = context;
  private readonly DbSet<T> _dbSet = context.Set<T>();

  public async Task<T> AddAsync(T entity)
  {
    await _dbSet.AddAsync(entity);
    await _context.SaveChangesAsync();

    return entity;
  }

  public async Task DeleteAllAsync(IEnumerable<T> entities)
  {
    _dbSet.RemoveRange(entities);
    await _context.SaveChangesAsync();
  }

  public async Task DeleteAsync(T entity)
  {
    _dbSet.Remove(entity);
    await _context.SaveChangesAsync();
  }

  public async Task<IQueryable<T>> GetAsync()
  {
    return _dbSet.AsQueryable();
  }

  public async Task<T?> GetByIdAsync(int id)
  {
    return await _dbSet.FindAsync(id);
  }

  public async Task UpdateAsync(T entity)
  {
    _dbSet.Entry(entity).State = EntityState.Modified;
    await _context.SaveChangesAsync();
  }
}