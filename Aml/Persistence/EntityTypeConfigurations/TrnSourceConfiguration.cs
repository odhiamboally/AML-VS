using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class TrnSourceConfiguration : IEntityTypeConfiguration<TrnSource>
{
    public void Configure(EntityTypeBuilder<TrnSource> builder)
    {
        builder.ToTable("TRNSOURCE");

        builder.HasKey(t => t.TrnSourceId);

        builder.Property(t => t.TrnSourceId)
            .ValueGeneratedNever();

        builder.Property(t => t.TrnSourceName)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(t => t.TrnSourceDesc)
            .IsRequired();

        builder.HasMany(t => t.OutCredits)
            .WithOne()
            .HasForeignKey(o => o.TrnSourceId)
            .OnDelete(DeleteBehavior.Restrict);  // Adjust delete behavior as needed

        builder.HasMany(t => t.OutDebits)
            .WithOne()
            .HasForeignKey(o => o.TrnSourceId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(t => t.OutRtgs)
            .WithOne()
            .HasForeignKey(o => o.TrnSourceId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

