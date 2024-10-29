using CafeShop.Utils;

namespace CafeShop.GUI;

public partial class FormManage : Form
{
    public FormManage()
    {
        InitializeComponent();
    }

    private void FormManage_Load(object sender, EventArgs e)
    {
        LoadData();

        cb_Category.DataSource = MenuBUS.Instance.GetCategories();
        cb_Category.DisplayMember = nameof(CategoryDTO.CategoryName);
        cb_Category.ValueMember = nameof(CategoryDTO.CategoryID);
        cb_Category.SelectedIndex = -1;
        MenuSelectedByRow(0);
        CategorySelectedByRow(0);
        TableSelectedByRow(0);
    }

    private void LoadData()
    {
        dgv_FoodMenu.DataSource = MenuBUS.Instance.GetMenus();
        dgv_FoodMenu.Columns[nameof(MenuDTO.CategoryID)].Visible = false;

        DataGridViewRow row = dgv_FoodMenu.Rows[0];
        txt_FoodID.Text = row.Cells[nameof(MenuDTO.MenuID)].Value.ToString();
        txt_FoodName.Text = row.Cells[nameof(MenuDTO.MenuName)].Value.ToString();
        txt_Price.Text = row.Cells[nameof(MenuDTO.Price)].Value.ToString();
        txt_Description.Text = row.Cells[nameof(MenuDTO.Description)].Value.ToString();
        cb_Category.SelectedValue = row.Cells[nameof(MenuDTO.CategoryID)].Value;

        dgv_Category.DataSource = CategoryBUS.Instance.GetCategories();
        dgv_Table.DataSource = TableBUS.Instance.GetTables();
    }

    #region Menu
    private void btn_TimMenu_Click(object sender, EventArgs e)
    {
        dgv_FoodMenu.DataSource = MenuBUS.Instance.GetMenus(txt_TimMenu.Text);
    }
    private void btn_ThemMenu_Click(object sender, EventArgs e)
    {
        MenuDTO menuDTO = new()
        {
            MenuName = txt_FoodName.Text,
            Description = txt_Description.Text,
            Price = Convert.ToInt64(txt_Price.Text.RemoveCommas()),
            CategoryID = Convert.ToInt32(cb_Category.SelectedValue)
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
    private void btn_SuaMenu_Click(object sender, EventArgs e)
    {
        MenuDTO menuDTO = new()
        {
            MenuID = Convert.ToInt32(txt_FoodID.Text),
            MenuName = txt_FoodName.Text,
            Description = txt_Description.Text,
            Price = Convert.ToInt64(txt_Price.Text.RemoveCommas()),
            CategoryID = Convert.ToInt32(cb_Category.SelectedValue)
        };
        bool result = MenuBUS.Instance.UpdateMenu(menuDTO);
        if (!result)
        {
            MessageBox.Show("Cập nhật menu thất bại");
            return;
        }
        LoadData();
    }

    private void btn_XoaMenu_Click(object sender, EventArgs e)
    {
        bool result = MenuBUS.Instance.DeleteMenu(Convert.ToInt32(txt_FoodID.Text));
        if (!result)
        {
            MessageBox.Show("Xoá menu thất bại");
            return;
        }
        ResetForm();
        LoadData();
    }
    private void btn_resetMenu_Click(object sender, EventArgs e)
    {
        ResetForm();
    }

    private void ResetForm()
    {
        txt_FoodID.Text = string.Empty;
        txt_FoodName.Text = string.Empty;
        txt_Price.Text = string.Empty;
        txt_Description.Text = string.Empty;
        cb_Category.SelectedIndex = -1;

        txt_CategoryID.Text = string.Empty;
        txt_CategoryName.Text = string.Empty;
        txt_Note.Text = string.Empty;

        txt_TableID.Text = string.Empty;
        txt_TableName.Text = string.Empty;
        txt_Booking.Text = string.Empty;
    }

    private void dgv_FoodMenu_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        MenuSelectedByRow(e.RowIndex);
    }
    private void MenuSelectedByRow(int rowIndex)
    {
        DataGridViewRow row = dgv_FoodMenu.Rows[rowIndex];
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
    #endregion

    #region Category
    private void btn_TimCategory_Click(object sender, EventArgs e)
    {
        dgv_Category.DataSource = CategoryBUS.Instance.GetCategory(txt_TimCategory.Text);
    }

    private void btn_ThemCategory_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txt_CategoryName.Text))
        {
            MessageBox.Show("Vui lòng nhập tên danh mục");
            return;
        }
        CategoryDTO cateDTO = new()
        {
            CategoryName = txt_CategoryName.Text,
            Note = txt_Note.Text
        };
        bool result = CategoryBUS.Instance.InsertCategory(cateDTO);

