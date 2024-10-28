using Microsoft.EntityFrameworkCore;
using Prototype.Configurations;
using Prototype.model;

namespace Prototype.data;

public class PrototypeDbContext(DbContextOptions<PrototypeDbContext> context) : DbContext(context)
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AuthorConfiguration());
        modelBuilder.ApplyConfiguration(new BookConfiguration());
    }
}