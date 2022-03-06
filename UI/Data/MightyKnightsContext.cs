using System;
using System.Collections.Generic;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace UI.Data
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

        public virtual DbSet<HistoryLog> HistoryLogs { get; set; } = null!;
        public virtual DbSet<ParkingLot> ParkingLots { get; set; } = null!;
        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().AddJsonFile("appSettings.json");
                IConfiguration configuration = configurationBuilder.Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HistoryLog>(entity =>
            {
                entity.HasKey(e => e.VehicleId)
                    .HasName("PK__HistoryL__476B54B22CEA2862");

                entity.ToTable("HistoryLog");

                entity.Property(e => e.VehicleId)
                    .ValueGeneratedNever()
                    .HasColumnName("VehicleID");

                entity.Property(e => e.PaidAmount).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Vehicle)
                    .WithOne(p => p.HistoryLog)
                    .HasForeignKey<HistoryLog>(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoryLog_Vehicles");
            });

            modelBuilder.Entity<ParkingLot>(entity =>
            {
                entity.HasKey(e => e.ParkingSpotId)
                    .HasName("PK__ParkingL__FE67E7DC28B13562");

                entity.ToTable("ParkingLot");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.LicancePlate).HasMaxLength(50);

                entity.Property(e => e.VehicleType).HasMaxLength(10);

                entity.HasMany(d => d.ParkingSpots)
                    .WithMany(p => p.Vehicles)
                    .UsingEntity<Dictionary<string, object>>(
                        "Parkedvehicle",
                        l => l.HasOne<ParkingLot>().WithMany().HasForeignKey("ParkingSpotId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Parkedvehicles_ParkingLot"),
                        r => r.HasOne<Vehicle>().WithMany().HasForeignKey("VehicleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Parkedvehicles_Vehicles"),
                        j =>
                        {
                            j.HasKey("VehicleId", "ParkingSpotId").HasName("PK__Parkedve__476B54B2109F3F07");

                            j.ToTable("Parkedvehicles");

                            j.IndexerProperty<int>("VehicleId").HasColumnName("VehicleID");

                            j.IndexerProperty<int>("ParkingSpotId").HasColumnName("ParkingSpotID");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
