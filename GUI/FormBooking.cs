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
}
