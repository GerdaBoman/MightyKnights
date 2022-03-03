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
        public string LicancePlate { get; set; } = null!;
        public string VehicleType { get; set; } = null!;
        public int UnitSize { get; set; }

        public virtual HistoryLogg HistoryLogg { get; set; } = null!;

        public virtual ICollection<ParkingLot> ParkingSpots { get; set; }
    }
}
