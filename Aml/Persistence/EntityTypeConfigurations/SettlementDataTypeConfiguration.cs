using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class SettlementDataTypeConfiguration : IEntityTypeConfiguration<SettlementDataType>
{
    public void Configure(EntityTypeBuilder<SettlementDataType> builder)
    {
        builder.ToTable("SETTLEMENTDATATYPE");

        builder.HasKey(sdt => sdt.SettlementDataTypeId);

        builder.Property(sdt => sdt.SettlementDataTypeId)
            .ValueGeneratedNever(); // No auto-generation for this ID

        builder.Property(sdt => sdt.TypeDescription)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(sdt => sdt.TypeCode)
            .IsRequired()
            .HasMaxLength(2);

        builder.HasMany(sdt => sdt.InSettlements)
            .WithOne(iset => iset.SettlementDataType)
            .HasForeignKey(iset => iset.SettlementDataTypeId)
            .OnDelete(DeleteBehavior.Cascade); // Adjust delete behavior as needed

        builder.HasMany(sdt => sdt.OutSettlements)
            .WithOne(oset => oset.SettlementDataType)
            .HasForeignKey(oset => oset.SettlementDataTypeId)
            .OnDelete(DeleteBehavior.Cascade); // Adjust delete behavior as needed
    }
}

