using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.HomeCalculations
{
    public class CountAllMC
    {
        public int CountMc()
        {
            using (var db = new MightyKnightsContext())
            {

                var count = db.Vehicles.Count(c => c.VehicleType == "MC");

                return count;
            }

        }
    }
}
