using DataAccess.Data;

namespace UI.ListViewer
{
    public class ListViewRefresh
    {
        //Refresh list view in the parking lot to show the most updated information
        public void RefreshParkingLotViewer(ListView listViewer)
        {

            using (var db = new MightyKnightsContext())
            {
                var parkingLotList = (from p in db.ParkingLots
                                      join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                      orderby p.SpotNumber ascending
                                      select new
                                      {
                                          ParkingSpot = p.SpotNumber,
                                          LicencePlate = v.RegNumber,
                                          CheckInDate = p.Arrival

                                      }).ToList();

                foreach (var parkedVehicle in parkingLotList)
                {
                    ListViewItem item = new(parkedVehicle.ParkingSpot.ToString());
                    item.SubItems.Add(parkedVehicle.LicencePlate.ToString());
                    item.SubItems.Add(parkedVehicle.CheckInDate.ToString());

                    listViewer.Items.Add(item);
                }

            }
        }

        //Refreshes list view that shows search results
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
                    ListViewItem item = new(parkedVehicle.LicancePlate.ToString());
                    item.SubItems.Add(parkedVehicle.VehicleType.ToString());
                    item.SubItems.Add(parkedVehicle.ParkingSpot.ToString());
                    item.SubItems.Add(parkedVehicle.CheckInDate.ToString());

                    listViewer.Items.Add(item);
                }


            }
        }

        //REfresh list view in the vehicle management form that shows all parked cars
        public void RefreshManegmentViewer(ListView listViewer)
        {

            using (var db = new MightyKnightsContext())
            {
                var allVehicles = (from p in db.ParkingLots
                                   join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                   orderby p.SpotNumber ascending
                                   select new
                                   {
                                       LicancePlate = v.RegNumber,
                                       VehicleType = v.VehicleType,
                                       ParkingSpot = p.SpotNumber,
                                       CheckInDate = p.Arrival
                                   }).ToList();

                foreach (var parkedVehicles in allVehicles)
                {
                    ListViewItem item = new(parkedVehicles.LicancePlate.ToString());
                    item.SubItems.Add(parkedVehicles.VehicleType.ToString());
                    item.SubItems.Add(parkedVehicles.ParkingSpot.ToString());
                    item.SubItems.Add(parkedVehicles.CheckInDate.ToString());

                    listViewer.Items.Add(item);
                }


            }
        }

        //Refreshes list view in the history from to show all the previous parked vehicles
        public void RefreshHistoryViewer(ListView listViewer)
        {
            using (var db = new MightyKnightsContext())
            {
                var logg = (from h in db.Histories
                            orderby h.LicencePlate ascending
                            select h).ToList();


                foreach (var history in logg)
                {
                    ListViewItem item = new(history.LicencePlate.ToString());
                    item.SubItems.Add(history.ParkingSpot.ToString());
                    item.SubItems.Add(history.ArrivalDate.ToString());
                    item.SubItems.Add(history.DepartureDate.ToString());
                    item.SubItems.Add(history.TotalCost.ToString());

                    listViewer.Items.Add(item);
                }
            }
        }


    }
}
