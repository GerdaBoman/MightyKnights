using Microsoft.Extensions.Configuration;

namespace UI
{
    public partial class FormHome : Form
    {
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
    }
}
