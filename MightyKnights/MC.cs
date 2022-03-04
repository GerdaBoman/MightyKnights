using DataAccess.Data;
using DataAccess.Models;

namespace Core;

public class Mc : Vehicle
{
    public void AddMc(string licencePlate)
    {
        using (var context = new MightyKnightsContext())
        {
            var mc = new Mc()
            {
                LicancePlate = licencePlate,
                VehiclesTypes = "MC",
                UnitSize = 2
            };
            context.Vehicles.Add(mc);
            context.SaveChanges();
        }
    }

    public void ParkMc(int parkingSpot, string licancePlate)
    {
        using (var context = new MightyKnightsContext())
        {
            var vehicleId = (from v in context.Vehicles
                             where v.LicancePlate == licancePlate
                             select v.VehicleId).FirstOrDefault();

            ParkingLot parkingMc = new ParkingLot();

            parkingMc.ParkingSpotId = parkingSpot;
            parkingMc.VehicleId = vehicleId;
            parkingMc.CheckInDate = DateTime.Now;

            context.ParkingLots.Add(parkingMc);
            context.SaveChanges();
        }
    }
}