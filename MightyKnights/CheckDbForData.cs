using DataAccess.Data;

namespace Core
{
    public class CheckDbForData
    {
        public static bool DataExist()
        {
            using (var db = new MightyKnightsContext())
            {
                if (!db.ParkingLots.Any())
                {
                    return false;
                }
                return true;
            }
        }

        public bool CheckIfVehicleExist(string licancePlate)
        {
            using (var db = new MightyKnightsContext())
            {
                var checkIfPresent = (from v in db.Vehicles
                                      where v.LicensePlate == licancePlate
                                      select v).ToList();
                if (checkIfPresent.Any())
                {
                    return true;
                }
                return false;
            }
        }

        public bool CheckIfSpotFull(int parkingSpot)
        {
            using (var db = new MightyKnightsContext())
            {
                var checkIfFull = (from p in db.ParkingLots
                                   join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                   where p.ParkingSpot == parkingSpot
                                   select v.UnitSize).ToList();

                if (checkIfFull.Sum() == 4)
                {
                    return true;
                }
                return false;
            }

        }

        public string CheckParkingSpotStatus(int selectedSpot)
        {
            using (var db = new MightyKnightsContext())
            {
                var spotCheck = (from p in db.ParkingLots
                                 join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                 where p.ParkingSpot == selectedSpot
                                 select new
                                 {
                                     ParkingSpot = p.ParkingSpot,
                                     LicancePlate = v.LicensePlate,
                                     VehicleType = v.VehicleType,
                                     CheckInDate = p.CheckInDate
                                 }).ToList();


                if (spotCheck.Count > 0)
                {
                    string results = string.Join(Environment.NewLine, spotCheck);
                    return results;

                }
                else
                {
                    return "Parking spot is empty!";
                }
            }
        }
    }
}

