using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Aml.Shared.Entitties;

namespace Aml.Persistence.EntityTypeConfigurations;

public class ChannelConfiguration : IEntityTypeConfiguration<Channel>
{
    public void Configure(EntityTypeBuilder<Channel> builder)
    {
        builder.ToTable("CHANNEL");

        builder.HasKey(x => x.ChannelId);

        builder.Property(x => x.ChannelName)
            .HasMaxLength(20);

        builder.Property(x => x.ChannelValue)
            .HasMaxLength(50);

        builder.Property(x => x.ChannelDesc)
            .HasMaxLength(100);

        builder.HasMany(x => x.RuleConfigs)
            .WithOne()
            .HasForeignKey(x => x.ChannelId)
            .OnDelete(DeleteBehavior.Cascade); // Assuming cascade delete for the relationship
    }
}

