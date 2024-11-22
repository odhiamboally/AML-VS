using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class RegionConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("REGION");

        builder.HasKey(r => r.RegionId);

        builder.Property(r => r.RegionId)
            .ValueGeneratedNever();

        builder.Property(r => r.RegionCode)
            .IsRequired()
            .HasMaxLength(5);

        builder.Property(r => r.RegionName)
            .IsRequired();

        builder.HasMany(r => r.Achcheques)
            .WithOne()
            .HasForeignKey(a => a.RegionId)
            .OnDelete(DeleteBehavior.Restrict);  // Adjust delete behavior based on your model's needs

        builder.HasMany(r => r.Branches)
            .WithOne()
            .HasForeignKey(b => b.RegionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(r => r.Incheques)
            .WithOne()
            .HasForeignKey(i => i.RegionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(r => r.Outcheques)
            .WithOne()
            .HasForeignKey(o => o.RegionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(r => r.Salaries)
            .WithOne()
            .HasForeignKey(s => s.RegionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(r => r.Status)
            .WithMany()
            .HasForeignKey(r => r.StatusId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

