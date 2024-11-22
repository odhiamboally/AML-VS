using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class OutChequeConfiguration : IEntityTypeConfiguration<OutCheque>
{
    public void Configure(EntityTypeBuilder<OutCheque> builder)
    {
        builder.ToTable("OUTCHEQUE");

        builder.HasKey(o => o.OutChequeId);

        builder.Property(o => o.OutChequeId)
            .HasColumnType("numeric")
            .ValueGeneratedOnAdd();

        builder.Property(o => o.ProcNo)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(o => o.MLine)
            .IsRequired();

        builder.Property(o => o.UserId)
            .IsRequired();

        builder.Property(o => o.CustBranch)
            .IsRequired();

        builder.Property(o => o.CustAccount)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(o => o.CustName)
            .IsRequired();

        builder.Property(o => o.BankId)
            .IsRequired();

        builder.Property(o => o.BranchId)
            .IsRequired();

        builder.Property(o => o.AccountNo)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(o => o.AccountName)
            .IsRequired();

        builder.Property(o => o.ChequeNo)
            .HasMaxLength(15)
            .IsRequired();

        builder.Property(o => o.VoucherId)
            .IsRequired();

        builder.Property(o => o.Amount)
            .HasColumnType("money")
            .IsRequired();

        builder.Property(o => o.Manual)
            .IsRequired();

        builder.Property(o => o.ClearingCodeId)
            .IsRequired();

        builder.Property(o => o.RegionId)
            .IsRequired();

        builder.Property(o => o.CheckDigit)
            .HasMaxLength(3)
            .IsRequired();

        builder.Property(o => o.ValueDate)
            .HasColumnType("date");

        builder.Property(o => o.CurrencyId)
            .IsRequired();

        builder.Property(o => o.SlipId)
            .HasColumnType("numeric")
            .IsRequired();

        builder.Property(o => o.Remarks)
            .HasMaxLength(255);

        builder.Property(o => o.Captured)
            .IsRequired();

        builder.Property(o => o.Verified)
            .IsRequired();

        builder.Property(o => o.Authorized)
            .IsRequired();

        builder.Property(o => o.Uploaded)
            .IsRequired();

        builder.Property(o => o.AchCreated)
            .IsRequired();

        builder.Property(o => o.Upload)
            .IsRequired();

        builder.Property(o => o.AchGenerate)
            .IsRequired();

        builder.Property(o => o.Returned)
            .IsRequired();

        builder.Property(o => o.ReturnReasonId)
            .IsRequired();

        builder.Property(o => o.FileId)
            .IsRequired();

        builder.Property(o => o.BackUpDate)
            .HasColumnType("date");

        builder.Property(o => o.SysTDate)
            .HasColumnType("timestamp")
            .IsRowVersion();

        builder.Property(o => o.DepositDate)
            .HasColumnType("date");

        builder.Property(o => o.PayeeName)
            .HasMaxLength(255);

        builder.Property(o => o.DepositorContact)
            .HasMaxLength(255);

        builder.Property(o => o.InstructionId)
            .HasMaxLength(50);

        builder.Property(o => o.InstrId)
            .HasMaxLength(50);

        builder.Property(o => o.EndToEndId)
            .HasMaxLength(50);

        builder.Property(o => o.TxId)
            .HasMaxLength(50);

        builder.Property(o => o.MsgId)
            .HasMaxLength(50);

        // Define the relationships
        builder.HasOne(o => o.Bank)
            .WithMany()
            .HasForeignKey(o => o.BankId)
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

        builder.HasOne(o => o.Region)
            .WithMany()
            .HasForeignKey(o => o.RegionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.ReturnReason)
            .WithMany()
            .HasForeignKey(o => o.ReturnReasonId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(o => o.Slip)
            .WithMany()
            .HasForeignKey(o => o.SlipId)
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

