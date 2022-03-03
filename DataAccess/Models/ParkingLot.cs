using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ParkingLot
    {
        public ParkingLot()
        {
            Vehicles = new HashSet<AllVehicle>();
        }

        public int ParkingSpotId { get; set; }
        public int VehicleId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }

        public virtual ICollection<AllVehicle> Vehicles { get; set; }
    }
}
