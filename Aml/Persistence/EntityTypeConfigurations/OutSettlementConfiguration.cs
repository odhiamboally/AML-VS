using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class OutSettlementConfiguration : IEntityTypeConfiguration<OutSettlement>
{
    public void Configure(EntityTypeBuilder<OutSettlement> builder)
    {
        builder.ToTable("OUTSETTLEMENT");

        builder.HasKey(os => os.OutSettlementId);

        builder.Property(os => os.OutSettlementId)
            .HasColumnType("numeric")
            .ValueGeneratedOnAdd();

        builder.Property(os => os.BankId)
            .IsRequired();

        builder.Property(os => os.CurrencyId)
            .IsRequired();

        builder.Property(os => os.ClearingSessionId)
            .IsRequired();

        builder.Property(os => os.SettlementDataTypeId)
            .IsRequired();

        builder.Property(os => os.ItemCount)
            .IsRequired();

        builder.Property(os => os.ItemSum)
            .IsRequired();

        builder.Property(os => os.UserId)
            .IsRequired();

        builder.Property(os => os.SysDate)
            .HasColumnType("timestamp")
            .IsRowVersion()
            .HasMaxLength(8);

        builder.Property(os => os.BackupDate)
            .HasColumnType("date");

        builder.HasOne(os => os.Bank)
            .WithMany()
            .HasForeignKey(os => os.BankId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(os => os.Currency)
            .WithMany()
            .HasForeignKey(os => os.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(os => os.ClearingSession)
            .WithMany()
            .HasForeignKey(os => os.ClearingSessionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(os => os.SettlementDataType)
            .WithMany()
            .HasForeignKey(os => os.SettlementDataTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(os => os.User)
            .WithMany()
            .HasForeignKey(os => os.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

