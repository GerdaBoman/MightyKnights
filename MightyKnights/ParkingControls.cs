using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ParkingControls
    {
        public void ParkVehicle(int parkingSpot, string regNumber)
        {
            using (var context = new MightyKnightsContext())
            {
                var vehicleId = (from v in context.Vehicles
                                 where v.RegNumber == regNumber
                                 select v.VehicleId).FirstOrDefault();

                ParkingLot parking = new();

                parking.SpotNumber = parkingSpot;
                parking.VehicleId = vehicleId;
                parking.Arrival = DateTime.Now;

                context.ParkingLots.Add(parking);
                context.SaveChanges();
            }
        }
    }
}
