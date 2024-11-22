using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class ClearingCodeConfiguration : IEntityTypeConfiguration<ClearingCode>
{
    public void Configure(EntityTypeBuilder<ClearingCode> builder)
    {
        builder.ToTable("CLEARINGCODE");

        builder.HasKey(x => x.ClearingCodeId);

        builder.Property(x => x.ClearingCodeId)
            .HasColumnName("CLEARINGCODEID")
            .IsRequired();

        builder.Property(x => x.ClearingCodeName)
            .HasColumnName("CLEARINGCODENAME")
            .IsRequired()
            .HasMaxLength(5);

        builder.Property(x => x.ClearingCodeDesc)
            .HasColumnName("CLEARINGCODEDESC")
            .IsRequired();

        builder.Property(x => x.TranTypeId)
            .HasColumnName("TRANTYPEID")
            .IsRequired();

        builder.Property(x => x.UnpayCode)
            .HasColumnName("UNPAYCODE")
            .IsRequired();

        builder.Property(x => x.Representable)
            .HasColumnName("REPRESENTABLE")
            .IsRequired();

        builder.Property(x => x.StatusId)
            .HasColumnName("STATUSID")
            .IsRequired();

        builder.Property(x => x.InUnpayChargeUsd)
            .HasColumnName("INUNPAYCHARGE_USD")
            .HasColumnType("money");

        builder.Property(x => x.OutUnpayChargeUsd)
            .HasColumnName("OUTUNPAYCHARGE_USD")
            .HasColumnType("money");

        builder.Property(x => x.InUnpayCharge)
            .HasColumnName("INUNPAYCHARGE")
            .HasColumnType("money");

        builder.Property(x => x.OutUnpayCharge)
            .HasColumnName("OUTUNPAYCHARGE")
            .HasColumnType("money");

        builder.Property(x => x.InUnpayChargeEur)
            .HasColumnName("INUNPAYCHARGE_EUR")
            .HasColumnType("money");

        builder.Property(x => x.OutUnpayChargeEur)
            .HasColumnName("OUTUNPAYCHARGE_EUR")
            .HasColumnType("money");

        builder.Property(x => x.InUnpayChargeGbp)
            .HasColumnName("INUNPAYCHARGE_GBP")
            .HasColumnType("money");

        builder.Property(x => x.OutUnpayChargeGbp)
            .HasColumnName("OUTUNPAYCHARGE_GBP")
            .HasColumnType("money");

        // Relationships
        builder.HasOne(x => x.Status)
            .WithMany()
            .HasForeignKey(x => x.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.TranType)
            .WithMany()
            .HasForeignKey(x => x.TranTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.AchCheque)
            .WithOne()
            .HasForeignKey(x => x.ClearingCodeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.AmlCredit)
            .WithOne()
            .HasForeignKey(x => x.ClearingCodeId)
            .OnDelete(DeleteBehavior.Cascade);

        // Add more relationships for the other collections
    }
}

