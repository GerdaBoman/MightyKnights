using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UpdateData
{
    public class UpdateParkingSpot
    {
        public void ChangeParkingSpot(string regNumber, int newParkingSpot)
        {
            using(var db = new MightyKnightsContext())
            {
                var originalParkingSpot = from p in db.ParkingLots
                                          join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                          where v.RegNumber == regNumber
                                          select p;

                foreach(var spot in originalParkingSpot)
                {
                    spot.SpotNumber = newParkingSpot;
                }
                db.SaveChanges();
            }
        }
    }
}
