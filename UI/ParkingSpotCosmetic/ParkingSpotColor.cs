using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ParkingSpotCosmetic
{
    public class ParkingSpotColor
    {
        public void SpotsStatus(int parkingSpot, Button buttonStatus)
        {
           
           using (var db = new MightyKnightsContext())
           {
             var checkIfFull = (from p in db.ParkingLots
                                 join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                 where p.ParkingSpotId == parkingSpot
                                 select v.UnitSize).ToList();
                int total = checkIfFull.Sum(x => Convert.ToInt32(x));

                if (total == 4)
               {
                    buttonStatus.BackColor = Color.Red;    
               }
               else if (total == 2)
                {
                    buttonStatus.BackColor = Color.Orange;
                }
                    
          }

            

        }
    }
}
