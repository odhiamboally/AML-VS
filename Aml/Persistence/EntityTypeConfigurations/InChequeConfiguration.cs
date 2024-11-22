using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class INChequeConfiguration : IEntityTypeConfiguration<InCheque>
{
    public void Configure(EntityTypeBuilder<InCheque> builder)
    {
        builder.ToTable("INCHEQUE");

        builder.HasKey(i => i.INChequeId);

        builder.Property(i => i.INChequeId)
            .HasColumnType("numeric")
            .ValueGeneratedOnAdd();

        builder.Property(i => i.ProcNo)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(i => i.BatchId)
            .HasColumnType("numeric");

        builder.Property(i => i.MLine)
            .IsRequired();

        builder.Property(i => i.UserId)
            .IsRequired();

        builder.Property(i => i.CustBranch)
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

        builder.Property(i => i.AccountName)
            .IsRequired();

        builder.Property(i => i.ChequeNo)
            .HasMaxLength(15)
            .IsRequired();

        builder.Property(i => i.VoucherId)
            .IsRequired();

        builder.Property(i => i.Amount)
            .HasColumnType("money");

        builder.Property(i => i.Manual)
            .IsRequired();

        builder.Property(i => i.ClearingCodeId)
            .IsRequired();

        builder.Property(i => i.RegionId)
            .IsRequired();

        builder.Property(i => i.CheckDigit)
            .HasMaxLength(3)
            .IsRequired();

        builder.Property(i => i.ValueDate)
            .HasColumnType("date");

        builder.Property(i => i.CurrencyId)
            .IsRequired();

        builder.Property(i => i.Remarks)
            .HasMaxLength(255);

        builder.Property(i => i.VerifyChecks)
            .HasMaxLength(10);

        builder.Property(i => i.Captured)
            .IsRequired();

        builder.Property(i => i.Verified)
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

        builder.Property(i => i.ReconStatusId)
            .IsRequired();

        builder.Property(i => i.UnpayCodeId)
            .IsRequired();

        builder.Property(i => i.BackupDate)
            .HasColumnType("date");

        builder.Property(i => i.SysDate)
            .IsRowVersion()
            .HasMaxLength(8);

        builder.Property(i => i.Payee)
            .HasMaxLength(25);

        builder.Property(i => i.PayeeName)
            .HasMaxLength(255);

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

        builder.Property(i => i.InstructionId)
            .HasMaxLength(50);

        builder.Property(i => i.PmtTpInfCode)
            .HasMaxLength(2);

        builder.Property(i => i.PmtTpInf)
            .HasMaxLength(1);

        builder.Property(i => i.DrTwnNm)
            .HasMaxLength(50);

        builder.Property(i => i.DrAdrLine)
            .HasMaxLength(50);

        builder.Property(i => i.CrTwnNm)
            .HasMaxLength(50);

        builder.Property(i => i.CrAdrLine)
            .HasMaxLength(50);

        builder.Property(i => i.CustAccountOrg)
            .HasMaxLength(25);

        builder.Property(i => i.CustNameOrg)
            .HasMaxLength(255);
    }
}
