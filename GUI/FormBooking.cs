using CafeShop.Utils;

namespace CafeShop.GUI;

public partial class FormBooking : Form
{
    private bool isLoadingCategories = false;
    public FormBooking()
    {
        InitializeComponent();
    }

    private void FormBooking_Load(object sender, EventArgs e)
    {
        LoadTables();
        LoadCategories();
        btn_switchTable.Enabled = false;
    }

    private void LoadCategories()
    {
        isLoadingCategories = true;
        cbo_Category.DataSource = CategoryBUS.Instance.GetCategories();
        cbo_Category.ValueMember = nameof(CategoryDTO.CategoryID);
        cbo_Category.DisplayMember = nameof(CategoryDTO.CategoryName);
        cbo_Category.SelectedIndex = -1;
        isLoadingCategories = false;
    }

    private void LoadMenusByCategoryID(int categoryID)
    {
        cbo_Menu.DataSource = MenuBUS.Instance.GetMenusByCategoryID(categoryID);
        cbo_Menu.ValueMember = nameof(MenuDTO.MenuID);
        cbo_Menu.DisplayMember = nameof(MenuDTO.MenuName);
        cbo_Menu.SelectedIndex = -1;
        txt_Price.Text = string.Empty;
    }

    private void LoadSwitchableTables(int tableID)
    {
        cbo_SwitchTable.DataSource = TableBUS.Instance.LoadSwitchableTables(tableID);
        cbo_SwitchTable.ValueMember = nameof(TableDTO.TableID);
        cbo_SwitchTable.DisplayMember = nameof(TableDTO.TableName);
        cbo_SwitchTable.SelectedItem = -1;
    }

    private void LoadTables()
    {
        flpTable.Controls.Clear();
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
        List<BillTempDTO> listTempBill = BillBUS.Instance.GetListTempBillByTableID(tableID);

        long totalPrice = 0;
        foreach (BillTempDTO item in listTempBill)
        {
            ListViewItem lsvItem = new(item.MenuName);
            lsvItem.SubItems.Add(item.Price.ToVND());
            lsvItem.SubItems.Add(item.Quantity.ToString());
            lsvItem.SubItems.Add(item.TotalPrice.ToVND());

            totalPrice += item.TotalPrice;
            lvMenuItem.Items.Add(lsvItem);
        }
        txt_totalPrice.Text = totalPrice.ToVND();
    }

    private void btn_Click(object sender, EventArgs e)
    {
        int tableID = ((sender as Button).Tag as TableDTO).TableID;
        lvMenuItem.Tag = (sender as Button).Tag;
        ShowBill(tableID);
        LoadSwitchableTables(tableID);
        btn_switchTable.Enabled = true;
    }


    private void btn_Add_Click(object sender, EventArgs e)
    {
        TableDTO table = lvMenuItem.Tag as TableDTO;
        if (table == null)
        {
            MessageBox.Show("Hãy chọn bàn");
            return;
        }
        if (nm_quantity.Value == 0)
        {
            return;
        }
        int billID = BillBUS.Instance.GetUnCheckBillIDByTableID(table.TableID);
        if (cbo_Menu.SelectedIndex == -1)
        {
            MessageBox.Show("Hãy chọn món");
            return;
        }

        int menuID = Convert.ToInt32(cbo_Menu.SelectedValue);
        int quantity = Convert.ToInt32(nm_quantity.Value);
        long price = Convert.ToInt64(txt_Price.Text);
        if (billID == -1)
        {
            BillBUS.Instance.InsertBill(table.TableID, menuID, price, quantity);
        }
        else
        {
            BillDetailBus.Instance.InsertBillDetail(billID, menuID, price, quantity);
        }
        ShowBill(table.TableID);
        LoadTables();
        LoadCategories();
    }

    private void cbo_Category_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!isLoadingCategories)
        {
            LoadMenusByCategoryID(Convert.ToInt32(cbo_Category.SelectedValue.ToString()));
        }
    }

    private void cbo_Menu_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_Menu.SelectedItem != null)
        {
            MenuDTO selectedItem = (MenuDTO)cbo_Menu.SelectedItem;
            txt_Price.Text = selectedItem.Price.ToString();
        }
    }

    private void cbo_SwitchTable_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btn_SwitchTable_Click(object sender, EventArgs e)
    {
        int tableID1 = (lvMenuItem.Tag as TableDTO).TableID;
        if (cbo_SwitchTable.SelectedValue == null)
        {
            MessageBox.Show("Hãy chọn bàn muốn chuyển");
            return;
        }
        int tableID2 = (int)cbo_SwitchTable.SelectedValue;
        string msg = $"Bạn có thật sự muốn chuyển {(lvMenuItem.Tag as TableDTO).TableName} sang {cbo_SwitchTable.Text}";
        bool isOK = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK;
        if (isOK)
        {
            TableBUS.Instance.SwitchTable(tableID1, tableID2);
            LoadTables();
            LoadCategories();
            btn_switchTable.Enabled = false;
        }
    }
}
