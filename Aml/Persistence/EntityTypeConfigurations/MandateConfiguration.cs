using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class MandateConfiguration : IEntityTypeConfiguration<Mandate>
{
    public void Configure(EntityTypeBuilder<Mandate> builder)
    {
        builder.ToTable("MANDATE");  // Map to table

        builder.HasKey(m => m.MandateId);  // Primary key configuration

        builder.Property(m => m.MandateId)
            .ValueGeneratedOnAdd();  // Identity column for MandateId

        builder.Property(m => m.AccountNo)
            .IsRequired();  // AccountNo is required

        builder.Property(m => m.MandateName)
            .IsRequired()
            .HasMaxLength(100);  // MandateName is required and has a max length of 100

        builder.Property(m => m.BranchId)
            .IsRequired(false);  // BranchId is optional

        builder.Property(m => m.MandateText)
            .IsRequired();  // MandateText is required

        builder.Property(m => m.SignatureUrl)
            .IsRequired();  // SignatureUrl is required

        builder.Property(m => m.SignatureImage)
            .IsRequired(false);  // SignatureImage is optional (nullable)

        builder.Property(m => m.StatusId)
            .IsRequired();  // StatusId is required

        // Configuring the relationship with Status
        builder.HasOne(m => m.Status)
            .WithMany()  // No collection navigation on Status, so we use WithMany()
            .HasForeignKey(m => m.StatusId);  // Foreign key to Status
    }
}

