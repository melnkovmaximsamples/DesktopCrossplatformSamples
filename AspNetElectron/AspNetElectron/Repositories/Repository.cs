using AspNetElectron.Data;
using AspNetElectron.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetElectron.Repositories;

public class Repository<T>: IRepository<T> where T: class, IEntity
{
    private readonly ApplicationDbContext _db;

    public Repository(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public async Task AddAsync(T entity)
    {
        await _db.Set<T>().AddAsync(entity);
        await _db.SaveChangesAsync();
    }

    public async Task RemoveAllAsync()
    {
        _db.Set<T>().RemoveRange(_db.Set<T>());
        
        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync() => await _db.Set<T>().ToListAsync();
}