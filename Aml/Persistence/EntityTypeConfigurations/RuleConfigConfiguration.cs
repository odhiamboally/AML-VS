using Aml.Shared.Entitties;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Aml.Persistence.EntityTypeConfigurations;

public class RuleConfigConfiguration : IEntityTypeConfiguration<RuleConfig>
{
    public void Configure(EntityTypeBuilder<RuleConfig> builder)
    {
        builder.ToTable("RULECONFIG");

        builder.HasKey(x => x.RuleNo);

        builder.Property(x => x.RuleCode)
            .HasMaxLength(20);

        builder.Property(x => x.RuleDesc)
            .HasMaxLength(250);

        builder.Property(x => x.RuleName)
            .HasMaxLength(250);

        builder.Property(x => x.DisplayColumn)
            .HasMaxLength(250);

        builder.Property(x => x.Condition)
            .HasMaxLength(250);

        builder.Property(x => x.RuleSource)
            .HasMaxLength(50);

        builder.Property(x => x.Functional)
            .IsRequired();

        builder.Property(x => x.Entity)
            .HasMaxLength(50);

        builder.Property(x => x.CategoryId)
            .IsRequired(false);

        builder.Property(x => x.ChannelId)
            .IsRequired(false);

        builder.Property(x => x.CurrencyId)
            .IsRequired(false);

        builder.HasOne(x => x.Category)
            .WithMany()
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Channel)
            .WithMany()
            .HasForeignKey(x => x.ChannelId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Currency)
            .WithMany()
            .HasForeignKey(x => x.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

