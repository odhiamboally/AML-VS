using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class UnusedChequeConfiguration : IEntityTypeConfiguration<UnusedCheque>
{
    public void Configure(EntityTypeBuilder<UnusedCheque> builder)
    {
        builder.ToTable("UNUSEDCHEQUE");

        builder.HasKey(uc => new { uc.AccountNo, uc.BranchId, uc.ChequeNo, uc.Used });

        builder.Property(uc => uc.AccountNo)
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(uc => uc.BranchId)
            .IsRequired();

        builder.Property(uc => uc.ChequeNo)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(uc => uc.ChequeBookNo)
            .HasMaxLength(20);

        builder.Property(uc => uc.Used)
            .IsRequired();

        builder.HasOne(uc => uc.Branch)
            .WithMany()
            .HasForeignKey(uc => uc.BranchId);
    }
}

