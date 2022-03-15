using Core;

namespace UI.ParkingSpotCosmetic
{
    public class ParkingLotSpaces
    {
        CheckDbForData check = new CheckDbForData();
        public void ParkingLotSize(int capacity, FlowLayoutPanel flowPanel)
        {
            for (int i = 1; i <= capacity; i++)
            {
                Button b = new Button();
                b.Text = i.ToString();
                b.Name = "pSpot" + i.ToString();
                b.Size = new Size(50, 60);
                b.BackColor = Color.FromArgb(89, 165, 216);
                b.Click += new EventHandler(pSpot1_Click);

                flowPanel.Controls.Add(b);

            }
        }

        private void pSpot1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string buttonText = button.Text.ToString();
            int selectedSpot = Int32.Parse(buttonText);
            string caption = "Parked Vehicle: ";

            MessageBox.Show(check.CheckParkingSpotStatus(selectedSpot), caption);

        }
    }
}
