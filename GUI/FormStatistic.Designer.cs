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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistic));
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Bill).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 129);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 16);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
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
            panel2.Location = new Point(3, 60);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 41);
            panel2.TabIndex = 3;
            // 
            // btn_Search
            // 
            btn_Search.Image = (Image)resources.GetObject("btn_Search.Image");
            btn_Search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Search.Location = new Point(419, 4);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(73, 31);
            btn_Search.TabIndex = 5;
            btn_Search.Text = "Tìm";
            btn_Search.TextAlign = ContentAlignment.MiddleRight;
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // dtp_ToDate
            // 
            dtp_ToDate.CustomFormat = "dd/MM/yyyy";
            dtp_ToDate.Format = DateTimePickerFormat.Custom;
            dtp_ToDate.Location = new Point(281, 7);
            dtp_ToDate.Margin = new Padding(3, 4, 3, 4);
            dtp_ToDate.Name = "dtp_ToDate";
            dtp_ToDate.Size = new Size(109, 27);
            dtp_ToDate.TabIndex = 4;
            // 
            // dtp_FromDate
            // 
            dtp_FromDate.CustomFormat = "dd/MM/yyyy";
            dtp_FromDate.Format = DateTimePickerFormat.Custom;
            dtp_FromDate.Location = new Point(74, 7);
            dtp_FromDate.Margin = new Padding(3, 4, 3, 4);
            dtp_FromDate.Name = "dtp_FromDate";
            dtp_FromDate.Size = new Size(109, 27);
            dtp_FromDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 12);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày:";
            // 
            // dgv_Bill
            // 
            dgv_Bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Bill.Location = new Point(14, 165);
            dgv_Bill.Margin = new Padding(3, 4, 3, 4);
            dgv_Bill.Name = "dgv_Bill";
            dgv_Bill.RowHeadersWidth = 51;
            dgv_Bill.Size = new Size(887, 463);
            dgv_Bill.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 645);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 2;
            label4.Text = "Số dòng hiển thị:";
            // 
            // cbo_selectedLines
            // 
            cbo_selectedLines.FormattingEnabled = true;
            cbo_selectedLines.Location = new Point(133, 641);
            cbo_selectedLines.Margin = new Padding(3, 4, 3, 4);
            cbo_selectedLines.Name = "cbo_selectedLines";
            cbo_selectedLines.Size = new Size(75, 28);
            cbo_selectedLines.TabIndex = 3;
            cbo_selectedLines.SelectedIndexChanged += cbo_selectedLines_SelectedIndexChanged;
            // 
            // btn_previous
            // 
            btn_previous.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_previous.Location = new Point(623, 641);
            btn_previous.Margin = new Padding(3, 4, 3, 4);
            btn_previous.Name = "btn_previous";
            btn_previous.Size = new Size(35, 31);
            btn_previous.TabIndex = 4;
            btn_previous.Text = "<<";
            btn_previous.UseVisualStyleBackColor = true;
            btn_previous.Click += btn_previous_Click;
            // 
            // btn_next
            // 
            btn_next.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_next.Location = new Point(698, 641);
            btn_next.Margin = new Padding(3, 4, 3, 4);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(35, 31);
            btn_next.TabIndex = 5;
            btn_next.Text = ">>";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // txt_pageNumber
            // 
            txt_pageNumber.Location = new Point(665, 641);
            txt_pageNumber.Margin = new Padding(3, 4, 3, 4);
            txt_pageNumber.Name = "txt_pageNumber";
            txt_pageNumber.Size = new Size(26, 27);
            txt_pageNumber.TabIndex = 6;
            txt_pageNumber.Text = "1";
            // 
            // lbl_totalPages
            // 
            lbl_totalPages.AutoSize = true;
            lbl_totalPages.Location = new Point(741, 647);
            lbl_totalPages.Name = "lbl_totalPages";
            lbl_totalPages.Size = new Size(85, 20);
            lbl_totalPages.TabIndex = 7;
            lbl_totalPages.Text = "Tổng trang:";
            // 
            // FormStatistic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 689);
            Controls.Add(lbl_totalPages);
            Controls.Add(txt_pageNumber);
            Controls.Add(btn_next);
            Controls.Add(btn_previous);
            Controls.Add(cbo_selectedLines);
            Controls.Add(label4);
            Controls.Add(dgv_Bill);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormStatistic";
            Text = "FormStatistic";
            Load += FormStatistic_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Bill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DateTimePicker dtp_FromDate;
        private Label label1;
        private Panel panel2;
        private DateTimePicker dtp_ToDate;
        private Label label3;
        private Button btn_Search;
        private DataGridView dgv_Bill;
        private Label label4;
        private ComboBox cbo_selectedLines;
        private Button btn_previous;
        private Button btn_next;
        private TextBox txt_pageNumber;
        private Label lbl_totalPages;
    }
}