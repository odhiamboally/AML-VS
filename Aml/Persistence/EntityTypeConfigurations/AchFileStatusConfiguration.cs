using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class AchFileStatusConfiguration : IEntityTypeConfiguration<AchFileStatus>
{
    public void Configure(EntityTypeBuilder<AchFileStatus> builder)
    {
        builder.ToTable("ACHFILESTATUS");

        builder.HasKey(afs => afs.AchFileStatusId);

        builder.Property(afs => afs.AchFileStatusId)
            .ValueGeneratedOnAdd(); // Primary key and identity column

        builder.Property(afs => afs.AchFileName)
            .IsRequired(false); // Optional field

        builder.Property(afs => afs.AchCodeId)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(afs => afs.CreateTime)
            .IsRequired()
            .HasColumnType("datetime");

        builder.HasOne(afs => afs.TranType)
            .WithMany(tt => tt.AchFileStatuses)
            .HasForeignKey(afs => afs.TranTypeId)
            .OnDelete(DeleteBehavior.Restrict); // Adjust delete behavior as needed
    }
}

