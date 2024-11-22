using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class UploadParamConfiguration : IEntityTypeConfiguration<UploadParam>
{
    public void Configure(EntityTypeBuilder<UploadParam> builder)
    {
        builder.ToTable("UPLOADPARAM");

        builder.HasKey(up => up.UploadParamId);

        builder.Property(up => up.OutChequeLedger)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(up => up.OutChequeCode)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(up => up.InChequeLedger)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(up => up.InChequeCode)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(up => up.OutRtgsLedger)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(up => up.OutRtgsCode)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(up => up.InRtgsLedger)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(up => up.InRtgsCode)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(up => up.OutCreditLedger)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(up => up.OutCreditCode)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(up => up.InCreditLedger)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(up => up.InCreditCode)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(up => up.OutDebitLedger)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(up => up.OutDebitCode)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(up => up.InDebitLedger)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(up => up.InDebitCode)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasOne(up => up.Branch)
            .WithMany()
            .HasForeignKey(up => up.BranchId);

        builder.HasOne(up => up.Currency)
            .WithMany()
            .HasForeignKey(up => up.CurrencyId);

        builder.HasOne(up => up.Status)
            .WithMany()
            .HasForeignKey(up => up.StatusId);
    }
}

