using Aml.Channels.Clearing.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aml.Persistence.EntityTypeConfigurations;

public class InCreditConfiguration : IEntityTypeConfiguration<InCredit>
{
    public void Configure(EntityTypeBuilder<InCredit> entity)
    {
        entity.ToTable("INCREDIT");

        entity.HasKey(e => e.InCreditId);

        entity.Property(e => e.InCreditId)
            .HasColumnName("INCREDITID")
            .HasColumnType("numeric")
            .ValueGeneratedOnAdd();

        entity.Property(e => e.BatchId)
            .HasColumnName("BATCHID")
            .HasColumnType("numeric");

        entity.Property(e => e.ProcNo)
            .IsRequired()
            .HasMaxLength(20);

        entity.Property(e => e.CustAccount)
            .IsRequired()
            .HasMaxLength(25);

        entity.Property(e => e.CustName)
            .IsRequired();

        entity.Property(e => e.AccountNo)
            .IsRequired()
            .HasMaxLength(25);

        entity.Property(e => e.BeneficiaryName)
            .IsRequired();

        entity.Property(e => e.OriginatorRef)
            .IsRequired()
            .HasMaxLength(35);

        entity.Property(e => e.Amount)
            .HasColumnType("money");

        entity.Property(e => e.BackupDate)
            .HasColumnType("date");

        entity.Property(e => e.SystDate)
            .HasColumnType("timestamp")
            .IsRowVersion();

        entity.Property(e => e.FileId)
            .HasMaxLength(50);

        entity.Property(e => e.SourceRef)
            .IsRequired()
            .HasMaxLength(20);

        entity.Property(e => e.PmtTpInf)
            .HasMaxLength(1);

        entity.Property(e => e.PmtTpInfCode)
            .HasMaxLength(2);

        entity.Property(e => e.DrTwnNm)
            .HasMaxLength(50);

        entity.Property(e => e.CrTwnNm)
            .HasMaxLength(50);

        entity.Property(e => e.AmlStatus)
            .HasMaxLength(10);

        // Relationships
        entity.HasOne(e => e.Bank)
            .WithMany()
            .HasForeignKey(e => e.BankId);

        entity.HasOne(e => e.Branch)
            .WithMany()
            .HasForeignKey(e => e.BranchId);

        entity.HasOne(e => e.ClearingCode)
            .WithMany()
            .HasForeignKey(e => e.ClearingCodeId);

        entity.HasOne(e => e.Currency)
            .WithMany()
            .HasForeignKey(e => e.CurrencyId);

        entity.HasOne(e => e.ReturnReason)
            .WithMany()
            .HasForeignKey(e => e.ReturnReasonId);
    }
}
