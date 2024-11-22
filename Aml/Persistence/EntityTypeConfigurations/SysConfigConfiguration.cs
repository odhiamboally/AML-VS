using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class SysConfigConfiguration : IEntityTypeConfiguration<SysConfig>
{
    public void Configure(EntityTypeBuilder<SysConfig> builder)
    {
        builder.ToTable("SYSCONFIG");  // Map to table

        builder.HasKey(sc => sc.SysConfigId);  // Primary key configuration

        builder.Property(sc => sc.SysConfigId)
            .ValueGeneratedOnAdd();  // Identity column for SysConfigId

        builder.Property(sc => sc.SysConfigName)
            .IsRequired()
            .HasMaxLength(30);  // SysConfigName is required and has a max length of 30

        builder.Property(sc => sc.SysConfigValue)
            .IsRequired();  // SysConfigValue is required

        builder.Property(sc => sc.SysConfigDesc)
            .IsRequired();  // SysConfigDesc is required

        builder.Property(sc => sc.StatusId)
            .IsRequired();  // StatusId is required

        // Configuring the relationship with Status
        builder.HasOne(sc => sc.Status)
            .WithMany()  // No collection navigation on Status, so we use WithMany()
            .HasForeignKey(sc => sc.StatusId);  // Foreign key to Status
    }
}

