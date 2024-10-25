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
            menuStrip1 = new MenuStrip();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            mnt_category = new ToolStripMenuItem();
            vaiTròToolStripMenuItem = new ToolStripMenuItem();
            mnt_role = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { danhMụcToolStripMenuItem, vaiTròToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1198, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnt_category });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(90, 24);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // mnt_category
            // 
            mnt_category.Name = "mnt_category";
            mnt_category.Size = new Size(224, 26);
            mnt_category.Text = "Quản lí danh mục";
            mnt_category.Click += mnt_category_Click;
            // 
            // vaiTròToolStripMenuItem
            // 
            vaiTròToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnt_role });
            vaiTròToolStripMenuItem.Name = "vaiTròToolStripMenuItem";
            vaiTròToolStripMenuItem.Size = new Size(66, 24);
            vaiTròToolStripMenuItem.Text = "Vai trò";
            // 
            // mnt_role
            // 
            mnt_role.Name = "mnt_role";
            mnt_role.Size = new Size(224, 26);
            mnt_role.Text = "Quản lí vai trò";
            mnt_role.Click += mnt_role_Click;
            // 
            // FormManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 703);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormManage";
            Text = "FormManage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem mnt_category;
        private ToolStripMenuItem vaiTròToolStripMenuItem;
        private ToolStripMenuItem mnt_role;
    }
}