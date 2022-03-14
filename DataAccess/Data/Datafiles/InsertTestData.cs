using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Datafiles
{
    public class InsertTestData
    {
        public void TestData()
        {
            using(var db = new MightyKnightsContext())
            {
                List<Vehicle> vehicles = new List<Vehicle>();
                db.Vehicles.Add(new Vehicle { RegNumber="abc123", VehicleType="Car", Size=4 });
                db.Vehicles.Add(new Vehicle { RegNumber= "bdl2010", VehicleType="MC", Size=2 });
                db.Vehicles.Add(new Vehicle { RegNumber= "4tdr9873", VehicleType="Car", Size=4 });
                db.Vehicles.Add(new Vehicle { RegNumber= "7amf124", VehicleType= "MC", Size=2 });
                db.Vehicles.Add(new Vehicle { RegNumber="poppy123", VehicleType="Car", Size=4 });
                db.Vehicles.Add(new Vehicle { RegNumber="sofie103", VehicleType= "MC", Size=2 });
                db.Vehicles.Add(new Vehicle { RegNumber="jonas002", VehicleType="Car", Size=4 });
                db.Vehicles.Add(new Vehicle { RegNumber="cleas101", VehicleType= "MC", Size=2 });
                db.Vehicles.Add(new Vehicle { RegNumber="jonathan", VehicleType="Car", Size=4 });
                db.Vehicles.Add(new Vehicle { RegNumber="samar124", VehicleType= "MC", Size=2 });
                db.Vehicles.Add(new Vehicle { RegNumber="patrik65", VehicleType="Car", Size=4 });
                db.Vehicles.Add(new Vehicle { RegNumber="helen34", VehicleType= "MC", Size=2 });
                db.Vehicles.Add(new Vehicle { RegNumber="gerda104", VehicleType="Car", Size=4 });
                db.Vehicles.Add(new Vehicle { RegNumber="samuel23", VehicleType= "MC", Size=2 });
                db.Vehicles.Add(new Vehicle { RegNumber="victor126", VehicleType="Car", Size=4 });
                db.Vehicles.Add(new Vehicle { RegNumber="bob332", VehicleType= "MC", Size=2 });
                db.Vehicles.Add(new Vehicle { RegNumber="el32lie", VehicleType= "MC", Size=2 });
                db.Vehicles.Add(new Vehicle { RegNumber="anders643", VehicleType="Car", Size=4 });
                db.Vehicles.Add(new Vehicle { RegNumber="yolo123", VehicleType= "MC", Size=2 });
                db.Vehicles.Add(new Vehicle { RegNumber="boo126", VehicleType="Car", Size=4 });
                db.Vehicles.Add(new Vehicle { RegNumber="cofi356", VehicleType= "MC", Size=2 });

                db.SaveChanges();

                List<ParkingLot> parkingLots = new List<ParkingLot>();
                db.ParkingLots.Add(new ParkingLot { VehicleId=1,  SpotNumber= 4, Arrival= DateTime.Parse("2022/03/12 15:41:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=2,  SpotNumber= 23, Arrival= DateTime.Parse("2022/03/12 17:22:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=3,  SpotNumber= 66, Arrival= DateTime.Parse("2022/03/14 18:55:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=4,  SpotNumber= 4, Arrival= DateTime.Parse("2022/03/12 20:32:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=5,  SpotNumber= 11, Arrival= DateTime.Parse("2022/03/10 01:53:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=6,  SpotNumber= 76, Arrival= DateTime.Parse("2022/03/20 12:21:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=7,  SpotNumber= 32, Arrival= DateTime.Parse("2022/03/11 14:41:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=8,  SpotNumber= 76, Arrival= DateTime.Parse("2022/03/12 16:53:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=9,  SpotNumber= 21, Arrival= DateTime.Parse("2022/03/15 16:21:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=10, SpotNumber= 98, Arrival= DateTime.Parse("2022/03/13 12:12:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=11, SpotNumber= 1, Arrival= DateTime.Parse("2022/03/14 05:00:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=12, SpotNumber= 98, Arrival= DateTime.Parse("2022/03/12 02:12:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=13, SpotNumber= 34, Arrival= DateTime.Parse("2022/03/11 03:12:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=14, SpotNumber= 21, Arrival= DateTime.Parse("2022/03/01 12:23:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=15, SpotNumber= 56, Arrival= DateTime.Parse("2022/03/04 01:53:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=16, SpotNumber= 85, Arrival= DateTime.Parse("2022/03/12 12:12:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=17, SpotNumber= 21, Arrival= DateTime.Parse("2022/02/21 14:14:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=18, SpotNumber= 10, Arrival= DateTime.Parse("2022/03/11 15:13:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=19, SpotNumber= 28, Arrival= DateTime.Parse("2022/03/13 16:21:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=20, SpotNumber= 30, Arrival= DateTime.Parse("2022/03/14 18:42:22"), Departure = null });
                db.ParkingLots.Add(new ParkingLot { VehicleId=21, SpotNumber= 15, Arrival= DateTime.Parse("2022/03/11 14:23:22"), Departure = null });

                db.SaveChanges();
            }
        }
    }
}
