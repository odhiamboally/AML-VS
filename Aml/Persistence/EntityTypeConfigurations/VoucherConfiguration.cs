using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Aml.Shared.Entitties;

namespace Aml.Persistence.EntityTypeConfigurations;

public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
{
    public void Configure(EntityTypeBuilder<Voucher> builder)
    {
        builder.ToTable("Voucher");

        builder.HasKey(v => v.VoucherId);

        builder.Property(v => v.VoucherCode)
            .IsRequired()
            .HasMaxLength(5);

        builder.Property(v => v.VoucherName)
            .IsRequired();

        builder.HasOne(v => v.Status)
            .WithMany()
            .HasForeignKey(v => v.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(v => v.TranType)
            .WithMany()
            .HasForeignKey(v => v.TranTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        // Configure relationships for collections
        builder.HasMany(v => v.AchChequeList)
            .WithOne()
            .HasForeignKey(ac => ac.VoucherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(v => v.AmlCreditList)
            .WithOne()
            .HasForeignKey(ac => ac.VoucherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(v => v.InChequeList)
            .WithOne()
            .HasForeignKey(ic => ic.VoucherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(v => v.InCreditList)
            .WithOne()
            .HasForeignKey(ic => ic.VoucherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(v => v.InDebitList)
            .WithOne()
            .HasForeignKey(id => id.VoucherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(v => v.OutChequeList)
            .WithOne()
            .HasForeignKey(oc => oc.VoucherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(v => v.OutCreditList)
            .WithOne()
            .HasForeignKey(oc => oc.VoucherId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(v => v.OutDebitList)
            .WithOne()
            .HasForeignKey(od => od.VoucherId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
