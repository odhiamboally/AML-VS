using Aml.Channels.IB.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aml.Channels.IB.Persistence.DataContext;

public class IBDataContext : DbContext
{
    public IBDataContext(DbContextOptions<DbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);
    }

    public DbSet<IBRule> Rules { get; set; }
    public DbSet<Report> Reports { get; set; }
}
