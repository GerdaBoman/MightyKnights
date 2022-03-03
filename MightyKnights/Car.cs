

using DataAccess.Data;
using DataAccess.Models;

namespace Core;

public class Car : Vehicle
{
    public void AddCar(string licencePlate)
    {
        using (var context = new MightyKnightsContext())
        {
            var car = new Car()
            {
                LicancePlate = licencePlate,
                VehiclesTypes = "Car",
                UnitSize = 4
            };
            context.Vehicles.Add(car);
        }
    }
}