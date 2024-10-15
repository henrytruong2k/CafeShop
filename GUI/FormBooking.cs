namespace CafeShop.GUI;

public partial class FormBooking : Form
{
    public FormBooking()
    {
        InitializeComponent();
    }

    private void FormBooking_Load(object sender, EventArgs e)
    {
        LoadTables();
        LoadCategories();
    }

    private void LoadCategories()
    {
        cbo_Category.DataSource = CategoryBUS.Instance.GetCategories();
        cbo_Category.ValueMember = nameof(CategoryDTO.CategoryID);
        cbo_Category.DisplayMember = nameof(CategoryDTO.CategoryName);
        cbo_Category.SelectedIndex = -1;
    }

    private void LoadMenusByCategoryID(int categoryID)
    {
        cbo_Menu.DataSource = MenuBUS.Instance.GetMenusByCategoryID(categoryID);
        cbo_Menu.ValueMember = nameof(MenuDTO.MenuID);
        cbo_Menu.DisplayMember = nameof(MenuDTO.MenuName);
    }

    private void LoadTables()
    {
        List<TableDTO> tables = TableBUS.Instance.LoadTables();
        foreach (TableDTO table in tables)
        {
            Button btn = new()
            {
                Width = 100,
                Height = 100,
                Text = table.TableName + Environment.NewLine + table.BookingStatus switch
                {
                    true => "Có người",
                    false => "Trống"
                },
                BackColor = table.BookingStatus switch
                {
                    true => Color.Aqua,
                    false => Color.LightGray
                },
                Tag = table
            };
            btn.Click += btn_Click;

            flpTable.Controls.Add(btn);
        }
    }

    private void ShowBill(int tableID)
    {
        lvMenuItem.Items.Clear();

    }

    private void btn_Click(object sender, EventArgs e)
    {
        int tableID = ((sender as Button).Tag as TableDTO).TableID;
        ShowBill(tableID);
    }


    private void btn_Add_Click(object sender, EventArgs e)
    {

    }

    private void cbo_Category_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_Category.SelectedIndex is 0 or -1) return;
        LoadMenusByCategoryID(Convert.ToInt32(cbo_Category.SelectedValue));
    }
}
