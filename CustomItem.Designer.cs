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
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnXacNhan = new Button();
            btnHuy = new Button();
            btnRandom = new Button();
            txtHang = new TextBox();
            txtSoTon = new TextBox();
            txtGiaTien = new TextBox();
            txtNgayNhap = new TextBox();
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
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnXacNhan);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnRandom);
            groupBox1.Controls.Add(txtHang);
            groupBox1.Controls.Add(txtSoTon);
            groupBox1.Controls.Add(txtGiaTien);
            groupBox1.Controls.Add(txtNgayNhap);
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
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 688);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Laptop";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 208);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 6;
            label10.Text = "Hãng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 156);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 6;
            label9.Text = "Số tồn:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 260);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 6;
            label8.Text = "Ngày nhập:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 520);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 5;
            label7.Text = "Giá tiền:";
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Maroon;
            btnXacNhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(377, 632);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 50);
            btnXacNhan.TabIndex = 4;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DarkGray;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(235, 632);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 50);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnRandom
            // 
            btnRandom.BackColor = Color.Maroon;
            btnRandom.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRandom.ForeColor = Color.White;
            btnRandom.Location = new Point(235, 35);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(36, 29);
            btnRandom.TabIndex = 3;
            btnRandom.Text = "↺";
            btnRandom.UseVisualStyleBackColor = false;
            btnRandom.Visible = false;
            btnRandom.Click += btnRandom_Click;
            // 
            // txtHang
            // 
            txtHang.BackColor = Color.FromArgb(224, 224, 224);
            txtHang.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtHang.ForeColor = Color.FromArgb(64, 64, 64);
            txtHang.Location = new Point(108, 205);
            txtHang.Name = "txtHang";
            txtHang.Size = new Size(365, 28);
            txtHang.TabIndex = 2;
            // 
            // txtSoTon
            // 
            txtSoTon.BackColor = Color.FromArgb(224, 224, 224);
            txtSoTon.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtSoTon.ForeColor = Color.FromArgb(64, 64, 64);
            txtSoTon.Location = new Point(108, 153);
            txtSoTon.Name = "txtSoTon";
            txtSoTon.Size = new Size(365, 28);
            txtSoTon.TabIndex = 2;
            // 
            // txtGiaTien
            // 
            txtGiaTien.BackColor = Color.FromArgb(224, 224, 224);
            txtGiaTien.Enabled = false;
            txtGiaTien.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtGiaTien.ForeColor = Color.FromArgb(64, 64, 64);
            txtGiaTien.Location = new Point(108, 517);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(365, 28);
            txtGiaTien.TabIndex = 2;
            // 
            // txtNgayNhap
            // 
            txtNgayNhap.BackColor = Color.FromArgb(224, 224, 224);
            txtNgayNhap.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtNgayNhap.ForeColor = Color.FromArgb(64, 64, 64);
            txtNgayNhap.Location = new Point(108, 257);
            txtNgayNhap.Name = "txtNgayNhap";
            txtNgayNhap.Size = new Size(365, 28);
            txtNgayNhap.TabIndex = 2;
            // 
            // txtOCung
            // 
            txtOCung.BackColor = Color.FromArgb(224, 224, 224);
            txtOCung.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtOCung.ForeColor = Color.FromArgb(64, 64, 64);
            txtOCung.Location = new Point(108, 465);
            txtOCung.Name = "txtOCung";
            txtOCung.Size = new Size(365, 28);
            txtOCung.TabIndex = 2;
            // 
            // txtRAM
            // 
            txtRAM.BackColor = Color.FromArgb(224, 224, 224);
            txtRAM.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtRAM.ForeColor = Color.FromArgb(64, 64, 64);
            txtRAM.Location = new Point(108, 413);
            txtRAM.Name = "txtRAM";
            txtRAM.Size = new Size(365, 28);
            txtRAM.TabIndex = 2;
            // 
            // txtGPU
            // 
            txtGPU.BackColor = Color.FromArgb(224, 224, 224);
            txtGPU.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtGPU.ForeColor = Color.FromArgb(64, 64, 64);
            txtGPU.Location = new Point(108, 361);
            txtGPU.Name = "txtGPU";
            txtGPU.Size = new Size(365, 28);
            txtGPU.TabIndex = 2;
            // 
            // txtCPU
            // 
            txtCPU.BackColor = Color.FromArgb(224, 224, 224);
            txtCPU.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtCPU.ForeColor = Color.FromArgb(64, 64, 64);
            txtCPU.Location = new Point(108, 309);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(365, 28);
            txtCPU.TabIndex = 2;
            // 
            // txtTenLaptop
            // 
            txtTenLaptop.BackColor = Color.FromArgb(224, 224, 224);
            txtTenLaptop.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtTenLaptop.ForeColor = Color.FromArgb(64, 64, 64);
            txtTenLaptop.Location = new Point(108, 101);
            txtTenLaptop.Name = "txtTenLaptop";
            txtTenLaptop.Size = new Size(365, 28);
            txtTenLaptop.TabIndex = 2;
            // 
            // txtMaLaptop
            // 
            txtMaLaptop.BackColor = Color.FromArgb(224, 224, 224);
            txtMaLaptop.Enabled = false;
            txtMaLaptop.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtMaLaptop.ForeColor = Color.FromArgb(64, 64, 64);
            txtMaLaptop.Location = new Point(108, 36);
            txtMaLaptop.Name = "txtMaLaptop";
            txtMaLaptop.Size = new Size(125, 28);
            txtMaLaptop.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 468);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 1;
            label6.Text = "Ổ cứng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 416);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 1;
            label5.Text = "RAM:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 364);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 1;
            label4.Text = "GPU:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 312);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 1;
            label3.Text = "CPU:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 104);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên Laptop:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Laptop:";
            // 
            // CustomItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(512, 724);
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
        private Label label7;
        private TextBox txtGiaTien;
        private Label label8;
        private Label label9;
        private TextBox txtSoTon;
        private TextBox txtNgayNhap;
        private Label label10;
        private TextBox txtHang;
    }
}