using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class History
    {
        public int HistoryId { get; set; }
        public string? LicencePlate { get; set; }
        public int? ParkingSpot { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public decimal? TotalCost { get; set; }
    }
}
