namespace CafeShop
{
    partial class FormUser
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
            dgv_user = new DataGridView();
            lbl_fullname = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_user).BeginInit();
            SuspendLayout();
            // 
            // dgv_user
            // 
            dgv_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_user.Location = new Point(22, 95);
            dgv_user.Name = "dgv_user";
            dgv_user.Size = new Size(756, 300);
            dgv_user.TabIndex = 0;
            // 
            // lbl_fullname
            // 
            lbl_fullname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_fullname.ImageAlign = ContentAlignment.TopLeft;
            lbl_fullname.Location = new Point(565, 25);
            lbl_fullname.Name = "lbl_fullname";
            lbl_fullname.Size = new Size(213, 54);
            lbl_fullname.TabIndex = 1;
            lbl_fullname.Text = "Nội dung rất dài, sẽ không đẩy chữ sang bên phải mà sẽ kéo qua bên trái nếu nó dài quá.";
            lbl_fullname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_fullname);
            Controls.Add(dgv_user);
            Name = "FormUser";
            Text = "FormUser";
            Load += FormUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_user).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_user;
        private Label lbl_fullname;
    }
}