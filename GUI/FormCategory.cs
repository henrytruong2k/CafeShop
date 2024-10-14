namespace CafeShop.GUI;

public partial class FormCategory : Form
{
    public FormCategory()
    {
        InitializeComponent();
    }

    private void FormCategory_Load(object sender, EventArgs e)
    {
        LoadData();
        CategorySelectedByRow(0);

    }
    private void LoadData()
    {
        dgv_Category.DataSource = CategoryBUS.Instance.GetCategories();
    }

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

    private void ResetForm()
    {
        txt_CategoryID.Text = string.Empty;
        txt_CategoryName.Text = string.Empty;
        txt_Note.Text = string.Empty;
    }

    private void btn_reset_Click(object sender, EventArgs e)
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
        ResetForm();
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
        txt_Note.Text = row.Cells[nameof(CategoryDTO.Note)].Value.ToString();
    }
}
