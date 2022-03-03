using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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

        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;
        public virtual DbSet<ParkingLot> ParkingLots { get; set; } = null!;
        public virtual DbSet<PreviousRecord> PreviousRecords { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().AddJsonFile("appSettings.json");
            IConfiguration configuration = configurationBuilder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.VehicleId)
                    .HasName("PK__Cars__476B54B23E5A1EFE");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.LicancePlate).HasMaxLength(50);

                entity.Property(e => e.VehiclesTypes).HasMaxLength(10);
            });

            modelBuilder.Entity<ParkingLot>(entity =>
            {
                entity.HasKey(e => e.ParkingSpotId)
                    .HasName("PK__ParkingG__FE67E7BC4B05C4B3");

                entity.ToTable("ParkingGarage");

                entity.Property(e => e.ParkingSpotId)
                    .ValueGeneratedNever()
                    .HasColumnName("ParkingSpotID");

                entity.Property(e => e.VehicleId)
                    .HasColumnName("VehicleID");

                entity.HasMany(d => d.Vehicles)
                    .WithMany(p => p.ParkingSpots)
                    .UsingEntity<Dictionary<string, object>>(
                        "ParkedVehicle",
                        l => l.HasOne<Vehicle>().WithMany().HasForeignKey("VehicleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ParkedVehicle_Cars"),
                        r => r.HasOne<ParkingLot>().WithMany().HasForeignKey("ParkingSpotId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ParkedVehicle_ParkingGarage"),
                        j =>
                        {
                            j.HasKey("ParkingSpotId", "VehicleId").HasName("PK__ParkedVe__FE67E7BC8A300490");

                            j.ToTable("ParkedVehicle");

                            j.IndexerProperty<int>("ParkingSpotId").ValueGeneratedOnAdd().HasColumnName("ParkingSpotID");

                            j.IndexerProperty<int>("VehicleId").HasColumnName("VehicleID");
                        });
            });

            modelBuilder.Entity<PreviousRecord>(entity =>
            {
                entity.HasKey(e => e.VehicleId)
                    .HasName("PK__Previous__476B54B274DB8A49");

                entity.Property(e => e.VehicleId)
                    .ValueGeneratedNever()
                    .HasColumnName("VehicleID");

                entity.Property(e => e.PaidAmount).HasColumnType("money");

                entity.Property(e => e.ParkingSpotId).HasColumnName("ParkingSpotID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Vehicle)
                    .WithOne(p => p.PreviousRecord)
                    .HasForeignKey<PreviousRecord>(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PreviousRecords_Cars");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
