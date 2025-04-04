using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Engine> Engines { get; set; }
    public DbSet<Car> Cars { get; set; }
    
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
}