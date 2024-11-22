using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class InRTGConfiguration : IEntityTypeConfiguration<InRTG>
{
    public void Configure(EntityTypeBuilder<InRTG> builder)
    {
        builder.ToTable("INRTGS");

        builder.HasKey(i => i.InrtgsId);

        builder.Property(i => i.BatchId)
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
            .IsRequired();

        builder.Property(i => i.Amount)
            .HasColumnType("money")
            .IsRequired();

        builder.Property(i => i.CurrencyId)
            .IsRequired();

        builder.Property(i => i.RtgsTypeId)
            .IsRequired();

        builder.Property(i => i.Remarks)
            .HasMaxLength(500);

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
            .HasColumnType("date");

        builder.Property(i => i.SystDate)
            .IsRowVersion()
            .IsRequired();

        builder.HasOne(i => i.Bank)
            .WithMany(b => b.InRtgs)
            .HasForeignKey(i => i.BankId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.Branch)
            .WithMany(b => b.InRtgs)
            .HasForeignKey(i => i.BranchId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.Currency)
            .WithMany(c => c.InRtgs)
            .HasForeignKey(i => i.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.RtgsType)
            .WithMany(r => r.InRtgs)
            .HasForeignKey(i => i.RtgsTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.User)
            .WithMany(u => u.InRtgs)
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.ReturnReason)
            .WithMany(r => r.InRtgs)
            .HasForeignKey(i => i.ReturnReasonId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

