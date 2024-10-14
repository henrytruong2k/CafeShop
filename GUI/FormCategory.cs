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
        CategoryDTO cateDTO = new()
        {
            CategoryName = txt_CategoryName.Text,
            Note = txt_Note.Text
        };
        bool result = CategoryBUS.Instance.InsertCategory(cateDTO);

        if (!result)
        {
            MessageBox.Show("Thêm menu thất bại");
            return;
        }
        LoadData();
        ResetForm();
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
        //bool result = CategoryBUS.Instance.DeleteMenu(Convert.ToInt32(txt_CategoryID.Text));
        //if (!result)
        //{
        //    MessageBox.Show("Xoá danh mục thất bại");
        //    return;
        //}
        //ResetForm();
        //LoadData();
    }



}
