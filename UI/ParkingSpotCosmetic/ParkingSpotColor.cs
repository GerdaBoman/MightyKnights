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
                                   where p.SpotNumber == parkingSpot
                                   select v.Size).ToArray();

                int total = 0; 

                for(int i = 0; i < checkIfFull.Length; i++)
                {
                    int value = checkIfFull[i];
                    total += value;
                    
                }

                if (total == 4)
                {
                    buttonStatus.BackColor = Color.Red;
                }
                else if (total == 2)
                {
                    buttonStatus.BackColor = Color.Orange;
                }
                else
                {
                    buttonStatus.BackColor = Color.FromArgb(89,165,216);
                }

            }



        }
    }
}
