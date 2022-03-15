using DataAccess.Data;
using DataAccess.Models;

namespace Core
{
    public class Bike : Vehicle
    {
        Config setting = new Config();

        public void AddBike(string licensePlate)
        {
            using (var context = new MightyKnightsContext())
            {
                var bike = new Bike()
                {
                    RegNumber = licensePlate,
                    VehicleType = "Bike",
                    Size = 1
                };
                context.Vehicles.Add(bike);
                context.SaveChanges();
            }
        }
    }
}
