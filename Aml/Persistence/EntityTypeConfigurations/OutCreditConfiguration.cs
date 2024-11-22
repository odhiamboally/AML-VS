using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class OutCreditConfiguration : IEntityTypeConfiguration<OutCredit>
{
    public void Configure(EntityTypeBuilder<OutCredit> builder)
    {
        builder.ToTable("OUTCREDIT");

        builder.HasKey(o => o.OutCreditId);

        builder.Property(o => o.OutCreditId)
            .HasColumnName("OUTCREDITID")
            .ValueGeneratedOnAdd();

        builder.Property(o => o.BatchId)
            .HasColumnName("BATCHID")
            .HasColumnType("numeric");

        builder.Property(o => o.ProcNo)
            .HasColumnName("PROCNO")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(o => o.UserId)
            .HasColumnName("USERID");

        builder.Property(o => o.CustBranchId)
            .HasColumnName("CUSTBRANCHID");

        builder.Property(o => o.CustAccount)
            .HasColumnName("CUSTACCOUNT")
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(o => o.CustName)
            .HasColumnName("CUSTNAME")
            .IsRequired();

        builder.Property(o => o.BankId)
            .HasColumnName("BANKID");

        builder.Property(o => o.BranchId)
            .HasColumnName("BRANCHID");

        builder.Property(o => o.AccountNo)
            .HasColumnName("ACCOUNTNO")
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(o => o.BeneficiaryName)
            .HasColumnName("BENEFICIARYNAME")
            .IsRequired();

        builder.Property(o => o.OriginatorRef)
            .HasColumnName("ORIGINATORREF")
            .HasMaxLength(35)
            .IsRequired();

        builder.Property(o => o.VoucherId)
            .HasColumnName("VOUCHERID");

        builder.Property(o => o.Amount)
            .HasColumnName("AMOUNT")
            .HasColumnType("money");

        builder.Property(o => o.CurrencyId)
            .HasColumnName("CURRENCYID");

        builder.Property(o => o.ClearingCodeId)
            .HasColumnName("CLEARINGCODEID");

        builder.Property(o => o.TrnSourceId)
            .HasColumnName("TRNSOURCEID");

        builder.Property(o => o.Remarks)
            .HasColumnName("REMARKS");

        builder.Property(o => o.Captured)
            .HasColumnName("CAPTURED");

        builder.Property(o => o.Verified)
            .HasColumnName("VERIFIED");

        builder.Property(o => o.Authorized)
            .HasColumnName("AUTHORIZED");

        builder.Property(o => o.Uploaded)
            .HasColumnName("UPLOADED");

        builder.Property(o => o.AchCreated)
            .HasColumnName("ACHCREATED");

        builder.Property(o => o.Upload)
            .HasColumnName("UPLOAD");

        builder.Property(o => o.AchGenerate)
            .HasColumnName("ACHGENERATE");

        builder.Property(o => o.Returned)
            .HasColumnName("RETURNED");

        builder.Property(o => o.ReturnReasonId)
            .HasColumnName("RETURNREASONID");

        builder.Property(o => o.FileId)
            .HasColumnName("FILEID")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(o => o.BackupDate)
            .HasColumnName("BACKUPDATE")
            .HasColumnType("date");

        builder.Property(o => o.SysDate)
            .HasColumnName("SYSTDATE")
            .HasColumnType("timestamp")
            .HasMaxLength(8);

        builder.Property(o => o.ValueDate)
            .HasColumnName("VALUEDATE")
            .HasColumnType("date");

        builder.Property(o => o.InstrId)
            .HasColumnName("INSTRID")
            .HasMaxLength(50);

        builder.Property(o => o.EndToEndId)
            .HasColumnName("ENDTOENDID")
            .HasMaxLength(50);

        builder.Property(o => o.TxId)
            .HasColumnName("TXID")
            .HasMaxLength(50);

        builder.Property(o => o.MsgId)
            .HasColumnName("MSGID")
            .HasMaxLength(50);

        // Define relationships
        builder.HasOne(o => o.Bank)
            .WithMany()
            .HasForeignKey(o => o.BankId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.Batch)
            .WithMany()
            .HasForeignKey(o => o.BatchId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.Branch)
            .WithMany()
            .HasForeignKey(o => o.BranchId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.ClearingCode)
            .WithMany()
            .HasForeignKey(o => o.ClearingCodeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.Currency)
            .WithMany()
            .HasForeignKey(o => o.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.ReturnReason)
            .WithMany()
            .HasForeignKey(o => o.ReturnReasonId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.TrnSource)
            .WithMany()
            .HasForeignKey(o => o.TrnSourceId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.User)
            .WithMany()
            .HasForeignKey(o => o.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.Voucher)
            .WithMany()
            .HasForeignKey(o => o.VoucherId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

