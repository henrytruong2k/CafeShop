namespace CafeShop.GUI
{
    partial class FormBooking
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
            panel2 = new Panel();
            panel1 = new Panel();
            lbl_Username = new Label();
            lbl_TableID = new Label();
            lbl_Checkout = new Label();
            lbl_Checkin = new Label();
            lbl_BillID = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lvMenuItem = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            label9 = new Label();
            txt_Price = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btn_Add = new Button();
            nm_quantity = new NumericUpDown();
            label1 = new Label();
            cbo_Category = new ComboBox();
            cbo_Menu = new ComboBox();
            panel5 = new Panel();
            cbo_MergeTable = new ComboBox();
            btn_MergeTable = new Button();
            txt_totalPrice = new Label();
            label10 = new Label();
            numericUpDown2 = new NumericUpDown();
            button3 = new Button();
            button2 = new Button();
            cbo_SwitchTable = new ComboBox();
            btn_switchTable = new Button();
            flpTable = new FlowLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_quantity).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(lvMenuItem);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(473, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 575);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_Username);
            panel1.Controls.Add(lbl_TableID);
            panel1.Controls.Add(lbl_Checkout);
            panel1.Controls.Add(lbl_Checkin);
            panel1.Controls.Add(lbl_BillID);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(13, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 93);
            panel1.TabIndex = 17;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new Point(299, 38);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(38, 15);
            lbl_Username.TabIndex = 23;
            lbl_Username.Text = "label9";
            // 
            // lbl_TableID
            // 
            lbl_TableID.AutoSize = true;
            lbl_TableID.Location = new Point(299, 14);
            lbl_TableID.Name = "lbl_TableID";
            lbl_TableID.Size = new Size(38, 15);
            lbl_TableID.TabIndex = 22;
            lbl_TableID.Text = "label9";
            // 
            // lbl_Checkout
            // 
            lbl_Checkout.AutoSize = true;
            lbl_Checkout.Location = new Point(92, 65);
            lbl_Checkout.Name = "lbl_Checkout";
            lbl_Checkout.Size = new Size(44, 15);
            lbl_Checkout.TabIndex = 21;
            lbl_Checkout.Text = "label11";
            // 
            // lbl_Checkin
            // 
            lbl_Checkin.AutoSize = true;
            lbl_Checkin.Location = new Point(92, 38);
            lbl_Checkin.Name = "lbl_Checkin";
            lbl_Checkin.Size = new Size(47, 15);
            lbl_Checkin.TabIndex = 20;
            lbl_Checkin.Text = "Giờ vào";
            // 
            // lbl_BillID
            // 
            lbl_BillID.AutoSize = true;
            lbl_BillID.Location = new Point(92, 14);
            lbl_BillID.Name = "lbl_BillID";
            lbl_BillID.Size = new Size(24, 15);
            lbl_BillID.TabIndex = 19;
            lbl_BillID.Text = "Mã";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(227, 38);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 18;
            label8.Text = "Nhân viên:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 14);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 17;
            label7.Text = "Mã hóa đơn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 65);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 16;
            label6.Text = "Giờ ra:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 38);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 15;
            label5.Text = "Giờ vào:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 14);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 14;
            label4.Text = "Bàn:";
            // 
            // lvMenuItem
            // 
            lvMenuItem.AllowColumnReorder = true;
            lvMenuItem.BackColor = SystemColors.Window;
            lvMenuItem.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvMenuItem.FullRowSelect = true;
            lvMenuItem.GridLines = true;
            lvMenuItem.Location = new Point(12, 176);
            lvMenuItem.Name = "lvMenuItem";
            lvMenuItem.Size = new Size(472, 300);
            lvMenuItem.TabIndex = 13;
            lvMenuItem.UseCompatibleStateImageBehavior = false;
            lvMenuItem.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Đơn giá";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số lượng";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 100;
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txt_Price);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btn_Add);
            panel3.Controls.Add(nm_quantity);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cbo_Category);
            panel3.Controls.Add(cbo_Menu);
            panel3.Location = new Point(12, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(473, 61);
            panel3.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(252, 11);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 9;
            label9.Text = "Giá:";
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(286, 8);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(93, 23);
            txt_Price.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(3, 37);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Tên món:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(1, 11);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Danh mục:";
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(385, 5);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(85, 53);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "Thêm món";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // nm_quantity
            // 
            nm_quantity.Location = new Point(286, 34);
            nm_quantity.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nm_quantity.Name = "nm_quantity";
            nm_quantity.Size = new Size(93, 23);
            nm_quantity.TabIndex = 3;
            nm_quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(252, 36);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 4;
            label1.Text = "SL:";
            // 
            // cbo_Category
            // 
            cbo_Category.FormattingEnabled = true;
            cbo_Category.Location = new Point(73, 8);
            cbo_Category.Name = "cbo_Category";
            cbo_Category.Size = new Size(173, 23);
            cbo_Category.TabIndex = 0;
            cbo_Category.SelectedIndexChanged += cbo_Category_SelectedIndexChanged;
            // 
            // cbo_Menu
            // 
            cbo_Menu.FormattingEnabled = true;
            cbo_Menu.Location = new Point(73, 33);
            cbo_Menu.Name = "cbo_Menu";
            cbo_Menu.Size = new Size(173, 23);
            cbo_Menu.TabIndex = 1;
            cbo_Menu.SelectedIndexChanged += cbo_Menu_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(cbo_MergeTable);
            panel5.Controls.Add(btn_MergeTable);
            panel5.Controls.Add(txt_totalPrice);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(numericUpDown2);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(cbo_SwitchTable);
            panel5.Controls.Add(btn_switchTable);
            panel5.Location = new Point(486, 494);
            panel5.Name = "panel5";
            panel5.Size = new Size(473, 80);
            panel5.TabIndex = 12;
            // 
            // cbo_MergeTable
            // 
            cbo_MergeTable.FormattingEnabled = true;
            cbo_MergeTable.Location = new Point(101, 33);
            cbo_MergeTable.Name = "cbo_MergeTable";
            cbo_MergeTable.Size = new Size(93, 23);
            cbo_MergeTable.TabIndex = 16;
            // 
            // btn_MergeTable
            // 
            btn_MergeTable.Location = new Point(101, 10);
            btn_MergeTable.Name = "btn_MergeTable";
            btn_MergeTable.Size = new Size(93, 24);
            btn_MergeTable.TabIndex = 15;
            btn_MergeTable.Text = "Gộp bàn";
            btn_MergeTable.UseVisualStyleBackColor = true;
            btn_MergeTable.Click += btn_MergeTable_Click;
            // 
            // txt_totalPrice
            // 
            txt_totalPrice.AutoSize = true;
            txt_totalPrice.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txt_totalPrice.Location = new Point(292, 33);
            txt_totalPrice.Name = "txt_totalPrice";
            txt_totalPrice.Size = new Size(23, 25);
            txt_totalPrice.TabIndex = 14;
            txt_totalPrice.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(292, 15);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 13;
            label10.Text = "Tổng tiền:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(200, 33);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(86, 23);
            numericUpDown2.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new Point(200, 11);
            button3.Name = "button3";
            button3.Size = new Size(86, 23);
            button3.TabIndex = 11;
            button3.Text = "Giảm giá";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(388, 5);
            button2.Name = "button2";
            button2.Size = new Size(85, 53);
            button2.TabIndex = 10;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbo_SwitchTable
            // 
            cbo_SwitchTable.FormattingEnabled = true;
            cbo_SwitchTable.Location = new Point(2, 33);
            cbo_SwitchTable.Name = "cbo_SwitchTable";
            cbo_SwitchTable.Size = new Size(93, 23);
            cbo_SwitchTable.TabIndex = 9;
            cbo_SwitchTable.SelectedIndexChanged += cbo_SwitchTable_SelectedIndexChanged;
            // 
            // btn_switchTable
            // 
            btn_switchTable.Location = new Point(2, 10);
            btn_switchTable.Name = "btn_switchTable";
            btn_switchTable.Size = new Size(93, 24);
            btn_switchTable.TabIndex = 8;
            btn_switchTable.Text = "Chuyển bàn";
            btn_switchTable.UseVisualStyleBackColor = true;
            btn_switchTable.Click += btn_SwitchTable_Click;
            // 
            // flpTable
            // 
            flpTable.Location = new Point(7, 12);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(460, 575);
            flpTable.TabIndex = 2;
            // 
            // FormBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 599);
            Controls.Add(flpTable);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Name = "FormBooking";
            Text = "FormBooking";
            Load += FormBooking_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nm_quantity).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private NumericUpDown nm_quantity;
        private Button btn_Add;
        private ComboBox cbo_Menu;
        private ComboBox cbo_Category;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flpTable;
        private ListView lvMenuItem;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Panel panel5;
        private NumericUpDown numericUpDown2;
        private Button button3;
        private Button button2;
        private ComboBox cbo_SwitchTable;
        private Button btn_switchTable;
        private Label label6;
        private Label label5;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label lbl_Checkout;
        private Label lbl_Checkin;
        private Label lbl_BillID;
        private Label lbl_Username;
        private Label lbl_TableID;
        private Label label9;
        private TextBox txt_Price;
        private Label txt_totalPrice;
        private Label label10;
        private ComboBox cbo_MergeTable;
        private Button btn_MergeTable;
    }
}