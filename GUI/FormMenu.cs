using CafeShop.Utils;

namespace CafeShop.GUI;

public partial class FormMenu : Form
{
    public FormMenu()
    {
        InitializeComponent();
    }

    private void FormMenu_Load(object sender, EventArgs e)
    {
        LoadData();

        cb_Category.DataSource = MenuBUS.Instance.GetCategories();
        cb_Category.DisplayMember = nameof(CategoryDTO.CategoryName);
        cb_Category.ValueMember = nameof(CategoryDTO.CategoryID);
        cb_Category.SelectedIndex = -1;
    }

    private void LoadData()
    {
        dgv_FoodMenu.DataSource = MenuBUS.Instance.GetMenus();
        dgv_FoodMenu.Columns[nameof(MenuDTO.CategoryID)].Visible = false;
    }

    private void btn_TimMenu_Click(object sender, EventArgs e)
    {
        dgv_FoodMenu.DataSource = MenuBUS.Instance.GetMenus(txt_TimMenu.Text);
    }

    private void dgv_FoodMenu_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        DataGridViewRow row = dgv_FoodMenu.Rows[e.RowIndex];
        txt_FoodID.Text = row.Cells[nameof(MenuDTO.MenuID)].Value.ToString();
        txt_FoodName.Text = row.Cells[nameof(MenuDTO.MenuName)].Value.ToString();
        txt_Price.Text = row.Cells[nameof(MenuDTO.Price)].Value.ToString();
        txt_Description.Text = row.Cells[nameof(MenuDTO.Description)].Value.ToString();
        cb_Category.SelectedValue = row.Cells[nameof(MenuDTO.CategoryID)].Value;
    }

    private void txt_Price_TextChanged(object sender, EventArgs e)
    {
        CurrencyUtils.FormatVND(txt_Price);
    }

    private void btn_reset_Click(object sender, EventArgs e)
    {
        ResetForm();
    }

    private void ResetForm()
    {
        txt_FoodID.Text = string.Empty;
        txt_FoodName.Text = string.Empty;
        txt_Price.Text = string.Empty;
        cb_Category.SelectedIndex = -1;
    }

    private void btn_ThemMenu_Click(object sender, EventArgs e)
    {
        MenuDTO menuDTO = new()
        {
            MenuName = txt_FoodName.Text,
            Price = Convert.ToInt64(txt_Price.Text.RemoveCommas())
        };
        bool result = MenuBUS.Instance.InsertMenu(menuDTO);
        if (!result)
        {
            MessageBox.Show("Thêm menu thất bại");
            return;
        }
        LoadData();
        ResetForm();
    }
}