        if (!result)
        {
            MessageBox.Show("Thêm danh mục thất bại");
            return;
        }
        LoadData();
        ResetForm();
    }
    private void btn_SuaCategory_Click(object sender, EventArgs e)
    {
        CategoryDTO categoryDTO = new()
        {
            CategoryID = Convert.ToInt32(txt_CategoryID.Text),
            CategoryName = txt_CategoryName.Text,
            Note = txt_Note.Text
        };
        bool result = CategoryBUS.Instance.UpdateCategory(categoryDTO);

        if (!result)
        {
            MessageBox.Show("Cập nhật danh mục thất bại !");
            return;
        }
        LoadData();
    }

    private void btn_resetCategoryClick(object sender, EventArgs e)
    {
        ResetForm();
    }

    private void btn_XoaCategory_Click(object sender, EventArgs e)
    {
        bool result = CategoryBUS.Instance.DeleteCategory(Convert.ToInt32(txt_CategoryID.Text));
        if (!result)
        {
            MessageBox.Show("Xoá danh mục thất bại");
            return;
        }
        LoadData();
    }

    private void dgv_Category_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        CategorySelectedByRow(e.RowIndex);
    }

    private void CategorySelectedByRow(int rowIndex)
    {
        DataGridViewRow row = dgv_Category.Rows[rowIndex];
        txt_CategoryID.Text = row.Cells[nameof(CategoryDTO.CategoryID)].Value.ToString();
        txt_CategoryName.Text = row.Cells[nameof(CategoryDTO.CategoryName)].Value.ToString();
        txt_Note.Text = row.Cells[nameof(CategoryDTO.Note)].Value?.ToString();
    }
    #endregion

    #region Table
    private void btn_ThemTable_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txt_TableName.Text))
        {
            MessageBox.Show("Vui lòng nhập tên bàn");
            return;
        }
        TableDTO tableDTO = new()
        {
            TableName = txt_TableName.Text,
        };
        bool result = TableBUS.Instance.InsertTable(tableDTO);

        if (!result)
        {
            MessageBox.Show("Thêm bàn ăn thất bại");
            return;
        }
        LoadData();
        ResetForm();
    }

    private void btn_SuaTable_Click(object sender, EventArgs e)
    {
        TableDTO tableDTO = new()
        {
            TableID = Convert.ToInt32(txt_TableID.Text),
            TableName = txt_TableName.Text,
        };
        bool result = TableBUS.Instance.UpdateTable(tableDTO);

        if (!result)
        {
            MessageBox.Show("Cập nhật bàn ăn thất bại !");
            return;
        }
        LoadData();
    }

    private void btn_XoaTable_Click(object sender, EventArgs e)
    {
        bool result = TableBUS.Instance.DeleteTable(Convert.ToInt32(txt_TableID.Text));
        if (!result)
        {
            MessageBox.Show("Xoá bàn ăn thất bại !!! ");
            return;
        }
        LoadData();
    }

    private void btn_resetTable_Click(object sender, EventArgs e)
    {
        ResetForm();
    }

    private void btn_TimTable_Click(object sender, EventArgs e)
    {
        dgv_Table.DataSource = TableBUS.Instance.GetTable(txt_TimTable.Text);
    }

    private void dgv_Table_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        TableSelectedByRow(e.RowIndex);
    }
    private void TableSelectedByRow(int rowIndex)
    {
        DataGridViewRow row = dgv_Table.Rows[rowIndex];
        txt_TableID.Text = row.Cells[nameof(TableDTO.TableID)].Value.ToString();
        txt_TableName.Text = row.Cells[nameof(TableDTO.TableName)].Value.ToString();
        txt_Booking.Text = Convert.ToBoolean(row.Cells[nameof(TableDTO.BookingStatus)].Value.ToString()) ? "Có người" : "Trống";
    }
    #endregion


}
