using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Departure
    {
        public void RemoveVehicle(string licencePlate)
        {
            using (var db = new MightyKnightsContext())
            {
                var vehicleToRemoveParking = (from v in db.Vehicles
                                              join p in db.ParkingLots on v.VehicleId equals p.VehicleId
                                              where v.RegNumber == licencePlate
                                              select p).FirstOrDefault();

                var vehicleToRemoveVehicle = db.Vehicles.FirstOrDefault(v => v.RegNumber == licencePlate);

                if (vehicleToRemoveVehicle != null)
                {
                    db.ParkingLots.Remove(vehicleToRemoveParking);
                    db.Vehicles.Remove(vehicleToRemoveVehicle);
                    


                    db.SaveChanges();
                }
            }
        }
    }
}

