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

        private void cPrice_edit_btn_Click(object sender, EventArgs e)
        {
            EditEnabled(cPrice_txt, cPrice_edit_btn);
        }

        public void EditEnabled(TextBox box, Button btn)
        {
            box.ReadOnly = false;
        }

    }
}
