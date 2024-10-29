namespace CafeShop.GUI
{
    partial class FormManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManage));
            tabControl1 = new TabControl();
            table = new TabPage();
            panel1 = new Panel();
            panel5 = new Panel();
            txt_Description = new TextBox();
            label5 = new Label();
            btn_resetMenu = new Button();
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
            tabPage2 = new TabPage();
            panel2 = new Panel();
            panel6 = new Panel();
            txt_Note = new TextBox();
            label6 = new Label();
            btn_resetCategory = new Button();
            btn_XoaCategory = new Button();
            btn_SuaCategory = new Button();
            btn_ThemCategory = new Button();
            txt_CategoryName = new TextBox();
            txt_CategoryID = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel7 = new Panel();
            btn_TimCategory = new Button();
            txt_TimCategory = new TextBox();
            panel8 = new Panel();
            dgv_Category = new DataGridView();
            tabPage1 = new TabPage();
            panel9 = new Panel();
            panel10 = new Panel();
            txt_Booking = new TextBox();
            label11 = new Label();
            btn_resetTable = new Button();
            btn_XoaTable = new Button();
            btn_SuaTable = new Button();
            btn_ThemTable = new Button();
            txt_TableName = new TextBox();
            txt_TableID = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panel11 = new Panel();
            btn_TimTable = new Button();
            txt_TimTable = new TextBox();
            panel12 = new Panel();
            dgv_Table = new DataGridView();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            table.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_FoodMenu).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Category).BeginInit();
            tabPage1.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Table).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(table);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1174, 679);
            tabControl1.TabIndex = 0;
            // 
            // table
            // 
            table.Controls.Add(panel1);
            table.Location = new Point(4, 29);
            table.Name = "table";
            table.Padding = new Padding(3);
            table.Size = new Size(1166, 646);
            table.TabIndex = 0;
            table.Text = "Menu";
            table.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(-4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1175, 644);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(txt_Description);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(btn_resetMenu);
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
            panel5.Location = new Point(772, 80);
            panel5.Name = "panel5";
            panel5.Size = new Size(389, 561);
            panel5.TabIndex = 3;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(178, 156);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(198, 97);
            txt_Description.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(19, 153);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 9;
            label5.Text = "Mô tả:";
            // 
            // btn_resetMenu
            // 
            btn_resetMenu.Image = (Image)resources.GetObject("btn_resetMenu.Image");
            btn_resetMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_resetMenu.Location = new Point(275, 396);
            btn_resetMenu.Name = "btn_resetMenu";
            btn_resetMenu.Size = new Size(109, 37);
            btn_resetMenu.TabIndex = 8;
            btn_resetMenu.Text = "Làm mới";
            btn_resetMenu.TextAlign = ContentAlignment.MiddleRight;
            btn_resetMenu.UseVisualStyleBackColor = true;
            btn_resetMenu.Click += btn_resetMenu_Click;
            // 
            // btn_XoaMenu
            // 
            btn_XoaMenu.Image = (Image)resources.GetObject("btn_XoaMenu.Image");
            btn_XoaMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_XoaMenu.Location = new Point(198, 396);
            btn_XoaMenu.Name = "btn_XoaMenu";
            btn_XoaMenu.Size = new Size(72, 37);
            btn_XoaMenu.TabIndex = 2;
            btn_XoaMenu.Text = "Xóa";
            btn_XoaMenu.TextAlign = ContentAlignment.MiddleRight;
            btn_XoaMenu.UseVisualStyleBackColor = true;
            btn_XoaMenu.Click += btn_XoaMenu_Click;
            // 
            // txt_Price
            // 
            txt_Price.Location = new Point(178, 332);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(198, 27);
            txt_Price.TabIndex = 7;
            // 
            // btn_SuaMenu
            // 
            btn_SuaMenu.Image = (Image)resources.GetObject("btn_SuaMenu.Image");
            btn_SuaMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_SuaMenu.Location = new Point(113, 396);
            btn_SuaMenu.Name = "btn_SuaMenu";
            btn_SuaMenu.Size = new Size(78, 37);
            btn_SuaMenu.TabIndex = 1;
            btn_SuaMenu.Text = "Sửa ";
            btn_SuaMenu.TextAlign = ContentAlignment.MiddleRight;
            btn_SuaMenu.UseVisualStyleBackColor = true;
            btn_SuaMenu.Click += btn_SuaMenu_Click;
            // 
            // cb_Category
            // 
            cb_Category.FormattingEnabled = true;
            cb_Category.Location = new Point(178, 276);
            cb_Category.Name = "cb_Category";
            cb_Category.Size = new Size(198, 28);
            cb_Category.TabIndex = 6;
            // 
            // btn_ThemMenu
            // 
            btn_ThemMenu.Image = (Image)resources.GetObject("btn_ThemMenu.Image");
            btn_ThemMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ThemMenu.Location = new Point(19, 396);
            btn_ThemMenu.Name = "btn_ThemMenu";
            btn_ThemMenu.Size = new Size(87, 37);
            btn_ThemMenu.TabIndex = 0;
            btn_ThemMenu.Text = "Thêm";
            btn_ThemMenu.TextAlign = ContentAlignment.MiddleRight;
            btn_ThemMenu.UseVisualStyleBackColor = true;
            btn_ThemMenu.Click += btn_ThemMenu_Click;
            // 
            // txt_FoodName
            // 
            txt_FoodName.Location = new Point(178, 93);
            txt_FoodName.Name = "txt_FoodName";
            txt_FoodName.Size = new Size(198, 27);
            txt_FoodName.TabIndex = 5;
            // 
            // txt_FoodID
            // 
            txt_FoodID.Location = new Point(178, 27);
            txt_FoodID.Name = "txt_FoodID";
            txt_FoodID.ReadOnly = true;
            txt_FoodID.Size = new Size(198, 27);
            txt_FoodID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(19, 335);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 3;
            label4.Text = "Giá :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(19, 279);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 2;
            label3.Text = "Danh mục :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 96);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên món :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã menu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_TimMenu);
            panel4.Controls.Add(txt_TimMenu);
            panel4.Location = new Point(3, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(761, 63);
            panel4.TabIndex = 2;
            // 
            // btn_TimMenu
            // 
            btn_TimMenu.Image = (Image)resources.GetObject("btn_TimMenu.Image");
            btn_TimMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_TimMenu.Location = new Point(654, 16);
            btn_TimMenu.Name = "btn_TimMenu";
            btn_TimMenu.Size = new Size(84, 39);
            btn_TimMenu.TabIndex = 0;
            btn_TimMenu.Text = "Tìm";
            btn_TimMenu.TextAlign = ContentAlignment.MiddleRight;
            btn_TimMenu.UseVisualStyleBackColor = true;
            // 
            // txt_TimMenu
            // 
            txt_TimMenu.Font = new Font("Segoe UI", 12F);
            txt_TimMenu.Location = new Point(3, 16);
            txt_TimMenu.Name = "txt_TimMenu";
            txt_TimMenu.Size = new Size(633, 34);
            txt_TimMenu.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_FoodMenu);
            panel3.Location = new Point(3, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(761, 567);
            panel3.TabIndex = 1;
            // 
            // dgv_FoodMenu
            // 
            dgv_FoodMenu.AllowUserToAddRows = false;
            dgv_FoodMenu.AllowUserToDeleteRows = false;
            dgv_FoodMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_FoodMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_FoodMenu.Location = new Point(3, -30);
            dgv_FoodMenu.MultiSelect = false;
            dgv_FoodMenu.Name = "dgv_FoodMenu";
            dgv_FoodMenu.ReadOnly = true;
            dgv_FoodMenu.RowHeadersWidth = 51;
            dgv_FoodMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_FoodMenu.Size = new Size(754, 561);
            dgv_FoodMenu.TabIndex = 0;
            dgv_FoodMenu.CellClick += dgv_FoodMenu_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1166, 646);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Danh mục";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel8);
            panel2.Location = new Point(-4, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1174, 637);
            panel2.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(txt_Note);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(btn_resetCategory);
            panel6.Controls.Add(btn_XoaCategory);
            panel6.Controls.Add(btn_SuaCategory);
            panel6.Controls.Add(btn_ThemCategory);
            panel6.Controls.Add(txt_CategoryName);
            panel6.Controls.Add(txt_CategoryID);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label10);
            panel6.Location = new Point(774, 99);
            panel6.Name = "panel6";
            panel6.Size = new Size(389, 536);
            panel6.TabIndex = 3;
            // 
            // txt_Note
            // 
            txt_Note.Location = new Point(178, 156);
            txt_Note.Multiline = true;
            txt_Note.Name = "txt_Note";
            txt_Note.Size = new Size(187, 97);
            txt_Note.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(19, 153);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 9;
            label6.Text = "Ghi chú:";
            // 
            // btn_resetCategory
            // 
            btn_resetCategory.Image = (Image)resources.GetObject("btn_resetCategory.Image");
            btn_resetCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btn_resetCategory.Location = new Point(277, 396);
            btn_resetCategory.Name = "btn_resetCategory";
            btn_resetCategory.Size = new Size(109, 37);
            btn_resetCategory.TabIndex = 8;
            btn_resetCategory.Text = "Làm mới";
            btn_resetCategory.TextAlign = ContentAlignment.MiddleRight;
            btn_resetCategory.UseVisualStyleBackColor = true;
            btn_resetCategory.Click += btn_resetCategory_Click;
            // 
            // btn_XoaCategory
            // 
            btn_XoaCategory.Image = (Image)resources.GetObject("btn_XoaCategory.Image");
            btn_XoaCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btn_XoaCategory.Location = new Point(198, 396);
            btn_XoaCategory.Name = "btn_XoaCategory";
            btn_XoaCategory.Size = new Size(72, 37);
            btn_XoaCategory.TabIndex = 2;
            btn_XoaCategory.Text = "Xóa";
            btn_XoaCategory.TextAlign = ContentAlignment.MiddleRight;
            btn_XoaCategory.UseVisualStyleBackColor = true;
            btn_XoaCategory.Click += btn_XoaCategory_Click;
            // 
            // btn_SuaCategory
            // 
            btn_SuaCategory.Image = (Image)resources.GetObject("btn_SuaCategory.Image");
            btn_SuaCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btn_SuaCategory.Location = new Point(113, 396);
            btn_SuaCategory.Name = "btn_SuaCategory";
            btn_SuaCategory.Size = new Size(78, 37);
            btn_SuaCategory.TabIndex = 1;
            btn_SuaCategory.Text = "Sửa ";
            btn_SuaCategory.TextAlign = ContentAlignment.MiddleRight;
            btn_SuaCategory.UseVisualStyleBackColor = true;
            btn_SuaCategory.Click += btn_SuaCategory_Click;
            // 
            // btn_ThemCategory
            // 
            btn_ThemCategory.Image = (Image)resources.GetObject("btn_ThemCategory.Image");
            btn_ThemCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ThemCategory.Location = new Point(19, 396);
            btn_ThemCategory.Name = "btn_ThemCategory";
            btn_ThemCategory.Size = new Size(87, 37);
            btn_ThemCategory.TabIndex = 0;
            btn_ThemCategory.Text = "Thêm";
            btn_ThemCategory.TextAlign = ContentAlignment.MiddleRight;
            btn_ThemCategory.UseVisualStyleBackColor = true;
            btn_ThemCategory.Click += btn_ThemCategory_Click;
            // 
            // txt_CategoryName
            // 
            txt_CategoryName.Location = new Point(178, 93);
            txt_CategoryName.Name = "txt_CategoryName";
            txt_CategoryName.Size = new Size(187, 27);
            txt_CategoryName.TabIndex = 5;
            // 
            // txt_CategoryID
            // 
            txt_CategoryID.Location = new Point(178, 27);
            txt_CategoryID.Name = "txt_CategoryID";
            txt_CategoryID.ReadOnly = true;
            txt_CategoryID.Size = new Size(187, 27);
            txt_CategoryID.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label7.Location = new Point(19, 335);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(19, 279);
            label8.Name = "label8";
            label8.Size = new Size(0, 28);
            label8.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(19, 96);
            label9.Name = "label9";
            label9.Size = new Size(82, 28);
            label9.TabIndex = 1;
            label9.Text = "Tên loại:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label10.Location = new Point(19, 26);
            label10.Name = "label10";
            label10.Size = new Size(81, 28);
            label10.TabIndex = 0;
            label10.Text = "Mã loai:";
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_TimCategory);
            panel7.Controls.Add(txt_TimCategory);
            panel7.Location = new Point(3, 24);
            panel7.Name = "panel7";
            panel7.Size = new Size(761, 63);
            panel7.TabIndex = 2;
            // 
            // btn_TimCategory
            // 
            btn_TimCategory.Image = (Image)resources.GetObject("btn_TimCategory.Image");
            btn_TimCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btn_TimCategory.Location = new Point(654, 16);
            btn_TimCategory.Name = "btn_TimCategory";
            btn_TimCategory.Size = new Size(104, 39);
            btn_TimCategory.TabIndex = 0;
            btn_TimCategory.Text = "Tìm";
            btn_TimCategory.UseVisualStyleBackColor = true;
            // 
            // txt_TimCategory
            // 
            txt_TimCategory.Font = new Font("Segoe UI", 12F);
            txt_TimCategory.Location = new Point(3, 16);
            txt_TimCategory.Name = "txt_TimCategory";
            txt_TimCategory.Size = new Size(633, 34);
            txt_TimCategory.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(dgv_Category);
            panel8.Location = new Point(3, 109);
            panel8.Name = "panel8";
            panel8.Size = new Size(761, 567);
            panel8.TabIndex = 1;
            // 
            // dgv_Category
            // 
            dgv_Category.AllowUserToAddRows = false;
            dgv_Category.AllowUserToDeleteRows = false;
            dgv_Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Category.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Category.Location = new Point(3, -9);
            dgv_Category.MultiSelect = false;
            dgv_Category.Name = "dgv_Category";
            dgv_Category.ReadOnly = true;
            dgv_Category.RowHeadersWidth = 51;
            dgv_Category.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Category.Size = new Size(762, 536);
            dgv_Category.TabIndex = 0;
            dgv_Category.CellClick += dgv_Category_CellClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel9);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1166, 646);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Bàn ăn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(panel12);
            panel9.Location = new Point(-4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(1174, 637);
            panel9.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Controls.Add(txt_Booking);
            panel10.Controls.Add(label11);
            panel10.Controls.Add(btn_resetTable);
            panel10.Controls.Add(btn_XoaTable);
            panel10.Controls.Add(btn_SuaTable);
            panel10.Controls.Add(btn_ThemTable);
            panel10.Controls.Add(txt_TableName);
            panel10.Controls.Add(txt_TableID);
            panel10.Controls.Add(label12);
            panel10.Controls.Add(label13);
            panel10.Controls.Add(label14);
            panel10.Controls.Add(label15);
            panel10.Location = new Point(774, 99);
            panel10.Name = "panel10";
            panel10.Size = new Size(389, 536);
            panel10.TabIndex = 3;
            // 
            // txt_Booking
            // 
            txt_Booking.Location = new Point(182, 157);
            txt_Booking.Name = "txt_Booking";
            txt_Booking.ReadOnly = true;
            txt_Booking.Size = new Size(183, 27);
            txt_Booking.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(19, 153);
            label11.Name = "label11";
            label11.Size = new Size(107, 28);
            label11.TabIndex = 9;
            label11.Text = "Trạng thái :";
            // 
            // btn_resetTable
            // 
            btn_resetTable.Image = (Image)resources.GetObject("btn_resetTable.Image");
            btn_resetTable.ImageAlign = ContentAlignment.MiddleLeft;
            btn_resetTable.Location = new Point(277, 396);
            btn_resetTable.Name = "btn_resetTable";
            btn_resetTable.Size = new Size(109, 37);
            btn_resetTable.TabIndex = 8;
            btn_resetTable.Text = "Làm mới";
            btn_resetTable.TextAlign = ContentAlignment.MiddleRight;
            btn_resetTable.UseVisualStyleBackColor = true;
            btn_resetTable.Click += btn_resetTable_Click;
            // 
            // btn_XoaTable
            // 
            btn_XoaTable.Image = (Image)resources.GetObject("btn_XoaTable.Image");
            btn_XoaTable.ImageAlign = ContentAlignment.MiddleLeft;
            btn_XoaTable.Location = new Point(198, 396);
            btn_XoaTable.Name = "btn_XoaTable";
            btn_XoaTable.Size = new Size(72, 37);
            btn_XoaTable.TabIndex = 2;
            btn_XoaTable.Text = "Xóa";
            btn_XoaTable.TextAlign = ContentAlignment.MiddleRight;
            btn_XoaTable.UseVisualStyleBackColor = true;
            btn_XoaTable.Click += btn_XoaTable_Click;
            // 
            // btn_SuaTable
            // 
            btn_SuaTable.Image = (Image)resources.GetObject("btn_SuaTable.Image");
            btn_SuaTable.ImageAlign = ContentAlignment.MiddleLeft;
            btn_SuaTable.Location = new Point(113, 396);
            btn_SuaTable.Name = "btn_SuaTable";
            btn_SuaTable.Size = new Size(78, 37);
            btn_SuaTable.TabIndex = 1;
            btn_SuaTable.Text = "Sửa ";
            btn_SuaTable.TextAlign = ContentAlignment.MiddleRight;
            btn_SuaTable.UseVisualStyleBackColor = true;
            btn_SuaTable.Click += btn_SuaTable_Click;
            // 
            // btn_ThemTable
            // 
            btn_ThemTable.Image = (Image)resources.GetObject("btn_ThemTable.Image");
            btn_ThemTable.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ThemTable.Location = new Point(19, 396);
            btn_ThemTable.Name = "btn_ThemTable";
            btn_ThemTable.Size = new Size(87, 37);
            btn_ThemTable.TabIndex = 0;
            btn_ThemTable.Text = "Thêm";
            btn_ThemTable.TextAlign = ContentAlignment.MiddleRight;
            btn_ThemTable.UseVisualStyleBackColor = true;
            btn_ThemTable.Click += btn_ThemTable_Click;
            // 
            // txt_TableName
            // 
            txt_TableName.Location = new Point(178, 93);
            txt_TableName.Name = "txt_TableName";
            txt_TableName.Size = new Size(187, 27);
            txt_TableName.TabIndex = 5;
            // 
            // txt_TableID
            // 
            txt_TableID.Location = new Point(178, 27);
            txt_TableID.Name = "txt_TableID";
            txt_TableID.ReadOnly = true;
            txt_TableID.Size = new Size(187, 27);
            txt_TableID.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label12.Location = new Point(19, 335);
            label12.Name = "label12";
            label12.Size = new Size(0, 28);
            label12.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(19, 279);
            label13.Name = "label13";
            label13.Size = new Size(0, 28);
            label13.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(19, 96);
            label14.Name = "label14";
            label14.Size = new Size(83, 28);
            label14.TabIndex = 1;
            label14.Text = "Tên bàn:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label15.Location = new Point(19, 26);
            label15.Name = "label15";
            label15.Size = new Size(82, 28);
            label15.TabIndex = 0;
            label15.Text = "Mã bàn:";
            // 
            // panel11
            // 
            panel11.Controls.Add(btn_TimTable);
            panel11.Controls.Add(txt_TimTable);
            panel11.Location = new Point(3, 24);
            panel11.Name = "panel11";
            panel11.Size = new Size(761, 63);
            panel11.TabIndex = 2;
            // 
            // btn_TimTable
            // 
            btn_TimTable.Image = (Image)resources.GetObject("btn_TimTable.Image");
            btn_TimTable.ImageAlign = ContentAlignment.MiddleLeft;
            btn_TimTable.Location = new Point(654, 16);
            btn_TimTable.Name = "btn_TimTable";
            btn_TimTable.Size = new Size(104, 39);
            btn_TimTable.TabIndex = 0;
            btn_TimTable.Text = "Tìm";
            btn_TimTable.UseVisualStyleBackColor = true;
            btn_TimTable.Click += btn_TimTable_Click;
            // 
            // txt_TimTable
            // 
            txt_TimTable.Font = new Font("Segoe UI", 12F);
            txt_TimTable.Location = new Point(3, 16);
            txt_TimTable.Name = "txt_TimTable";
            txt_TimTable.Size = new Size(633, 34);
            txt_TimTable.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.Controls.Add(dgv_Table);
            panel12.Location = new Point(3, 109);
            panel12.Name = "panel12";
            panel12.Size = new Size(761, 567);
            panel12.TabIndex = 1;
            // 
            // dgv_Table
            // 
            dgv_Table.AllowUserToAddRows = false;
            dgv_Table.AllowUserToDeleteRows = false;
            dgv_Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Table.Location = new Point(3, -9);
            dgv_Table.MultiSelect = false;
            dgv_Table.Name = "dgv_Table";
            dgv_Table.ReadOnly = true;
            dgv_Table.RowHeadersWidth = 51;
            dgv_Table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Table.Size = new Size(762, 536);
            dgv_Table.TabIndex = 0;
            dgv_Table.CellClick += dgv_Table_CellClick;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1166, 646);
            tabPage3.TabIndex = 3;
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 703);
            Controls.Add(tabControl1);
            Name = "FormManage";
            Text = "FormManage";
            Load += FormManage_Load;
            tabControl1.ResumeLayout(false);
            table.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_FoodMenu).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Category).EndInit();
            tabPage1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage table;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private Panel panel1;
        private Panel panel5;
        private TextBox txt_Description;
        private Label label5;
        private Button btn_resetMenu;
        private Button btn_XoaMenu;
        private TextBox txt_Price;
        private Button btn_SuaMenu;
        private ComboBox cb_Category;
        private Button btn_ThemMenu;
        private TextBox txt_FoodName;
        private TextBox txt_FoodID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Button btn_TimMenu;
        private TextBox txt_TimMenu;
        private Panel panel3;
        private DataGridView dgv_FoodMenu;
        private Panel panel2;
        private Panel panel6;
        private TextBox txt_Note;
        private Label label6;
        private Button btn_resetCategory;
        private Button btn_XoaCategory;
        private Button btn_SuaCategory;
        private Button btn_ThemCategory;
        private TextBox txt_CategoryName;
        private TextBox txt_CategoryID;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel7;
        private Button btn_TimCategory;
        private TextBox txt_TimCategory;
        private Panel panel8;
        private DataGridView dgv_Category;
        private Panel panel9;
        private Panel panel10;
        private Label label11;
        private Button btn_resetTable;
        private Button btn_XoaTable;
        private Button btn_SuaTable;
        private Button btn_ThemTable;
        private TextBox txt_TableName;
        private TextBox txt_TableID;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel panel11;
        private Button btn_TimTable;
        private TextBox txt_TimTable;
        private Panel panel12;
        private DataGridView dgv_Table;
        private TextBox txt_Booking;
    }
}