using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ParkingSpotStatus
    {
        public int CarSize(string licancePlate)
        {
            using (var db = new MightyKnightsContext())
            {
                var unitSize = (from v in db.Vehicles
                                where v.LicancePlate == licancePlate
                                select v.UnitSize).SingleOrDefault();

                return (int)unitSize;

            }
        }  
        
        public int MCSize(string licancePlate)
        {
            using (var db = new MightyKnightsContext())
            {
                var unitSize = (from v in db.Vehicles
                                where v.LicancePlate == licancePlate
                                select v.UnitSize).SingleOrDefault();

                return (int)unitSize;

            }
        }

        public bool CheckSpaceForMC(int? currentStatus)
        {
            if(currentStatus == null && currentStatus  == 2)
            {
                return true;
            }

            return false;

        }
    }
}
