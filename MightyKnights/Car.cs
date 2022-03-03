

using DataAccess.Data;
using DataAccess.Models;

namespace Core;

public class Car : Vehicle
{
    public void AddCar(string licencePlate)
    {
        using (var context = new MightyKnightsContext())
        {
            var car = new Car()
            {
                LicancePlate = licencePlate,
                VehiclesTypes = "Car",
                UnitSize = 4
            };
            context.Vehicles.Add(car);
            context.SaveChanges();
        }
    }

    public void ParkCar(int parkingSpot, string licancePlate)
    {
        using(var context = new MightyKnightsContext())
        {
            var vehicleId = (from v in context.Vehicles
                             where v.LicancePlate == licancePlate
                             select v.VehicleId).FirstOrDefault();

            ParkingLot parkingCar = new ParkingLot();

            parkingCar.ParkingSpotId = parkingSpot;
            parkingCar.VehicleId = vehicleId;
            parkingCar.CheckInDate = DateTime.Now;

            context.ParkingLots.Add(parkingCar);
            context.SaveChanges();
        }
    }
}