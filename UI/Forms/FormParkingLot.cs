
using Core;
using DataAccess.Data;
using System.Data;
using UI.ListViewer;
using UI.ParkingSpotCosmetic;

namespace UI
{
    public partial class FormParkingLot : Form
    {
        ListViewRefresh refresh = new();
        CheckDbForData check = new();
        ParkingSpotColor color = new();


        public FormParkingLot()
        {
            InitializeComponent();

       
            using (MightyKnightsContext context = new MightyKnightsContext())
            {
                var fullSpots = (from p in context.ParkingLots
                                 select p.ParkingSpot).ToList();
                foreach (var spot in fullSpots)
                {
                    string chosenSpot = "pSpot" + spot;

                    Button myButton = Controls.Find(chosenSpot, true).FirstOrDefault() as Button;

                    color.SpotsStatus(spot, myButton);

                }
            }
        }

        private void FormParkingLot_Load(object sender, EventArgs e)
        {
            bool check = CheckDbForData.DataExist();

            if (check == true)
            {
                refresh.RefreshListViewer(listView1);
            }
        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            string vehicleType = vehicleCombo.GetItemText(vehicleCombo.SelectedItem.ToString());
            bool? spotStatus;

            int parkingSpot = int.Parse(parkingSpotBox.Text);
            string chosenSpot = "pSpot" + parkingSpotBox.Text;
            Button takenSpot = Controls.Find(chosenSpot, true).FirstOrDefault() as Button;
            bool checkLicancePlate = check.CheckIfVehicleExist(regPlateTextBox.Text.ToString());

            switch (vehicleType)
            {
                case "Car":

                    #region Adding Car

                    if (checkLicancePlate == true)
                    {
                        MessageBox.Show("This vechile is already in parking lot");
                        regPlateTextBox.Clear();
                        break;
                    }
                    else
                    {
                        spotStatus = check.CheckIfSpotFull(parkingSpot);
                        if (spotStatus == true)
                        {
                            MessageBox.Show("Chosen parking spot is already full!");
                            parkingSpotBox.Clear();
                            break;
                        }
                        else
                        {
                            Car car = new Car();
                            car.AddCar(regPlateTextBox.Text.ToString());
                            car.ParkCar(parkingSpot, regPlateTextBox.Text.ToString());


                            color.SpotsStatus(parkingSpot, takenSpot);

                            regPlateTextBox.Clear();
                            vehicleCombo.ResetText();
                            parkingSpotBox.Clear();

                            listView1.Items.Clear();
                            refresh.RefreshListViewer(listView1);
                            break;
                        }

                    }
                #endregion


                case "Motercycle":

                    #region Adding Motercycle
                    if (checkLicancePlate == true)
                    {
                        MessageBox.Show("This vechile is already in parking lot");
                        regPlateTextBox.Clear();
                        break;
                    }
                    else
                    {
                        spotStatus = check.CheckIfSpotFull(parkingSpot);
                        if (spotStatus == true)
                        {
                            MessageBox.Show("Chosen parking spot is already full!");
                            parkingSpotBox.Clear();
                            break;
                        }
                        else
                        {
                            Mc mc = new Mc();
                            mc.AddMc(regPlateTextBox.Text.ToString());
                            mc.ParkMc(parkingSpot, regPlateTextBox.Text.ToString());

                            color.SpotsStatus(parkingSpot, takenSpot);

                            regPlateTextBox.Clear();
                            vehicleCombo.ResetText();
                            parkingSpotBox.Clear();

                            listView1.Items.Clear();
                            refresh.RefreshListViewer(listView1);
                            break;
                        }


                    }
                    #endregion

            }
        }

       // Parking Spot Status
        private void pSpot1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string buttonText = button.Text.ToString();
            int selectedSpot = Int32.Parse(buttonText);

           MessageBox.Show(check.CheckParkingSpotStatus(selectedSpot));

        }

        
    }
}
    

