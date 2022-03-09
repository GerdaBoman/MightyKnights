using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class ParkingLot
    {
        public ParkingLot()
        {
            Histories = new HashSet<History>();
        }

        public int ParkingLotId { get; set; }
        public int SpotNumber { get; set; }
        public int VehicleId { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime? Departure { get; set; }

        public virtual Vehicle Vehicle { get; set; } = null!;
        public virtual ICollection<History> Histories { get; set; }
    }
}
