namespace CafeShop.GUI
{
    partial class FormMenu
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
            panel1 = new Panel();
            panel5 = new Panel();
            txt_Description = new TextBox();
            label5 = new Label();
            btn_reset = new Button();
            btn_XoaMenu = new Button();
            txt_Price = new TextBox();
            btn_SuaMenu = new Button();
            cb_Category = new ComboBox();
            btn_ThemMenu = new Button();
            txt_FoodName = new TextBox();
            txt_FoodID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            btn_TimMenu = new Button();
            txt_TimMenu = new TextBox();
            panel3 = new Panel();
            dgv_FoodMenu = new DataGridView();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_FoodMenu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(8, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 486);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(txt_Description);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(btn_reset);
            panel5.Controls.Add(btn_XoaMenu);
            panel5.Controls.Add(txt_Price);
            panel5.Controls.Add(btn_SuaMenu);
            panel5.Controls.Add(cb_Category);
            panel5.Controls.Add(btn_ThemMenu);
            panel5.Controls.Add(txt_FoodName);
            panel5.Controls.Add(txt_FoodID);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(677, 82);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(340, 421);
            panel5.TabIndex = 3;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(156, 117);
            txt_Description.Margin = new Padding(3, 2, 3, 2);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(164, 74);
            txt_Description.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(17, 115);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 9;
            label5.Text = "Mô tả:";
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(242, 297);
            btn_reset.Margin = new Padding(3, 2, 3, 2);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(78, 28);
            btn_reset.TabIndex = 8;
            btn_reset.Text = "Làm mới";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_XoaMenu
            // 
            btn_XoaMenu.Location = new Point(173, 297);
            btn_XoaMenu.Margin = new Padding(3, 2, 3, 2);
            btn_XoaMenu.Name = "btn_XoaMenu";
            btn_XoaMenu.Size = new Size(63, 28);
            btn_XoaMenu.TabIndex = 2;
            btn_XoaMenu.Text = "Xóa";
            btn_XoaMenu.UseVisualStyleBackColor = true;
            btn_XoaMenu.Click += btn_XoaMenu_Click;
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(156, 249);
            txt_Price.Margin = new Padding(3, 2, 3, 2);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(164, 23);
            txt_Price.TabIndex = 7;
            txt_Price.TextChanged += txt_Price_TextChanged;
            // 
            // btn_SuaMenu
            // 
            btn_SuaMenu.Location = new Point(99, 297);
            btn_SuaMenu.Margin = new Padding(3, 2, 3, 2);
            btn_SuaMenu.Name = "btn_SuaMenu";
            btn_SuaMenu.Size = new Size(68, 28);
            btn_SuaMenu.TabIndex = 1;
            btn_SuaMenu.Text = "Sửa ";
            btn_SuaMenu.UseVisualStyleBackColor = true;
            btn_SuaMenu.Click += btn_SuaMenu_Click;
            // 
            // cb_Category
            // 
            cb_Category.FormattingEnabled = true;
            cb_Category.Location = new Point(156, 207);
            cb_Category.Margin = new Padding(3, 2, 3, 2);
            cb_Category.Name = "cb_Category";
            cb_Category.Size = new Size(164, 23);
            cb_Category.TabIndex = 6;
            // 
            // btn_ThemMenu
            // 
            btn_ThemMenu.Location = new Point(17, 297);
            btn_ThemMenu.Margin = new Padding(3, 2, 3, 2);
            btn_ThemMenu.Name = "btn_ThemMenu";
            btn_ThemMenu.Size = new Size(76, 28);
            btn_ThemMenu.TabIndex = 0;
            btn_ThemMenu.Text = "Thêm";
            btn_ThemMenu.UseVisualStyleBackColor = true;
            btn_ThemMenu.Click += btn_ThemMenu_Click;
            // 
            // txt_FoodName
            // 
            txt_FoodName.Location = new Point(156, 70);
            txt_FoodName.Margin = new Padding(3, 2, 3, 2);
            txt_FoodName.Name = "txt_FoodName";
            txt_FoodName.Size = new Size(164, 23);
            txt_FoodName.TabIndex = 5;
            // 
            // txt_FoodID
            // 
            txt_FoodID.Location = new Point(156, 20);
            txt_FoodID.Margin = new Padding(3, 2, 3, 2);
            txt_FoodID.Name = "txt_FoodID";
            txt_FoodID.ReadOnly = true;
            txt_FoodID.Size = new Size(164, 23);
            txt_FoodID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(17, 251);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 3;
            label4.Text = "Giá :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 209);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 2;
            label3.Text = "Danh mục :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 72);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên món :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã menu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_TimMenu);
            panel4.Controls.Add(txt_TimMenu);
            panel4.Location = new Point(3, 31);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(666, 47);
            panel4.TabIndex = 2;
            // 
            // btn_TimMenu
            // 
            btn_TimMenu.Location = new Point(572, 12);
            btn_TimMenu.Margin = new Padding(3, 2, 3, 2);
            btn_TimMenu.Name = "btn_TimMenu";
            btn_TimMenu.Size = new Size(91, 29);
            btn_TimMenu.TabIndex = 0;
            btn_TimMenu.Text = "Tìm";
            btn_TimMenu.UseVisualStyleBackColor = true;
            btn_TimMenu.Click += btn_TimMenu_Click;
            // 
            // txt_TimMenu
            // 
            txt_TimMenu.Font = new Font("Segoe UI", 12F);
            txt_TimMenu.Location = new Point(3, 12);
            txt_TimMenu.Margin = new Padding(3, 2, 3, 2);
            txt_TimMenu.Name = "txt_TimMenu";
            txt_TimMenu.Size = new Size(554, 29);
            txt_TimMenu.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_FoodMenu);
            panel3.Location = new Point(3, 82);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(666, 425);
            panel3.TabIndex = 1;
            // 
            // dgv_FoodMenu
            // 
            dgv_FoodMenu.AllowUserToAddRows = false;
            dgv_FoodMenu.AllowUserToDeleteRows = false;
            dgv_FoodMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_FoodMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_FoodMenu.Location = new Point(3, 0);
            dgv_FoodMenu.Margin = new Padding(3, 2, 3, 2);
            dgv_FoodMenu.MultiSelect = false;
            dgv_FoodMenu.Name = "dgv_FoodMenu";
            dgv_FoodMenu.ReadOnly = true;
            dgv_FoodMenu.RowHeadersWidth = 51;
            dgv_FoodMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_FoodMenu.Size = new Size(660, 421);
            dgv_FoodMenu.TabIndex = 0;
            dgv_FoodMenu.CellClick += dgv_FoodMenu_CellClick;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 527);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMenu";
            Text = "Menu";
            Load += FormMenu_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_FoodMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btn_ThemMenu;
        private Panel panel5;
        private Panel panel4;
        private TextBox txt_TimMenu;
        private Button btn_TimMenu;
        private Button btn_XoaMenu;
        private Button btn_SuaMenu;
        private Label label2;
        private Label label1;
        private ComboBox cb_Category;
        private TextBox txt_FoodName;
        private TextBox txt_FoodID;
        private Label label4;
        private Label label3;
        private TextBox txt_Price;
        private DataGridView dgv_FoodMenu;
        private Button btn_reset;
        private TextBox txt_Description;
        private Label label5;
    }
}