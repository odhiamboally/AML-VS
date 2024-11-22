
using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class RtgsTypeConfiguration : IEntityTypeConfiguration<RtgsType>
{
    public void Configure(EntityTypeBuilder<RtgsType> builder)
    {
        builder.ToTable("RTGSTYPE");

        builder.HasKey(x => x.RtgsTypeId);

        builder.Property(x => x.RtgsTypeId)
            .IsRequired()
            .ValueGeneratedNever(); // Not auto-generated

        builder.Property(x => x.RtgsTypeName)
            .IsRequired()
            .HasMaxLength(25);

        builder.HasMany(x => x.AchMessages)
            .WithOne(x => x.RtgsType)
            .HasForeignKey(x => x.RtgsTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.InRtgs)
            .WithOne()
            .HasForeignKey(x => x.RtgsTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.OutRtgs)
            .WithOne()
            .HasForeignKey(x => x.RtgsTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

