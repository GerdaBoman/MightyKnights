using DataAccess.Data;
using DataAccess.Models;

namespace Core;

public class Mc : Vehicle
{
    public void AddMc(string licencePlate)
    {
        using (var context = new MightyKnightsContext())
        {
            var mc = new Mc()
            {
                LicancePlate = licencePlate,
                VehiclesTypes = "MC",
                UnitSize = 2
            };
            context.Vehicles.Add(mc);
        }
    }
}