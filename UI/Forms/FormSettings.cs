namespace UI
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            cPrice_txt.Text = Config.CarPriceHour.ToString();
            mcPrice_txt.Text = Config.McPriceHour.ToString();
            gSize_txt.Text = Config.ParkingLotSize.ToString();
        }

        public static bool EditEnabled(TextBox box, Button btn)
        {
            if (btn.Text == "Edit")
            {
                btn.Text = "OK";
                box.ReadOnly = false;
                return box.ReadOnly;
            }
            else 
            {
                btn.Text = "Edit";
                box.ReadOnly = true;
                return box.ReadOnly;
            }
        }

        private void cPrice_edit_btn_Click(object sender, EventArgs e)
        {
            EditEnabled(cPrice_txt, cPrice_edit_btn);
        }

    }
}
