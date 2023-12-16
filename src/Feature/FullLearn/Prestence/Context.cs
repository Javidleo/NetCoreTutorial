using FullLearn.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FullLearn.Prestence;

public class Context : DbContext
{
    public Context(DbContextOptions options) : base (options) 
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<Courses> Courses { get; set; }
}
