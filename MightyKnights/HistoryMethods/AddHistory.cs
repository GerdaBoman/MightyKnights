﻿using DataAccess.Data;
using DataAccess.Models;


namespace Core.HistoryMethods
{
    public class AddHistory
    {
        ParkingFeeCalculations parkingFeeCalculations = new();

        //Adds all the information of the vehicle to the history table
        public void AddToLogg(string regNumber)
        {
            using (var db = new MightyKnightsContext())
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

                History history = new();

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
