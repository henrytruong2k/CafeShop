namespace CafeShop;

public partial class FormUser : Form
{
    private readonly AccountDTO accountDTO;
    public FormUser(AccountDTO accountDTO)
    {
        InitializeComponent();
        this.accountDTO = accountDTO;
    }

    private void FormUser_Load(object sender, EventArgs e)
    {
        dgv_user.DataSource = DataProvider.Instance.ExecuteSQLGetList<AccountDTO>("SELECT * FROM Users");
        lbl_fullname.Text = accountDTO.FullName;
    }
}
