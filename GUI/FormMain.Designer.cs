﻿namespace CafeShop.GUI
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
            SuspendLayout();
            // 
            // btn_booking
            // 
            btn_booking.Location = new Point(66, 70);
            btn_booking.Name = "btn_booking";
            btn_booking.Size = new Size(129, 52);
            btn_booking.TabIndex = 0;
            btn_booking.Text = "Chọn bàn";
            btn_booking.UseVisualStyleBackColor = true;
            btn_booking.Click += btn_booking_Click;
            // 
            // txt_Statistics
            // 
            txt_Statistics.Location = new Point(66, 225);
            txt_Statistics.Name = "txt_Statistics";
            txt_Statistics.Size = new Size(129, 52);
            txt_Statistics.TabIndex = 1;
            txt_Statistics.Text = "Thống kê";
            txt_Statistics.UseVisualStyleBackColor = true;
            txt_Statistics.Click += txt_Statistics_Click;
            // 
            // btn_menu
            // 
            btn_menu.Location = new Point(400, 70);
            btn_menu.Name = "btn_menu";
            btn_menu.Size = new Size(129, 52);
            btn_menu.TabIndex = 2;
            btn_menu.Text = "Menu";
            btn_menu.UseVisualStyleBackColor = true;
            btn_menu.Click += btn_menu_Click;
            // 
            // btn_manage
            // 
            btn_manage.Location = new Point(400, 225);
            btn_manage.Name = "btn_manage";
            btn_manage.Size = new Size(129, 52);
            btn_manage.TabIndex = 3;
            btn_manage.Text = "Quản lý";
            btn_manage.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 353);
            Controls.Add(btn_manage);
            Controls.Add(btn_menu);
            Controls.Add(txt_Statistics);
            Controls.Add(btn_booking);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_booking;
        private Button txt_Statistics;
        private Button btn_menu;
        private Button btn_manage;
    }
}