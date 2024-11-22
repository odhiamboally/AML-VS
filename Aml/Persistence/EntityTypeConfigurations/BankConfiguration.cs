using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Aml.Shared.Entitties;

namespace Aml.Persistence.EntityTypeConfigurations;

public class BankConfiguration : IEntityTypeConfiguration<Bank>
{
    public void Configure(EntityTypeBuilder<Bank> builder)
    {
        // Table Mapping
        builder.ToTable("BANK");

        // Primary Key
        builder.HasKey(b => b.BankId);

        // Property Configurations
        builder.Property(b => b.BankId)
            .HasColumnName("BANKID");

        builder.Property(b => b.BankCode)
            .HasColumnName("BANKCODE")
            .HasMaxLength(5)
            .IsRequired();

        builder.Property(b => b.BankName)
            .HasColumnName("BANKNAME")
            .IsRequired();

        builder.Property(b => b.BankAbbrev)
            .HasColumnName("BANKABBREV")
            .HasMaxLength(10);

        builder.Property(b => b.ClearingBankCode)
            .HasColumnName("CLEARINGBANKCODE")
            .HasMaxLength(15)
            .IsRequired();

        builder.Property(b => b.UploadCode)
            .HasColumnName("UPLOADCODE")
            .IsRequired();

        builder.Property(b => b.Clearing)
            .HasColumnName("CLEARING");

        builder.Property(b => b.Fcy)
            .HasColumnName("FCY");

        builder.Property(b => b.StatusId)
            .HasColumnName("STATUSID");

        // Relationships (if any specific configurations are required)
        // Example: If there are any foreign keys or many-to-one relationships
        // they can be configured here.
    }
}
