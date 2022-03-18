using DataAccess.Data;

namespace Core.UpdateData
{
    public class UpdateRegNumber
    {
        //Methods to chance license plate number of a selected vehicle
        public void UpdateLicencePlate(string regNumber, string newRegNumber)
        {
            using (var db = new MightyKnightsContext())
            {
                var vehicle = from v in db.Vehicles
                              where v.RegNumber == regNumber
                              select v;

                foreach (var edit in vehicle)
                {
                    edit.RegNumber = newRegNumber.ToUpper();

                }
                db.SaveChanges();
            }

        }
    }
}
