using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Aml.Shared.Entitties;

namespace Aml.Persistence.EntityTypeConfigurations;

public class StatusConfiguration : IEntityTypeConfiguration<Status>
{
    public void Configure(EntityTypeBuilder<Status> builder)
    {
        // Configure primary key
        builder.HasKey(s => s.StatusId);

        // Configure properties
        builder.Property(s => s.StatusDesc)
            .IsRequired()
            .HasMaxLength(255);  // You can adjust the length of the description as needed

        // Configure relationships with other entities
        builder.HasMany(s => s.AccessRights)
            .WithOne()
            .HasForeignKey(ar => ar.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.AccountTypes)
            .WithOne()
            .HasForeignKey(at => at.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.AccountValues)
            .WithOne()
            .HasForeignKey(av => av.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.AuditTrails)
            .WithOne()
            .HasForeignKey(at => at.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Branches)
            .WithOne()
            .HasForeignKey(b => b.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.ChargeExemptionClients)
            .WithOne()
            .HasForeignKey(cec => cec.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.ClearingCodes)
            .WithOne()
            .HasForeignKey(cc => cc.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.ClearingSessions)
            .WithOne()
            .HasForeignKey(cs => cs.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Currencies)
            .WithOne()
            .HasForeignKey(c => c.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Holidays)
            .WithOne()
            .HasForeignKey(h => h.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.LocationTypes)
            .WithOne()
            .HasForeignKey(lt => lt.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.MakerCheckers)
            .WithOne()
            .HasForeignKey(mc => mc.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Mandates)
            .WithOne()
            .HasForeignKey(m => m.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Menus)
            .WithOne()
            .HasForeignKey(m => m.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Profiles)
            .WithOne()
            .HasForeignKey(p => p.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Regions)
            .WithOne()
            .HasForeignKey(r => r.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.ReturnReasons)
            .WithOne()
            .HasForeignKey(rr => rr.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.SecurityParams)
            .WithOne()
            .HasForeignKey(sp => sp.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.SpsClients)
            .WithOne()
            .HasForeignKey(spc => spc.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.AccountTemp)
            .WithOne()
            .HasForeignKey(at => at.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.SysConfigs)
            .WithOne()
            .HasForeignKey(sc => sc.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.SysParams)
            .WithOne()
            .HasForeignKey(sp => sp.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.TranTypes)
            .WithOne()
            .HasForeignKey(tt => tt.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.UploadParams)
            .WithOne()
            .HasForeignKey(up => up.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Users)
            .WithOne()
            .HasForeignKey(u => u.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.ValueDays)
            .WithOne()
            .HasForeignKey(vd => vd.StatusId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Vouchers)
            .WithOne()
            .HasForeignKey(v => v.StatusId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
