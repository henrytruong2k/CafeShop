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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            btn_booking = new Button();
            btn_statistics = new Button();
            btn_manage = new Button();
            btn_history = new Button();
            SuspendLayout();
            // 
            // btn_booking
            // 
            btn_booking.Image = (Image)resources.GetObject("btn_booking.Image");
            btn_booking.ImageAlign = ContentAlignment.MiddleLeft;
            btn_booking.Location = new Point(65, 64);
            btn_booking.Name = "btn_booking";
            btn_booking.Size = new Size(120, 69);
            btn_booking.TabIndex = 0;
            btn_booking.Text = "Chọn bàn";
            btn_booking.TextAlign = ContentAlignment.MiddleRight;
            btn_booking.UseVisualStyleBackColor = true;
            btn_booking.Click += btn_booking_Click;
            // 
            // btn_statistics
            // 
            btn_statistics.Image = (Image)resources.GetObject("btn_statistics.Image");
            btn_statistics.ImageAlign = ContentAlignment.MiddleLeft;
            btn_statistics.Location = new Point(328, 64);
            btn_statistics.Name = "btn_statistics";
            btn_statistics.Size = new Size(108, 69);
            btn_statistics.TabIndex = 1;
            btn_statistics.Text = "Thống kê";
            btn_statistics.TextAlign = ContentAlignment.MiddleRight;
            btn_statistics.UseVisualStyleBackColor = true;
            btn_statistics.Click += btn_statistics_Click;
            // 
            // btn_manage
            // 
            btn_manage.Image = (Image)resources.GetObject("btn_manage.Image");
            btn_manage.ImageAlign = ContentAlignment.MiddleLeft;
            btn_manage.Location = new Point(328, 202);
            btn_manage.Name = "btn_manage";
            btn_manage.Size = new Size(108, 69);
            btn_manage.TabIndex = 2;
            btn_manage.Text = "Quản lí";
            btn_manage.TextAlign = ContentAlignment.MiddleRight;
            btn_manage.UseVisualStyleBackColor = true;
            btn_manage.Click += btn_manage_Click;
            // 
            // btn_history
            // 
            btn_history.Image = (Image)resources.GetObject("btn_history.Image");
            btn_history.ImageAlign = ContentAlignment.MiddleLeft;
            btn_history.Location = new Point(65, 202);
            btn_history.Name = "btn_history";
            btn_history.Size = new Size(170, 69);
            btn_history.TabIndex = 3;
            btn_history.Text = "Nhật kí hoạt động";
            btn_history.TextAlign = ContentAlignment.MiddleRight;
            btn_history.UseVisualStyleBackColor = true;
            btn_history.Click += btn_history_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 357);
            Controls.Add(btn_history);
            Controls.Add(btn_manage);
            Controls.Add(btn_statistics);
            Controls.Add(btn_booking);
            Name = "Main";
            Text = "Giao diện chính";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_booking;
        private Button btn_statistics;
        private Button btn_manage;
        private Button btn_history;
    }
}