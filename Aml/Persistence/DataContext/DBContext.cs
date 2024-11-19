using Aml.Channels.IB.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.DataContext;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);
    }

    public DbSet<IBRule> Rules { get; set; }
    public DbSet<Report> Reports { get; set; }
}
