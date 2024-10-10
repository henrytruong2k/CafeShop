using CafeShop.GUI;

namespace CafeShop;

public partial class FormLogin : Form
{
    public FormLogin()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        AccountDTO accountDTO = Login(txt_username.Text, txt_password.Text);
        if (accountDTO == null)
        {
            MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            return;
        }

        this.Hide();
        FormMain formMain = new();
        formMain.ShowDialog();
        this.Show();
    }

    private AccountDTO Login(string username, string password) => AccountBUS.Instance.Login(username, password);

    private void FormLogin_Load(object sender, EventArgs e)
    {
        txt_username.Text = "admin";
        txt_password.Text = "admin";
    }

    private void btn_Show_Click(object sender, EventArgs e)
    {
        if(btn_Show.Text =="Show")
        {
            txt_password.PasswordChar= '\0';
            btn_Show.Text = "Hide";
        }else
        {
            txt_password.PasswordChar = '*';
            btn_Show.Text = "Show";
        }
    }
}
