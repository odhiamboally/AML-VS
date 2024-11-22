using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class ChargeExemptionClientConfiguration : IEntityTypeConfiguration<ChargeExemptionClient>
{
    public void Configure(EntityTypeBuilder<ChargeExemptionClient> builder)
    {
        builder.ToTable("CHARGEEXEMPTIONCLIENT");  // Map to table

        builder.HasKey(cec => cec.ChargeExemptionClientId);  // Primary key configuration

        builder.Property(cec => cec.ChargeExemptionClientId)
            .ValueGeneratedOnAdd();  // Identity column for ChargeExemptionClientId

        builder.Property(cec => cec.ClientCode)
            .IsRequired()
            .HasMaxLength(4);  // ClientCode is required and has a max length of 4

        builder.Property(cec => cec.ClientName)
            .IsRequired();  // ClientName is required

        builder.Property(cec => cec.AccountNo)
            .IsRequired()
            .HasMaxLength(20);  // AccountNo is required and has a max length of 20

        builder.Property(cec => cec.StatusId)
            .IsRequired();  // StatusId is required

        // Configuring the relationship with Status
        builder.HasOne(cec => cec.Status)
            .WithMany()  // No collection navigation on Status, so we use WithMany()
            .HasForeignKey(cec => cec.StatusId);  // Foreign key to Status
    }
}

