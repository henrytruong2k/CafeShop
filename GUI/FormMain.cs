namespace CafeShop.GUI;

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

    private void btn_statistics_Click(object sender, EventArgs e)
    {
        FormStatistic formStatistic = new();
        formStatistic.ShowDialog();
    }

    private void btn_history_Click(object sender, EventArgs e)
    {
        FormHistoryLog formHistoryLog = new();
        formHistoryLog.ShowDialog();
    }

    private void btn_manage_Click(object sender, EventArgs e)
    {
        FormManage formManage = new();
        formManage.ShowDialog();
    }
}
