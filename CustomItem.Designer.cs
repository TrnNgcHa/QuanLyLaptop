namespace QuanLyLaptop
{
    partial class CustomItem
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
            groupBox1 = new GroupBox();
            btnXacNhan = new Button();
            btnHuy = new Button();
            btnRandom = new Button();
            txtOCung = new TextBox();
            txtRAM = new TextBox();
            txtGPU = new TextBox();
            txtCPU = new TextBox();
            txtTenLaptop = new TextBox();
            txtMaLaptop = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXacNhan);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnRandom);
            groupBox1.Controls.Add(txtOCung);
            groupBox1.Controls.Add(txtRAM);
            groupBox1.Controls.Add(txtGPU);
            groupBox1.Controls.Add(txtCPU);
            groupBox1.Controls.Add(txtTenLaptop);
            groupBox1.Controls.Add(txtMaLaptop);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 396);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Laptop";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(192, 341);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 4;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(50, 341);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(227, 35);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(36, 29);
            btnRandom.TabIndex = 3;
            btnRandom.Text = "↺";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Visible = false;
            btnRandom.Click += btnRandom_Click;
            // 
            // txtOCung
            // 
            txtOCung.Location = new Point(98, 289);
            txtOCung.Name = "txtOCung";
            txtOCung.Size = new Size(213, 27);
            txtOCung.TabIndex = 2;
            // 
            // txtRAM
            // 
            txtRAM.Location = new Point(98, 242);
            txtRAM.Name = "txtRAM";
            txtRAM.Size = new Size(213, 27);
            txtRAM.TabIndex = 2;
            // 
            // txtGPU
            // 
            txtGPU.Location = new Point(98, 195);
            txtGPU.Name = "txtGPU";
            txtGPU.Size = new Size(213, 27);
            txtGPU.TabIndex = 2;
            // 
            // txtCPU
            // 
            txtCPU.Location = new Point(98, 148);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(213, 27);
            txtCPU.TabIndex = 2;
            // 
            // txtTenLaptop
            // 
            txtTenLaptop.Location = new Point(98, 101);
            txtTenLaptop.Name = "txtTenLaptop";
            txtTenLaptop.Size = new Size(215, 27);
            txtTenLaptop.TabIndex = 2;
            // 
            // txtMaLaptop
            // 
            txtMaLaptop.Enabled = false;
            txtMaLaptop.Location = new Point(96, 36);
            txtMaLaptop.Name = "txtMaLaptop";
            txtMaLaptop.Size = new Size(125, 27);
            txtMaLaptop.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 292);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 1;
            label6.Text = "Ổ cứng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 245);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 1;
            label5.Text = "RAM:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 198);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 1;
            label4.Text = "GPU:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 151);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 1;
            label3.Text = "CPU:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 104);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên Laptop:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Laptop:";
            // 
            // CustomItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 450);
            Controls.Add(groupBox1);
            Name = "CustomItem";
            Text = "CustomItem";
            Load += CustomItem_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtOCung;
        private TextBox txtRAM;
        private TextBox txtGPU;
        private TextBox txtCPU;
        private TextBox txtTenLaptop;
        private TextBox txtMaLaptop;
        private Button btnRandom;
        private Button btnXacNhan;
        private Button btnHuy;
    }
}