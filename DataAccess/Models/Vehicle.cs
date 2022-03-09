using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            ParkingSpots = new HashSet<ParkingLot>();
        }

        public int VehicleId { get; set; }
        public string? LicancePlate { get; set; }
        public string? VehicleType { get; set; }
        public int? UnitSize { get; set; }

        public virtual HistoryLog HistoryLog { get; set; } = null!;

        public virtual ICollection<ParkingLot> ParkingSpots { get; set; }
    }
}




/*

    konstruktor i Car,Mc 
    this.carsize = Config.CarSize;

*/