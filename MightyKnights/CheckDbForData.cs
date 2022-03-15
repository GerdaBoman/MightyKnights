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
                                      where v.RegNumber == licancePlate
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
                                   where p.SpotNumber == parkingSpot
                                   select v.Size).ToList();

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
                                 where p.SpotNumber == selectedSpot
                                 select new
                                 {
                                     ParkingSpot = p.SpotNumber,
                                     LicencePlate = v.RegNumber,
                                     VehicleType = v.VehicleType,
                                     CheckInDate = p.Arrival
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

        public string GetVehicleType(string regNumber)
        {
            using (var db = new MightyKnightsContext())
            {
                var vehicleType = (from v in db.Vehicles
                                   where v.RegNumber == regNumber
                                   select v.VehicleType).FirstOrDefault();
                if (vehicleType != null)
                {
                    return vehicleType;
                }
                else
                    return "";
            }
        }

        public int GetParkingSpot(string regNumber)
        {
            using (var db = new MightyKnightsContext())
            {
                var parkingSpot = (from v in db.Vehicles
                                   join p in db.ParkingLots on v.VehicleId equals p.VehicleId
                                   where v.RegNumber == regNumber
                                   select p.SpotNumber).FirstOrDefault();
                if (parkingSpot != null)
                {
                    return parkingSpot;
                }
                else
                    return 0;
            }
        }

        public DateTime? GetArrivalTime(string regNumber)
        {
            using (var db = new MightyKnightsContext())
            {
                var arrivalTime = (from v in db.Vehicles
                                   join p in db.ParkingLots on v.VehicleId equals p.VehicleId
                                   where v.RegNumber == regNumber
                                   select p.Arrival).FirstOrDefault();

                if (arrivalTime != null)
                {
                    return arrivalTime;
                }
                else
                    return null;
            }
        }
    }
}

