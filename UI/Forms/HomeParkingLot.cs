using Core;
using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.ListViewer;

namespace UI
{
    public partial class FormParkingLot : Form
    {
        ListViewRefresh refresh = new ();

        public FormParkingLot()
        {
            InitializeComponent();

            using (MightyKnightsContext context = new MightyKnightsContext())
            {
                var fullSpots = (from p in context.ParkingLots
                                 select p.ParkingSpotId).ToList();
                foreach (var spot in fullSpots)
                {
                    string chosenSpot = "pSpot" + spot;

                    Button myButton = Controls.Find(chosenSpot, true).FirstOrDefault() as Button;
                    myButton.BackColor = Color.Red;

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
            if(vehicleCombo.GetItemText(vehicleCombo.SelectedItem) == "Car")
            {
                int parkingSpot = int.Parse(parkingSpotBox.Text);

                Car car = new Car();
                car.AddCar(regPlateTextBox.Text.ToString());
                car.ParkCar(parkingSpot, regPlateTextBox.Text.ToString());
                

                string chosenSpot = "pSpot" + parkingSpotBox.Text;

                Button takenSpot = Controls.Find(chosenSpot, true).FirstOrDefault() as Button;
                takenSpot.BackColor = Color.Red;

                regPlateTextBox.Clear();
                vehicleCombo.ResetText();
                parkingSpotBox.Clear();

                listView1.Items.Clear();
                refresh.RefreshListViewer(listView1);
            }
        }
    }
}
