using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Aml.Persistence.EntityTypeConfigurations;

public class ReturnReasonConfiguration : IEntityTypeConfiguration<ReturnReason>
{
    public void Configure(EntityTypeBuilder<ReturnReason> builder)
    {
        // Table name configuration
        builder.ToTable("ReturnReason");

        // Primary key configuration
        builder.HasKey(r => r.ReturnReasonId);

        // Property configurations
        builder.Property(r => r.ReturnReasonDesc)
            .IsRequired()  // Ensuring this field is required
            .HasMaxLength(255);  // Max length for the description

        builder.Property(r => r.StatusId)
            .IsRequired();  // StatusId is required

        // Configure the relationship between ReturnReason and Status
        builder.HasOne(r => r.Status)
            .WithMany()  // Status can be linked to multiple return reasons
            .HasForeignKey(r => r.StatusId)
            .OnDelete(DeleteBehavior.Restrict);  // Prevent cascading deletes from Status to ReturnReason

        // Define relationships with other entities (example for AmlCredits)
        builder.HasMany(r => r.AmlCredits)
            .WithOne()
            .HasForeignKey(ac => ac.ReturnReasonId);

        builder.HasMany(r => r.InCheques)
            .WithOne()
            .HasForeignKey(ic => ic.ReturnReasonId);

        builder.HasMany(r => r.InCredits)
            .WithOne()
            .HasForeignKey(ic => ic.ReturnReasonId);

        builder.HasMany(r => r.InDebits)
            .WithOne()
            .HasForeignKey(id => id.ReturnReasonId);

        builder.HasMany(r => r.InRtgs)
            .WithOne()
            .HasForeignKey(ir => ir.ReturnReasonId);

        builder.HasMany(r => r.OutCheques)
            .WithOne()
            .HasForeignKey(oc => oc.ReturnReasonId);

        builder.HasMany(r => r.OutCredits)
            .WithOne()
            .HasForeignKey(oc => oc.ReturnReasonId);

        builder.HasMany(r => r.OutDebits)
            .WithOne()
            .HasForeignKey(od => od.ReturnReasonId);

        builder.HasMany(r => r.OutRtgs)
            .WithOne()
            .HasForeignKey(ortg => ortg.ReturnReasonId);
    }
}