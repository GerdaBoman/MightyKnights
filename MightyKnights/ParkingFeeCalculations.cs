using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ParkingFeeCalculations
    {
        public TimeSpan TotalTimeParked(string regNumber)
        {
            DateTime checkOutDay = DateTime.Now;

            using (var db = new MightyKnightsContext())
            {
                var vehicle = (from v in db.Vehicles
                               join p in db.ParkingLots on v.VehicleId equals p.VehicleId
                               where v.RegNumber == regNumber
                               select p.Arrival).FirstOrDefault();

                var payableParkingTime = checkOutDay.AddMinutes(-10);

                var duration = payableParkingTime - vehicle;

                return duration;

            }
        }

        public double? TotalAmountToPay(string regNumber)
        {
            double? totalAmount;
            TimeSpan time = TotalTimeParked(regNumber);
            using (var db = new MightyKnightsContext())
            {
                var vehicle = (from v in db.Vehicles
                               join p in db.ParkingLots on v.VehicleId equals p.VehicleId
                               where v.RegNumber == regNumber
                               select v.VehicleType).FirstOrDefault();

                if (vehicle == "Car")
                {
                    return totalAmount = time.TotalHours * 20;
                }
                else if (vehicle == "Mc")
                {
                    return totalAmount = time.TotalHours * 10;
                }
                else
                    return totalAmount = null;
            }
        }
    }

}
