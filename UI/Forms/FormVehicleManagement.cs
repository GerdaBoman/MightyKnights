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
        string captionError = "Error";
        string captionEdit = "Update Completed";


        public FormVehicleManagement()
        {

            InitializeComponent();
         

            
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            searchResultsView.Items.Clear();
            string regNumber = RegNummerTextBox.Text.ToString();

            if (string.IsNullOrEmpty(regNumber))
            {
                MessageBox.Show("Please enter licence plate number!", captionError,MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    MessageBox.Show("Vehicle not found! Have you entered correct licence plate number?", captionError,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    RegNummerTextBox.Clear();
                }
            }

        }

        private void FormVehicleManagement_Load(object sender, EventArgs e)
        {
            update.RefreshManegmentViewer(parkingLotViewer);
            UpdateAutoComplete(RegNummerTextBox);

        }

        private void UpdateLicencePlate_Click(object sender, EventArgs e)
        {
            string regNumber = editRegNumber.Text.ToString().ToUpper();
            string newRegNumber = newLicencePlate.Text.ToString().ToUpper();

            if (string.IsNullOrEmpty(regNumber))
            {
                MessageBox.Show("Please search for the vehicle you want to update!", captionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(newRegNumber))
            {
                MessageBox.Show("Please enter valid licence plate number!", captionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (check.CheckIfVehicleExist(regNumber) == true)
            {
                updateRegNumber.UpdateLicencePlate(regNumber, newRegNumber);
                MessageBox.Show("Licence Plate updated!", captionEdit, MessageBoxButtons.OK, MessageBoxIcon.Information);

                editRegNumber.Text = newLicencePlate.Text.ToString().ToUpper();
                UpdateAutoComplete(RegNummerTextBox);
                newLicencePlate.Clear();
            }
            else
            {
                MessageBox.Show("Vehicle not found", captionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateAllListViewers(parkingLotViewer, searchResultsView,newRegNumber);

        }

        private void UpdateVehicleType_Click(object sender, EventArgs e)
        {
            bool parkingSpotCheck = int.TryParse(editParkingSpot.Text.ToString(), out int parkingSpot);
            string regNumber = editRegNumber.Text.ToString();
            string? newVehicleType = NewVehicleType.GetItemText(NewVehicleType.SelectedItem?.ToString());

            if (parkingSpotCheck == false)
            {
                MessageBox.Show("Please search for the vehicle you want to update!", captionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(newVehicleType))
            {
                MessageBox.Show("Please choose valid vehicle type!",captionError,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (newVehicleType == "Car")
            {
                bool control = check.CheckIfSpotFull(parkingSpot);
                if (control == true)
                {
                    MessageBox.Show("Parking space is not big enough for this vehicle! Change parking spot if necessary!", captionError,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    updateVehicleType.EditVehicleType(regNumber, newVehicleType);
                    MessageBox.Show("Vehicle Type updated!", captionEdit, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editVehicleType.Text = newVehicleType.ToString();

                }

            }
            else if (newVehicleType == "MC")
            {
                updateVehicleType.EditVehicleType(regNumber, newVehicleType);
                MessageBox.Show("Vehicle Type updated!", captionEdit, MessageBoxButtons.OK, MessageBoxIcon.Information);
                editVehicleType.Text = newVehicleType.ToString();

                
            }
            else
            {
                MessageBox.Show("Vehicle Type Invalid!",captionError,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            UpdateAllListViewers(parkingLotViewer, searchResultsView,regNumber);

        }

        private void UpdateCheckInDate_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker.Value.ToShortDateString();
            string time = timePicker.Value.ToLongTimeString();
            string join = date + " " + time;
            DateTime newDate = DateTime.Parse(join);
            string regNumber = editRegNumber.Text.ToString();

            if (string.IsNullOrEmpty(regNumber))
            {
                MessageBox.Show("Please search for the vehicle you want to update!",captionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                updateCheckInDate.UpdateArrivalTime(regNumber, newDate);

                UpdateAllListViewers(parkingLotViewer, searchResultsView, regNumber);

                MessageBox.Show("Arrival Time updated!", captionEdit, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MoveVehicleButton_Click(object sender, EventArgs e)
        {
            string regNumber = editRegNumber.Text.ToString();

            int newSpot = int.Parse(newParkingSpot.Text.ToString());

            bool control = check.CheckIfSpotFull(newSpot);
            if (control == true)
            {
                MessageBox.Show("Chosen vehicle is too big for this parking spot! Choose another spot!", captionError,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                updateParkingSpot.ChangeParkingSpot(regNumber, newSpot);
                editParkingSpot.Text = newSpot.ToString();
                newParkingSpot.Clear();
                UpdateAllListViewers(parkingLotViewer, searchResultsView,regNumber);
                MessageBox.Show("Vehicle has been moved!", "Move Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            
            
            if (string.IsNullOrEmpty(regNumber))
            {
                MessageBox.Show("Please enter valid licence plate number!",captionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to remove {regNumber} vehicle?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    departure.RemoveVehicleLeaveNoHisotry(regNumber);
                    UpdateAllListViewers(parkingLotViewer, searchResultsView,regNumber);
                }
                else if(result == DialogResult.No)
                {
                    MessageBox.Show("Removal canceled!", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }

        private void RegNummerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Name = (sender as TextBox).Text;
            }
        }

        private void UpdateAllListViewers(ListView main, ListView search, string regNumber)
        {
            main.Items.Clear();
            search.Items.Clear();
            update.RefreshManegmentViewer(main);
            update.RefreshSearchViewer(search,regNumber);
        }

        private void UpdateAutoComplete(TextBox textBox)
        {
            using (var db = new MightyKnightsContext())
            {
                suggestionLlist.AddRange(db.Vehicles.Select(r => r.RegNumber).ToArray());
                textBox.AutoCompleteCustomSource = suggestionLlist;
                textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox.KeyDown += RegNummerTextBox_KeyDown;
            }
        }
    }
}
