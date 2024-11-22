using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class AuditTrailConfiguration : IEntityTypeConfiguration<AuditTrail>
{
    public void Configure(EntityTypeBuilder<AuditTrail> builder)
    {
        builder.ToTable("AUDITTRAIL");

        builder.HasKey(x => x.AuditId);

        builder.Property(x => x.AuditId)
            .IsRequired()
            .ValueGeneratedOnAdd(); // Identity or auto-generated

        builder.Property(x => x.UserId)
            .IsRequired(false); // Nullable

        builder.Property(x => x.ModuleName)
            .IsRequired();

        builder.Property(x => x.AuditAction)
            .IsRequired();

        builder.Property(x => x.AuditDate)
            .IsRequired();

        builder.Property(x => x.WindowsUser)
            .IsRequired();

        builder.Property(x => x.IpAddress)
            .IsRequired();

        builder.Property(x => x.Workstation)
            .IsRequired();

        builder.Property(x => x.StatusId)
            .IsRequired();

        builder.Property(x => x.HashCode)
            .IsRequired();

        builder.Property(x => x.SysDate)
            .IsRequired()
            .HasMaxLength(8)
            .IsRowVersion(); // Mapping the timestamp field

        builder.HasOne(x => x.Status)
            .WithMany()
            .HasForeignKey(x => x.StatusId)
            .OnDelete(DeleteBehavior.Restrict); // Assuming the status entity

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict); // Assuming the user entity
    }
}

