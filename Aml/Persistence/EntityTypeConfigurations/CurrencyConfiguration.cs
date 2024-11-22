using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.ToTable("CURRENCY");

        builder.HasKey(c => c.CurrencyId);

        builder.Property(c => c.CurrencyCode)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(c => c.CurrencyName)
            .IsRequired();

        builder.Property(c => c.UploadCode)
            .HasMaxLength(50);

        builder.Property(c => c.IsoCode)
            .HasMaxLength(3);

        builder.Property(c => c.ValueCap)
            .HasColumnType("money")
            .IsRequired();

        builder.Property(c => c.ExchangeRate)
            .IsRequired();

        builder.Property(c => c.RoundCents)
            .IsRequired();

        builder.HasMany(c => c.AccountTemp) // Currency can have many AccountTemp
            .WithOne(a => a.Currency)      // AccountTemp has one Currency
            .HasForeignKey(a => a.CurrencyId); // Use a foreign key


        // Configuring the many-to-many relationship
        builder.HasMany(c => c.AccountTypes)  // Currency can have many AccountTypes
            .WithMany()  // AccountType does not have a direct navigation property
            .UsingEntity<Dictionary<string, object>>(
                "CurrencyAccountType", // Define the join table name
                j => j.HasOne<AccountType>().WithMany().HasForeignKey("AccountTypeId"),  // Relationship from AccountType to Currency
                j => j.HasOne<Currency>().WithMany().HasForeignKey("CurrencyId")  // Relationship from Currency to AccountType
            );

        // Additional relationships can be defined here, as necessary
    }
}

