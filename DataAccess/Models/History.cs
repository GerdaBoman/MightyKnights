using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class History
    {
        public int HistoryId { get; set; }
        public string RegNumber { get; set; } = null!;
        public int ParkingLotId { get; set; }
        public decimal Cost { get; set; }

        public virtual ParkingLot ParkingLot { get; set; } = null!;
    }
}
