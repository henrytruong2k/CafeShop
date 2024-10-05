namespace CafeShop.GUI;

public partial class FormMenu : Form
{
    public FormMenu()
    {
        InitializeComponent();
    }

    private void FormMenu_Load(object sender, EventArgs e)
    {
        dgv_FoodMenu.DataSource = MenuBUS.Instance.GetMenus();
    }

    private void btn_ThemMenu_Click(object sender, EventArgs e)
    {

    }

    private void dgv_FoodMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btn_TimMenu_Click(object sender, EventArgs e)
    {
        
        dgv_FoodMenu.DataSource = MenuBUS.Instance.GetMenus(txt_TimMenu.Text);
    }

}
