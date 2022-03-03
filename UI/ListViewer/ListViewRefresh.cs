using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ListViewer
{
    public class ListViewRefresh
    {
        public void RefreshListViewer(ListView listViewer)
        {

            using (MightyKnightsContext db = new MightyKnightsContext())
            {
                var parkingLotList = (from p in db.ParkingLots
                                join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                select new
                                {
                                   ParkingSpot = p.ParkingSpotId , 
                                   LicancePlate = v.LicancePlate,
                                   CheckInDate = p.CheckInDate
                                }).ToList();

                foreach (var parkedVehicle in parkingLotList)
                {
                    ListViewItem item = new ListViewItem(parkedVehicle.ParkingSpot.ToString());
                    item.SubItems.Add(parkedVehicle.LicancePlate.ToString());
                    item.SubItems.Add(parkedVehicle.CheckInDate.ToString());
                   
                    listViewer.Items.Add(item);
                }

            }
        }
    }
}
