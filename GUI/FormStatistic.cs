using CafeShop.Utils;
using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace CafeShop.GUI;

public partial class FormStatistic : Form
{
    private int _pageSize = 5;
    private int _pageNumber = 1;
    private int _totalRecords = 0;

    public FormStatistic()
    {
        InitializeComponent();
    }

    private void FormStatistic_Load(object sender, EventArgs e)
    {
        int[] lines = [5, 10, 20, 100];
        cbo_selectedLines.DataSource = lines;
        btn_previous.Enabled = btn_next.Enabled = false;
    }

    private void btn_Search_Click(object sender, EventArgs e)
    {
        string from = dtp_FromDate.Value.ToString("yyyy-MM-dd");
        string to = dtp_ToDate.Value.ToString("yyyy-MM-dd");
        _pageNumber = int.TryParse(txt_pageNumber.Text, out int parsedInt) ? parsedInt : 1;
        int offset = (_pageNumber - 1) * _pageSize;
        int limit = _pageSize;
        (List<BillStatisticDTO> list, _totalRecords) = BillBUS.Instance.GetListBillByDate(from, to, offset, limit);
        PaginationHandler();
        dgv_Bill.DataSource = list;
    }

    private void PaginationHandler()
    {
        int totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
        btn_previous.Enabled = _pageNumber > 1;
        btn_next.Enabled = _pageNumber < totalPages;
        lbl_totalPages.Text = $"Tổng trang: {totalPages} ({_totalRecords} bản ghi)";
    }

    private void cbo_selectedLines_SelectedIndexChanged(object sender, EventArgs e)
    {
        _pageSize = (int)cbo_selectedLines.SelectedItem;
        PaginationHandler();
    }

    private void btn_next_Click(object sender, EventArgs e)
    {
        txt_pageNumber.Text = (int.Parse(txt_pageNumber.Text) + 1).ToString();
        btn_Search_Click(sender, e);
    }

    private void btn_previous_Click(object sender, EventArgs e)
    {
        txt_pageNumber.Text = (int.Parse(txt_pageNumber.Text) - 1).ToString();
        btn_Search_Click(sender, e);
    }


    private void tabControl1_Click(object sender, EventArgs e)
    {
        if (tabControl1.SelectedTab.Text == "Doanh thu")
        {
            int currentMonth = DateTime.Now.Month;
            List<DailyRevenueDTO> dailyRevenues = BillBUS.Instance.GetDailyRevenues(currentMonth);
            chartRevenue.Titles.Clear();
            chartRevenue.Titles.Add($"Doanh thu tháng {currentMonth}");

            chartRevenue.Series.Clear();
            Series series = chartRevenue.Series.Add("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.Blue;
            for (int i = 0; i < dailyRevenues.Count; i++)
            {
                series.Points.AddXY(int.Parse(dailyRevenues[i].RevenueDate.ToString("dd")), dailyRevenues[i].DailyRevenue);
                series.Points[i].Label = dailyRevenues[i].DailyRevenue.ToVND();
                series.Points[i].AxisLabel = dailyRevenues[i].RevenueDate.ToString("dd");
            }
            chartRevenue.ChartAreas[0].AxisX.Title = "Ngày";
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
        }
    }
}
