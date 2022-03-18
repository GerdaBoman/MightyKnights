using DataAccess.Data;

namespace Core.UpdateData
{
    public class UpdateCheckInDate
    {
        //Change the arrival date and time of a vehicle
        public void UpdateArrivalTime(string regNumber, DateTime newDate)
        {
            using (var db = new MightyKnightsContext())
            {
                var parkingSpot = from p in db.ParkingLots
                                  join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                  where v.RegNumber == regNumber
                                  select p;

                foreach (var edit in parkingSpot)
                {
                    edit.Arrival = newDate;

                }
                db.SaveChanges();

            }
        }
    }
}
