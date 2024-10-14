namespace CafeShop.GUI
{
    partial class FormBooking
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
            panel2 = new Panel();
            panel5 = new Panel();
            numericUpDown2 = new NumericUpDown();
            button3 = new Button();
            button2 = new Button();
            comboBox3 = new ComboBox();
            button1 = new Button();
            panel4 = new Panel();
            listView1 = new ListView();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            btn_Add = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            flpTable = new FlowLayoutPanel();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(473, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 448);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(numericUpDown2);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(comboBox3);
            panel5.Controls.Add(button1);
            panel5.Location = new Point(12, 386);
            panel5.Name = "panel5";
            panel5.Size = new Size(473, 59);
            panel5.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(135, 33);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(86, 23);
            numericUpDown2.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new Point(135, 11);
            button3.Name = "button3";
            button3.Size = new Size(86, 23);
            button3.TabIndex = 11;
            button3.Text = "Giảm giá";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(378, 0);
            button2.Name = "button2";
            button2.Size = new Size(85, 56);
            button2.TabIndex = 10;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(13, 33);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(93, 23);
            comboBox3.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(13, 11);
            button1.Name = "button1";
            button1.Size = new Size(93, 24);
            button1.TabIndex = 8;
            button1.Text = "Chuyển bàn";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(listView1);
            panel4.Location = new Point(12, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 303);
            panel4.TabIndex = 7;
            // 
            // listView1
            // 
            listView1.Location = new Point(13, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(450, 297);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btn_Add);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(comboBox2);
            panel3.Location = new Point(12, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(473, 61);
            panel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(13, 37);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Tên món:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(13, 11);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Danh mục:";
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(378, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(85, 53);
            btn_Add.TabIndex = 2;
            btn_Add.Text = "Thêm món";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(300, 32);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(60, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(300, 8);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Số lượng:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(85, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(85, 34);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(199, 23);
            comboBox2.TabIndex = 1;
            // 
            // flpTable
            // 
            flpTable.Location = new Point(7, 12);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(460, 448);
            flpTable.TabIndex = 2;
            // 
            // FormBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 472);
            Controls.Add(flpTable);
            Controls.Add(panel2);
            Name = "FormBooking";
            Text = "FormBooking";
            Load += FormBooking_Load;
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private NumericUpDown numericUpDown1;
        private Button btn_Add;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Panel panel5;
        private Button button2;
        private ComboBox comboBox3;
        private Button button1;
        private NumericUpDown numericUpDown2;
        private Button button3;
        private ListView listView1;
        private FlowLayoutPanel flpTable;
    }
}