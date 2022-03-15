﻿
using Core;
using DataAccess.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
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
        Form1 form1 = new Form1();

        public FormParkingLot()
        {
            InitializeComponent();
        }

        private void FormParkingLot_Load(object sender, EventArgs e)
        {
            bool check = CheckDbForData.DataExist();

            if (check == true)
            {
                refresh.RefreshParkingLotViewer(listView1);
            }

            //TODO: CONNECT TO JSON TO CHANGE CAPACITY OF PARKING LOT

            //var appSettingsPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "appSettings.json");
            //var json = File.ReadAllText(appSettingsPath);

            //var jsonString = JObject.Parse(json);
            //var parkingLotSize = jsonString["ParkingLotSize"].ToString();

            //Config value = new Config();
            //{
            //    ParkingLotSize = (int)jsonString["ParkingLotSize"]["ParkingLotSize"]
            //};


            //int capacity = value.ParkingLotSize;
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
                            parkingControls.ParkVehicle(parkingSpot, regPlateTextBox.Text.ToString());
                            //car.ParkCar(parkingSpot, regPlateTextBox.Text.ToString());


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
                            mc.AddMc(regPlateTextBox.Text.ToString());
                            parkingControls.ParkVehicle(parkingSpot, regPlateTextBox.Text.ToString());
                            //mc.ParkMc(parkingSpot, regPlateTextBox.Text.ToString());

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

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            string regNumber = checkOutTextBox.Text.ToString();

            double? amount = calculations.TotalAmountToPay(regNumber);

            string toDecimal = amount.ToString();

            int parkingSpot = int.Parse(checkoutSpotBox.Text);
            string checkOutSpot = "pSpot" + checkoutSpotBox.Text;
            Button checkSpot = Controls.Find(checkOutSpot, true).FirstOrDefault() as Button;

            if (amount > 0)
            {
                decimal roundedAmount = Math.Round(decimal.Parse(toDecimal), 2);

                MessageBox.Show($"Amount to pay : {roundedAmount} CZK");
                departure.RemoveVehicle(regNumber);

                color.SpotsStatus(parkingSpot, checkSpot);

                listView1.Items.Clear();
                refresh.RefreshParkingLotViewer(listView1);
                checkOutTextBox.Clear();
                checkoutSpotBox.Clear();

            }
            else if(amount < 0 )
            {
                MessageBox.Show("Vehicle has free parking!");
                departure.RemoveVehicle(regNumber);

                color.SpotsStatus(parkingSpot, checkSpot);

                listView1.Items.Clear();
                refresh.RefreshParkingLotViewer(listView1);
                checkOutTextBox.Clear();
                checkoutSpotBox.Clear();
            }
            else
            {
                MessageBox.Show("Vehicle not found!");

                checkOutTextBox.Clear();
                checkoutSpotBox.Clear();
            }


        }

       
    }
}
    

