using DataAccess.Data;
using DataAccess.Models;

namespace Core.Vehicles
{
    public class Bus : Vehicle
    {
        Config setting = new();

        public void AddBus(string licensePlate)
        {
            using (var context = new MightyKnightsContext())
            {
                var bus = new Bus()
                {
                    RegNumber = licensePlate,
                    VehicleType = "Bus",
                    Size = 16
                };
                context.Vehicles.Add(bus);
                context.SaveChanges();
            }
        }
    }
}
