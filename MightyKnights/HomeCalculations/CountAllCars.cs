using DataAccess.Data;

namespace Core.HomeCalculations
{
    public class CountAllCars
    {
        public int CountCars()
        {
            using (var db = new MightyKnightsContext())
            {

                var count = db.Vehicles.Count(c => c.VehicleType == "Car");

                return count;
            }

        }
    }
}
