using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class HistoryLogg
    {
        public int VehicleId { get; set; }
        public int? ParkingSpotId { get; set; }
        public DateTime? TimeParked { get; set; }
        public decimal? Price { get; set; }
        public decimal? PaidAmount { get; set; }

        public virtual Vehicle Vehicle { get; set; } = null!;
    }
}
