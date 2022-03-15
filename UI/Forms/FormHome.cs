using Core.HomeCalculations;
using DataAccess.Data.Datafiles;
using Microsoft.Extensions.Configuration;

namespace UI
{
    public partial class FormHome : Form
    {
        CountAllCars car = new CountAllCars();
        CountAllMC mc = new CountAllMC();
        InsertTestData data = new();
        public FormHome()
        {
            InitializeComponent();


            var config = new ConfigurationBuilder()
             .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
             .AddJsonFile("appSettings.json")
             .Build()
              .Get<Config>();




            //priceList = File.ReadAllLines(@"C:\Users\jonas\source\repos\MightyKnights\DataAccess\Prague_Parking_PriceList.txt")
            //    .ToList();

            //foreach (var item in priceList)
            //{
            //    price_ListVw.Items.Add(item);
            //}
        }

        private void FormHome_Load(object sender, EventArgs e)
        {



            int totalCars = car.CountCars();

            NumberOfCars.Text = totalCars.ToString();

            int totalMc = mc.CountMc();

            NumberOfMC.Text = totalMc.ToString();
        }

        private void TestDataButton_Click(object sender, EventArgs e)
        {
            data.TestData();
            MessageBox.Show("Import Completed!");

        }
    }
}
