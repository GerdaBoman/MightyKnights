using DataAccess.Data;

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
