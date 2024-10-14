namespace CafeShop.GUI
{
    partial class FormCategory
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
            txt_Note = new TextBox();
            label5 = new Label();
            btn_reset = new Button();
            btn_XoaCategory = new Button();
            btn_SuaCategory = new Button();
            btn_ThemCategory = new Button();
            txt_CategoryName = new TextBox();
            txt_CategoryID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            btn_TimCategory = new Button();
            txt_TimCategory = new TextBox();
            panel3 = new Panel();
            dgv_Category = new DataGridView();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Category).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1175, 648);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(txt_Note);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(btn_reset);
            panel5.Controls.Add(btn_XoaCategory);
            panel5.Controls.Add(btn_SuaCategory);
            panel5.Controls.Add(btn_ThemCategory);
            panel5.Controls.Add(txt_CategoryName);
            panel5.Controls.Add(txt_CategoryID);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(774, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(389, 561);
            panel5.TabIndex = 3;
            // 
            // txt_Note
            // 
            txt_Note.Location = new Point(178, 156);
            txt_Note.Multiline = true;
            txt_Note.Name = "txt_Note";
            txt_Note.Size = new Size(187, 97);
            txt_Note.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(19, 153);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 9;
            label5.Text = "Ghi chú:";
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(277, 396);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(89, 37);
            btn_reset.TabIndex = 8;
            btn_reset.Text = "Làm mới";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_XoaCategory
            // 
            btn_XoaCategory.Location = new Point(198, 396);
            btn_XoaCategory.Name = "btn_XoaCategory";
            btn_XoaCategory.Size = new Size(72, 37);
            btn_XoaCategory.TabIndex = 2;
            btn_XoaCategory.Text = "Xóa";
            btn_XoaCategory.UseVisualStyleBackColor = true;
            btn_XoaCategory.Click += btn_XoaCategory_Click;
            // 
            // btn_SuaCategory
            // 
            btn_SuaCategory.Location = new Point(113, 396);
            btn_SuaCategory.Name = "btn_SuaCategory";
            btn_SuaCategory.Size = new Size(78, 37);
            btn_SuaCategory.TabIndex = 1;
            btn_SuaCategory.Text = "Sửa ";
            btn_SuaCategory.UseVisualStyleBackColor = true;
            // 
            // btn_ThemCategory
            // 
            btn_ThemCategory.Location = new Point(19, 396);
            btn_ThemCategory.Name = "btn_ThemCategory";
            btn_ThemCategory.Size = new Size(87, 37);
            btn_ThemCategory.TabIndex = 0;
            btn_ThemCategory.Text = "Thêm";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(19, 335);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(19, 279);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 96);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã loai:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_TimCategory);
            panel4.Controls.Add(txt_TimCategory);
            panel4.Location = new Point(3, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(761, 63);
            panel4.TabIndex = 2;
            // 
            // btn_TimCategory
            // 
            btn_TimCategory.Location = new Point(654, 16);
            btn_TimCategory.Name = "btn_TimCategory";
            btn_TimCategory.Size = new Size(104, 39);
            btn_TimCategory.TabIndex = 0;
            btn_TimCategory.Text = "Tìm";
            btn_TimCategory.UseVisualStyleBackColor = true;
            btn_TimCategory.Click += btn_TimCategory_Click;
            // 
            // txt_TimCategory
            // 
            txt_TimCategory.Font = new Font("Segoe UI", 12F);
            txt_TimCategory.Location = new Point(3, 16);
            txt_TimCategory.Name = "txt_TimCategory";
            txt_TimCategory.Size = new Size(633, 34);
            txt_TimCategory.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_Category);
            panel3.Location = new Point(3, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(761, 567);
            panel3.TabIndex = 1;
            // 
            // dgv_Category
            // 
            dgv_Category.AllowUserToAddRows = false;
            dgv_Category.AllowUserToDeleteRows = false;
            dgv_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Category.Location = new Point(3, 0);
            dgv_Category.MultiSelect = false;
            dgv_Category.Name = "dgv_Category";
            dgv_Category.ReadOnly = true;
            dgv_Category.RowHeadersWidth = 51;
            dgv_Category.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Category.Size = new Size(762, 536);
            dgv_Category.TabIndex = 0;
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 703);
            Controls.Add(panel1);
            Name = "FormCategory";
            Text = "Danh mục";
            Load += FormCategory_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Category).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private TextBox txt_Note;
        private Label label5;
        private Button btn_reset;
        private Button btn_XoaCategory;
        private Button btn_SuaCategory;
        private Button btn_ThemCategory;
        private TextBox txt_CategoryName;
        private TextBox txt_CategoryID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Button btn_TimCategory;
        private TextBox txt_TimCategory;
        private Panel panel3;
        private DataGridView dgv_Category;
    }
}