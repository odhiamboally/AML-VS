using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class LocationTypeConfiguration : IEntityTypeConfiguration<LocationType>
{
    public void Configure(EntityTypeBuilder<LocationType> builder)
    {
        builder.ToTable("LOCATIONTYPE");

        builder.HasKey(x => x.LocationTypeId);

        builder.Property(x => x.LocationTypeId)
            .IsRequired()
            .ValueGeneratedNever(); // Matches DatabaseGeneratedOption.None

        builder.Property(x => x.LocationTypeCode)
            .IsRequired()
            .HasMaxLength(5);

        builder.Property(x => x.LocationTypeDesc)
            .IsRequired()
            .HasMaxLength(255); // Same as revised class above

        builder.HasOne(x => x.Status)
            .WithMany()
            .HasForeignKey(x => x.StatusId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes if required

        builder.HasMany(x => x.Branches)
            .WithOne(x => x.LocationType)
            .HasForeignKey(x => x.LocationTypeId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes for branches
    }
}

