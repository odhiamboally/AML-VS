using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class ValueDayConfiguration : IEntityTypeConfiguration<ValueDay>
{
    public void Configure(EntityTypeBuilder<ValueDay> builder)
    {
        builder.ToTable("VALUEDAY");  // Map to table

        builder.HasKey(vd => vd.ValueDayId);  // Primary key configuration

        builder.Property(vd => vd.ValueDayId)
            .ValueGeneratedOnAdd();  // Identity column for ValueDayId

        builder.Property(vd => vd.ValueDayCode)
            .IsRequired()
            .HasMaxLength(5);  // ValueDayCode is required and has a max length of 5

        builder.Property(vd => vd.ValueDayDesc)
            .IsRequired();  // ValueDayDesc is required

        builder.Property(vd => vd.StatusId)
            .IsRequired();  // StatusId is required

        // Configuring the relationship with AccountValue
        builder.HasMany(vd => vd.AccountValues)
            .WithOne(av => av.ValueDay)  // Each AccountValue has one ValueDay
            .HasForeignKey(av => av.ValueDayId);  // Foreign key is ValueDayId

        // Configuring the relationship with Status
        builder.HasOne(vd => vd.Status)
            .WithMany()  // No collection navigation on Status, so we use WithMany()
            .HasForeignKey(vd => vd.StatusId);  // Foreign key to Status
    }
}

