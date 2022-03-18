using DataAccess.Data;

namespace Core
{
    public class ParkingFeeCalculations
    {

        Config config = new();
        //Calculates the total time that vehicle has been parked for
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

        //Calculates how much did the parking cost depending on vehicle type
        public double? TotalAmountToPay(string regNumber)
        {
            config.ReadFromJson();

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
                    return totalAmount = time.TotalHours * config.CarPriceHour;
                }
                else if (vehicle == "MC")
                {
                    return totalAmount = time.TotalHours * config.McPriceHour;
                }
                else
                    return totalAmount = null;
            }
        }
    }

}
