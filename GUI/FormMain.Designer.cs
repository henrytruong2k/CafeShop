namespace CafeShop.GUI
{
    partial class FormMain
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
            btn_booking = new Button();
            txt_Statistics = new Button();
            btn_menu = new Button();
            btn_manage = new Button();
            btn_history = new Button();
            SuspendLayout();
            // 
            // btn_booking
            // 
            btn_booking.Location = new Point(75, 93);
            btn_booking.Margin = new Padding(3, 4, 3, 4);
            btn_booking.Name = "btn_booking";
            btn_booking.Size = new Size(147, 69);
            btn_booking.TabIndex = 0;
            btn_booking.Text = "Chọn bàn";
            btn_booking.UseVisualStyleBackColor = true;
            btn_booking.Click += btn_booking_Click;
            // 
            // txt_Statistics
            // 
            txt_Statistics.Location = new Point(75, 300);
            txt_Statistics.Margin = new Padding(3, 4, 3, 4);
            txt_Statistics.Name = "txt_Statistics";
            txt_Statistics.Size = new Size(147, 69);
            txt_Statistics.TabIndex = 1;
            txt_Statistics.Text = "Thống kê";
            txt_Statistics.UseVisualStyleBackColor = true;
            txt_Statistics.Click += txt_Statistics_Click;
            // 
            // btn_menu
            // 
            btn_menu.Location = new Point(457, 93);
            btn_menu.Margin = new Padding(3, 4, 3, 4);
            btn_menu.Name = "btn_menu";
            btn_menu.Size = new Size(147, 69);
            btn_menu.TabIndex = 2;
            btn_menu.Text = "Menu";
            btn_menu.UseVisualStyleBackColor = true;
            btn_menu.Click += btn_menu_Click;
            // 
            // btn_manage
            // 
            btn_manage.Location = new Point(457, 300);
            btn_manage.Margin = new Padding(3, 4, 3, 4);
            btn_manage.Name = "btn_manage";
            btn_manage.Size = new Size(147, 69);
            btn_manage.TabIndex = 3;
            btn_manage.Text = "Quản lý";
            btn_manage.UseVisualStyleBackColor = true;
            btn_manage.Click += btn_manage_Click;
            // 
            // btn_history
            // 
            btn_history.Location = new Point(244, 206);
            btn_history.Name = "btn_history";
            btn_history.Size = new Size(176, 69);
            btn_history.TabIndex = 4;
            btn_history.Text = "Nhật kí hoạt động";
            btn_history.UseVisualStyleBackColor = true;
            btn_history.Click += btn_history_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 471);
            Controls.Add(btn_history);
            Controls.Add(btn_manage);
            Controls.Add(btn_menu);
            Controls.Add(txt_Statistics);
            Controls.Add(btn_booking);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_booking;
        private Button txt_Statistics;
        private Button btn_menu;
        private Button btn_manage;
        private Button btn_history;
    }
}