using DataAccess.Data;

namespace Core.UpdateData
{
    public class UpdateVehicleType
    {
        Config config = new();
        // Change the vehicle type of the vehicle and give new sizes value to it
        public void EditVehicleType(string regNumber, string newVehicleType)
        {
            config.ReadFromJson();

            using (var db = new MightyKnightsContext())
            {
                var vehicle = from v in db.Vehicles
                              where v.RegNumber == regNumber
                              select v;

                foreach (var edit in vehicle)
                {
                    edit.VehicleType = newVehicleType;

                    if (newVehicleType == "Car")
                    {
                        edit.Size = config.CarSize;
                    }
                    else if (newVehicleType == "MC")
                    {
                        edit.Size = config.McSize;
                    }

                }
                db.SaveChanges();

            }

        }
    }
}
