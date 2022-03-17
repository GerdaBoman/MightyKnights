
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
        ParkingControls parkingControls = new();
        ParkingFeeCalculations calculations = new();
        Departure departure = new();
        ParkingLotSpaces parkingLotSpaces = new();
        private AutoCompleteStringCollection suggestionlist = new AutoCompleteStringCollection();
        Form1 form1 = new Form1();

        string amountToPayCap = "Amount to Pay";
        string errorCap = "Error";

        public FormParkingLot()
        {
            InitializeComponent();

            using (var db = new MightyKnightsContext())
            {
                suggestionlist.AddRange(db.Vehicles.Select(r => r.RegNumber).ToArray());
                checkOutTextBox.AutoCompleteCustomSource = suggestionlist;
                checkOutTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                checkOutTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                checkOutTextBox.KeyDown += checkOutTextBox_KeyDown;
            }
        }

        private void FormParkingLot_Load(object sender, EventArgs e)
        {
            bool check = CheckDbForData.DataExist();

            if (check == true)
            {
                refresh.RefreshParkingLotViewer(listView1);
            }


            int capacity = form1.config.ParkingLotSize;

            parkingLotSpaces.ParkingLotSize(capacity, parkingSpotHolder);

            using (MightyKnightsContext context = new MightyKnightsContext())
            {
                var fullSpots = (from p in context.ParkingLots
                                 select p.SpotNumber).ToList();
                foreach (var spot in fullSpots)
                {
                    string chosenSpot = "pSpot" + spot;

                    Button myButton = Controls.Find(chosenSpot, true).FirstOrDefault() as Button;

                    color.SpotsStatus(spot, myButton);

                }
            }
        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            string vehicleType = vehicleCombo.Text;
            bool? spotStatus;
            bool? spotPartialStatus;

            string regNumber = regPlateTextBox.Text.Trim().ToUpper(); 

            bool parkingSpotCheck = int.TryParse(parkingSpotBox.Text,out int parkingSpot);
            string chosenSpot = "pSpot" + parkingSpotBox.Text;
            Button takenSpot = Controls.Find(chosenSpot, true).FirstOrDefault() as Button;
            bool checkLicancePlate = check.CheckIfVehicleExist(regPlateTextBox.Text.ToString());

            int parkingLotSize = form1.config.ParkingLotSize;


            if (string.IsNullOrEmpty(regNumber))
            {
                MessageBox.Show("Please enter vehicles licence plate number to check in!", errorCap, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(vehicleType))
                {
                    MessageBox.Show("Vehicle Type is not chosen.Please specify vehicle type to check in!", errorCap, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    if (parkingLotSize > 0 && parkingSpot < parkingLotSize && parkingSpotCheck != false && parkingSpot != 0)
                    {
                        switch (vehicleType)
                        {
                            case "Car":

                                #region Adding Car

                                if (checkLicancePlate == true)
                                {
                                    MessageBox.Show("This vechile is already in parking lot", errorCap, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    regPlateTextBox.Clear();
                                    break;
                                }
                                else
                                {

                                    spotPartialStatus = check.CheckIfSpotPartialFull(parkingSpot);
                                    spotStatus = check.CheckIfSpotFull(parkingSpot);
                                    if (spotStatus == true || spotPartialStatus ==true)
                                    {
                                        MessageBox.Show("Chosen parking spot is already full!", errorCap, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        parkingSpotBox.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Car car = new Car();
                                        car.AddCar(regPlateTextBox.Text.ToString().ToUpper());
                                        parkingControls.ParkVehicle(parkingSpot, regPlateTextBox.Text.ToString());

                                        color.SpotsStatus(parkingSpot, takenSpot);

                                        regPlateTextBox.Clear();
                                        vehicleCombo.ResetText();
                                        parkingSpotBox.Clear();

                                        listView1.Items.Clear();
                                        refresh.RefreshParkingLotViewer(listView1);
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
                                        mc.AddMc(regPlateTextBox.Text.ToString().ToUpper());
                                        parkingControls.ParkVehicle(parkingSpot, regPlateTextBox.Text.ToString());
                                  

                                        color.SpotsStatus(parkingSpot, takenSpot);

                                        regPlateTextBox.Clear();
                                        vehicleCombo.ResetText();
                                        parkingSpotBox.Clear();

                                        listView1.Items.Clear();
                                        refresh.RefreshParkingLotViewer(listView1);
                                        break;
                                    }


                                }
                                #endregion
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is no parking space with that number. Please enter a valid parking spot.", errorCap, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        parkingSpotBox.Clear();
                    }
                }
            }
            
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            string regNumber = checkOutTextBox.Text.ToString();

           int parkingSpot = int.Parse(checkoutSpotBox.Text.ToString());

            double? amount = calculations.TotalAmountToPay(regNumber);

            string toDecimal = amount.ToString();

            string checkOutSpot = "pSpot" + checkoutSpotBox.Text;

            Button checkSpot = Controls.Find(checkOutSpot, true).FirstOrDefault() as Button;


            if(string.IsNullOrEmpty(regNumber))
            {

                MessageBox.Show("Please enter a licence plate of the vehicle to check out!", errorCap, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (amount > 0)
            {
                decimal roundedAmount = Math.Round(decimal.Parse(toDecimal), 2);

                MessageBox.Show($"Amount to pay : {roundedAmount} CZK", amountToPayCap, MessageBoxButtons.OK, MessageBoxIcon.Information);
                departure.RemoveVehicle(regNumber);

                color.SpotsStatus(parkingSpot, checkSpot);

                listView1.Items.Clear();
                refresh.RefreshParkingLotViewer(listView1);
                checkOutTextBox.Clear();
                checkoutSpotBox.Clear();

            }
            else if (amount < 0)
            {
                MessageBox.Show("Vehicle has free parking!", amountToPayCap, MessageBoxButtons.OK, MessageBoxIcon.Information);
                departure.RemoveVehicle(regNumber);

                color.SpotsStatus(parkingSpot, checkSpot);

                listView1.Items.Clear();
                refresh.RefreshParkingLotViewer(listView1);
                checkOutTextBox.Clear();
                checkoutSpotBox.Clear();
            }
            else
            {
                MessageBox.Show("Vehicle not found!", errorCap, MessageBoxButtons.OK, MessageBoxIcon.Error);

                checkOutTextBox.Clear();
                checkoutSpotBox.Clear();
            }
        }

        private void checkOutTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Name = (sender as TextBox).Text;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string regNumber = checkOutTextBox.Text.ToString();

            int? parkingSpot = check.GetParkingSpot(regNumber);

            if (parkingSpot <= 0 || parkingSpot == null)
            {
                MessageBox.Show("Vehicle not found!", errorCap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkOutTextBox.Clear();
            }
            else
            {
                checkoutSpotBox.Text = parkingSpot.ToString();
            }


        }
    }
}


