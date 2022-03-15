using DataAccess.Data;
using DataAccess.Models;

namespace Core;

public class Car : Vehicle
{
    Config setting = new Config();
        //public Car()
        //{
        //    setting = Config.ReadSettingsFromFile();
        //    base.Size = setting.CarSize;
        //}

    public void AddCar(string licensePlate)
    {
        using (var context = new MightyKnightsContext())
        {
            var car = new Car()
            {
                RegNumber = licensePlate,
                VehicleType = "Car",
                Size = 4
            };
            context.Vehicles.Add(car);
            context.SaveChanges();
        }
    }

    //public void ParkCar(int parkingSpot, string licensePlate)
    //{
    //    using (var context = new MightyKnightsContext())
    //    {
    //        var vehicleId = (from v in context.Vehicles
    //                         where v.LicensePlate == licensePlate
    //                         select v.VehicleId).FirstOrDefault();

    //        ParkingLot parkingCar = new ();

    //        parkingCar.ParkingSpot = parkingSpot;
    //        parkingCar.VehicleId = vehicleId;
    //        parkingCar.CheckInDate = DateTime.Now;

    //        context.ParkingLots.Add(parkingCar);
    //        context.SaveChanges();
    //    }
    //}
}