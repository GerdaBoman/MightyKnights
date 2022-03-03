using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class CheckDbForData
    {
        public static bool DataExist()
        {
            using (MightyKnightsContext db=new MightyKnightsContext())
            {
                if(!db.ParkingLots.Any())
                {
                    return false; 
                }
                return true;
            }
        }
    }
}
