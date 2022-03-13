using Core.HomeCalculations;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace UI
{
    public partial class FormHome : Form
    {
        CountAllCars car = new CountAllCars();
        CountAllMC mc= new CountAllMC();    
        public FormHome()
        {
            InitializeComponent();

            //priceList = File.ReadAllLines(@"C:\Users\jonas\source\repos\MightyKnights\DataAccess\Prague_Parking_PriceList.txt")
            //    .ToList();

            //foreach (var item in priceList)
            //{
            //    price_ListVw.Items.Add(item);
            //}
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            //dynamic jsonFile = JsonConvert.DeserializeObject<Config>("C: \\Users\\gerda\\source\\repos\\MightyKnights\\DataAccess\appSettings.json");

            //TotalCarparkSize.Text = jsonFile["ParkinhLotSize"];

            int totalCars = car.CountCars();

            NumberOfCars.Text= totalCars.ToString();    

            int totalMc = mc.CountMc();

            NumberOfMC.Text= totalMc.ToString();
        }

        
    }
}
