using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.HomeCalculations
{
    public class CountAllCars
    {
        public int CountCars()
        {
            using(var db = new MightyKnightsContext())
            {

                var count = db.Vehicles.Count(c => c.VehicleType == "Car");
                
                return count;
            }
           
        }
    }
}
