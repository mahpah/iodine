using Iodine.Abstract.Devices;
using Iodine.Infrastructure.Setup;
using Microsoft.EntityFrameworkCore;

namespace Iodine.Infrastructure.Data
{
    public class IodineDbContext : DbContext
    {
        public IodineDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeviceBase>()
                .Property(t => t.LastUpdated)
                .ValueGeneratedOnAddOrUpdate();

            modelBuilder.Entity<DeviceBase>()
                .Property(t => t.CreatedAt)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<DeviceBase>().HasDiscriminator(t => t.Type)
                .HasValue<AlarmBell>(nameof(AlarmBell).ToLowerInvariant())
                .HasValue<DirectionLight>(nameof(DirectionLight).ToLowerInvariant())
                .HasValue<Gateway>(nameof(Gateway).ToLowerInvariant())
                .HasValue<PrimaryAlarmBell>(nameof(PrimaryAlarmBell).ToLowerInvariant())
                .HasValue<SmokeDetector>(nameof(SmokeDetector).ToLowerInvariant())
                .HasValue<Station>(nameof(Station).ToLowerInvariant())
                .HasValue<Sprinkler>(nameof(Sprinkler).ToLowerInvariant());

            modelBuilder.Entity<ConnectedDevice>()
                .HasOne(t => t.Gateway)
                .WithMany()
                .HasForeignKey(t => t.GatewayId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Gateway>().HasData(SeedData.Gateways);
            modelBuilder.Entity<ConnectedDevice>().HasData(SeedData.ConnectedDevices);
        }
    }
}
