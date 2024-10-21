namespace CafeShop.GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            FormBooking formBooking = new();
            formBooking.ShowDialog();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new();
            formMenu.ShowDialog();
        }

        private void txt_Statistics_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new();
            formStatistic.ShowDialog();
        }
    }
}
