using Aml.Channels.Clearing.Entities;
using Aml.Channels.IB.Entities;
using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.DataContext;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);
    }


    public DbSet<InCredit>? InCredits { get; set; }
    public DbSet<IBRule>? IBRules { get; set; }
    public DbSet<Report>? Reports { get; set; }



    public DbSet<ReturnReason>? ReturnReasons { get; set; }


}
