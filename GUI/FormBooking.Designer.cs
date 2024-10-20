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
            hid_totalPrice = new Label();
            cbo_MergeTable = new ComboBox();
            btn_MergeTable = new Button();
            txt_totalPrice = new Label();
            label10 = new Label();
            nm_Discount = new NumericUpDown();
            button3 = new Button();
            btn_Checkout = new Button();
            cbo_SwitchTable = new ComboBox();
            btn_switchTable = new Button();
            flpTable = new FlowLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_quantity).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_Discount).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lvMenuItem);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(473, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 575);
            panel2.TabIndex = 1;
            // 
            // lvMenuItem
            // 
            lvMenuItem.BackColor = SystemColors.Window;
            lvMenuItem.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvMenuItem.FullRowSelect = true;
            lvMenuItem.GridLines = true;
            lvMenuItem.Location = new Point(12, 74);
            lvMenuItem.Name = "lvMenuItem";
            lvMenuItem.Size = new Size(484, 399);
            lvMenuItem.TabIndex = 13;
            lvMenuItem.UseCompatibleStateImageBehavior = false;
            lvMenuItem.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 220;
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
            panel3.Size = new Size(487, 61);
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
            btn_Add.Location = new Point(399, 5);
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
            panel5.Controls.Add(hid_totalPrice);
            panel5.Controls.Add(cbo_MergeTable);
            panel5.Controls.Add(btn_MergeTable);
            panel5.Controls.Add(txt_totalPrice);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(nm_Discount);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(btn_Checkout);
            panel5.Controls.Add(cbo_SwitchTable);
            panel5.Controls.Add(btn_switchTable);
            panel5.Location = new Point(486, 494);
            panel5.Name = "panel5";
            panel5.Size = new Size(483, 80);
            panel5.TabIndex = 12;
            // 
            // hid_totalPrice
            // 
            hid_totalPrice.AutoSize = true;
            hid_totalPrice.Location = new Point(296, 58);
            hid_totalPrice.Name = "hid_totalPrice";
            hid_totalPrice.Size = new Size(0, 15);
            hid_totalPrice.TabIndex = 17;
            hid_totalPrice.Visible = false;
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
            txt_totalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_totalPrice.Location = new Point(292, 33);
            txt_totalPrice.Name = "txt_totalPrice";
            txt_totalPrice.Size = new Size(19, 21);
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
            // nm_Discount
            // 
            nm_Discount.Location = new Point(200, 33);
            nm_Discount.Name = "nm_Discount";
            nm_Discount.Size = new Size(86, 23);
            nm_Discount.TabIndex = 12;
            nm_Discount.ValueChanged += nm_Discount_ValueChanged;
            // 
            // button3
            // 
            button3.Location = new Point(200, 11);
            button3.Name = "button3";
            button3.Size = new Size(86, 23);
            button3.TabIndex = 11;
            button3.Text = "Giảm giá (%)";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn_Checkout
            // 
            btn_Checkout.Location = new Point(395, 3);
            btn_Checkout.Name = "btn_Checkout";
            btn_Checkout.Size = new Size(85, 53);
            btn_Checkout.TabIndex = 10;
            btn_Checkout.Text = "Thanh toán";
            btn_Checkout.UseVisualStyleBackColor = true;
            btn_Checkout.Click += btn_Checkout_Click;
            // 
            // cbo_SwitchTable
            // 
            cbo_SwitchTable.FormattingEnabled = true;
            cbo_SwitchTable.Location = new Point(2, 33);
            cbo_SwitchTable.Name = "cbo_SwitchTable";
            cbo_SwitchTable.Size = new Size(93, 23);
            cbo_SwitchTable.TabIndex = 9;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nm_quantity).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nm_Discount).EndInit();
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
        private NumericUpDown nm_Discount;
        private Button button3;
        private Button btn_Checkout;
        private ComboBox cbo_SwitchTable;
        private Button btn_switchTable;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label9;
        private TextBox txt_Price;
        private Label txt_totalPrice;
        private Label label10;
        private ComboBox cbo_MergeTable;
        private Button btn_MergeTable;
        private Label hid_totalPrice;
    }
}