using DataAccess.Data;

namespace Core.HistoryMethods
{
    public class DataBetweenDates
    {
        //Counts how many vehicles has been parked between start and end date
        public int AmoutVehicles(DateTime fromDate, DateTime toDate)
        {
            TimeSpan range = toDate - fromDate;

            using (var db = new MightyKnightsContext())
            {
                var vehicles = (from h in db.Histories
                                where h.ArrivalDate >= fromDate &&
                                h.DepartureDate <= toDate
                                select h.LicencePlate).Count();

                int vehicleCount = vehicles;

                return vehicleCount;
            }

        }

        //Counts the total of the vehicles that been parked between two dates
        public decimal? TotalEarned(DateTime fromDate, DateTime toDate)
        {
            using (var db = new MightyKnightsContext())
            {
                var moneyEarned = (from h in db.Histories
                                   where h.ArrivalDate >= fromDate &&
                                   h.DepartureDate <= toDate
                                   select h.TotalCost).Sum().ToString();


                decimal totalEarned = Math.Round(Convert.ToDecimal(moneyEarned), 2);

                return totalEarned;

            }

        }
    }
}
