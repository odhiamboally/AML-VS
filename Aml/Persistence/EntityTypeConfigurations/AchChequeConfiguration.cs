using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class AchChequeConfiguration : IEntityTypeConfiguration<AchCheque>
{
    public void Configure(EntityTypeBuilder<AchCheque> builder)
    {
        builder.ToTable("ACHCHEQUE");

        builder.HasKey(a => a.AchChequeId);

        builder.Property(a => a.ProcNo)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(a => a.MLine)
            .IsRequired();

        builder.Property(a => a.CustAccount)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(a => a.CustName)
            .IsRequired();

        builder.Property(a => a.AccountNo)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(a => a.AccountName)
            .IsRequired();

        builder.Property(a => a.ChequeNo)
            .IsRequired()
            .HasMaxLength(15);

        builder.Property(a => a.Amount)
            .HasColumnType("money");

        builder.Property(a => a.CheckDigit)
            .IsRequired()
            .HasMaxLength(3);

        builder.Property(a => a.ValueDate)
            .HasColumnType("date");

        builder.Property(a => a.Remarks)
            .HasMaxLength(255);

        builder.Property(a => a.FileName)
            .HasMaxLength(255);

        builder.Property(a => a.TransRef)
            .HasMaxLength(255);

        builder.Property(a => a.FileId)
            .HasMaxLength(100);

        builder.Property(a => a.BackupDate)
            .HasColumnType("date");

        builder.Property(a => a.SysDate)
            .IsRowVersion();

        builder.Property(a => a.InstructionId)
            .HasMaxLength(50);

        builder.Property(a => a.DrTwnNm)
            .HasMaxLength(50);

        builder.Property(a => a.DrAdrLine)
            .HasMaxLength(50);

        builder.Property(a => a.CrTwnNm)
            .HasMaxLength(50);

        builder.Property(a => a.CrAdrLine)
            .HasMaxLength(50);

        builder.Property(a => a.PmtTpInfCode)
            .HasMaxLength(2);

        builder.Property(a => a.PmtTpInf)
            .HasMaxLength(1);

        builder.Property(a => a.InstrId)
            .HasMaxLength(50);

        builder.Property(a => a.EndToEndId)
            .HasMaxLength(50);

        builder.Property(a => a.TxId)
            .HasMaxLength(50);

        builder.Property(a => a.MsgId)
            .HasMaxLength(50);

        // Relationships
        builder.HasOne(a => a.Bank)
            .WithMany()
            .HasForeignKey(a => a.BankId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(a => a.Branch)
            .WithMany()
            .HasForeignKey(a => a.BranchId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(a => a.ClearingCode)
            .WithMany()
            .HasForeignKey(a => a.ClearingCodeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(a => a.ClearingSession)
            .WithMany()
            .HasForeignKey(a => a.ClearingSessionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(a => a.Currency)
            .WithMany()
            .HasForeignKey(a => a.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(a => a.Region)
            .WithMany()
            .HasForeignKey(a => a.RegionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(a => a.User)
            .WithMany()
            .HasForeignKey(a => a.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(a => a.Voucher)
            .WithMany()
            .HasForeignKey(a => a.VoucherId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
