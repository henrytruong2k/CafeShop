namespace CafeShop
{
    partial class FormLogin
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
            btnLogin = new Button();
            label1 = new Label();
            lbl_username = new Label();
            lbl_password = new Label();
            txt_username = new TextBox();
            panel1 = new Panel();
            txt_password = new TextBox();
            btn_Show = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(187, 151);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 44);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 0;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_username.Location = new Point(22, 17);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(103, 28);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "Tài khoản";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_password.Location = new Point(24, 80);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(102, 28);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "Mật khẩu";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 12F);
            txt_username.Location = new Point(187, 13);
            txt_username.Margin = new Padding(3, 4, 3, 4);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(341, 34);
            txt_username.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Show);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(lbl_username);
            panel1.Controls.Add(lbl_password);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txt_username);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 259);
            panel1.TabIndex = 4;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 12F);
            txt_password.Location = new Point(187, 76);
            txt_password.Margin = new Padding(3, 4, 3, 4);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(250, 34);
            txt_password.TabIndex = 4;
            // 
            // btn_Show
            // 
            btn_Show.Location = new Point(433, 76);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(95, 34);
            btn_Show.TabIndex = 5;
            btn_Show.Text = "show";
            btn_Show.UseVisualStyleBackColor = true;
            btn_Show.Click += btn_Show_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 288);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private Label lbl_username;
        private Label lbl_password;
        private TextBox txt_username;
        private Panel panel1;
        private TextBox txt_password;
        private Button btn_Show;
    }
}