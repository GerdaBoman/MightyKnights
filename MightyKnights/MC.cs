using DataAccess.Data;
using DataAccess.Models;

namespace Core;

public class Mc : Vehicle
{   
    Config setting = new Config();
        public MC()
        {
            setting = Config.ReadSettingsFromFile();
            base.Size = setting.McSize;
        }

    public void AddMc(string licensePlate)
    {
        using (var context = new MightyKnightsContext())
        {
            var mc = new Mc()
            {
                RegNumber = licensePlate,
                VehicleType = "MC",
                Size = 2
            };
            context.Vehicles.Add(mc);
            context.SaveChanges();
        }
    }

    //public void ParkMc(int parkingSpot, string licensePlate)
    //{
    //    using (var context = new MightyKnightsContext())
    //    {
    //        var vehicleId = (from v in context.Vehicles
    //                         where v.LicensePlate == licensePlate
    //                         select v.VehicleId).FirstOrDefault();

    //        ParkingLot parkingMc = new ParkingLot();

    //        parkingMc.ParkingSpot = parkingSpot;
    //        parkingMc.VehicleId = vehicleId;
    //        parkingMc.CheckInDate = DateTime.Now;

    //        context.ParkingLots.Add(parkingMc);
    //        context.SaveChanges();
    //    }
    //}
}