using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class UploadBatchConfiguration : IEntityTypeConfiguration<UploadBatch>
{
    public void Configure(EntityTypeBuilder<UploadBatch> builder)
    {
        builder.ToTable("UPLOADBATCH");

        builder.HasKey(x => new { x.Id, x.Batch, x.SessionId, x.CurrencyId });

        builder.Property(x => x.Id)
            .IsRequired();

        builder.Property(x => x.Batch)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(x => x.SessionId)
            .IsRequired();

        builder.Property(x => x.CurrencyId)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(50);

        builder.HasOne(x => x.Currency)
            .WithMany()
            .HasForeignKey(x => x.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict); // Assuming a CURRENCY entity
    }
}

