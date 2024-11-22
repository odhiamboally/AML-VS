using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("CATEGORY");

        builder.HasKey(x => x.CategoryId);

        builder.Property(x => x.CategoryName)
            .HasMaxLength(50);

        builder.Property(x => x.CategoryValue)
            .HasMaxLength(50);

        builder.Property(x => x.CategoryDesc)
            .HasMaxLength(100);

        builder.HasMany(x => x.RuleConfigs)
            .WithOne()
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.Cascade); // Assuming cascade delete for the relationship
    }
}

