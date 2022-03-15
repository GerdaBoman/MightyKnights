using DataAccess.Data;

namespace Core.UpdateData
{
    public class UpdateRegNumber
    {
        public void UpdateLicencePlate(string regNumber, string newRegNumber)
        {
            using (var db = new MightyKnightsContext())
            {
                var vehicle = from v in db.Vehicles
                              where v.RegNumber == regNumber
                              select v;

                foreach (var edit in vehicle)
                {
                    edit.RegNumber = newRegNumber;

                }
                db.SaveChanges();
            }

        }
    }
}
