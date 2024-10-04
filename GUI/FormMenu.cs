namespace CafeShop.GUI;

public partial class FormMenu : Form
{
    public FormMenu()
    {
        InitializeComponent();
    }

    void LoadListFood()
    {
        dgv_FoodMenu.DataSource = FoodDAO.Instance.GetListFood();
    }

    private void btn_XemMenu_Click(object sender, EventArgs e)
    {
        LoadListFood();
    }

    private void FormMenu_Load(object sender, EventArgs e)
    {
        dgv_FoodMenu.DataSource = FoodBUS.Instance.GetListFood();
    }
}
