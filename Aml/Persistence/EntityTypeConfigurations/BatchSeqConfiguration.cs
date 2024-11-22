using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class BatchSeqConfiguration : IEntityTypeConfiguration<BatchSeq>
{
    public void Configure(EntityTypeBuilder<BatchSeq> builder)
    {
        builder.ToTable("BATCHSEQ");

        builder.HasKey(bs => bs.BatchSeqId);

        builder.Property(bs => bs.BatchSeqId)
            .IsRequired();

        builder.Property(bs => bs.BranchId)
            .IsRequired();

        builder.Property(bs => bs.BatchSeed)
            .IsRequired();

        builder.Property(bs => bs.CurrentBatch)
            .IsRequired();

        builder.HasOne(bs => bs.Branch)
            .WithMany(b => b.BatchSequences)
            .HasForeignKey(bs => bs.BranchId)
            .OnDelete(DeleteBehavior.Cascade); // Adjust delete behavior as necessary
    }
}

