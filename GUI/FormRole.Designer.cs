namespace CafeShop.GUI
{
    partial class FormRole
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
            txt_RoleName = new TextBox();
            label6 = new Label();
            txt_Note = new TextBox();
            label5 = new Label();
            btn_reset = new Button();
            btn_XoaRole = new Button();
            btn_SuaRole = new Button();
            btn_ThemRole = new Button();
            txt_RoleID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            btn_TimRole = new Button();
            txt_TimRole = new TextBox();
            panel3 = new Panel();
            dgv_Role = new DataGridView();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Role).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 664);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(txt_RoleName);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txt_Note);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(btn_reset);
            panel5.Controls.Add(btn_XoaRole);
            panel5.Controls.Add(btn_SuaRole);
            panel5.Controls.Add(btn_ThemRole);
            panel5.Controls.Add(txt_RoleID);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(774, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(389, 536);
            panel5.TabIndex = 3;
            // 
            // txt_RoleName
            // 
            txt_RoleName.Location = new Point(182, 88);
            txt_RoleName.Name = "txt_RoleName";
            txt_RoleName.Size = new Size(184, 27);
            txt_RoleName.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(24, 84);
            label6.Name = "label6";
            label6.Size = new Size(78, 28);
            label6.TabIndex = 11;
            label6.Text = "Vai trò :";
            // 
            // txt_Note
            // 
            txt_Note.Location = new Point(182, 148);
            txt_Note.Multiline = true;
            txt_Note.Name = "txt_Note";
            txt_Note.Size = new Size(184, 97);
            txt_Note.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(24, 144);
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
            // btn_XoaRole
            // 
            btn_XoaRole.Location = new Point(198, 396);
            btn_XoaRole.Name = "btn_XoaRole";
            btn_XoaRole.Size = new Size(72, 37);
            btn_XoaRole.TabIndex = 2;
            btn_XoaRole.Text = "Xóa";
            btn_XoaRole.UseVisualStyleBackColor = true;
            btn_XoaRole.Click += btn_XoaRole_Click;
            // 
            // btn_SuaRole
            // 
            btn_SuaRole.Location = new Point(113, 396);
            btn_SuaRole.Name = "btn_SuaRole";
            btn_SuaRole.Size = new Size(78, 37);
            btn_SuaRole.TabIndex = 1;
            btn_SuaRole.Text = "Sửa ";
            btn_SuaRole.UseVisualStyleBackColor = true;
            btn_SuaRole.Click += btn_SuaRole_Click;
            // 
            // btn_ThemRole
            // 
            btn_ThemRole.Location = new Point(19, 396);
            btn_ThemRole.Name = "btn_ThemRole";
            btn_ThemRole.Size = new Size(87, 37);
            btn_ThemRole.TabIndex = 0;
            btn_ThemRole.Text = "Thêm";
            btn_ThemRole.UseVisualStyleBackColor = true;
            btn_ThemRole.Click += btn_ThemRole_Click;
            // 
            // txt_RoleID
            // 
            txt_RoleID.Location = new Point(182, 31);
            txt_RoleID.Name = "txt_RoleID";
            txt_RoleID.ReadOnly = true;
            txt_RoleID.Size = new Size(184, 27);
            txt_RoleID.TabIndex = 4;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 0;
            label1.Text = "Role ID:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_TimRole);
            panel4.Controls.Add(txt_TimRole);
            panel4.Location = new Point(3, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(761, 63);
            panel4.TabIndex = 2;
            // 
            // btn_TimRole
            // 
            btn_TimRole.Location = new Point(654, 16);
            btn_TimRole.Name = "btn_TimRole";
            btn_TimRole.Size = new Size(104, 39);
            btn_TimRole.TabIndex = 0;
            btn_TimRole.Text = "Tìm";
            btn_TimRole.UseVisualStyleBackColor = true;
            btn_TimRole.Click += btn_TimRole_Click;
            // 
            // txt_TimRole
            // 
            txt_TimRole.Font = new Font("Segoe UI", 12F);
            txt_TimRole.Location = new Point(3, 16);
            txt_TimRole.Name = "txt_TimRole";
            txt_TimRole.Size = new Size(633, 34);
            txt_TimRole.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_Role);
            panel3.Location = new Point(3, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(761, 567);
            panel3.TabIndex = 1;
            // 
            // dgv_Role
            // 
            dgv_Role.AllowUserToAddRows = false;
            dgv_Role.AllowUserToDeleteRows = false;
            dgv_Role.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Role.Location = new Point(3, 0);
            dgv_Role.MultiSelect = false;
            dgv_Role.Name = "dgv_Role";
            dgv_Role.ReadOnly = true;
            dgv_Role.RowHeadersWidth = 51;
            dgv_Role.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Role.Size = new Size(762, 536);
            dgv_Role.TabIndex = 0;
            dgv_Role.CellClick += dgv_Role_CellClick;
            // 
            // FormRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 703);
            Controls.Add(panel1);
            Name = "FormRole";
            Text = "Vai Trò";
            Load += FormRole_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Role).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private TextBox txt_Note;
        private Label label5;
        private Button btn_reset;
        private Button btn_XoaRole;
        private Button btn_SuaRole;
        private Button btn_ThemRole;
        private TextBox txt_RoleID;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel4;
        private Button btn_TimRole;
        private TextBox txt_TimRole;
        private Panel panel3;
        private DataGridView dgv_Role;
        private Label label6;
        private TextBox txt_RoleName;
    }
}