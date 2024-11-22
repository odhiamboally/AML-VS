using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class ReconStatusConfiguration : IEntityTypeConfiguration<ReconStatus>
{
    public void Configure(EntityTypeBuilder<ReconStatus> builder)
    {
        builder.ToTable("RECONSTATUS");

        builder.HasKey(rs => rs.ReconStatusId);

        builder.Property(rs => rs.ReconStatusId)
            .ValueGeneratedNever();

        builder.Property(rs => rs.ReconStatusName)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasMany(rs => rs.Incheques)
            .WithOne()
            .HasForeignKey(i => i.ReconStatusId)
            .OnDelete(DeleteBehavior.Restrict);  // Adjust delete behavior based on your model's needs
    }
}

