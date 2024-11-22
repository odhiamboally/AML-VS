using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class InSettlementConfiguration : IEntityTypeConfiguration<InSettlement>
{
    public void Configure(EntityTypeBuilder<InSettlement> builder)
    {
        builder.ToTable("INSETTLEMENT");

        builder.HasKey(i => i.InSettlementId);

        builder.Property(i => i.InSettlementId)
            .HasColumnName("INSETTLEMENTID")
            .HasColumnType("numeric")
            .ValueGeneratedOnAdd();

        builder.Property(i => i.BankId)
            .HasColumnName("BANKID");

        builder.Property(i => i.CurrencyId)
            .HasColumnName("CURRENCYID");

        builder.Property(i => i.ClearingSessionId)
            .HasColumnName("CLEARINGSESSIONID");

        builder.Property(i => i.SettlementDataTypeId)
            .HasColumnName("SETTLEMENTDATATYPEID");

        builder.Property(i => i.ItemCount)
            .HasColumnName("ITEMCOUNT");

        builder.Property(i => i.ItemSum)
            .HasColumnName("ITEMSUM");

        builder.Property(i => i.UserId)
            .HasColumnName("USERID");

        builder.Property(i => i.SysDate)
            .HasColumnName("SYSTDATE")
            .HasColumnType("timestamp")
            .HasMaxLength(8);

        builder.Property(i => i.BackupDate)
            .HasColumnName("BACKUPDATE")
            .HasColumnType("datetime");

        // Define relationships
        builder.HasOne(i => i.Bank)
            .WithMany()
            .HasForeignKey(i => i.BankId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.Currency)
            .WithMany()
            .HasForeignKey(i => i.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.ClearingSession)
            .WithMany()
            .HasForeignKey(i => i.ClearingSessionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.SettlementDataType)
            .WithMany()
            .HasForeignKey(i => i.SettlementDataTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(i => i.User)
            .WithMany()
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

