using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // Table name
        builder.ToTable("USER");

        // Primary key
        builder.HasKey(u => u.UserId);

        // Properties
        builder.Property(u => u.UserName)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(u => u.Surname)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(u => u.OtherNames)
            .IsRequired();

        builder.Property(u => u.Password)
            .IsRequired();

        builder.Property(u => u.LoggedInSession)
            .IsRequired();

        builder.Property(u => u.Email)
            .HasMaxLength(50);

        builder.Property(u => u.PhoneNo)
            .HasMaxLength(20);

        builder.Property(u => u.LastPassChange)
            .HasColumnType("date");

        builder.Property(u => u.LastLogin)
            .HasColumnType("date");

        builder.Property(u => u.TokenName)
            .HasMaxLength(100);

        // Relationships
        builder.HasOne(u => u.Branch)
            .WithMany(b => b.Users)
            .HasForeignKey(u => u.BranchId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(u => u.Profile)
            .WithMany(p => p.Users)
            .HasForeignKey(u => u.ProfileId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(u => u.Status)
            .WithMany(s => s.Users)
            .HasForeignKey(u => u.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(u => u.AccessRights)
            .WithOne(ar => ar.User)
            .HasForeignKey(ar => ar.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Similar configurations can be added for other collections
    }
}
