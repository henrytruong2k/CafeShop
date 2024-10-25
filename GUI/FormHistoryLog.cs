using System.Security.AccessControl;

namespace CafeShop.GUI;

public partial class FormHistoryLog : Form
{
    public FormHistoryLog()
    {
        InitializeComponent();
    }

    private void FormHistoryLog_Load(object sender, EventArgs e)
    {
        loadData();
    }

    private void loadData()
    {
        dgv_HistoryLog.DataSource = HistoryLogBUS.Instance.GetHistoryLogs();
    }

    private void btn_Tim_Click(object sender, EventArgs e)
    {
        
    }

    

}
