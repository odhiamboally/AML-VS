using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class MenuCategoryConfiguration : IEntityTypeConfiguration<MenuCategory>
{
    public void Configure(EntityTypeBuilder<MenuCategory> builder)
    {
        builder.ToTable("MENUCATEGORY");

        builder.HasKey(x => x.MenuCategoryId);

        builder.Property(x => x.MenuCategoryId)
            .IsRequired()
            .ValueGeneratedNever(); // Explicitly set by the application or database

        builder.Property(x => x.MenuCategoryName)
            .IsRequired()
            .HasMaxLength(25);

        builder.HasMany(x => x.Menus)
            .WithOne(x => x.MenuCategory)
            .HasForeignKey(x => x.MenuCategoryId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes
    }
}

