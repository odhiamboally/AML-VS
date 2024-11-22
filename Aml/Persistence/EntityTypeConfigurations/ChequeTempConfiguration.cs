using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class ChequeTempConfiguration : IEntityTypeConfiguration<ChequeTemp>
{
    public void Configure(EntityTypeBuilder<ChequeTemp> builder)
    {
        builder.ToTable("CHEQUETEMP");

        builder.HasKey(c => c.ChequeTempId);

        builder.Property(c => c.ChequeTempId)
            .ValueGeneratedOnAdd()
            .HasColumnType("numeric");

        builder.Property(c => c.SlipId)
            .HasColumnType("numeric")
            .IsRequired();

        builder.Property(c => c.ProcNo)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(c => c.RawmLine)
            .IsRequired();

        builder.Property(c => c.Rejected)
            .IsRequired();

        builder.Property(c => c.RejectReason)
            .HasMaxLength(500); // Adjust the max length as necessary

        builder.HasOne(c => c.Slip)
            .WithMany(s => s.ChequeTemps)
            .HasForeignKey(c => c.SlipId)
            .OnDelete(DeleteBehavior.Cascade);  // Adjust delete behavior as needed
    }
}

