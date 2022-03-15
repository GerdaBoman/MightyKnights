using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AddHistory
    {
        ParkingFeeCalculations parkingFeeCalculations= new ParkingFeeCalculations();
        public void AddToLogg(string regNumber)
        {
            using(var db = new MightyKnightsContext())
            {
                var vehicleParkingLotInfo = (from v in db.Vehicles
                               join p in db.ParkingLots on v.VehicleId equals p.VehicleId
                               where v.RegNumber == regNumber
                               select p).ToList(); 
                
                var vehicleInfo = (from v in db.Vehicles
                               where v.RegNumber == regNumber
                               select v).ToList();

                double? cost = parkingFeeCalculations.TotalAmountToPay(regNumber);
                string toDecimal = cost.ToString();
                decimal roundedAmount = Math.Round(decimal.Parse(toDecimal), 2);

                History history = new History();
                
                history.LicencePlate = vehicleInfo[0].RegNumber;
                history.ParkingSpot = vehicleParkingLotInfo[0].SpotNumber;
                history.ArrivalDate = vehicleParkingLotInfo[0].Arrival;
                history.DepartureDate = DateTime.Now;
                history.TotalCost = roundedAmount;

                db.Histories.Add(history);
                db.SaveChanges();

            }

        }

    }
}
