using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Aml.Shared.Entitties;

namespace Aml.Persistence.EntityTypeConfigurations;

public class BatchConfiguration : IEntityTypeConfiguration<Batch>
{
    public void Configure(EntityTypeBuilder<Batch> builder)
    {
        builder.ToTable("BATCH");

        builder.HasKey(b => b.BatchId);

        builder.Property(b => b.BatchId)
            .HasColumnName("BATCHID")
            .HasColumnType("numeric")
            .ValueGeneratedOnAdd();

        builder.Property(b => b.BatchNo)
            .HasColumnName("BATCHNO")
            .IsRequired()
            .HasMaxLength(4);

        builder.Property(b => b.BranchId)
            .HasColumnName("BRANCHID")
            .IsRequired();

        builder.Property(b => b.CurrencyId)
            .HasColumnName("CURRENCYID")
            .IsRequired();

        builder.Property(b => b.BatchTypeId)
            .HasColumnName("BATCHTYPEID")
            .IsRequired();

        builder.Property(b => b.ClearingSessionId)
            .HasColumnName("CLEARINGSESSIONID")
            .IsRequired();

        builder.Property(b => b.UserId)
            .HasColumnName("USERID")
            .IsRequired();

        builder.Property(b => b.Verifier)
            .HasColumnName("VERIFIER");

        builder.Property(b => b.Authorizer)
            .HasColumnName("AUTHORIZER");

        builder.Property(b => b.Day2)
            .HasColumnName("DAY2")
            .IsRequired();

        builder.Property(b => b.Captured)
            .HasColumnName("CAPTURED")
            .IsRequired();

        builder.Property(b => b.Verified)
            .HasColumnName("VERIFIED")
            .IsRequired();

        builder.Property(b => b.Authorized)
            .HasColumnName("AUTHORIZED")
            .IsRequired();

        builder.Property(b => b.Uploaded)
            .HasColumnName("UPLOADED")
            .IsRequired();

        builder.Property(b => b.Commissioned)
            .HasColumnName("COMMISSIONED")
            .IsRequired();

        builder.Property(b => b.BackupDate)
            .HasColumnName("BACKUPDATE")
            .HasColumnType("date");

        builder.Property(b => b.SysDate)
            .HasColumnName("SYSTDATE")
            .HasColumnType("timestamp")
            .IsRowVersion();

        builder.Property(b => b.Switched)
            .HasColumnName("SWITCHED");

        builder.Property(b => b.AchGenerated)
            .HasColumnName("ACHGENERATED");

        builder.HasOne(b => b.BatchType)
            .WithMany()
            .HasForeignKey(b => b.BatchTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.Branch)
            .WithMany()
            .HasForeignKey(b => b.BranchId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.ClearingSession)
            .WithMany()
            .HasForeignKey(b => b.ClearingSessionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.Currency)
            .WithMany()
            .HasForeignKey(b => b.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(b => b.User)
            .WithMany()
            .HasForeignKey(b => b.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        // One-to-many relationships with Incheques, Indebits, etc.
        builder.HasMany(b => b.Incheques)
            .WithOne()
            .HasForeignKey(i => i.BatchId) // assuming Incheque has BatchId
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(b => b.InDebits)
            .WithOne()
            .HasForeignKey(i => i.BatchId) // assuming Indebit has BatchId
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(b => b.Outcredits)
            .WithOne()
            .HasForeignKey(o => o.BatchId) // assuming Outcredit has BatchId
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(b => b.Outdebits)
            .WithOne()
            .HasForeignKey(o => o.BatchId) // assuming Outdebit has BatchId
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(b => b.Salaries)
            .WithOne()
            .HasForeignKey(s => s.BatchId) // assuming Salary has BatchId
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(b => b.Slips)
            .WithOne()
            .HasForeignKey(s => s.BatchId) // assuming Slip has BatchId
            .OnDelete(DeleteBehavior.Cascade);
    }
}


