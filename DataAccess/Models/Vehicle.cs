namespace DataAccess.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            ParkingLots = new HashSet<ParkingLot>();
        }

        public int VehicleId { get; set; }
        public string RegNumber { get; set; } = null!;
        public string VehicleType { get; set; } = null!;
        public int Size { get; set; }

        public virtual ICollection<ParkingLot> ParkingLots { get; set; }
    }
}
