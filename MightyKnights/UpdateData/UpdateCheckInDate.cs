using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UpdateData
{
    public class UpdateCheckInDate
    {
        public void UpdateArrivalTime(string regNumber, DateTime newDate)
        {
            using (var db = new MightyKnightsContext())
            {
                var parkingSpot = from p in db.ParkingLots
                                 join v in db.Vehicles on p.VehicleId equals v.VehicleId
                              where v.RegNumber == regNumber
                              select p;

                foreach (var edit in parkingSpot)
                {
                    edit.Arrival = newDate;

                }
                db.SaveChanges();

            }
        }
    }
}
