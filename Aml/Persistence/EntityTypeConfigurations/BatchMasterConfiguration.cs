using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class BatchMasterConfiguration : IEntityTypeConfiguration<BatchMaster>
{
    public void Configure(EntityTypeBuilder<BatchMaster> builder)
    {
        builder.ToTable("BATCHMASTER");

        builder.HasKey(bm => bm.BatchMasterId);

        builder.Property(bm => bm.BatchMasterId)
            .ValueGeneratedOnAdd(); // As DatabaseGeneratedOption.Identity is used

        builder.Property(bm => bm.BatchNo)
            .HasMaxLength(4)
            .IsRequired();

        builder.HasOne(bm => bm.BatchType)
            .WithMany(bt => bt.BatchMasters)
            .HasForeignKey(bm => bm.BatchTypeId)
            .OnDelete(DeleteBehavior.Cascade);  // Adjust delete behavior as needed

        builder.HasOne(bm => bm.Branch)
            .WithMany(b => b.BatchMasters)
            .HasForeignKey(bm => bm.BranchId)
            .OnDelete(DeleteBehavior.Restrict); // Adjust delete behavior as needed

        builder.HasOne(bm => bm.User)
            .WithMany(u => u.BatchMasters)
            .HasForeignKey(bm => bm.UserId)
            .OnDelete(DeleteBehavior.Restrict); // Adjust delete behavior as needed
    }
}

