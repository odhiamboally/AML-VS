using Aml.Channels.IB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aml.Channels.IB.Persistence.EntityConfigurations;

public class RuleEntityTypeConfiguration : IEntityTypeConfiguration<IBRule>
{
    public void Configure(EntityTypeBuilder<IBRule> builder)
    {
        builder
            .Property(e => e.Description)
            .IsRequired();

        
    }
}
