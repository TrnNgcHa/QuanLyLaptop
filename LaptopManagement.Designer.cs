namespace QuanLyLaptop
{
    partial class LaptopManagement
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
            grbTTLaptop = new GroupBox();
            dtpNgayNhap = new DateTimePicker();
            label10 = new Label();
            btnHuy = new Button();
            btnXacNhan = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtHang = new TextBox();
            txtSoTon = new TextBox();
            txtGiaTien = new TextBox();
            txtOCung = new TextBox();
            txtRAM = new TextBox();
            txtGPU = new TextBox();
            txtCPU = new TextBox();
            txtTenLaptop = new TextBox();
            txtMaLaptop = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            lblTenLaptop = new Label();
            grbCTSP = new GroupBox();
            lblRAMInfo = new Label();
            lblStorageInfo = new Label();
            lblGPUInfo = new Label();
            lblCPUInfo = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            btnTimKiem = new Button();
            txtFilter = new TextBox();
            cmbLoaiTimKiem = new ComboBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLaptop).BeginInit();
            panel1.SuspendLayout();
            grbTTLaptop.SuspendLayout();
            groupBox1.SuspendLayout();
            grbCTSP.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(dgvDanhSachLaptop, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(1924, 1055);
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
            dgvDanhSachLaptop.Size = new Size(1148, 944);
            dgvDanhSachLaptop.TabIndex = 1;
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
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(grbTTLaptop);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblTenLaptop);
            panel1.Controls.Add(grbCTSP);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1157, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 944);
            panel1.TabIndex = 2;
            // 
            // grbTTLaptop
            // 
            grbTTLaptop.BackColor = Color.LightGray;
            grbTTLaptop.Controls.Add(dtpNgayNhap);
            grbTTLaptop.Controls.Add(label10);
            grbTTLaptop.Controls.Add(btnHuy);
            grbTTLaptop.Controls.Add(btnXacNhan);
            grbTTLaptop.Controls.Add(label9);
            grbTTLaptop.Controls.Add(label8);
            grbTTLaptop.Controls.Add(label7);
            grbTTLaptop.Controls.Add(txtHang);
            grbTTLaptop.Controls.Add(txtSoTon);
            grbTTLaptop.Controls.Add(txtGiaTien);
            grbTTLaptop.Controls.Add(txtOCung);
            grbTTLaptop.Controls.Add(txtRAM);
            grbTTLaptop.Controls.Add(txtGPU);
            grbTTLaptop.Controls.Add(txtCPU);
            grbTTLaptop.Controls.Add(txtTenLaptop);
            grbTTLaptop.Controls.Add(txtMaLaptop);
            grbTTLaptop.Controls.Add(label11);
            grbTTLaptop.Controls.Add(label12);
            grbTTLaptop.Controls.Add(label13);
            grbTTLaptop.Controls.Add(label14);
            grbTTLaptop.Controls.Add(label15);
            grbTTLaptop.Controls.Add(label16);
            grbTTLaptop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbTTLaptop.ForeColor = Color.FromArgb(64, 64, 64);
            grbTTLaptop.Location = new Point(425, 50);
            grbTTLaptop.Name = "grbTTLaptop";
            grbTTLaptop.Size = new Size(330, 573);
            grbTTLaptop.TabIndex = 7;
            grbTTLaptop.TabStop = false;
            grbTTLaptop.Text = "Thông tin Laptop";
            grbTTLaptop.Visible = false;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(108, 236);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(160, 27);
            dtpNgayNhap.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 149);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 6;
            label10.Text = "Hãng:";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Gray;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(104, 517);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(89, 45);
            btnHuy.TabIndex = 0;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Maroon;
            btnXacNhan.Cursor = Cursors.Hand;
            btnXacNhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(212, 517);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(112, 45);
            btnXacNhan.TabIndex = 0;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 194);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 6;
            label9.Text = "Số tồn:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 239);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 6;
            label8.Text = "Ngày nhập:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 464);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 5;
            label7.Text = "Giá tiền:";
            // 
            // txtHang
            // 
            txtHang.BackColor = Color.White;
            txtHang.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtHang.ForeColor = Color.Black;
            txtHang.Location = new Point(108, 146);
            txtHang.Name = "txtHang";
            txtHang.Size = new Size(115, 27);
            txtHang.TabIndex = 2;
            // 
            // txtSoTon
            // 
            txtSoTon.BackColor = Color.White;
            txtSoTon.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtSoTon.ForeColor = Color.Black;
            txtSoTon.Location = new Point(108, 191);
            txtSoTon.Name = "txtSoTon";
            txtSoTon.Size = new Size(115, 27);
            txtSoTon.TabIndex = 2;
            txtSoTon.KeyPress += txtSoTon_KeyPress;
            // 
            // txtGiaTien
            // 
            txtGiaTien.BackColor = Color.White;
            txtGiaTien.Enabled = false;
            txtGiaTien.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtGiaTien.ForeColor = Color.Black;
            txtGiaTien.Location = new Point(108, 461);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.Size = new Size(186, 27);
            txtGiaTien.TabIndex = 2;
            // 
            // txtOCung
            // 
            txtOCung.BackColor = Color.White;
            txtOCung.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtOCung.ForeColor = Color.Black;
            txtOCung.Location = new Point(108, 416);
            txtOCung.Name = "txtOCung";
            txtOCung.Size = new Size(186, 27);
            txtOCung.TabIndex = 2;
            // 
            // txtRAM
            // 
            txtRAM.BackColor = Color.White;
            txtRAM.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtRAM.ForeColor = Color.Black;
            txtRAM.Location = new Point(108, 371);
            txtRAM.Name = "txtRAM";
            txtRAM.Size = new Size(186, 27);
            txtRAM.TabIndex = 2;
            // 
            // txtGPU
            // 
            txtGPU.BackColor = Color.White;
            txtGPU.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtGPU.ForeColor = Color.Black;
            txtGPU.Location = new Point(108, 326);
            txtGPU.Name = "txtGPU";
            txtGPU.Size = new Size(186, 27);
            txtGPU.TabIndex = 2;
            // 
            // txtCPU
            // 
            txtCPU.BackColor = Color.White;
            txtCPU.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtCPU.ForeColor = Color.Black;
            txtCPU.Location = new Point(108, 281);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(186, 27);
            txtCPU.TabIndex = 2;
            // 
            // txtTenLaptop
            // 
            txtTenLaptop.BackColor = Color.White;
            txtTenLaptop.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtTenLaptop.ForeColor = Color.Black;
            txtTenLaptop.Location = new Point(108, 101);
            txtTenLaptop.Name = "txtTenLaptop";
            txtTenLaptop.Size = new Size(186, 27);
            txtTenLaptop.TabIndex = 2;
            // 
            // txtMaLaptop
            // 
            txtMaLaptop.BackColor = Color.White;
            txtMaLaptop.Enabled = false;
            txtMaLaptop.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtMaLaptop.ForeColor = Color.Black;
            txtMaLaptop.Location = new Point(108, 36);
            txtMaLaptop.Name = "txtMaLaptop";
            txtMaLaptop.Size = new Size(125, 27);
            txtMaLaptop.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 419);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 1;
            label11.Text = "Ổ cứng:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(49, 374);
            label12.Name = "label12";
            label12.Size = new Size(48, 20);
            label12.TabIndex = 1;
            label12.Text = "RAM:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(53, 329);
            label13.Name = "label13";
            label13.Size = new Size(44, 20);
            label13.TabIndex = 1;
            label13.Text = "GPU:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(55, 284);
            label14.Name = "label14";
            label14.Size = new Size(42, 20);
            label14.TabIndex = 1;
            label14.Text = "CPU:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 104);
            label15.Name = "label15";
            label15.Size = new Size(91, 20);
            label15.TabIndex = 0;
            label15.Text = "Tên Laptop:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 39);
            label16.Name = "label16";
            label16.Size = new Size(88, 20);
            label16.TabIndex = 0;
            label16.Text = "Mã Laptop:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox1.Location = new Point(13, 290);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 128);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Gray;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(124, 73);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 45);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DarkGreen;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(6, 73);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 45);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Maroon;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(124, 26);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 45);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DarkGreen;
            btnThem.Cursor = Cursors.Hand;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(6, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 45);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lblTenLaptop
            // 
            lblTenLaptop.Anchor = AnchorStyles.Top;
            lblTenLaptop.AutoSize = true;
            lblTenLaptop.BorderStyle = BorderStyle.FixedSingle;
            lblTenLaptop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenLaptop.ForeColor = Color.Maroon;
            lblTenLaptop.Location = new Point(107, 8);
            lblTenLaptop.Name = "lblTenLaptop";
            lblTenLaptop.Size = new Size(2, 30);
            lblTenLaptop.TabIndex = 5;
            lblTenLaptop.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grbCTSP
            // 
            grbCTSP.Anchor = AnchorStyles.Top;
            grbCTSP.BackColor = Color.LightGray;
            grbCTSP.Controls.Add(lblRAMInfo);
            grbCTSP.Controls.Add(lblStorageInfo);
            grbCTSP.Controls.Add(lblGPUInfo);
            grbCTSP.Controls.Add(lblCPUInfo);
            grbCTSP.Controls.Add(label4);
            grbCTSP.Controls.Add(label3);
            grbCTSP.Controls.Add(label2);
            grbCTSP.Controls.Add(label1);
            grbCTSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbCTSP.ForeColor = Color.FromArgb(64, 64, 64);
            grbCTSP.Location = new Point(13, 50);
            grbCTSP.Name = "grbCTSP";
            grbCTSP.Size = new Size(397, 234);
            grbCTSP.TabIndex = 4;
            grbCTSP.TabStop = false;
            grbCTSP.Text = "Chi Tiết Sản Phẩm";
            // 
            // lblRAMInfo
            // 
            lblRAMInfo.BorderStyle = BorderStyle.Fixed3D;
            lblRAMInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRAMInfo.ForeColor = Color.Black;
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
            lblStorageInfo.ForeColor = Color.Black;
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
            lblGPUInfo.ForeColor = Color.Black;
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
            lblCPUInfo.ForeColor = Color.Black;
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
            label5.Location = new Point(13, 9);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 3;
            label5.Text = "Laptop:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(txtFilter);
            panel2.Controls.Add(cmbLoaiTimKiem);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1148, 99);
            panel2.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Maroon;
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(485, 28);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(30, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "⌕";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtFilter
            // 
            txtFilter.BackColor = Color.WhiteSmoke;
            txtFilter.ForeColor = Color.FromArgb(64, 64, 64);
            txtFilter.Location = new Point(221, 29);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(258, 27);
            txtFilter.TabIndex = 2;
            txtFilter.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbLoaiTimKiem
            // 
            cmbLoaiTimKiem.BackColor = Color.WhiteSmoke;
            cmbLoaiTimKiem.Cursor = Cursors.Hand;
            cmbLoaiTimKiem.ForeColor = Color.FromArgb(64, 64, 64);
            cmbLoaiTimKiem.FormattingEnabled = true;
            cmbLoaiTimKiem.Items.AddRange(new object[] { "Mã Laptop", "Tên Laptop", "Hãng Laptop", "CPU", "GPU", "RAM", "Ổ cứng" });
            cmbLoaiTimKiem.Location = new Point(98, 28);
            cmbLoaiTimKiem.Name = "cmbLoaiTimKiem";
            cmbLoaiTimKiem.Size = new Size(117, 28);
            cmbLoaiTimKiem.TabIndex = 1;
            cmbLoaiTimKiem.Text = "Tên Laptop";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(19, 31);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 0;
            label6.Text = "Tìm kiếm:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(224, 224, 224);
            groupBox2.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox2.Location = new Point(9, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(523, 67);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // LaptopManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(tableLayoutPanel1);
            Name = "LaptopManagement";
            Text = "LaptopManagement";
            WindowState = FormWindowState.Maximized;
            Load += LaptopManagement_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLaptop).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbTTLaptop.ResumeLayout(false);
            grbTTLaptop.PerformLayout();
            groupBox1.ResumeLayout(false);
            grbCTSP.ResumeLayout(false);
            grbCTSP.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvDanhSachLaptop;
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
        private Panel panel1;
        private Label lblTenLaptop;
        private GroupBox grbCTSP;
        private Label lblRAMInfo;
        private Label lblStorageInfo;
        private Label lblGPUInfo;
        private Label lblCPUInfo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel2;
        private Label label6;
        private ComboBox cmbLoaiTimKiem;
        private TextBox txtFilter;
        private Button btnTimKiem;
        private Button btnThoat;
        private GroupBox groupBox2;
        private GroupBox grbTTLaptop;
        private DateTimePicker dtpNgayNhap;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtHang;
        private TextBox txtSoTon;
        private TextBox txtGiaTien;
        private TextBox txtOCung;
        private TextBox txtRAM;
        private TextBox txtGPU;
        private TextBox txtCPU;
        private TextBox txtTenLaptop;
        private TextBox txtMaLaptop;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button btnXacNhan;
        private Button btnHuy;
    }
}