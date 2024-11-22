using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class BranchConfiguration : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.ToTable("BRANCH");

        builder.HasKey(b => b.BranchId);

        builder.Property(b => b.BranchCode)
            .IsRequired()
            .HasMaxLength(5);

        builder.Property(b => b.BranchName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(b => b.UploadCode)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(b => b.IsHeadOffice)
            .IsRequired();

        builder.Property(b => b.StatusId)
            .IsRequired();

        // Configure relationships (Navigation properties)
        builder.HasOne(b => b.Bank)
            .WithMany()
            .HasForeignKey(b => b.BankId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.LocationType)
            .WithMany()
            .HasForeignKey(b => b.LocationTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.Region)
            .WithMany()
            .HasForeignKey(b => b.RegionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.Status)
            .WithMany()
            .HasForeignKey(b => b.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        // Define Collection relationships
        builder.HasMany(b => b.AchCheques)
            .WithOne()
            .HasForeignKey(ac => ac.BranchId);

        // Add other collection relationships similarly...
    }
}
