using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class AccessRightConfiguration : IEntityTypeConfiguration<AccessRight>
{
    public void Configure(EntityTypeBuilder<AccessRight> builder)
    {
        builder.ToTable("ACCESSRIGHT");

        builder.HasKey(x => x.AccessRightId);

        builder.Property(x => x.AccessRightId)
            .IsRequired()
            .HasColumnType("numeric")
            .ValueGeneratedOnAdd(); // Matches DatabaseGeneratedOption.Identity

        builder.Property(x => x.ProfileId)
            .IsRequired();

        builder.Property(x => x.MenuId)
            .IsRequired();

        builder.Property(x => x.StatusId)
            .IsRequired();

        builder.Property(x => x.UserId)
            .IsRequired();

        builder.HasOne(x => x.Menu)
            .WithMany()
            .HasForeignKey(x => x.MenuId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes for Menu

        builder.HasOne(x => x.Status)
            .WithMany()
            .HasForeignKey(x => x.StatusId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes for Status

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes for User
    }
}

