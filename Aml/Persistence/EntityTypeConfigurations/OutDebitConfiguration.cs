using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class OutDebitConfiguration : IEntityTypeConfiguration<OutDebit>
{
    public void Configure(EntityTypeBuilder<OutDebit> builder)
    {
        builder.ToTable("OUTDEBIT");

        builder.HasKey(od => od.OutDebitId);

        builder.Property(od => od.OutDebitId)
            .HasColumnName("OUTDEBITID")
            .HasColumnType("numeric")
            .ValueGeneratedOnAdd();

        builder.Property(od => od.BatchId)
            .HasColumnName("BATCHID")
            .HasColumnType("numeric")
            .IsRequired();

        builder.Property(od => od.ProcNo)
            .HasColumnName("PROCNO")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(od => od.UserId)
            .HasColumnName("USERID")
            .IsRequired();

        builder.Property(od => od.CustBranchId)
            .HasColumnName("CUSTBRANCHID")
            .IsRequired();

        builder.Property(od => od.CustAccount)
            .HasColumnName("CUSTACCOUNT")
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(od => od.CustName)
            .HasColumnName("CUSTNAME")
            .IsRequired();

        builder.Property(od => od.BankId)
            .HasColumnName("BANKID")
            .IsRequired();

        builder.Property(od => od.BranchId)
            .HasColumnName("BRANCHID")
            .IsRequired();

        builder.Property(od => od.AccountNo)
            .HasColumnName("ACCOUNTNO")
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(od => od.BeneficiaryName)
            .HasColumnName("BENEFICIARYNAME")
            .IsRequired();

        builder.Property(od => od.OriginatorRef)
            .HasColumnName("ORIGINATORREF")
            .HasMaxLength(35)
            .IsRequired();

        builder.Property(od => od.VoucherId)
            .HasColumnName("VOUCHERID")
            .IsRequired();

        builder.Property(od => od.Amount)
            .HasColumnName("AMOUNT")
            .HasColumnType("money")
            .IsRequired();

        builder.Property(od => od.CurrencyId)
            .HasColumnName("CURRENCYID")
            .IsRequired();

        builder.Property(od => od.ClearingCodeId)
            .HasColumnName("CLEARINGCODEID")
            .IsRequired();

        builder.Property(od => od.TrnSourceId)
            .HasColumnName("TRNSOURCEID")
            .IsRequired();

        builder.Property(od => od.Policy1)
            .HasColumnName("POLICY1")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(od => od.Policy2)
            .HasColumnName("POLICY2")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(od => od.SignDate)
            .HasColumnName("SIGNDATE")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(od => od.Remarks)
            .HasColumnName("REMARKS");

        builder.Property(od => od.Captured)
            .HasColumnName("CAPTURED")
            .IsRequired();

        builder.Property(od => od.Verified)
            .HasColumnName("VERIFIED")
            .IsRequired();

        builder.Property(od => od.Authorized)
            .HasColumnName("AUTHORIZED")
            .IsRequired();

        builder.Property(od => od.Uploaded)
            .HasColumnName("UPLOADED")
            .IsRequired();

        builder.Property(od => od.AchCreated)
            .HasColumnName("ACHCREATED")
            .IsRequired();

        builder.Property(od => od.Upload)
            .HasColumnName("UPLOAD")
            .IsRequired();

        builder.Property(od => od.AchGenerate)
            .HasColumnName("ACHGENERATE")
            .IsRequired();

        builder.Property(od => od.Returned)
            .HasColumnName("RETURNED")
            .IsRequired();

        builder.Property(od => od.ReturnReasonId)
            .HasColumnName("RETURNREASONID")
            .IsRequired();

        builder.Property(od => od.FileId)
            .HasColumnName("FILEID")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(od => od.BackupDate)
            .HasColumnName("BACKUPDATE")
            .HasColumnType("date");

        builder.Property(od => od.SysDate)
            .HasColumnName("SYSTDATE")
            .HasColumnType("timestamp")
            .IsRowVersion();

        builder.Property(od => od.ImportedFileId)
            .HasColumnName("IMPORTEDFILEID")
            .HasColumnType("numeric");

        builder.Property(od => od.InstrId)
            .HasColumnName("INSTRID")
            .HasMaxLength(50);

        builder.Property(od => od.EndToEndId)
            .HasColumnName("ENDTOENDID")
            .HasMaxLength(50);

        builder.Property(od => od.TxId)
            .HasColumnName("TXID")
            .HasMaxLength(50);

        builder.Property(od => od.MsgId)
            .HasColumnName("MSGID")
            .HasMaxLength(50);

        builder.Property(od => od.PmtTpInf)
            .HasColumnName("PMTTPIINF")
            .HasMaxLength(1);

        builder.Property(od => od.PmtTpInfCode)
            .HasColumnName("PMTTPIINFCode")
            .HasMaxLength(2);

        builder.Property(od => od.DrTwnNm)
            .HasColumnName("DRTWNNM")
            .HasMaxLength(50);

        builder.Property(od => od.DrAdrLine)
            .HasColumnName("DRADRLINE")
            .HasMaxLength(50);

        builder.Property(od => od.CrTwnNm)
            .HasColumnName("CRTWNAM")
            .HasMaxLength(50);

        builder.Property(od => od.CrAdrLine)
            .HasColumnName("CRADRLINE")
            .HasMaxLength(50);

        builder.Property(od => od.MndtId)
            .HasColumnName("MNDTID")
            .HasMaxLength(50);

        builder.Property(od => od.DtOfSgntr)
            .HasColumnName("DTOFSGNTR")
            .HasColumnType("date");

        builder.Property(od => od.FnlColltnDt)
            .HasColumnName("FNLCLLDT")
            .HasColumnType("date");

        builder.Property(od => od.Frqcy)
            .HasColumnName("FRQCY")
            .HasMaxLength(50);
    }
}

