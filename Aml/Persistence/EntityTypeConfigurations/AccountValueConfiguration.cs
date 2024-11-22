using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class AccountValueConfiguration : IEntityTypeConfiguration<AccountValue>
{
    public void Configure(EntityTypeBuilder<AccountValue> builder)
    {
        builder.ToTable("ACCOUNTVALUE");  // Mapping the table name

        builder.HasKey(av => av.AccountValueId);  // Setting primary key

        builder.Property(av => av.AccountValueId)
            .HasColumnType("numeric")
            .ValueGeneratedOnAdd();  // Identity column for AccountValueId

        builder.Property(av => av.AccountNo)
            .IsRequired()
            .HasMaxLength(25);  // Defining required field and max length

        builder.Property(av => av.ValueDayId)
            .IsRequired();  // Marking as required

        builder.Property(av => av.StatusId)
            .IsRequired();  // Marking as required

        // Defining relationships with Status and ValueDay
        builder.HasOne(av => av.Status)
            .WithMany()  // No collection navigation in Status, so we use WithMany()
            .HasForeignKey(av => av.StatusId);  // Foreign key to Status

        builder.HasOne(av => av.ValueDay)
            .WithMany()  // No collection navigation in ValueDay, so we use WithMany()
            .HasForeignKey(av => av.ValueDayId);  // Foreign key to ValueDay
    }
}

