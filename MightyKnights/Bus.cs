using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Bus:Vehicle 
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
