using DataAccess;

namespace UI
{
    public partial class FormSettings : Form
    {
        Form1 form1 = new Form1();
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            cPrice_txt.Text = form1.config.CarPriceHour.ToString();
            mcPrice_txt.Text = form1.config.McPriceHour.ToString();
            gSize_txt.Text = form1.config.ParkingLotSize.ToString();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            EditValue();
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            string carPrice = cPrice_txt.Text;
            string mcPrice = mcPrice_txt.Text;
            string gSize = gSize_txt.Text;
            form1.config.UpdateJson(carPrice, mcPrice, gSize);
        }
        private void EditValue()
        {
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.ReadOnly = false;
                textbox.BorderStyle = BorderStyle.Fixed3D;
            }
        }
    }
}
