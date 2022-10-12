using AspNetElectron.Entities;

namespace AspNetElectron.Repositories;

public interface IRepository<T> where T: IEntity
{
    Task AddAsync(T entity);
    Task RemoveAllAsync();
    Task<IEnumerable<T>> GetAllAsync();
}