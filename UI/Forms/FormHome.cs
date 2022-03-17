using Core.HomeCalculations;
using DataAccess.Data.Datafiles;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UI.ListViewer;

namespace UI
{
    public partial class FormHome : Form
    {
        CountAllCars car = new ();
        CountAllMC mc = new();
        InsertTestData data = new();
        CountSpaces count = new();
        ListViewRefresh refresh = new();
        Config config = new();  
        public FormHome()
        {
            InitializeComponent();
            config.ReadFromJson();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

            RefreshCalculationsLabels();
            RefreshPriceList(price_ListVw);
            
        }

        private void TestDataButton_Click(object sender, EventArgs e)
        {
            data.TestData();
            MessageBox.Show("Import Completed!");

            RefreshCalculationsLabels();


        }

        private void RefreshCalculationsLabels()
        {
            int parkingSize =config.ParkingLotSize;

            TotalCarparkSize.Text = parkingSize.ToString();

            NumberOfFreeSpots.Text = (parkingSize - count.CountAllTakenSpaces()).ToString();

            fullSpaces.Text = count.CountFullSpaces().ToString();

            partialTakenSpots.Text = count.CountPartialSpaces().ToString();

            NumberOfCars.Text = car.CountCars().ToString();

            NumberOfMC.Text = mc.CountMc().ToString();
        }
        
        private void RefreshPriceList(ListView listViewer)
        {
            string priceCar = config.CarPriceHour.ToString();
            string priceMc= config.McPriceHour.ToString();

            listViewer.Items.Add("Car price per hour : "+ priceCar+ " CZK");
            listViewer.Items.Add("Motercycle price per hour : " + priceMc + " CZK");
            listViewer.Update();
            listViewer.Refresh();
        }

    }
}
