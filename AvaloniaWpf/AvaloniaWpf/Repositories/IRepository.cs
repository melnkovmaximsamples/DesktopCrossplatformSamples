using System.Collections.Generic;
using System.Threading.Tasks;
using AvaloniaWpf.Entities;

namespace AvaloniaWpf.Repositories;

public interface IRepository<T> where T: IEntity
{
    Task AddRangeAsync(IEnumerable<T> entities);
    Task RemoveAllAsync();
    Task<IEnumerable<T>> GetAllAsync();
}