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
        public void RefreshParkingLotViewer(ListView listViewer)
        {

            using (var db = new MightyKnightsContext())
            {
                var parkingLotList = (from p in db.ParkingLots
                                      join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                      select new
                                      {
                                          ParkingSpot = p.SpotNumber,
                                          LicencePlate = v.RegNumber,
                                          CheckInDate = p.Arrival

                                      }).ToList();

                foreach (var parkedVehicle in parkingLotList)
                {
                    ListViewItem item = new ListViewItem(parkedVehicle.ParkingSpot.ToString());
                    item.SubItems.Add(parkedVehicle.LicencePlate.ToString());
                    item.SubItems.Add(parkedVehicle.CheckInDate.ToString());

                    listViewer.Items.Add(item);
                }

            }
        }
        
        public void RefreshSearchViewer(ListView listViewer, string regNumber)
        {

            using (var db = new MightyKnightsContext())
            {
                var searchResult = (from p in db.ParkingLots
                                      join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                      where v.RegNumber == regNumber
                                      select new
                                      {
                                          LicancePlate = v.RegNumber,
                                          VehicleType = v.VehicleType,
                                          ParkingSpot = p.SpotNumber,
                                          CheckInDate = p.Arrival
                                      }).ToList();


                foreach (var parkedVehicle in searchResult)
                {
                    ListViewItem item = new ListViewItem(parkedVehicle.LicancePlate.ToString());
                    item.SubItems.Add(parkedVehicle.VehicleType.ToString());
                    item.SubItems.Add(parkedVehicle.ParkingSpot.ToString());
                    item.SubItems.Add(parkedVehicle.CheckInDate.ToString());

                    listViewer.Items.Add(item);
                }


            }
        }
        public void RefreshManegmentViewer(ListView listViewer)
        {

            using (var db = new MightyKnightsContext())
            {
                var allVehicles = (from p in db.ParkingLots
                                      join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                      
                                      select new
                                      {
                                          LicancePlate = v.RegNumber,
                                          VehicleType = v.VehicleType,
                                          ParkingSpot = p.SpotNumber,
                                          CheckInDate = p.Arrival
                                      }).ToList();

                foreach (var parkedVehicles in allVehicles)
                {
                    ListViewItem item = new ListViewItem(parkedVehicles.LicancePlate.ToString());
                    item.SubItems.Add(parkedVehicles.VehicleType.ToString());
                    item.SubItems.Add(parkedVehicles.ParkingSpot.ToString());
                    item.SubItems.Add(parkedVehicles.CheckInDate.ToString());

                    listViewer.Items.Add(item);
                }


            }
        }
    }
}
