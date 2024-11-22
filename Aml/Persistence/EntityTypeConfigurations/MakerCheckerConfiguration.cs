using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class MakerCheckerConfiguration : IEntityTypeConfiguration<MakerChecker>
{
    public void Configure(EntityTypeBuilder<MakerChecker> builder)
    {
        builder.ToTable("MAKERCHECKER");

        builder.HasKey(x => x.MakerCheckerId);

        builder.Property(x => x.MakerCheckerId)
            .IsRequired()
            .ValueGeneratedOnAdd(); // Identity or auto-generated

        builder.Property(x => x.ObjectCategory)
            .IsRequired();

        builder.Property(x => x.ObjectName)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(x => x.ActionDescription)
            .IsRequired();

        builder.Property(x => x.QueryString)
            .IsRequired();

        builder.Property(x => x.HashCode)
            .IsRequired();

        builder.Property(x => x.MakerId)
            .IsRequired();

        builder.Property(x => x.CheckerId)
            .IsRequired(false); // Nullable field

        builder.Property(x => x.StatusId)
            .IsRequired();

        builder.Property(x => x.CheckerDate)
            .IsRequired();

        builder.Property(x => x.SysDate)
            .IsRequired()
            .HasMaxLength(8)
            .IsRowVersion(); // Mapping the timestamp field

        builder.Property(x => x.ActionReason)
            .IsRequired();

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.MakerId)
            .OnDelete(DeleteBehavior.Restrict); // Assuming the user entity

        builder.HasOne(x => x.Status)
            .WithMany()
            .HasForeignKey(x => x.StatusId)
            .OnDelete(DeleteBehavior.Restrict); // Assuming the status entity
    }
}

