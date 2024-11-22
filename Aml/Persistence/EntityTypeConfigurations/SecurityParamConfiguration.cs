using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class SecurityParamConfiguration : IEntityTypeConfiguration<SecurityParam>
{
    public void Configure(EntityTypeBuilder<SecurityParam> builder)
    {
        builder.ToTable("SECURITYPARAM");  // Map to table

        builder.HasKey(sp => sp.SecurityParamId);  // Primary key configuration

        builder.Property(sp => sp.SecurityParamId)
            .ValueGeneratedOnAdd();  // Identity column for SecurityParamId

        builder.Property(sp => sp.ParamName)
            .IsRequired()
            .HasMaxLength(30);  // ParamName is required and has a max length of 30

        builder.Property(sp => sp.ParamValue)
            .IsRequired();  // ParamValue is required

        builder.Property(sp => sp.ParamDesc)
            .IsRequired();  // ParamDesc is required

        builder.Property(sp => sp.StatusId)
            .IsRequired();  // StatusId is required

        // Configuring the relationship with Status
        builder.HasOne(sp => sp.Status)
            .WithMany()  // No collection navigation on Status, so we use WithMany()
            .HasForeignKey(sp => sp.StatusId);  // Foreign key to Status
    }
}

