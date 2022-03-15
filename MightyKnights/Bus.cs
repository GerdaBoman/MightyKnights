using DataAccess.Data;
using DataAccess.Models;

namespace Core
{
    public class Bus : Vehicle
    {
        Config setting = new Config();

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
