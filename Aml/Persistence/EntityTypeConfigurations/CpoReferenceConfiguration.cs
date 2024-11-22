using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class CpoReferenceConfiguration : IEntityTypeConfiguration<CpoReference>
{
    public void Configure(EntityTypeBuilder<CpoReference> builder)
    {
        builder.ToTable("CPOREFERENCE");

        //builder.HasKey(x => new { x.DdMicrNo, x.AccountNo, x.Amount, x.LcyAmount, x.CurrencyId });
        builder.HasNoKey();

        builder.Property(x => x.DdMicrNo)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(x => x.AccountNo)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(x => x.Amount)
            .IsRequired();

        builder.Property(x => x.LcyAmount)
            .IsRequired();

        builder.Property(x => x.CurrencyId)
            .IsRequired();

        builder.Property(x => x.InstrumentNo)
            .HasMaxLength(50);

        builder.Property(x => x.Beneficiary)
            .HasMaxLength(100);

        builder.Property(x => x.Narrative)
            .HasMaxLength(255);

        builder.HasOne(x => x.Currency)
            .WithMany()
            .HasForeignKey(x => x.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict); // Assuming a CURRENCY entity
    }
}

