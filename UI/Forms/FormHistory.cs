using Core.HistoryMethods;
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

namespace UI.Forms
{
    public partial class FormHistory : Form
    {
        ListViewRefresh refresh = new();
        RemoveHistory remove = new();
        DataBetweenDates data = new DataBetweenDates(); 
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

        private void DeteleButton_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Are you sure you want to delete the whole history log?","Warning:",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
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

        private void selectButton_Click(object sender, EventArgs e)
        {
            DateTime fromDate = FromDatePicker.Value;
            DateTime toDate = ToDatePicker.Value;

            if (toDate < fromDate)
            {
                MessageBox.Show("To date has to be later than from date!");
            }
            else
            {
                int amountVehicles = data.AmoutVehicles(fromDate, toDate);
                decimal? moneyEarned = data.TotalEarned(fromDate, toDate);
                if(amountVehicles <= 0)
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
