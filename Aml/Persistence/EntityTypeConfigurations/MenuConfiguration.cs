using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class MenuConfiguration : IEntityTypeConfiguration<Menu>
{
    public void Configure(EntityTypeBuilder<Menu> builder)
    {
        builder.ToTable("MENU");

        builder.HasKey(x => x.MenuId);

        builder.Property(x => x.MenuId)
            .IsRequired()
            .ValueGeneratedNever(); // Explicitly set by the application or database

        builder.Property(x => x.MenuCode)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.MenuName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.MenuUrl)
            .IsRequired();

        builder.Property(x => x.MenuCategoryId)
            .IsRequired();

        builder.Property(x => x.MenuLevel)
            .IsRequired();

        builder.Property(x => x.MainMenu)
            .IsRequired();

        builder.Property(x => x.Functional)
            .IsRequired();

        builder.Property(x => x.StatusId)
            .IsRequired();

        builder.HasOne(x => x.MenuCategory)
            .WithMany()
            .HasForeignKey(x => x.MenuCategoryId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes for MenuCategory

        builder.HasOne(x => x.Status)
            .WithMany()
            .HasForeignKey(x => x.StatusId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes for Status
    }
}

