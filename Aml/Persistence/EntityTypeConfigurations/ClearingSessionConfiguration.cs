using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class ClearingSessionConfiguration : IEntityTypeConfiguration<ClearingSession>
{
    public void Configure(EntityTypeBuilder<ClearingSession> builder)
    {
        builder.ToTable("CLEARINGSESSION");

        builder.HasKey(cs => cs.ClearingSessionId);

        builder.Property(cs => cs.ClearingSessionId)
            .ValueGeneratedOnAdd(); // Primary key and identity column

        builder.Property(cs => cs.SessionCode)
            .HasMaxLength(5);

        builder.Property(cs => cs.SessionName)
            .IsRequired();

        builder.Property(cs => cs.StartTime)
            .HasColumnType("time");

        builder.Property(cs => cs.CutOffTime)
            .HasColumnType("time");

        builder.HasOne(cs => cs.Status)
            .WithMany(s => s.ClearingSessions)
            .HasForeignKey(cs => cs.StatusId)
            .OnDelete(DeleteBehavior.Restrict); // Adjust delete behavior as needed

        builder.HasMany(cs => cs.AchCheque)
            .WithOne(ac => ac.ClearingSession)
            .HasForeignKey(ac => ac.ClearingSessionId);

        builder.HasMany(cs => cs.Batch)
            .WithOne(b => b.ClearingSession)
            .HasForeignKey(b => b.ClearingSessionId);

        builder.HasMany(cs => cs.InSettlement)
            .WithOne(i => i.ClearingSession)
            .HasForeignKey(i => i.ClearingSessionId);

        builder.HasMany(cs => cs.OutSettlement)
            .WithOne(os => os.ClearingSession)
            .HasForeignKey(os => os.ClearingSessionId);
    }
}

