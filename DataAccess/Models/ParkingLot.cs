using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ParkingLot
    {
        public ParkingLot()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public int ParkingSpotId { get; set; }
        public string VehicleId { get; set; } = null!;
        public DateTime CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
