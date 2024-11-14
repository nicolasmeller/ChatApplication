using Infrastructure.Context;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly ChatDatabase _context;
        private readonly DbSet<T> _table;

        public GenericRepository(ChatDatabase context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _table.FindAsync(id);
        }

        public async Task<T> InsertAsync(T obj)
        {
            await _table.AddAsync(obj);
            return obj;
        }

        public async Task InsertRangeAsync(ICollection<T> objCollection)
        {
            await _table.AddRangeAsync(objCollection);
        }

        public void Update(T obj)
        {
            _table.Update(obj);
        }

        public void UpdateRange(IEnumerable<T> objCollection)
        {
            _table.UpdateRange(objCollection);
        }

        public async Task RemoveAsync(int id)
        {
            T? existing = await _table.FindAsync(id);
            if (existing != null)
                _table.Remove(existing);
        }

        public void RemoveRange(ICollection<T> objCollection)
        {
            _table.RemoveRange(objCollection);
        }

        public IEnumerable<T> GetAllByProperty(Func<T, bool> func)
        {
            return _table.Where(func);
        }

        public async Task ReloadEntityAsync(T entity)
        {
            await _table.Entry(entity).ReloadAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}