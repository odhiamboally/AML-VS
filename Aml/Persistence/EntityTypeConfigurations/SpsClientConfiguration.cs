using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class SpsClientConfiguration : IEntityTypeConfiguration<SpsClient>
{
    public void Configure(EntityTypeBuilder<SpsClient> builder)
    {
        builder.ToTable("SPSCLIENT");  // Map to table

        builder.HasKey(sc => sc.SpsClientId);  // Primary key configuration

        builder.Property(sc => sc.SpsClientId)
            .ValueGeneratedOnAdd();  // Identity column for SpsClientId

        builder.Property(sc => sc.ClientCode)
            .IsRequired()
            .HasMaxLength(4);  // ClientCode is required and has a max length of 4

        builder.Property(sc => sc.ClientName)
            .IsRequired();  // ClientName is required

        builder.Property(sc => sc.AccountNo)
            .IsRequired()
            .HasMaxLength(20);  // AccountNo is required and has a max length of 20

        builder.Property(sc => sc.StatusId)
            .IsRequired();  // StatusId is required

        // Configuring the relationship with Status
        builder.HasOne(sc => sc.Status)
            .WithMany()  // No collection navigation on Status, so we use WithMany()
            .HasForeignKey(sc => sc.StatusId);  // Foreign key to Status
    }
}

