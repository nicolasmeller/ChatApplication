namespace Infrastructure.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T?> GetByIdAsync(int Id);

        Task<T> InsertAsync(T obj);

        Task InsertRangeAsync(ICollection<T> objCollection);

        Task RemoveAsync(int Id);

        IEnumerable<T> GetAllByProperty(Func<T, bool> func);

        Task ReloadEntityAsync(T entity);

        Task SaveAsync();

        void Update(T obj);

        void UpdateRange(IEnumerable<T> objCollection);

    }
}
