using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class PasswordListConfiguration : IEntityTypeConfiguration<PasswordList>
{
    public void Configure(EntityTypeBuilder<PasswordList> builder)
    {
        builder.ToTable("PASSWORDLIST");

        builder.HasKey(x => x.PasswordListId);

        builder.Property(x => x.PasswordListId)
            .IsRequired()
            .ValueGeneratedOnAdd(); // Identity or auto-generated

        builder.Property(x => x.UserId)
            .IsRequired();

        builder.Property(x => x.Password)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.ChangeDate)
            .IsRequired();

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict); // Assuming the user entity
    }
}

