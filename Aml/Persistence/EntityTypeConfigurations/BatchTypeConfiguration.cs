using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class BatchTypeConfiguration : IEntityTypeConfiguration<BatchType>
{
    public void Configure(EntityTypeBuilder<BatchType> builder)
    {
        builder.ToTable("BATCHTYPE");

        builder.HasKey(b => b.BatchTypeId);

        builder.Property(b => b.BatchTypeId)
            .ValueGeneratedNever(); // Since DatabaseGeneratedOption.None is used

        builder.Property(b => b.BatchTypeCode)
            .HasMaxLength(3)
            .IsRequired(false); // This allows for null BatchTypeCode, adjust as needed

        builder.Property(b => b.BatchTypeDesc)
            .HasMaxLength(500); // Adjust length based on requirements

        builder.HasMany(b => b.Batches)
            .WithOne(b => b.BatchType)
            .HasForeignKey(b => b.BatchTypeId)
            .OnDelete(DeleteBehavior.Cascade);  // Adjust delete behavior as needed

        builder.HasMany(b => b.BatchMasters)
            .WithOne(bm => bm.BatchType)
            .HasForeignKey(bm => bm.BatchTypeId)
            .OnDelete(DeleteBehavior.Cascade);  // Adjust delete behavior as needed
    }
}

