namespace CafeShop.GUI;

public partial class FormRole : Form
{
    public FormRole()
    {
        InitializeComponent();
    }
    private void FormRole_Load(object sender, EventArgs e)
    {
        LoadData();
        RoleSelectedByRow(0);
    }
    private void LoadData()
    {
        dgv_Role.DataSource = RoleBUS.Instance.GetRoles();
    }
    private void btn_ThemRole_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txt_RoleName.Text))
        {
            MessageBox.Show("Vui lòng nhập tên vai tro !");
            return;
        }
        RoleDTO roleDTO = new()
        {
            RoleName = txt_RoleName.Text,
            Note = txt_Note.Text
        };
        bool result = RoleBUS.Instance.InsertRole(roleDTO);

        if (!result)
        {
            MessageBox.Show("Thêm vai tro thất bại");
            return;
        }
        LoadData();
        ResetForm();
    }

    private void btn_SuaRole_Click(object sender, EventArgs e)
    {
        RoleDTO roleDTO = new()
        {
            RoleID = Convert.ToInt32(txt_RoleID.Text),
            RoleName = txt_RoleName.Text,
            Note = txt_Note.Text
        };
        bool result = RoleBUS.Instance.UpdateRole(roleDTO);

        if (!result)
        {
            MessageBox.Show("Cập nhật danh mục thất bại !");
            return;
        }
        LoadData();
    }

    private void btn_XoaRole_Click(object sender, EventArgs e)
    {
        bool result = RoleBUS.Instance.DeleteRole(Convert.ToInt32(txt_RoleID.Text));
        if (!result)
        {
            MessageBox.Show("Xoá vai tro  thất bại");
            return;
        }
        LoadData();
        ResetForm();
    }

    private void btn_reset_Click(object sender, EventArgs e)
    {
        ResetForm();
    }
    private void ResetForm()
    {
        txt_RoleID.Text = string.Empty;
        txt_RoleName.Text = string.Empty;
        txt_Note.Text = string.Empty;
    }
    private void dgv_Role_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        RoleSelectedByRow(e.RowIndex);
    }
    private void RoleSelectedByRow(int rowIndex)
    {
        DataGridViewRow row = dgv_Role.Rows[rowIndex];
        txt_RoleID.Text = row.Cells[nameof(RoleDTO.RoleID)].Value.ToString();
        txt_RoleName.Text = row.Cells[nameof(RoleDTO.RoleName)].Value.ToString();
        txt_Note.Text = row.Cells[nameof(RoleDTO.Note)].Value.ToString();
    }

    private void btn_TimRole_Click(object sender, EventArgs e)
    {
        dgv_Role.DataSource = RoleBUS.Instance.GetRole(txt_TimRole.Text);
    }
}
