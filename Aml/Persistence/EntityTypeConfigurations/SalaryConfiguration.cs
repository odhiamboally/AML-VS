using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class SalaryConfiguration : IEntityTypeConfiguration<Salary>
{
    public void Configure(EntityTypeBuilder<Salary> builder)
    {
        builder.ToTable("SALARY");

        builder.HasKey(s => s.SalaryId);

        builder.Property(s => s.SalaryId)
            .ValueGeneratedOnAdd();

        builder.Property(s => s.EmpName)
            .IsRequired();

        builder.Property(s => s.EmpAccNo)
            .IsRequired();

        builder.Property(s => s.Amount)
            .IsRequired();

        builder.Property(s => s.BankId)
            .IsRequired();

        builder.Property(s => s.BranchId)
            .IsRequired();

        builder.Property(s => s.SalaryDate)
            .IsRequired();

        builder.Property(s => s.RefNo)
            .HasMaxLength(30);

        builder.Property(s => s.RegionId)
            .IsRequired();

        builder.Property(s => s.CurrencyId)
            .IsRequired();

        builder.Property(s => s.IsRejected)
            .HasColumnType("bit");

        builder.Property(s => s.RejectReason)
            .HasMaxLength(255);

        builder.Property(s => s.ImportedFileId)
            .HasColumnType("numeric");

        builder.Property(s => s.BatchId)
            .HasColumnType("numeric");

        builder.Property(s => s.UserId)
            .IsRequired();

        builder.Property(s => s.SysDate)
            .HasColumnType("timestamp")
            .IsRowVersion()
            .HasMaxLength(8);

        builder.Property(s => s.ProcNo)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(s => s.BackupDate)
            .HasColumnType("date");

        builder.Property(s => s.Captured)
            .HasColumnType("bit");

        builder.Property(s => s.Verified)
            .HasColumnType("bit");

        builder.Property(s => s.Authorized)
            .HasColumnType("bit");

        builder.Property(s => s.ClientName)
            .HasMaxLength(100);

        builder.Property(s => s.ClientAccNo)
            .HasMaxLength(50);

        builder.Property(s => s.SpsClientId)
            .IsRequired(false);

        builder.Property(s => s.FileName)
            .HasMaxLength(255);

        builder.HasOne(s => s.Bank)
            .WithMany()
            .HasForeignKey(s => s.BankId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(s => s.Batch)
            .WithMany()
            .HasForeignKey(s => s.BatchId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(s => s.Branch)
            .WithMany()
            .HasForeignKey(s => s.BranchId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(s => s.Currency)
            .WithMany()
            .HasForeignKey(s => s.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(s => s.ImportedFile)
            .WithMany()
            .HasForeignKey(s => s.ImportedFileId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(s => s.Region)
            .WithMany()
            .HasForeignKey(s => s.RegionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(s => s.User)
            .WithMany()
            .HasForeignKey(s => s.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

