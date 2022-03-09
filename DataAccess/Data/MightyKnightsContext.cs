using System;
using System.Collections.Generic;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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

        public virtual DbSet<History> Histories { get; set; } = null!;
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
            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("History");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.ParkingLotId).HasColumnName("ParkingLotID");

                entity.Property(e => e.RegNumber).HasMaxLength(10);

                entity.HasOne(d => d.ParkingLot)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.ParkingLotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_History_ParkingLot");
            });

            modelBuilder.Entity<ParkingLot>(entity =>
            {
                entity.ToTable("ParkingLot");

                entity.Property(e => e.ParkingLotId).HasColumnName("ParkingLotID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.ParkingLots)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParkingLot_Vehicles");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.RegNumber).HasMaxLength(10);

                entity.Property(e => e.VehicleType).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
