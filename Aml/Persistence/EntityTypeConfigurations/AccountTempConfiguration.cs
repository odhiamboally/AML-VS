using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class AccountTempConfiguration : IEntityTypeConfiguration<AccountTemp>
{
    public void Configure(EntityTypeBuilder<AccountTemp> builder)
    {
        builder.ToTable("ACCOUNT_TEMP");

        builder.HasNoKey();
        //builder.HasKey(x => x.CustomerNo);


        builder.Property(x => x.CustomerNo)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(x => x.AccountNo)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(x => x.AccountName)
            .IsRequired();

        builder.Property(x => x.CurrencyId)
            .IsRequired();

        builder.Property(x => x.BranchId)
            .IsRequired();

        builder.Property(x => x.StatusId)
            .IsRequired();

        builder.Property(x => x.UploadMethodId)
            .IsRequired();

        builder.Property(x => x.AllowCredit)
            .IsRequired();

        builder.Property(x => x.AllowDebit)
            .IsRequired();

        builder.Property(x => x.NewAccount)
            .HasMaxLength(15);

        builder.Property(x => x.AccountClass)
            .HasMaxLength(50);

        builder.Property(x => x.ReactivationDate)
            .HasColumnType("date");

        builder.Property(x => x.CreationDate)
            .HasMaxLength(50);

        builder.Property(x => x.ExemptAutoDelete)
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

