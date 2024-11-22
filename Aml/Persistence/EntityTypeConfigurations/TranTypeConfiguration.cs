using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class TranTypeConfiguration : IEntityTypeConfiguration<TranType>
{
    public void Configure(EntityTypeBuilder<TranType> builder)
    {
        builder.ToTable("TRANTYPE");

        builder.HasKey(t => t.TranTypeId);

        builder.Property(t => t.TranTypeId)
            .ValueGeneratedNever();

        builder.Property(t => t.TranTypeCode)
            .IsRequired()
            .HasMaxLength(5);

        builder.Property(t => t.TranTypeDesc)
            .IsRequired();

        builder.HasMany(t => t.AchFileStatuses)
            .WithOne()
            .HasForeignKey(a => a.TranTypeId)
            .OnDelete(DeleteBehavior.Restrict);  // Adjust delete behavior as needed

        builder.HasMany(t => t.ClearingCodes)
            .WithOne()
            .HasForeignKey(c => c.TranTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(t => t.Vouchers)
            .WithOne()
            .HasForeignKey(v => v.TranTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(t => t.Status)
            .WithMany()
            .HasForeignKey(t => t.StatusId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

