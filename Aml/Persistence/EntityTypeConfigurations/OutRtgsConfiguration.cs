using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class OutRtgsConfiguration : IEntityTypeConfiguration<OutRtgs>
{
    public void Configure(EntityTypeBuilder<OutRtgs> builder)
    {
        builder.ToTable("OUTRTGS");

        builder.HasKey(rtgs => rtgs.OutRtgsId);

        builder.Property(rtgs => rtgs.OutRtgsId)
            .HasColumnName("OUTRTGSID")
            .HasColumnType("numeric");

        builder.Property(rtgs => rtgs.BatchId)
            .HasColumnName("BATCHID")
            .HasColumnType("numeric");

        builder.Property(rtgs => rtgs.ProcNo)
            .HasColumnName("PROCNO")
            .HasMaxLength(20);

        builder.Property(rtgs => rtgs.UserId)
            .HasColumnName("USERID");

        builder.Property(rtgs => rtgs.CustBranchId)
            .HasColumnName("CUSTBRANCHID");

        builder.Property(rtgs => rtgs.CustAccount)
            .HasColumnName("CUSTACCOUNT")
            .HasMaxLength(25);

        builder.Property(rtgs => rtgs.CustName)
            .HasColumnName("CUSTNAME");

        builder.Property(rtgs => rtgs.BankId)
            .HasColumnName("BANKID");

        builder.Property(rtgs => rtgs.BranchId)
            .HasColumnName("BRANCHID");

        builder.Property(rtgs => rtgs.AccountNo)
            .HasColumnName("ACCOUNTNO")
            .HasMaxLength(25);

        builder.Property(rtgs => rtgs.BeneficiaryName)
            .HasColumnName("BENEFICIARYNAME");

        builder.Property(rtgs => rtgs.OriginatorRef)
            .HasColumnName("ORIGINATORREF")
            .HasMaxLength(35);

        builder.Property(rtgs => rtgs.Amount)
            .HasColumnName("AMOUNT")
            .HasColumnType("money");

        builder.Property(rtgs => rtgs.CurrencyId)
            .HasColumnName("CURRENCYID");

        builder.Property(rtgs => rtgs.RtgsTypeId)
            .HasColumnName("RTGSTYPEID");

        builder.Property(rtgs => rtgs.TrnSourceId)
            .HasColumnName("TRNSOURCEID");

        builder.Property(rtgs => rtgs.Remarks)
            .HasColumnName("REMARKS");

        builder.Property(rtgs => rtgs.Captured)
            .HasColumnName("CAPTURED");

        builder.Property(rtgs => rtgs.Verified)
            .HasColumnName("VERIFIED");

        builder.Property(rtgs => rtgs.Authorized)
            .HasColumnName("AUTHORIZED");

        builder.Property(rtgs => rtgs.Uploaded)
            .HasColumnName("UPLOADED");

        builder.Property(rtgs => rtgs.AchCreated)
            .HasColumnName("ACHCREATED");

        builder.Property(rtgs => rtgs.Upload)
            .HasColumnName("UPLOAD");

        builder.Property(rtgs => rtgs.AchGenerate)
            .HasColumnName("ACHGENERATE");

        builder.Property(rtgs => rtgs.Returned)
            .HasColumnName("RETURNED");

        builder.Property(rtgs => rtgs.ReturnReasonId)
            .HasColumnName("RETURNREASONID");

        builder.Property(rtgs => rtgs.FileId)
            .HasColumnName("FILEID");

        builder.Property(rtgs => rtgs.BackupDate)
            .HasColumnName("BACKUPDATE")
            .HasColumnType("date");

        builder.Property(rtgs => rtgs.SysDate)
            .HasColumnName("SYSTDATE")
            .HasColumnType("timestamp")
            .IsConcurrencyToken();

        // Configure relationships
        builder.HasOne(rtgs => rtgs.Bank)
            .WithMany()
            .HasForeignKey(rtgs => rtgs.BankId);

        builder.HasOne(rtgs => rtgs.Branch)
            .WithMany()
            .HasForeignKey(rtgs => rtgs.BranchId);

        builder.HasOne(rtgs => rtgs.Currency)
            .WithMany()
            .HasForeignKey(rtgs => rtgs.CurrencyId);

        builder.HasOne(rtgs => rtgs.ReturnReason)
            .WithMany()
            .HasForeignKey(rtgs => rtgs.ReturnReasonId);

        builder.HasOne(rtgs => rtgs.RtgsType)
            .WithMany()
            .HasForeignKey(rtgs => rtgs.RtgsTypeId);

        builder.HasOne(rtgs => rtgs.TrnSource)
            .WithMany()
            .HasForeignKey(rtgs => rtgs.TrnSourceId);

        builder.HasOne(rtgs => rtgs.User)
            .WithMany()
            .HasForeignKey(rtgs => rtgs.UserId);
    }
}

