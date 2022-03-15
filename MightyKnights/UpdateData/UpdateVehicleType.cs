using DataAccess.Data;

namespace Core.UpdateData
{
    public class UpdateVehicleType
    {
        public void EditVehicleType(string regNumber, string newVehicleType)
        {
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
                        edit.Size = 4;
                    }
                    else if (newVehicleType == "MC")
                    {
                        edit.Size = 2;
                    }

                }
                db.SaveChanges();

            }

        }
    }
}
