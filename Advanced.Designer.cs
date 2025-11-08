namespace QuanLyLaptop
{
    partial class Advanced
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            flpBinhLuan = new FlowLayoutPanel();
            ckbNamSao = new CheckBox();
            ckbBonSao = new CheckBox();
            groupBox4 = new GroupBox();
            btnDanhGia = new Button();
            cmbSoSao = new ComboBox();
            txtDanhGia = new TextBox();
            label11 = new Label();
            ckbBaSao = new CheckBox();
            lblTenLaptop = new Label();
            ckbHaiSao = new CheckBox();
            groupBox2 = new GroupBox();
            lblRAMInfo = new Label();
            lblStorageInfo = new Label();
            lblGPUInfo = new Label();
            lblCPUInfo = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ckbMotSao = new CheckBox();
            label5 = new Label();
            label14 = new Label();
            groupBox1 = new GroupBox();
            btnTTTK = new Button();
            btnNapTien = new Button();
            btnThoat = new Button();
            btnPurchase = new Button();
            panel2 = new Panel();
            lblSoDu = new Label();
            lblTenTaiKhoan = new Label();
            lblTenNguoiDung = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            btnTimKiem = new Button();
            txtFilter = new TextBox();
            cmbLoaiTimKiem = new ComboBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            flpDanhSachLaptop = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.7921F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.207901F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(flpDanhSachLaptop, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(1924, 1055);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(flpBinhLuan);
            panel1.Controls.Add(ckbNamSao);
            panel1.Controls.Add(ckbBonSao);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(ckbBaSao);
            panel1.Controls.Add(lblTenLaptop);
            panel1.Controls.Add(ckbHaiSao);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(ckbMotSao);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1442, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 944);
            panel1.TabIndex = 1;
            // 
            // flpBinhLuan
            // 
            flpBinhLuan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flpBinhLuan.AutoScroll = true;
            flpBinhLuan.Location = new Point(9, 631);
            flpBinhLuan.Name = "flpBinhLuan";
            flpBinhLuan.Size = new Size(467, 290);
            flpBinhLuan.TabIndex = 4;
            // 
            // ckbNamSao
            // 
            ckbNamSao.AutoSize = true;
            ckbNamSao.Checked = true;
            ckbNamSao.CheckState = CheckState.Checked;
            ckbNamSao.Cursor = Cursors.Hand;
            ckbNamSao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckbNamSao.ForeColor = Color.FromArgb(26, 26, 26);
            ckbNamSao.Location = new Point(369, 606);
            ckbNamSao.Name = "ckbNamSao";
            ckbNamSao.Size = new Size(58, 24);
            ckbNamSao.TabIndex = 1;
            ckbNamSao.Text = "5 ★";
            ckbNamSao.UseVisualStyleBackColor = true;
            ckbNamSao.CheckedChanged += ChonLoaiDanhGia;
            // 
            // ckbBonSao
            // 
            ckbBonSao.AutoSize = true;
            ckbBonSao.Checked = true;
            ckbBonSao.CheckState = CheckState.Checked;
            ckbBonSao.Cursor = Cursors.Hand;
            ckbBonSao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckbBonSao.ForeColor = Color.FromArgb(26, 26, 26);
            ckbBonSao.Location = new Point(307, 606);
            ckbBonSao.Name = "ckbBonSao";
            ckbBonSao.Size = new Size(58, 24);
            ckbBonSao.TabIndex = 1;
            ckbBonSao.Text = "4 ★";
            ckbBonSao.UseVisualStyleBackColor = true;
            ckbBonSao.CheckedChanged += ChonLoaiDanhGia;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Silver;
            groupBox4.Controls.Add(btnDanhGia);
            groupBox4.Controls.Add(cmbSoSao);
            groupBox4.Controls.Add(txtDanhGia);
            groupBox4.Controls.Add(label11);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.FromArgb(26, 26, 26);
            groupBox4.Location = new Point(9, 517);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(433, 83);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Đánh Giá";
            // 
            // btnDanhGia
            // 
            btnDanhGia.Image = Properties.Resources.send;
            btnDanhGia.Location = new Point(395, 38);
            btnDanhGia.Name = "btnDanhGia";
            btnDanhGia.Size = new Size(29, 29);
            btnDanhGia.TabIndex = 4;
            btnDanhGia.UseVisualStyleBackColor = true;
            btnDanhGia.Click += btnDanhGia_Click;
            // 
            // cmbSoSao
            // 
            cmbSoSao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSoSao.FormattingEnabled = true;
            cmbSoSao.Items.AddRange(new object[] { "1 ★", "2 ★", "3 ★", "4 ★", "5 ★" });
            cmbSoSao.Location = new Point(84, 39);
            cmbSoSao.Name = "cmbSoSao";
            cmbSoSao.Size = new Size(52, 28);
            cmbSoSao.TabIndex = 3;
            cmbSoSao.Text = "5 ★";
            // 
            // txtDanhGia
            // 
            txtDanhGia.Location = new Point(148, 39);
            txtDanhGia.Multiline = true;
            txtDanhGia.Name = "txtDanhGia";
            txtDanhGia.Size = new Size(249, 28);
            txtDanhGia.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(26, 26, 26);
            label11.Location = new Point(6, 42);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 1;
            label11.Text = "Mức sao:";
            // 
            // ckbBaSao
            // 
            ckbBaSao.AutoSize = true;
            ckbBaSao.Checked = true;
            ckbBaSao.CheckState = CheckState.Checked;
            ckbBaSao.Cursor = Cursors.Hand;
            ckbBaSao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckbBaSao.ForeColor = Color.FromArgb(26, 26, 26);
            ckbBaSao.Location = new Point(245, 606);
            ckbBaSao.Name = "ckbBaSao";
            ckbBaSao.Size = new Size(58, 24);
            ckbBaSao.TabIndex = 1;
            ckbBaSao.Text = "3 ★";
            ckbBaSao.UseVisualStyleBackColor = true;
            ckbBaSao.CheckedChanged += ChonLoaiDanhGia;
            // 
            // lblTenLaptop
            // 
            lblTenLaptop.Anchor = AnchorStyles.Top;
            lblTenLaptop.AutoSize = true;
            lblTenLaptop.BorderStyle = BorderStyle.FixedSingle;
            lblTenLaptop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenLaptop.ForeColor = Color.Maroon;
            lblTenLaptop.Location = new Point(115, 15);
            lblTenLaptop.Name = "lblTenLaptop";
            lblTenLaptop.Size = new Size(2, 30);
            lblTenLaptop.TabIndex = 2;
            lblTenLaptop.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ckbHaiSao
            // 
            ckbHaiSao.AutoSize = true;
            ckbHaiSao.Checked = true;
            ckbHaiSao.CheckState = CheckState.Checked;
            ckbHaiSao.Cursor = Cursors.Hand;
            ckbHaiSao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckbHaiSao.ForeColor = Color.FromArgb(26, 26, 26);
            ckbHaiSao.Location = new Point(183, 606);
            ckbHaiSao.Name = "ckbHaiSao";
            ckbHaiSao.Size = new Size(58, 24);
            ckbHaiSao.TabIndex = 1;
            ckbHaiSao.Text = "2 ★";
            ckbHaiSao.UseVisualStyleBackColor = true;
            ckbHaiSao.CheckedChanged += ChonLoaiDanhGia;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(lblRAMInfo);
            groupBox2.Controls.Add(lblStorageInfo);
            groupBox2.Controls.Add(lblGPUInfo);
            groupBox2.Controls.Add(lblCPUInfo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(26, 26, 26);
            groupBox2.Location = new Point(9, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 234);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi Tiết Sản Phẩm";
            // 
            // lblRAMInfo
            // 
            lblRAMInfo.BackColor = Color.FromArgb(224, 224, 224);
            lblRAMInfo.BorderStyle = BorderStyle.Fixed3D;
            lblRAMInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRAMInfo.ForeColor = Color.FromArgb(64, 64, 64);
            lblRAMInfo.Location = new Point(106, 192);
            lblRAMInfo.Name = "lblRAMInfo";
            lblRAMInfo.Size = new Size(257, 25);
            lblRAMInfo.TabIndex = 1;
            lblRAMInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStorageInfo
            // 
            lblStorageInfo.BackColor = Color.FromArgb(224, 224, 224);
            lblStorageInfo.BorderStyle = BorderStyle.Fixed3D;
            lblStorageInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStorageInfo.ForeColor = Color.FromArgb(64, 64, 64);
            lblStorageInfo.Location = new Point(106, 145);
            lblStorageInfo.Name = "lblStorageInfo";
            lblStorageInfo.Size = new Size(257, 25);
            lblStorageInfo.TabIndex = 1;
            lblStorageInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGPUInfo
            // 
            lblGPUInfo.BackColor = Color.FromArgb(224, 224, 224);
            lblGPUInfo.BorderStyle = BorderStyle.Fixed3D;
            lblGPUInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGPUInfo.ForeColor = Color.FromArgb(64, 64, 64);
            lblGPUInfo.Location = new Point(106, 106);
            lblGPUInfo.Name = "lblGPUInfo";
            lblGPUInfo.Size = new Size(257, 25);
            lblGPUInfo.TabIndex = 1;
            lblGPUInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCPUInfo
            // 
            lblCPUInfo.BackColor = Color.FromArgb(224, 224, 224);
            lblCPUInfo.BorderStyle = BorderStyle.Fixed3D;
            lblCPUInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCPUInfo.ForeColor = Color.FromArgb(64, 64, 64);
            lblCPUInfo.Location = new Point(106, 60);
            lblCPUInfo.Name = "lblCPUInfo";
            lblCPUInfo.Size = new Size(257, 25);
            lblCPUInfo.TabIndex = 1;
            lblCPUInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 194);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 0;
            label4.Text = "RAM:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 150);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 0;
            label3.Text = "Ổ Cứng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 106);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "GPU:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 62);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "CPU:";
            // 
            // ckbMotSao
            // 
            ckbMotSao.AutoSize = true;
            ckbMotSao.Checked = true;
            ckbMotSao.CheckState = CheckState.Checked;
            ckbMotSao.Cursor = Cursors.Hand;
            ckbMotSao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckbMotSao.ForeColor = Color.FromArgb(26, 26, 26);
            ckbMotSao.Location = new Point(121, 606);
            ckbMotSao.Name = "ckbMotSao";
            ckbMotSao.Size = new Size(58, 24);
            ckbMotSao.TabIndex = 1;
            ckbMotSao.Text = "1 ★";
            ckbMotSao.UseVisualStyleBackColor = true;
            ckbMotSao.CheckedChanged += ChonLoaiDanhGia;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(9, 16);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 0;
            label5.Text = "Laptop:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(26, 26, 26);
            label14.Location = new Point(9, 608);
            label14.Name = "label14";
            label14.Size = new Size(106, 20);
            label14.TabIndex = 0;
            label14.Text = "Loại đánh giá:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(btnTTTK);
            groupBox1.Controls.Add(btnNapTien);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnPurchase);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox1.Location = new Point(9, 322);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // btnTTTK
            // 
            btnTTTK.BackColor = Color.SteelBlue;
            btnTTTK.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTTTK.ForeColor = Color.White;
            btnTTTK.Location = new Point(185, 40);
            btnTTTK.Name = "btnTTTK";
            btnTTTK.Size = new Size(120, 58);
            btnTTTK.TabIndex = 4;
            btnTTTK.Text = "Trung tâm\r\ntài khoản";
            btnTTTK.UseVisualStyleBackColor = false;
            btnTTTK.Click += btnTTTK_Click;
            // 
            // btnNapTien
            // 
            btnNapTien.BackColor = Color.DarkGoldenrod;
            btnNapTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNapTien.ForeColor = Color.White;
            btnNapTien.Location = new Point(35, 104);
            btnNapTien.Name = "btnNapTien";
            btnNapTien.Size = new Size(120, 58);
            btnNapTien.TabIndex = 4;
            btnNapTien.Text = "Nạp tiền";
            btnNapTien.UseVisualStyleBackColor = false;
            btnNapTien.Click += btnNapTien_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Gray;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(185, 104);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 58);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.Maroon;
            btnPurchase.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.ForeColor = Color.White;
            btnPurchase.Location = new Point(35, 40);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(120, 58);
            btnPurchase.TabIndex = 0;
            btnPurchase.Text = "Mua";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(lblSoDu);
            panel2.Controls.Add(lblTenTaiKhoan);
            panel2.Controls.Add(lblTenNguoiDung);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1442, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 99);
            panel2.TabIndex = 2;
            // 
            // lblSoDu
            // 
            lblSoDu.AutoSize = true;
            lblSoDu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoDu.ForeColor = Color.Maroon;
            lblSoDu.Location = new Point(283, 54);
            lblSoDu.Name = "lblSoDu";
            lblSoDu.Size = new Size(0, 20);
            lblSoDu.TabIndex = 3;
            // 
            // lblTenTaiKhoan
            // 
            lblTenTaiKhoan.AutoSize = true;
            lblTenTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenTaiKhoan.ForeColor = Color.Maroon;
            lblTenTaiKhoan.Location = new Point(312, 17);
            lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            lblTenTaiKhoan.Size = new Size(0, 20);
            lblTenTaiKhoan.TabIndex = 2;
            // 
            // lblTenNguoiDung
            // 
            lblTenNguoiDung.AutoSize = true;
            lblTenNguoiDung.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenNguoiDung.ForeColor = Color.FromArgb(64, 64, 64);
            lblTenNguoiDung.Location = new Point(107, 17);
            lblTenNguoiDung.Name = "lblTenNguoiDung";
            lblTenNguoiDung.Size = new Size(0, 20);
            lblTenNguoiDung.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(232, 54);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 0;
            label8.Text = "Số dư:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(232, 17);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 0;
            label7.Text = "Tài khoản:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(9, 17);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 0;
            label6.Text = "Người dùng:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(txtFilter);
            panel3.Controls.Add(cmbLoaiTimKiem);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(groupBox3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1433, 99);
            panel3.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Maroon;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(482, 45);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(30, 29);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "⌕";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtFilter
            // 
            txtFilter.BackColor = Color.White;
            txtFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFilter.ForeColor = Color.FromArgb(64, 64, 64);
            txtFilter.Location = new Point(218, 46);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(258, 27);
            txtFilter.TabIndex = 6;
            txtFilter.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbLoaiTimKiem
            // 
            cmbLoaiTimKiem.BackColor = Color.White;
            cmbLoaiTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbLoaiTimKiem.ForeColor = Color.FromArgb(64, 64, 64);
            cmbLoaiTimKiem.FormattingEnabled = true;
            cmbLoaiTimKiem.Items.AddRange(new object[] { "Tất cả", "Mã Laptop", "Tên Laptop", "Hãng Laptop", "CPU", "GPU", "RAM", "Ổ cứng" });
            cmbLoaiTimKiem.Location = new Point(95, 45);
            cmbLoaiTimKiem.Name = "cmbLoaiTimKiem";
            cmbLoaiTimKiem.Size = new Size(117, 28);
            cmbLoaiTimKiem.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(16, 48);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 4;
            label9.Text = "Tìm kiếm:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(224, 224, 224);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(179, 179, 179);
            groupBox3.Location = new Point(9, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(513, 93);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // flpDanhSachLaptop
            // 
            flpDanhSachLaptop.AutoScroll = true;
            flpDanhSachLaptop.BackColor = Color.FromArgb(224, 224, 224);
            flpDanhSachLaptop.Dock = DockStyle.Fill;
            flpDanhSachLaptop.Location = new Point(3, 108);
            flpDanhSachLaptop.Name = "flpDanhSachLaptop";
            flpDanhSachLaptop.Size = new Size(1433, 944);
            flpDanhSachLaptop.TabIndex = 4;
            // 
            // Advanced
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(tableLayoutPanel1);
            Name = "Advanced";
            Text = "Advanced";
            Load += Advanced_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private FlowLayoutPanel flpBinhLuan;
        private CheckBox ckbNamSao;
        private CheckBox ckbBonSao;
        private GroupBox groupBox4;
        private Button btnDanhGia;
        private ComboBox cmbSoSao;
        private TextBox txtDanhGia;
        private Label label11;
        private CheckBox ckbBaSao;
        private Label lblTenLaptop;
        private CheckBox ckbHaiSao;
        private GroupBox groupBox2;
        private Label lblRAMInfo;
        private Label lblStorageInfo;
        private Label lblGPUInfo;
        private Label lblCPUInfo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox ckbMotSao;
        private Label label5;
        private Label label14;
        private GroupBox groupBox1;
        private Button btnTTTK;
        private Button btnNapTien;
        private Button btnThoat;
        private Button btnPurchase;
        private Panel panel2;
        private Label lblSoDu;
        private Label lblTenTaiKhoan;
        private Label lblTenNguoiDung;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel3;
        private Button btnTimKiem;
        private TextBox txtFilter;
        private ComboBox cmbLoaiTimKiem;
        private Label label9;
        private GroupBox groupBox3;
        private FlowLayoutPanel flpDanhSachLaptop;
    }
}