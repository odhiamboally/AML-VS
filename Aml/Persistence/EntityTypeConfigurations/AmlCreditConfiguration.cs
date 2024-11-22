using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class AmlCreditConfiguration : IEntityTypeConfiguration<AmlCredit>
{
    public void Configure(EntityTypeBuilder<AmlCredit> builder)
    {
        builder.ToTable("AMLCREDIT");

        builder.HasKey(a => a.InCreditId);

        builder.Property(a => a.InCreditId)
            .ValueGeneratedOnAdd();

        builder.Property(a => a.BatchId)
            .HasColumnType("numeric");

        builder.Property(a => a.ProcNo)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(a => a.UserId)
            .IsRequired();

        builder.Property(a => a.CustBranchId)
            .IsRequired();

        builder.Property(a => a.CustAccount)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(a => a.CustName)
            .IsRequired();

        builder.Property(a => a.BankId)
            .IsRequired();

        builder.Property(a => a.BranchId)
            .IsRequired();

        builder.Property(a => a.AccountNo)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(a => a.BeneficiaryName)
            .IsRequired();

        builder.Property(a => a.OriginatorRef)
            .HasMaxLength(35)
            .IsRequired();

        builder.Property(a => a.VoucherId)
            .IsRequired();

        builder.Property(a => a.Amount)
            .HasColumnType("money")
            .IsRequired();

        builder.Property(a => a.CurrencyId)
            .IsRequired();

        builder.Property(a => a.ClearingCodeId)
            .IsRequired();

        builder.Property(a => a.Remarks)
            .HasMaxLength(255);

        builder.Property(a => a.Captured)
            .IsRequired();

        builder.Property(a => a.Authorized)
            .IsRequired();

        builder.Property(a => a.Uploaded)
            .IsRequired();

        builder.Property(a => a.Upload)
            .IsRequired();

        builder.Property(a => a.Returned)
            .IsRequired();

        builder.Property(a => a.ReturnReasonId)
            .IsRequired();

        builder.Property(a => a.BackUpdate)
            .HasColumnType("date");

        builder.Property(a => a.SysDate)
            .HasColumnType("timestamp")
            .HasMaxLength(8)
            .IsRowVersion();

        builder.Property(a => a.FileId)
            .HasMaxLength(50);

        builder.Property(a => a.SourceRef)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(a => a.FlaggedClearingCodeId)
            .IsRequired();

        builder.Property(a => a.ValueDate)
            .HasColumnType("date");

        builder.Property(a => a.PmtTpInf)
            .HasMaxLength(1);

        builder.Property(a => a.PmtTpInfCode)
            .HasMaxLength(2);

        builder.Property(a => a.DrTwnNm)
            .HasMaxLength(50);

        builder.Property(a => a.DrAdrLine)
            .HasMaxLength(50);

        builder.Property(a => a.CrTwnNm)
            .HasMaxLength(50);

        builder.Property(a => a.CrAdrLine)
            .HasMaxLength(50);

        builder.Property(a => a.InstrId)
            .HasMaxLength(50);

        builder.Property(a => a.EndToEndId)
            .HasMaxLength(50);

        builder.Property(a => a.TxId)
            .HasMaxLength(50);

        builder.Property(a => a.MsgId)
            .HasMaxLength(50);

        builder.Property(a => a.CustAccountOrg)
            .HasMaxLength(25);

        builder.Property(a => a.CustNameOrg)
            .HasMaxLength(255);

        builder.Property(a => a.CbsPosted)
            .IsRequired(false);

        builder.Property(a => a.UploadAttemptRef)
            .HasMaxLength(255);

        builder.Property(a => a.FlagDate)
            .HasColumnType("date");

        builder.Property(a => a.ReleaseDate)
            .HasColumnType("date");

        builder.Property(a => a.Released)
            .IsRequired(false);

        // Relationships
        builder.HasOne(a => a.Bank)
            .WithMany()
            .HasForeignKey(a => a.BankId);

        builder.HasOne(a => a.Branch)
            .WithMany()
            .HasForeignKey(a => a.BranchId);

        builder.HasOne(a => a.ClearingCode)
            .WithMany()
            .HasForeignKey(a => a.ClearingCodeId);

        builder.HasOne(a => a.Currency)
            .WithMany()
            .HasForeignKey(a => a.CurrencyId);

        builder.HasOne(a => a.ReturnReason)
            .WithMany()
            .HasForeignKey(a => a.ReturnReasonId);

        builder.HasOne(a => a.User)
            .WithMany()
            .HasForeignKey(a => a.UserId);

        builder.HasOne(a => a.Voucher)
            .WithMany()
            .HasForeignKey(a => a.VoucherId);
    }
}
