using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class AccountTypeConfiguration : IEntityTypeConfiguration<AccountType>
{
    public void Configure(EntityTypeBuilder<AccountType> builder)
    {
        builder.ToTable("ACCOUNTTYPE");

        builder.HasKey(x => x.AccountTypeId);

        builder.Property(x => x.AccountClass)
            .IsRequired()
            .HasMaxLength(50); // Assuming a max length for account class, adjust if needed

        builder.Property(x => x.AccountTypeDesc)
            .HasMaxLength(250); // Assuming max length for description, adjust if needed

        builder.Property(x => x.CurrencyId)
            .IsRequired(false);

        builder.Property(x => x.StatusId)
            .IsRequired(false);

        builder.HasOne(x => x.Currency)
            .WithMany()
            .HasForeignKey(x => x.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Status)
            .WithMany()
            .HasForeignKey(x => x.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        
    }
}

