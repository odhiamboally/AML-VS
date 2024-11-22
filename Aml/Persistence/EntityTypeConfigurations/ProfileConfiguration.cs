using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Aml.Shared.Entitties;

namespace Aml.Persistence.EntityTypeConfigurations;

public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
{
    public void Configure(EntityTypeBuilder<Profile> builder)
    {
        // Table name
        builder.ToTable("PROFILE");

        // Primary key
        builder.HasKey(p => p.ProfileId);

        // Properties
        builder.Property(p => p.ProfileCode)
            .IsRequired()
            .HasMaxLength(5);

        builder.Property(p => p.ProfileName)
            .IsRequired();

        builder.Property(p => p.ProfileDesc)
            .IsRequired();

        builder.Property(p => p.StatusId)
            .IsRequired();

        // Relationships
        builder.HasOne(p => p.Status)
            .WithMany(s => s.Profiles)
            .HasForeignKey(p => p.StatusId)
            .OnDelete(DeleteBehavior.Restrict); // Ensure no cascading delete

        builder.HasMany(p => p.Users)
            .WithOne(u => u.Profile)
            .HasForeignKey(u => u.ProfileId)
            .OnDelete(DeleteBehavior.Cascade); // Cascading delete from Profile to User
    }
}
