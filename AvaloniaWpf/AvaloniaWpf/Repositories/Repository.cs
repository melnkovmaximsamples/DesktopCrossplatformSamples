using System.Collections.Generic;
using System.Threading.Tasks;
using AvaloniaWpf.Data;
using AvaloniaWpf.Entities;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaWpf.Repositories;

public class Repository<T>: IRepository<T> where T: class, IEntity
{
    private readonly ApplicationDbContext _db;

    public Repository(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public async Task AddRangeAsync(IEnumerable<T> entities)
    {
        await _db.Set<T>().AddRangeAsync(entities);
        await _db.SaveChangesAsync();
    }

    public async Task RemoveAllAsync()
    {
        _db.Set<T>().RemoveRange(_db.Set<T>());
        
        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync() => await _db.Set<T>().ToListAsync();
}