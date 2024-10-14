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
                Text = table.TableName + Environment.NewLine + table.BookingStatus switch { 
                    true => "Có người",
                    false => "Trống"
                },
                BackColor = table.BookingStatus switch
                {
                    true => Color.Aqua,
                    false => Color.LightGray
                }

            };

            flpTable.Controls.Add(btn);
        }
    }
}
