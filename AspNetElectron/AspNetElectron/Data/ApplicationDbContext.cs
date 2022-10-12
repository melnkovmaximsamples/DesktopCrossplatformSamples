using AspNetElectron.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetElectron.Data;

public class ApplicationDbContext: DbContext
{
    public DbSet<MessageEntity> Messages { get; init; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options)
    {
          
    }
}