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
            nm_FoodPrice = new NumericUpDown();
            cb_Category = new ComboBox();
            txt_FoodName = new TextBox();
            txt_FoodID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            txt_TimMenu = new TextBox();
            btn_TimMenu = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btn_XoaMenu = new Button();
            btn_SuaMenu = new Button();
            btn_ThemMenu = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_FoodPrice).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 679);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(nm_FoodPrice);
            panel5.Controls.Add(cb_Category);
            panel5.Controls.Add(txt_FoodName);
            panel5.Controls.Add(txt_FoodID);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(867, 112);
            panel5.Name = "panel5";
            panel5.Size = new Size(388, 561);
            panel5.TabIndex = 3;
            // 
            // nm_FoodPrice
            // 
            nm_FoodPrice.Location = new Point(175, 237);
            nm_FoodPrice.Name = "nm_FoodPrice";
            nm_FoodPrice.Size = new Size(187, 27);
            nm_FoodPrice.TabIndex = 7;
            // 
            // cb_Category
            // 
            cb_Category.FormattingEnabled = true;
            cb_Category.Location = new Point(175, 170);
            cb_Category.Name = "cb_Category";
            cb_Category.Size = new Size(187, 28);
            cb_Category.TabIndex = 6;
            // 
            // txt_FoodName
            // 
            txt_FoodName.Location = new Point(175, 97);
            txt_FoodName.Name = "txt_FoodName";
            txt_FoodName.Size = new Size(187, 27);
            txt_FoodName.TabIndex = 5;
            // 
            // txt_FoodID
            // 
            txt_FoodID.Location = new Point(175, 34);
            txt_FoodID.Name = "txt_FoodID";
            txt_FoodID.ReadOnly = true;
            txt_FoodID.Size = new Size(187, 27);
            txt_FoodID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(19, 232);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 3;
            label4.Text = "Giá :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(19, 166);
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
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(40, 28);
            label1.TabIndex = 0;
            label1.Text = "ID :";
            // 
            // panel4
            // 
            panel4.Controls.Add(txt_TimMenu);
            panel4.Controls.Add(btn_TimMenu);
            panel4.Location = new Point(867, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(388, 70);
            panel4.TabIndex = 2;
            // 
            // txt_TimMenu
            // 
            txt_TimMenu.Location = new Point(29, 22);
            txt_TimMenu.Name = "txt_TimMenu";
            txt_TimMenu.Size = new Size(219, 27);
            txt_TimMenu.TabIndex = 1;
            // 
            // btn_TimMenu
            // 
            btn_TimMenu.Location = new Point(266, 0);
            btn_TimMenu.Name = "btn_TimMenu";
            btn_TimMenu.Size = new Size(120, 70);
            btn_TimMenu.TabIndex = 0;
            btn_TimMenu.Text = "Tìm";
            btn_TimMenu.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(3, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(851, 567);
            panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(845, 561);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_XoaMenu);
            panel2.Controls.Add(btn_SuaMenu);
            panel2.Controls.Add(btn_ThemMenu);
            panel2.Location = new Point(39, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 71);
            panel2.TabIndex = 0;
            // 
            // btn_XoaMenu
            // 
            btn_XoaMenu.Location = new Point(617, 0);
            btn_XoaMenu.Name = "btn_XoaMenu";
            btn_XoaMenu.Size = new Size(150, 70);
            btn_XoaMenu.TabIndex = 2;
            btn_XoaMenu.Text = "Xóa";
            btn_XoaMenu.UseVisualStyleBackColor = true;
            // 
            // btn_SuaMenu
            // 
            btn_SuaMenu.Location = new Point(291, 0);
            btn_SuaMenu.Name = "btn_SuaMenu";
            btn_SuaMenu.Size = new Size(150, 70);
            btn_SuaMenu.TabIndex = 1;
            btn_SuaMenu.Text = "Sửa ";
            btn_SuaMenu.UseVisualStyleBackColor = true;
            // 
            // btn_ThemMenu
            // 
            btn_ThemMenu.Location = new Point(0, 0);
            btn_ThemMenu.Name = "btn_ThemMenu";
            btn_ThemMenu.Size = new Size(150, 70);
            btn_ThemMenu.TabIndex = 0;
            btn_ThemMenu.Text = "Thêm";
            btn_ThemMenu.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 703);
            Controls.Add(panel1);
            Name = "FormMenu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nm_FoodPrice).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btn_ThemMenu;
        private Panel panel5;
        private Panel panel4;
        private TextBox txt_TimMenu;
        private Button btn_TimMenu;
        private Button btn_XoaMenu;
        private Button btn_SuaMenu;
        private Label label2;
        private Label label1;
        private NumericUpDown nm_FoodPrice;
        private ComboBox cb_Category;
        private TextBox txt_FoodName;
        private TextBox txt_FoodID;
        private Label label4;
        private Label label3;
    }
}