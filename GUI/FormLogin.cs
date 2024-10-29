using CafeShop.GUI;
using AppContext = CafeShop.Core.AppContext;


namespace CafeShop;

public partial class FormLogin : Form
{
    private Image iconShow;
    private Image iconHide;
    public FormLogin()
    {
        InitializeComponent();
        iconShow = Image.FromFile("C:\\Users\\admin\\Desktop\\GreatDoAn\\CafeShop\\Icon\\show.png");
        iconHide = Image.FromFile("C:\\Users\\admin\\Desktop\\GreatDoAn\\CafeShop\\Icon\\hide.png");
        btn_Show.Image = iconShow;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        AccountDTO accountDTO = Login(txt_username.Text, txt_password.Text);
        if (accountDTO == null)
        {
            MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            return;
        }
        AppContext.UserID = accountDTO.UserID;
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
        if (btn_Show.Text == "Show")
        {
            txt_password.PasswordChar = '\0';
            btn_Show.Text = "Hide";
            btn_Show.Image = iconHide;
        }
        else
        {
            txt_password.PasswordChar = '*';
            btn_Show.Text = "Show";
            btn_Show.Image = iconShow;
        }
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }
}