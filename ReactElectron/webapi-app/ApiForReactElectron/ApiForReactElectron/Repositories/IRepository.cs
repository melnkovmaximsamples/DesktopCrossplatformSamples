using ApiForReactElectron.Entities;

namespace ApiForReactElectron.Repositories;

public interface IRepository<T> where T: IEntity
{
    Task AddAsync(T entity);
    Task RemoveAllAsync();
    Task<IEnumerable<T>> GetAllAsync();
}