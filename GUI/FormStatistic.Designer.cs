namespace CafeShop.GUI
{
    partial class FormStatistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            btn_Search = new Button();
            dtp_ToDate = new DateTimePicker();
            dtp_FromDate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dgv_Bill = new DataGridView();
            label4 = new Label();
            cbo_selectedLines = new ComboBox();
            btn_previous = new Button();
            btn_next = new Button();
            txt_pageNumber = new TextBox();
            lbl_totalPages = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            tabPage2 = new TabPage();
            chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage3 = new TabPage();
            chartTopMenuItem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Bill).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTopMenuItem).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(7, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 97);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(293, 12);
            label3.Name = "label3";
            label3.Size = new Size(200, 30);
            label3.TabIndex = 4;
            label3.Text = "Thống kê hóa đơn";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Search);
            panel2.Controls.Add(dtp_ToDate);
            panel2.Controls.Add(dtp_FromDate);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 31);
            panel2.TabIndex = 3;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(348, 5);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(75, 23);
            btn_Search.TabIndex = 5;
            btn_Search.Text = "Tìm kiếm";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // dtp_ToDate
            // 
            dtp_ToDate.CustomFormat = "dd/MM/yyyy";
            dtp_ToDate.Format = DateTimePickerFormat.Custom;
            dtp_ToDate.Location = new Point(246, 5);
            dtp_ToDate.Name = "dtp_ToDate";
            dtp_ToDate.Size = new Size(96, 23);
            dtp_ToDate.TabIndex = 4;
            // 
            // dtp_FromDate
            // 
            dtp_FromDate.CustomFormat = "dd/MM/yyyy";
            dtp_FromDate.Format = DateTimePickerFormat.Custom;
            dtp_FromDate.Location = new Point(65, 5);
            dtp_FromDate.Name = "dtp_FromDate";
            dtp_FromDate.Size = new Size(96, 23);
            dtp_FromDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 9);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày:";
            // 
            // dgv_Bill
            // 
            dgv_Bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Bill.Location = new Point(7, 107);
            dgv_Bill.Name = "dgv_Bill";
            dgv_Bill.RowHeadersWidth = 51;
            dgv_Bill.Size = new Size(773, 314);
            dgv_Bill.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 21);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 2;
            label4.Text = "Số dòng hiển thị:";
            // 
            // cbo_selectedLines
            // 
            cbo_selectedLines.FormattingEnabled = true;
            cbo_selectedLines.Location = new Point(115, 18);
            cbo_selectedLines.Name = "cbo_selectedLines";
            cbo_selectedLines.Size = new Size(66, 23);
            cbo_selectedLines.TabIndex = 3;
            cbo_selectedLines.SelectedIndexChanged += cbo_selectedLines_SelectedIndexChanged;
            // 
            // btn_previous
            // 
            btn_previous.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_previous.Location = new Point(471, 17);
            btn_previous.Name = "btn_previous";
            btn_previous.Size = new Size(31, 23);
            btn_previous.TabIndex = 4;
            btn_previous.Text = "<<";
            btn_previous.UseVisualStyleBackColor = true;
            btn_previous.Click += btn_previous_Click;
            // 
            // btn_next
            // 
            btn_next.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_next.Location = new Point(537, 17);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(31, 23);
            btn_next.TabIndex = 5;
            btn_next.Text = ">>";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // txt_pageNumber
            // 
            txt_pageNumber.Location = new Point(508, 18);
            txt_pageNumber.Name = "txt_pageNumber";
            txt_pageNumber.Size = new Size(23, 23);
            txt_pageNumber.TabIndex = 6;
            txt_pageNumber.Text = "1";
            // 
            // lbl_totalPages
            // 
            lbl_totalPages.AutoSize = true;
            lbl_totalPages.Location = new Point(579, 21);
            lbl_totalPages.Name = "lbl_totalPages";
            lbl_totalPages.Size = new Size(68, 15);
            lbl_totalPages.TabIndex = 7;
            lbl_totalPages.Text = "Tổng trang:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 513);
            tabControl1.TabIndex = 8;
            tabControl1.Click += tabControl1_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dgv_Bill);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 485);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hóa đơn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cbo_selectedLines);
            panel3.Controls.Add(lbl_totalPages);
            panel3.Controls.Add(btn_next);
            panel3.Controls.Add(btn_previous);
            panel3.Controls.Add(txt_pageNumber);
            panel3.Location = new Point(7, 427);
            panel3.Name = "panel3";
            panel3.Size = new Size(773, 52);
            panel3.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(chartRevenue);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 485);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Doanh thu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartRevenue
            // 
            chartArea3.Name = "ChartArea1";
            chartRevenue.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartRevenue.Legends.Add(legend3);
            chartRevenue.Location = new Point(16, 6);
            chartRevenue.Name = "chartRevenue";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartRevenue.Series.Add(series3);
            chartRevenue.Size = new Size(766, 473);
            chartRevenue.TabIndex = 0;
            chartRevenue.Text = "chart1";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(chartTopMenuItem);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(789, 485);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Menu";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartTopMenuItem
            // 
            chartArea4.Name = "ChartArea1";
            chartTopMenuItem.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartTopMenuItem.Legends.Add(legend4);
            chartTopMenuItem.Location = new Point(99, 46);
            chartTopMenuItem.Name = "chartTopMenuItem";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartTopMenuItem.Series.Add(series4);
            chartTopMenuItem.Size = new Size(524, 298);
            chartTopMenuItem.TabIndex = 0;
            chartTopMenuItem.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Thống kê top 5 món bán chạy nhất";
            chartTopMenuItem.Titles.Add(title2);
            // 
            // FormStatistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 517);
            Controls.Add(tabControl1);
            Name = "FormStatistic";
            Text = "FormStatistic";
            Load += FormStatistic_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Bill).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRevenue).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartTopMenuItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DateTimePicker dtp_FromDate;
        private Label label1;
        private Panel panel2;
        private DateTimePicker dtp_ToDate;
        private Label label3;
        private DataGridView dgv_Bill;
        private Label label4;
        private ComboBox cbo_selectedLines;
        private Button btn_previous;
        private Button btn_next;
        private TextBox txt_pageNumber;
        private Label lbl_totalPages;
        private Button btn_Search;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopMenuItem;
    }
}