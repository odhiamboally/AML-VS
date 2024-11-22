using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class SysParamConfiguration : IEntityTypeConfiguration<SysParam>
{
    public void Configure(EntityTypeBuilder<SysParam> builder)
    {
        builder.ToTable("SYSPARAM");  // Map to table

        builder.HasKey(sp => sp.SysParamId);  // Primary key configuration

        builder.Property(sp => sp.SysParamId)
            .ValueGeneratedOnAdd();  // Identity column for SysParamId

        builder.Property(sp => sp.SysParamName)
            .IsRequired()
            .HasMaxLength(30);  // SysParamName is required and has a max length of 30

        builder.Property(sp => sp.SysParamValue)
            .IsRequired();  // SysParamValue is required

        builder.Property(sp => sp.SysParamDesc)
            .IsRequired();  // SysParamDesc is required

        builder.Property(sp => sp.StatusId)
            .IsRequired();  // StatusId is required

        // Configuring the relationship with Status
        builder.HasOne(sp => sp.Status)
            .WithMany()  // No collection navigation on Status, so we use WithMany()
            .HasForeignKey(sp => sp.StatusId);  // Foreign key to Status
    }
}

