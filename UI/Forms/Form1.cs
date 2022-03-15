

using DataAccess.Data;
using FontAwesome.Sharp;
using UI.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        private IconButton currentButton;
        private Panel leftBorderButton;
        private System.Windows.Forms.Form currentChildForm;
        public Config config = new Config();

        public Form1()
        {
            config.ReadFromJson();

            InitializeComponent();
            MightyKnightsContext db = new();
            db.Database.EnsureCreated();



            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 60);
            MenuPanel.Controls.Add(leftBorderButton);
            OpenChildForm(new FormHome());
            timer.Start();
        }

        #region Buttons
        private void logoButton_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            DisableHighlightButton();
            OpenChildForm(new FormHome());
            currentChildButton.IconChar = IconChar.Home;

        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            OpenChildForm(new FormHome());
        }

        private void ParkingLotButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            OpenChildForm(new FormParkingLot());
        }

        private void VehicleManagementButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            OpenChildForm(new FormVehicleManagement());
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            OpenChildForm(new FormSettings());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            Application.Exit();
        }
        private void HistoryButton_Click(object sender, EventArgs e)
        {
            HighlightButton(sender, Color.FromArgb(56, 111, 164));
            OpenChildForm(new FormHistory());

        }

        #endregion

        private void OpenChildForm(System.Windows.Forms.Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            currentChildFormLabel.Text = childForm.Text;
        }

        #region Button Highlights

        private void HighlightButton(object selectedButton, Color colour)
        {
            if (selectedButton != null)
            {
                DisableHighlightButton();

                currentButton = (IconButton)selectedButton;
                currentButton.BackColor = Color.FromArgb(56, 111, 164);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderButton.BackColor = colour;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();

                currentChildButton.IconChar = currentButton.IconChar;
                currentChildButton.IconColor = Color.Gainsboro;

            }
        }

        private void DisableHighlightButton()
        {
            if (currentButton != null)
            {

                currentButton.BackColor = Color.FromArgb(19, 60, 85);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;


            }
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockStatusStrip.Text = DateTime.Now.ToString("T");
        }


    }
}