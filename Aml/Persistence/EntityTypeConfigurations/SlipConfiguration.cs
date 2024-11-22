using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class SlipConfiguration : IEntityTypeConfiguration<Slip>
{
    public void Configure(EntityTypeBuilder<Slip> builder)
    {
        builder.ToTable("SLIP");

        builder.HasKey(s => s.SlipId);

        builder.Property(s => s.SlipId)
            .ValueGeneratedOnAdd()
            .HasColumnType("numeric");

        builder.Property(s => s.SlipNo)
            .IsRequired()
            .HasMaxLength(4);

        builder.Property(s => s.BatchId)
            .HasColumnType("numeric");

        builder.Property(s => s.CustBranchId)
            .IsRequired();

        builder.Property(s => s.CustAccount)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(s => s.ItemCount)
            .IsRequired();

        builder.Property(s => s.ItemSum)
            .HasColumnType("money")
            .IsRequired();

        builder.Property(s => s.Remarks)
            .HasMaxLength(500); // Adjust size as per requirement

        builder.Property(s => s.Bulk)
            .IsRequired();

        builder.Property(s => s.Captured)
            .IsRequired();

        builder.Property(s => s.Verified)
            .IsRequired();

        builder.Property(s => s.Authorized)
            .IsRequired();

        builder.Property(s => s.Uploaded)
            .IsRequired();

        builder.Property(s => s.BackupDate)
            .HasColumnType("date");

        builder.Property(s => s.SystDate)
            .HasColumnType("timestamp")
            .IsRequired()
            .IsRowVersion();

        builder.HasOne(s => s.Batch)
            .WithMany()
            .HasForeignKey(s => s.BatchId)
            .OnDelete(DeleteBehavior.Restrict);  // Adjust delete behavior as needed

        builder.HasOne(s => s.Branch)
            .WithMany()
            .HasForeignKey(s => s.CustBranchId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.ChequeTemps)
            .WithOne()
            .HasForeignKey(c => c.SlipId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(s => s.OutCheques)
            .WithOne()
            .HasForeignKey(o => o.SlipId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

