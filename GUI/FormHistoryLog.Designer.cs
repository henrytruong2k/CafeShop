﻿namespace CafeShop.GUI
{
    partial class FormHistoryLog
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
            components = new System.ComponentModel.Container();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand3 = new Microsoft.Data.SqlClient.SqlCommand();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            dgv_HistoryLog = new DataGridView();
            sqlCommand4 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HistoryLog).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand3
            // 
            sqlCommand3.CommandTimeout = 30;
            sqlCommand3.EnableOptimizedParameterBinding = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(958, 629);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgv_HistoryLog);
            panel2.Location = new Point(3, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(955, 533);
            panel2.TabIndex = 1;
            // 
            // dgv_HistoryLog
            // 
            dgv_HistoryLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HistoryLog.Location = new Point(3, 3);
            dgv_HistoryLog.Name = "dgv_HistoryLog";
            dgv_HistoryLog.RowHeadersWidth = 51;
            dgv_HistoryLog.Size = new Size(949, 527);
            dgv_HistoryLog.TabIndex = 0;
            // 
            // sqlCommand4
            // 
            sqlCommand4.CommandTimeout = 30;
            sqlCommand4.EnableOptimizedParameterBinding = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 87);
            panel1.TabIndex = 0;
            // 
            // FormHistoryLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(flowLayoutPanel1);
            Name = "FormHistoryLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch sử đăng nhập";
            Load += FormHistoryLog_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_HistoryLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand3;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private DataGridView dgv_HistoryLog;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand4;
        private Panel panel1;
    }
}