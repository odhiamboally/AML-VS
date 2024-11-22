using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class StoppedChequeConfiguration : IEntityTypeConfiguration<StoppedCheque>
{
    public void Configure(EntityTypeBuilder<StoppedCheque> builder)
    {
        builder.ToTable("STOPPEDCHEQUE");

        builder.HasKey(sc => new
        {
            sc.StoppedChequeNo,
            sc.AccountNo,
            sc.StartAt,
            sc.EndAt,
            sc.Amount,
            sc.CodeLine,
            sc.BranchId,
            sc.Manual
        });

        builder.Property(sc => sc.StoppedChequeNo)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(sc => sc.AccountNo)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(sc => sc.StartAt)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(sc => sc.EndAt)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(sc => sc.CodeLine)
            .IsRequired();

        builder.Property(sc => sc.BranchId)
            .IsRequired();

        builder.Property(sc => sc.Amount)
            .HasColumnType("decimal(18,2)");

        builder.HasOne(sc => sc.Branch)
            .WithMany()
            .HasForeignKey(sc => sc.BranchId);
    }
}

