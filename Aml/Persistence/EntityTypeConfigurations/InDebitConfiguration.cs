using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class InDebitConfiguration : IEntityTypeConfiguration<InDebit>
{
    public void Configure(EntityTypeBuilder<InDebit> builder)
    {
        builder.ToTable("INDEBIT");

        builder.HasKey(i => i.InDebitId);

        builder.Property(i => i.InDebitId)
            .ValueGeneratedOnAdd();

        builder.Property(i => i.BatchId)
            .HasColumnType("numeric")
            .IsRequired();

        builder.Property(i => i.ProcNo)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(i => i.UserId)
            .IsRequired();

        builder.Property(i => i.CustBranchId)
            .IsRequired();

        builder.Property(i => i.CustAccount)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(i => i.CustName)
            .IsRequired();

        builder.Property(i => i.BankId)
            .IsRequired();

        builder.Property(i => i.BranchId)
            .IsRequired();

        builder.Property(i => i.AccountNo)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(i => i.BeneficiaryName)
            .IsRequired();

        builder.Property(i => i.OriginatorRef)
            .HasMaxLength(35)
            .IsRequired();

        builder.Property(i => i.VoucherId)
            .IsRequired();

        builder.Property(i => i.Amount)
            .HasColumnType("money")
            .IsRequired();

        builder.Property(i => i.CurrencyId)
            .IsRequired();

        builder.Property(i => i.ClearingCodeId)
            .IsRequired();

        builder.Property(i => i.Policy1)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(i => i.Policy2)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(i => i.SignDate)
            .HasColumnType("date")
            .IsRequired();

        builder.Property(i => i.Remarks)
            .HasMaxLength(500)
            .IsRequired(false);

        builder.Property(i => i.Captured)
            .IsRequired();

        builder.Property(i => i.Authorized)
            .IsRequired();

        builder.Property(i => i.Uploaded)
            .IsRequired();

        builder.Property(i => i.Upload)
            .IsRequired();

        builder.Property(i => i.Returned)
            .IsRequired();

        builder.Property(i => i.ReturnReasonId)
            .IsRequired();

        builder.Property(i => i.BackupDate)
            .HasColumnType("date")
            .IsRequired(false);

        builder.Property(i => i.SysDate)
            .HasColumnType("timestamp")
            .IsRequired();

        builder.Property(i => i.FileId)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.SourceRef)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(i => i.FlaggedClearingCodeId)
            .IsRequired();

        builder.Property(i => i.Flagged)
            .IsRequired();

        builder.Property(i => i.RejectionAuthorized)
            .IsRequired();

        builder.Property(i => i.MarkedForRejection)
            .IsRequired();

        builder.Property(i => i.RejectionUploaded)
            .IsRequired();

        builder.Property(i => i.UnpayCodeId)
            .IsRequired();

        builder.Property(i => i.PmtTpInf)
            .HasMaxLength(1)
            .IsRequired(false);

        builder.Property(i => i.PmtTpInfCode)
            .HasMaxLength(2)
            .IsRequired(false);

        builder.Property(i => i.DrTwnNm)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.DrAdrLine)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.CrTwnNm)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.CrAdrLine)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.MndtId)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.DtOfSgntr)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.FnlColltnDt)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.Frqcy)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.ValueDate)
            .HasColumnType("date")
            .IsRequired(false);

        builder.Property(i => i.InstrId)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.EndToEndId)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.TxId)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.MsgId)
            .HasMaxLength(50)
            .IsRequired(false);

        builder.Property(i => i.CustAccountOrg)
            .HasMaxLength(25)
            .IsRequired(false);

        builder.Property(i => i.CustNameOrg)
            .HasMaxLength(500)
            .IsRequired(false);

        builder.HasOne(i => i.Bank)
            .WithMany(b => b.InDebits)
            .HasForeignKey(i => i.BankId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.Batch)
            .WithMany(b => b.InDebits)
            .HasForeignKey(i => i.BatchId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.Branch)
            .WithMany(b => b.InDebits)
            .HasForeignKey(i => i.BranchId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.Currency)
            .WithMany(c => c.InDebits)
            .HasForeignKey(i => i.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.ClearingCode)
            .WithMany(c => c.InDebit)
            .HasForeignKey(i => i.ClearingCodeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.User)
            .WithMany(u => u.InDebits)
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.Voucher)
            .WithMany(v => v.InDebitList)
            .HasForeignKey(i => i.VoucherId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

