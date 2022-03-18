using Core.HistoryMethods;
using UI.ListViewer;

namespace UI.Forms
{
    public partial class FormHistory : Form
    {
        ListViewRefresh refresh = new();
        RemoveHistory remove = new();
        DataBetweenDates data = new();
        public FormHistory()
        {
            InitializeComponent();
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            refresh.RefreshHistoryViewer(historyViewer);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            historyViewer.Items.Clear();
            refresh.RefreshHistoryViewer(historyViewer);
        }

        //Deletes everything from the history table
        private void DeteleButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the whole history log?", "Warning:", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                remove.HistoryRemoval();
                historyViewer.Items.Clear();
                refresh.RefreshHistoryViewer(historyViewer);

            }
            else
            {
                MessageBox.Show("Canceled!");
            }
        }

        //Select start and end date time to see statistics of how many vehicles there parked and how much was the total income
        private void selectButton_Click(object sender, EventArgs e)
        {
            string startDate = FromDatePicker.Value.ToShortDateString();
            string fromTime = startTime.Value.ToLongTimeString();
            string endDate = ToDatePicker.Value.ToShortDateString();
            string toTime = endTime.Value.ToLongTimeString();



            DateTime fromDate = Convert.ToDateTime(startDate + " " + fromTime);
            DateTime toDate = Convert.ToDateTime(endDate + " " + toTime);


            if (toDate < fromDate)
            {
                MessageBox.Show("Start date has to be later than End date!");
            }
            else
            {
                int amountVehicles = data.AmoutVehicles(fromDate, toDate);
                decimal? moneyEarned = data.TotalEarned(fromDate, toDate);
                if (amountVehicles <= 0)
                {
                    MessageBox.Show("No history found");
                }
                else
                {
                    NumberOfVehicles.Text = amountVehicles.ToString();
                    AmountEarned.Text = moneyEarned.ToString() + " CZK";
                }

            }

        }
    }
}
