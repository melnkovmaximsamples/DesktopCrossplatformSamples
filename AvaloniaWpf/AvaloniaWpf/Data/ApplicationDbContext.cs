using AvaloniaWpf.Entities;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaWpf.Data;

public class ApplicationDbContext: DbContext
{
     public DbSet<Message> Messages { get; init; }

     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          :base(options)
     {
          
     }
}