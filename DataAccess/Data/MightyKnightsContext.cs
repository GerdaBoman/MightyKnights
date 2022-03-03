
using Microsoft.EntityFrameworkCore;
using DataAccess.Models;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Data
{
    public partial class MightyKnightsContext : DbContext
    {
        public MightyKnightsContext()
        {
        }

        public MightyKnightsContext(DbContextOptions<MightyKnightsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllVehicle> AllVehicles { get; set; } = null!;
        public virtual DbSet<HistoryLogg> HistoryLoggs { get; set; } = null!;
        public virtual DbSet<ParkingLot> ParkingLots { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().AddJsonFile("appSettings.json");
            IConfiguration configuration = configurationBuilder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllVehicle>(entity =>
            {
                entity.HasKey(e => e.VehicleId)
                    .HasName("PK__AllVehic__476B54B2ABF03991");

                entity.Property(e => e.VehicleId)
                    .ValueGeneratedNever()
                    .HasColumnName("VehicleID");

                entity.Property(e => e.LicancePlate).HasMaxLength(50);

                entity.Property(e => e.VechileType).HasMaxLength(50);
            });

            modelBuilder.Entity<HistoryLogg>(entity =>
            {
                entity.HasKey(e => e.VehicleId)
                    .HasName("PK__HistoryL__476B54B25E2FE5C1");

                entity.ToTable("HistoryLogg");

                entity.Property(e => e.VehicleId)
                    .ValueGeneratedNever()
                    .HasColumnName("VehicleID");

                entity.Property(e => e.PaidAmount).HasColumnType("money");

                entity.Property(e => e.ParkingSpotId).HasColumnName("ParkingSpotID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Vehicle)
                    .WithOne(p => p.HistoryLogg)
                    .HasForeignKey<HistoryLogg>(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoryLogg_AllVehicles");
            });

            modelBuilder.Entity<ParkingLot>(entity =>
            {
                entity.HasKey(e => e.ParkingSpotId)
                    .HasName("PK__ParkingL__FE67E7BCB88F2344");

                entity.ToTable("ParkingLot");

                entity.Property(e => e.ParkingSpotId)
                    .ValueGeneratedNever()
                    .HasColumnName("ParkingSpotID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasMany(d => d.Vehicles)
                    .WithMany(p => p.ParkingSpots)
                    .UsingEntity<Dictionary<string, object>>(
                        "ParkedVehicle",
                        l => l.HasOne<AllVehicle>().WithMany().HasForeignKey("VehicleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ParkedVehicles_AllVehicles"),
                        r => r.HasOne<ParkingLot>().WithMany().HasForeignKey("ParkingSpotId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ParkedVehicles_ParkingLot"),
                        j =>
                        {
                            j.HasKey("ParkingSpotId", "VehicleId");

                            j.ToTable("ParkedVehicles");

                            j.IndexerProperty<int>("ParkingSpotId").ValueGeneratedOnAdd().HasColumnName("ParkingSpotID");

                            j.IndexerProperty<int>("VehicleId").HasColumnName("VehicleID");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
