﻿using DataAccess.Models;

namespace DataAccess.Data.Datafiles
{
    public class InsertTestData
    {
        //Test data to be able to test the program
        public void TestData()
        {
            using var db = new MightyKnightsContext();

            db.Vehicles.Add(new Vehicle { RegNumber = "ABC123", VehicleType = "Car", Size = 4 });
            db.Vehicles.Add(new Vehicle { RegNumber = "BDL2010", VehicleType = "MC", Size = 2 });
            db.Vehicles.Add(new Vehicle { RegNumber = "4TDR9873", VehicleType = "Car", Size = 4 });
            db.Vehicles.Add(new Vehicle { RegNumber = "7AMF124", VehicleType = "MC", Size = 2 });
            db.Vehicles.Add(new Vehicle { RegNumber = "POPPY123", VehicleType = "Car", Size = 4 });
            db.Vehicles.Add(new Vehicle { RegNumber = "SOFIE103", VehicleType = "MC", Size = 2 });
            db.Vehicles.Add(new Vehicle { RegNumber = "JONAS002", VehicleType = "Car", Size = 4 });
            db.Vehicles.Add(new Vehicle { RegNumber = "CLAES101", VehicleType = "MC", Size = 2 });
            db.Vehicles.Add(new Vehicle { RegNumber = "JONATHAN", VehicleType = "Car", Size = 4 });
            db.Vehicles.Add(new Vehicle { RegNumber = "SAMAR124", VehicleType = "MC", Size = 2 });
            db.Vehicles.Add(new Vehicle { RegNumber = "PATRIK65", VehicleType = "Car", Size = 4 });
            db.Vehicles.Add(new Vehicle { RegNumber = "HELEN34", VehicleType = "MC", Size = 2 });
            db.Vehicles.Add(new Vehicle { RegNumber = "GERDA104", VehicleType = "Car", Size = 4 });
            db.Vehicles.Add(new Vehicle { RegNumber = "SAMUEL23", VehicleType = "MC", Size = 2 });
            db.Vehicles.Add(new Vehicle { RegNumber = "VICTOR126", VehicleType = "Car", Size = 4 });
            db.Vehicles.Add(new Vehicle { RegNumber = "BOB332", VehicleType = "MC", Size = 2 });
            db.Vehicles.Add(new Vehicle { RegNumber = "EL32LIE", VehicleType = "MC", Size = 2 });
            db.Vehicles.Add(new Vehicle { RegNumber = "ANDERS643", VehicleType = "Car", Size = 4 });
            db.Vehicles.Add(new Vehicle { RegNumber = "YOLO123", VehicleType = "MC", Size = 2 });
            db.Vehicles.Add(new Vehicle { RegNumber = "BOO126", VehicleType = "Car", Size = 4 });
            db.Vehicles.Add(new Vehicle { RegNumber = "COFI356", VehicleType = "MC", Size = 2 });

            db.SaveChanges();


            db.ParkingLots.Add(new ParkingLot { VehicleId = 1, SpotNumber = 4, Arrival = DateTime.Parse("2022/03/12 15:41:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 2, SpotNumber = 23, Arrival = DateTime.Parse("2022/03/12 17:22:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 3, SpotNumber = 66, Arrival = DateTime.Parse("2022/03/14 18:55:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 4, SpotNumber = 88, Arrival = DateTime.Parse("2022/03/12 20:32:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 5, SpotNumber = 11, Arrival = DateTime.Parse("2022/03/10 01:53:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 6, SpotNumber = 76, Arrival = DateTime.Parse("2022/03/20 12:21:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 7, SpotNumber = 32, Arrival = DateTime.Parse("2022/03/11 14:41:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 8, SpotNumber = 76, Arrival = DateTime.Parse("2022/03/12 16:53:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 9, SpotNumber = 21, Arrival = DateTime.Parse("2022/03/15 16:21:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 10, SpotNumber = 98, Arrival = DateTime.Parse("2022/03/13 12:12:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 11, SpotNumber = 1, Arrival = DateTime.Parse("2022/03/14 05:00:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 12, SpotNumber = 98, Arrival = DateTime.Parse("2022/03/12 02:12:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 13, SpotNumber = 34, Arrival = DateTime.Parse("2022/03/11 03:12:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 14, SpotNumber = 25, Arrival = DateTime.Parse("2022/03/01 12:23:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 15, SpotNumber = 56, Arrival = DateTime.Parse("2022/03/04 01:53:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 16, SpotNumber = 30, Arrival = DateTime.Parse("2022/03/12 12:12:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 17, SpotNumber = 30, Arrival = DateTime.Parse("2022/02/21 14:14:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 18, SpotNumber = 10, Arrival = DateTime.Parse("2022/03/11 15:13:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 19, SpotNumber = 28, Arrival = DateTime.Parse("2022/03/13 16:21:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 20, SpotNumber = 35, Arrival = DateTime.Parse("2022/03/14 18:42:22"), Departure = null });
            db.ParkingLots.Add(new ParkingLot { VehicleId = 21, SpotNumber = 15, Arrival = DateTime.Parse("2022/03/11 14:23:22"), Departure = null });

            db.SaveChanges();

            db.Histories.Add(new History { LicencePlate = "GREWS123", ParkingSpot = 23, ArrivalDate = DateTime.Parse("2022/02/12 12:43:31"), DepartureDate = DateTime.Parse("2022/03/11 14:23:22"), TotalCost = 25353.23m });
            db.Histories.Add(new History { LicencePlate = "233FSFG", ParkingSpot = 12, ArrivalDate = DateTime.Parse("2022/03/15 13:41:15"), DepartureDate = DateTime.Parse("2022/03/15 12:43:12"), TotalCost = 42.54m });
            db.Histories.Add(new History { LicencePlate = "GEORGE123", ParkingSpot = 43, ArrivalDate = DateTime.Parse("2022/03/15 15:33:31"), DepartureDate = DateTime.Parse("2022/03/15 18:23:22"), TotalCost = 80.43m });
            db.Histories.Add(new History { LicencePlate = "XDE234", ParkingSpot = 16, ArrivalDate = DateTime.Parse("2022/03/12 13:13:31"), DepartureDate = DateTime.Parse("2022/03/13 08:23:12"), TotalCost = 1780.32m });
            db.Histories.Add(new History { LicencePlate = "123DWE", ParkingSpot = 75, ArrivalDate = DateTime.Parse("2022/03/14 12:54:12"), DepartureDate = DateTime.Parse("2022/03/14 14:23:22"), TotalCost = 32.54m });
            db.Histories.Add(new History { LicencePlate = "53FDEX", ParkingSpot = 31, ArrivalDate = DateTime.Parse("2022/03/11 09:15:42"), DepartureDate = DateTime.Parse("2022/03/11 11:22:23"), TotalCost = 35.43m });

            db.SaveChanges();
        }
    }
}
