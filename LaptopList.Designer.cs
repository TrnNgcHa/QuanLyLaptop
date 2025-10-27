namespace QuanLyLaptop
{
    partial class LaptopList
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
            dgvDanhSachLaptop = new DataGridView();
            STT1 = new DataGridViewTextBoxColumn();
            MaLaptop = new DataGridViewTextBoxColumn();
            TenLaptop = new DataGridViewTextBoxColumn();
            TenHang = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            SoTon = new DataGridViewTextBoxColumn();
            CPU = new DataGridViewTextBoxColumn();
            GPU = new DataGridViewTextBoxColumn();
            OCung = new DataGridViewTextBoxColumn();
            RAM = new DataGridViewTextBoxColumn();
            GiaTien = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            lblTenLaptop = new Label();
            groupBox2 = new GroupBox();
            lblRAMInfo = new Label();
            lblStorageInfo = new Label();
            lblGPUInfo = new Label();
            lblCPUInfo = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnReview = new Button();
            btnPurchase = new Button();
            panel2 = new Panel();
            btnNapTien = new Button();
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
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLaptop).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Black;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(dgvDanhSachLaptop, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(1894, 1055);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDanhSachLaptop
            // 
            dgvDanhSachLaptop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachLaptop.Columns.AddRange(new DataGridViewColumn[] { STT1, MaLaptop, TenLaptop, TenHang, NgayNhap, SoTon, CPU, GPU, OCung, RAM, GiaTien });
            dgvDanhSachLaptop.Dock = DockStyle.Fill;
            dgvDanhSachLaptop.Location = new Point(3, 108);
            dgvDanhSachLaptop.Name = "dgvDanhSachLaptop";
            dgvDanhSachLaptop.RowHeadersWidth = 51;
            dgvDanhSachLaptop.Size = new Size(1130, 944);
            dgvDanhSachLaptop.TabIndex = 0;
            dgvDanhSachLaptop.CellEnter += dgvDanhSachLaptop_CellEnter;
            dgvDanhSachLaptop.DataBindingComplete += dgvDanhSachLaptop_DataBindingComplete;
            // 
            // STT1
            // 
            STT1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            STT1.HeaderText = "STT";
            STT1.MinimumWidth = 6;
            STT1.Name = "STT1";
            STT1.Width = 62;
            // 
            // MaLaptop
            // 
            MaLaptop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaLaptop.DataPropertyName = "LaptopID";
            MaLaptop.HeaderText = "Mã Laptop";
            MaLaptop.MinimumWidth = 6;
            MaLaptop.Name = "MaLaptop";
            MaLaptop.Width = 110;
            // 
            // TenLaptop
            // 
            TenLaptop.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenLaptop.DataPropertyName = "LaptopName";
            TenLaptop.HeaderText = "Tên Laptop";
            TenLaptop.MinimumWidth = 6;
            TenLaptop.Name = "TenLaptop";
            // 
            // TenHang
            // 
            TenHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenHang.DataPropertyName = "AgencyName";
            TenHang.HeaderText = "Tên Hãng";
            TenHang.MinimumWidth = 6;
            TenHang.Name = "TenHang";
            TenHang.Width = 101;
            // 
            // NgayNhap
            // 
            NgayNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NgayNhap.DataPropertyName = "StockInDate";
            NgayNhap.HeaderText = "Ngày Nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.Width = 113;
            // 
            // SoTon
            // 
            SoTon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SoTon.DataPropertyName = "RemainAmount";
            SoTon.HeaderText = "Số Tồn";
            SoTon.MinimumWidth = 6;
            SoTon.Name = "SoTon";
            SoTon.Width = 84;
            // 
            // CPU
            // 
            CPU.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CPU.DataPropertyName = "CPU";
            CPU.HeaderText = "CPU";
            CPU.MinimumWidth = 6;
            CPU.Name = "CPU";
            CPU.Visible = false;
            CPU.Width = 125;
            // 
            // GPU
            // 
            GPU.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GPU.DataPropertyName = "GPU";
            GPU.HeaderText = "GPU";
            GPU.MinimumWidth = 6;
            GPU.Name = "GPU";
            GPU.Visible = false;
            GPU.Width = 125;
            // 
            // OCung
            // 
            OCung.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OCung.DataPropertyName = "Storage";
            OCung.HeaderText = "Ổ Cứng";
            OCung.MinimumWidth = 6;
            OCung.Name = "OCung";
            OCung.Visible = false;
            OCung.Width = 125;
            // 
            // RAM
            // 
            RAM.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RAM.DataPropertyName = "RAM";
            RAM.HeaderText = "RAM";
            RAM.MinimumWidth = 6;
            RAM.Name = "RAM";
            RAM.Visible = false;
            RAM.Width = 125;
            // 
            // GiaTien
            // 
            GiaTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GiaTien.DataPropertyName = "Price";
            GiaTien.HeaderText = "Giá Tiền";
            GiaTien.MinimumWidth = 6;
            GiaTien.Name = "GiaTien";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblTenLaptop);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1139, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 944);
            panel1.TabIndex = 1;
            // 
            // lblTenLaptop
            // 
            lblTenLaptop.Anchor = AnchorStyles.Top;
            lblTenLaptop.AutoSize = true;
            lblTenLaptop.BorderStyle = BorderStyle.FixedSingle;
            lblTenLaptop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenLaptop.ForeColor = Color.Maroon;
            lblTenLaptop.Location = new Point(284, 7);
            lblTenLaptop.Name = "lblTenLaptop";
            lblTenLaptop.Size = new Size(2, 30);
            lblTenLaptop.TabIndex = 2;
            lblTenLaptop.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.BackColor = Color.FromArgb(224, 224, 224);
            groupBox2.Controls.Add(lblRAMInfo);
            groupBox2.Controls.Add(lblStorageInfo);
            groupBox2.Controls.Add(lblGPUInfo);
            groupBox2.Controls.Add(lblCPUInfo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox2.Location = new Point(178, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 234);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi Tiết Sản Phẩm";
            // 
            // lblRAMInfo
            // 
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
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(190, 8);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 0;
            label5.Text = "Laptop:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnReview);
            groupBox1.Controls.Add(btnPurchase);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox1.Location = new Point(178, 301);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.DarkGray;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(297, 40);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 40);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnReview
            // 
            btnReview.BackColor = Color.Red;
            btnReview.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReview.ForeColor = Color.White;
            btnReview.Location = new Point(132, 40);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(120, 40);
            btnReview.TabIndex = 0;
            btnReview.Text = "Đánh Giá";
            btnReview.UseVisualStyleBackColor = false;
            btnReview.Click += btnReview_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.Red;
            btnPurchase.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.ForeColor = Color.White;
            btnPurchase.Location = new Point(6, 40);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(120, 40);
            btnPurchase.TabIndex = 0;
            btnPurchase.Text = "Mua";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnNapTien);
            panel2.Controls.Add(lblSoDu);
            panel2.Controls.Add(lblTenTaiKhoan);
            panel2.Controls.Add(lblTenNguoiDung);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1139, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 99);
            panel2.TabIndex = 2;
            // 
            // btnNapTien
            // 
            btnNapTien.BackColor = Color.Goldenrod;
            btnNapTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNapTien.ForeColor = Color.White;
            btnNapTien.Location = new Point(625, 13);
            btnNapTien.Name = "btnNapTien";
            btnNapTien.Size = new Size(94, 34);
            btnNapTien.TabIndex = 4;
            btnNapTien.Text = "Nạp tiền";
            btnNapTien.UseVisualStyleBackColor = false;
            btnNapTien.Click += btnNapTien_Click;
            // 
            // lblSoDu
            // 
            lblSoDu.AutoSize = true;
            lblSoDu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoDu.ForeColor = Color.FromArgb(64, 64, 64);
            lblSoDu.Location = new Point(470, 17);
            lblSoDu.Name = "lblSoDu";
            lblSoDu.Size = new Size(0, 20);
            lblSoDu.TabIndex = 3;
            // 
            // lblTenTaiKhoan
            // 
            lblTenTaiKhoan.AutoSize = true;
            lblTenTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenTaiKhoan.ForeColor = Color.FromArgb(64, 64, 64);
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
            label8.Location = new Point(419, 17);
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
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(txtFilter);
            panel3.Controls.Add(cmbLoaiTimKiem);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(groupBox3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1130, 99);
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
            cmbLoaiTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbLoaiTimKiem.ForeColor = Color.FromArgb(64, 64, 64);
            cmbLoaiTimKiem.FormattingEnabled = true;
            cmbLoaiTimKiem.Items.AddRange(new object[] { "Mã Laptop", "Tên Laptop", "Hãng Laptop", "CPU", "GPU", "RAM", "Ổ cứng" });
            cmbLoaiTimKiem.Location = new Point(95, 45);
            cmbLoaiTimKiem.Name = "cmbLoaiTimKiem";
            cmbLoaiTimKiem.Size = new Size(117, 28);
            cmbLoaiTimKiem.TabIndex = 5;
            cmbLoaiTimKiem.Text = "Tên Laptop";
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
            // LaptopList
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1894, 1055);
            Controls.Add(tableLayoutPanel1);
            Name = "LaptopList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Sách Laptop";
            WindowState = FormWindowState.Maximized;
            Load += DanhSachLaptop_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLaptop).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private DataGridView dgvDanhSachLaptop;
        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnReview;
        private Button btnPurchase;
        private Label lblCPUInfo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblRAMInfo;
        private Label lblStorageInfo;
        private Label lblGPUInfo;
        private DataGridViewTextBoxColumn STT1;
        private DataGridViewTextBoxColumn MaLaptop;
        private DataGridViewTextBoxColumn TenLaptop;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn SoTon;
        private DataGridViewTextBoxColumn CPU;
        private DataGridViewTextBoxColumn GPU;
        private DataGridViewTextBoxColumn OCung;
        private DataGridViewTextBoxColumn RAM;
        private DataGridViewTextBoxColumn GiaTien;
        private Label lblTenLaptop;
        private Panel panel2;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label lblTenNguoiDung;
        private Label lblTenTaiKhoan;
        private Label label8;
        private Label lblSoDu;
        private Panel panel3;
        private Button btnTimKiem;
        private TextBox txtFilter;
        private ComboBox cmbLoaiTimKiem;
        private Label label9;
        private Button btnThoat;
        private Button btnNapTien;
        private GroupBox groupBox3;
    }
}