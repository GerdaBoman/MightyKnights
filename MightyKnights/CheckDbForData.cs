using DataAccess.Data;
using System.Text;

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
        public bool CheckIfSpotPartialFull(int parkingSpot)
        {
            using (var db = new MightyKnightsContext())
            {
                var checkIfFull = (from p in db.ParkingLots
                                   join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                   where p.SpotNumber == parkingSpot
                                   select v.Size).ToList();

                if (checkIfFull.Sum() == 2)
                {
                    return true;
                }
                return false;
            }

        }

        public string GetParkingSpotStatus(int selectedSpot)
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
                    List<string> statusList = new List<string>();
                    string status = null;

                    for (int i = 0; i < spotCheck.Count; i++)
                    {
                        status = $"{i + 1}:\nLicence Plate: " + spotCheck[i].LicencePlate + "\nParking Spot: " +
                            spotCheck[i].ParkingSpot + "\nVehicle Type: " + spotCheck[i].VehicleType + "\nCheck In Date: " +
                            spotCheck[i].CheckInDate;

                        statusList.Add(status);

                        
                    }
                   
                    string results = string.Join(Environment.NewLine, statusList);

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

