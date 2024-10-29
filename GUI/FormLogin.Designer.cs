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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            txt_username = new TextBox();
            btnLogin = new Button();
            lbl_password = new Label();
            lbl_username = new Label();
            txt_password = new TextBox();
            btn_Show = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 0;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 12F);
            txt_username.Location = new Point(129, 32);
            txt_username.Margin = new Padding(3, 4, 3, 4);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(302, 34);
            txt_username.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleRight;
            btnLogin.Location = new Point(169, 197);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 43);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.TextAlign = ContentAlignment.MiddleLeft;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_password.Location = new Point(5, 96);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(102, 28);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "Mật khẩu";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_username.Location = new Point(3, 35);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(103, 28);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "Tài khoản";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 12F);
            txt_password.Location = new Point(129, 93);
            txt_password.Margin = new Padding(3, 4, 3, 4);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(222, 34);
            txt_password.TabIndex = 4;
            // 
            // btn_Show
            // 
            btn_Show.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Show.Location = new Point(348, 91);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(83, 39);
            btn_Show.TabIndex = 5;
            btn_Show.Text = "Show";
            btn_Show.UseVisualStyleBackColor = true;
            btn_Show.Click += btn_Show_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Show);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(lbl_username);
            panel1.Controls.Add(lbl_password);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txt_username);
            panel1.Location = new Point(343, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 253);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 255);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 280);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txt_username;
        private Button btnLogin;
        private Label lbl_password;
        private Label lbl_username;
        private TextBox txt_password;
        private Button btn_Show;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}