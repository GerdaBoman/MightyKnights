using Core;
using Core.UpdateData;
using DataAccess.Data;
using System.Data;
using UI.ListViewer;

namespace UI
{
    public partial class FormVehicleManagement : Form
    {
        private AutoCompleteStringCollection suggestionLlist = new AutoCompleteStringCollection();
        ListViewRefresh update = new();
        CheckDbForData check = new CheckDbForData();
        UpdateRegNumber updateRegNumber = new();
        UpdateVehicleType updateVehicleType = new UpdateVehicleType();
        UpdateCheckInDate updateCheckInDate = new UpdateCheckInDate();
        UpdateParkingSpot updateParkingSpot = new UpdateParkingSpot();
        Departure departure = new Departure();
        string caption = "Error";


        public FormVehicleManagement()
        {

            InitializeComponent();

            using (var db = new MightyKnightsContext())
            {
                suggestionLlist.AddRange(db.Vehicles.Select(r => r.RegNumber).ToArray());
                RegNummerTextBox.AutoCompleteCustomSource = suggestionLlist;
                RegNummerTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                RegNummerTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                RegNummerTextBox.KeyDown += RegNummerTextBox_KeyDown;
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {

            string regNumber = RegNummerTextBox.Text.ToString();

            if (string.IsNullOrEmpty(regNumber))
            {
                MessageBox.Show("Please enter licence plate number!", caption);
                RegNummerTextBox.Clear();
            }
            else
            {
                bool test = check.CheckIfVehicleExist(regNumber);
                if (test == true)
                {
                    update.RefreshSearchViewer(searchResultsView, regNumber);
                    editRegNumber.Text = regNumber;
                    editVehicleType.Text = check.GetVehicleType(regNumber);
                    editParkingSpot.Text = check.GetParkingSpot(regNumber).ToString();
                    dateTimePicker.Value = check.GetArrivalTime(regNumber).Value.Date;
                    timePicker.Value = DateTime.Parse(check.GetArrivalTime(regNumber).Value.ToLongTimeString());
                    RegNummerTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Vehicle not found! Have you entered correct licence plate number?", caption);
                    RegNummerTextBox.Clear();
                }
            }

        }

        private void FormVehicleManagement_Load(object sender, EventArgs e)
        {
            update.RefreshManegmentViewer(parkingLotViewer);
        }

        private void UpdateLicencePlate_Click(object sender, EventArgs e)
        {
            string regNumber = editRegNumber.Text.ToString();
            string newRegNumber = newLicencePlate.Text.ToString();

            if (check.CheckIfVehicleExist(regNumber) == true)
            {
                updateRegNumber.UpdateLicencePlate(regNumber, newRegNumber);

                parkingLotViewer.Items.Clear();
                update.RefreshManegmentViewer(parkingLotViewer);
                MessageBox.Show("Licence Plate updated!");

            }
            else
                MessageBox.Show("Vehicle not found", caption);



        }

        private void UpdateVehicleType_Click(object sender, EventArgs e)
        {
            int parkingSpot = int.Parse(editParkingSpot.Text.ToString());
            string regNumber = editRegNumber.Text.ToString();
            string newVehicleType = NewVehicleType.GetItemText(NewVehicleType.SelectedItem.ToString());

            if (newVehicleType == "Car")
            {
                bool control = check.CheckIfSpotFull(parkingSpot);
                if (control == true)
                {
                    MessageBox.Show("Parking space is not big enough for this vehicle! Change parking spot if necessary!", caption);
                }
                else
                {
                    updateVehicleType.EditVehicleType(regNumber, newVehicleType);
                    MessageBox.Show("Vehicle Type updated!");
                }

            }
            else if (newVehicleType == "MC")
            {
                updateVehicleType.EditVehicleType(regNumber, newVehicleType);
                MessageBox.Show("Vehicle Type updated!");
            }
            else
            {
                MessageBox.Show("Vehicle Type Invalid!");
            }

            parkingLotViewer.Items.Clear();
            update.RefreshManegmentViewer(parkingLotViewer);


        }

        private void UpdateCheckInDate_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker.Value.ToShortDateString();
            string time = timePicker.Value.ToLongTimeString();
            string join = date + " " + time;
            DateTime newDate = DateTime.Parse(join);
            string regNumber = editRegNumber.Text.ToString();

            updateCheckInDate.UpdateArrivalTime(regNumber, newDate);

            parkingLotViewer.Items.Clear();
            update.RefreshManegmentViewer(parkingLotViewer);
            MessageBox.Show("Arrival Time updated!");
        }

        private void MoveVehicleButton_Click(object sender, EventArgs e)
        {
            string regNumber = editRegNumber.Text.ToString();

            int newSpot = int.Parse(newParkingSpot.Text.ToString());

            bool control = check.CheckIfSpotFull(newSpot);
            if (control == true)
            {
                MessageBox.Show("Chosen vehicle is too big for this parking spot! Choose another spot!", caption);
            }
            else
            {
                updateParkingSpot.ChangeParkingSpot(regNumber, newSpot);
                parkingLotViewer.Items.Clear();
                update.RefreshManegmentViewer(parkingLotViewer);
                MessageBox.Show("Vehicle has been moved!");
            }

        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            RegNummerTextBox.Clear();
            searchResultsView.Items.Clear();
            editRegNumber.Clear();
            newLicencePlate.Clear();
            editVehicleType.Clear();
            NewVehicleType.Items.Clear();
            dateTimePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
            editParkingSpot.Clear();
            newParkingSpot.Clear();

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string regNumber = editRegNumber.Text.ToString();


            DialogResult result = MessageBox.Show($"Are you sure you want to remove {regNumber} vehicle?", "!!!!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                departure.RemoveVehicle(regNumber);
                parkingLotViewer.Items.Clear();
                update.RefreshManegmentViewer(parkingLotViewer);
            }
            else
            {
                MessageBox.Show("Removal canceled!");
            }


        }

        private void RegNummerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Name = (sender as TextBox).Text;
            }
        }
    }
}
