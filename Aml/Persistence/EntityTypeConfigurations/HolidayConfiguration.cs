using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class HolidayConfiguration : IEntityTypeConfiguration<Holiday>
{
    public void Configure(EntityTypeBuilder<Holiday> builder)
    {
        builder.ToTable("HOLIDAY");

        builder.HasKey(x => x.HolidayId);

        builder.Property(x => x.HolidayId)
            .IsRequired()
            .ValueGeneratedOnAdd(); // Identity or auto-generated

        builder.Property(x => x.HolidayName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.HolidayDate)
            .IsRequired()
            .HasColumnType("date");

        builder.Property(x => x.LcyHoliday)
            .IsRequired();

        builder.Property(x => x.FcyHoliday)
            .IsRequired();

        builder.Property(x => x.Recurrent)
            .IsRequired();

        builder.Property(x => x.MakerId)
            .IsRequired();

        builder.Property(x => x.CheckerId)
            .IsRequired();

        builder.Property(x => x.StatusId)
            .IsRequired();

        builder.Property(x => x.CheckerDate)
            .IsRequired();

        builder.Property(x => x.SysDate)
            .IsRequired()
            .HasMaxLength(8)
            .IsRowVersion(); // Mapping the timestamp field

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

