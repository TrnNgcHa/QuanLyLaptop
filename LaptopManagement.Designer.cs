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
            groupBox1 = new GroupBox();
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
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLaptop).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            grbCTSP.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(dgvDanhSachLaptop, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(1371, 614);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDanhSachLaptop
            // 
            dgvDanhSachLaptop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachLaptop.Columns.AddRange(new DataGridViewColumn[] { STT1, MaLaptop, TenLaptop, TenHang, NgayNhap, SoTon, CPU, GPU, OCung, RAM, GiaTien });
            dgvDanhSachLaptop.Dock = DockStyle.Fill;
            dgvDanhSachLaptop.Location = new Point(3, 64);
            dgvDanhSachLaptop.Name = "dgvDanhSachLaptop";
            dgvDanhSachLaptop.RowHeadersWidth = 51;
            dgvDanhSachLaptop.Size = new Size(953, 547);
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
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblTenLaptop);
            panel1.Controls.Add(grbCTSP);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(962, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 547);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(3, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 76);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(267, 30);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(151, 30);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(35, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblTenLaptop
            // 
            lblTenLaptop.AutoSize = true;
            lblTenLaptop.BorderStyle = BorderStyle.FixedSingle;
            lblTenLaptop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenLaptop.Location = new Point(97, 10);
            lblTenLaptop.Name = "lblTenLaptop";
            lblTenLaptop.Size = new Size(2, 30);
            lblTenLaptop.TabIndex = 5;
            lblTenLaptop.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grbCTSP
            // 
            grbCTSP.BackColor = Color.Cornsilk;
            grbCTSP.Controls.Add(lblRAMInfo);
            grbCTSP.Controls.Add(lblStorageInfo);
            grbCTSP.Controls.Add(lblGPUInfo);
            grbCTSP.Controls.Add(lblCPUInfo);
            grbCTSP.Controls.Add(label4);
            grbCTSP.Controls.Add(label3);
            grbCTSP.Controls.Add(label2);
            grbCTSP.Controls.Add(label1);
            grbCTSP.Location = new Point(3, 52);
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
            label4.Size = new Size(44, 20);
            label4.TabIndex = 0;
            label4.Text = "RAM:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 150);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 0;
            label3.Text = "Ổ Cứng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 106);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 0;
            label2.Text = "GPU:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 62);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "CPU:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 11);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 3;
            label5.Text = "Laptop:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(txtFilter);
            panel2.Controls.Add(cmbLoaiTimKiem);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(953, 55);
            panel2.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(475, 13);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(30, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "⌕";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(211, 14);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(258, 27);
            txtFilter.TabIndex = 2;
            txtFilter.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbLoaiTimKiem
            // 
            cmbLoaiTimKiem.FormattingEnabled = true;
            cmbLoaiTimKiem.Items.AddRange(new object[] { "Mã Laptop", "Tên Laptop", "Hãng Laptop", "CPU", "GPU", "RAM", "Ổ cứng" });
            cmbLoaiTimKiem.Location = new Point(88, 13);
            cmbLoaiTimKiem.Name = "cmbLoaiTimKiem";
            cmbLoaiTimKiem.Size = new Size(117, 28);
            cmbLoaiTimKiem.TabIndex = 1;
            cmbLoaiTimKiem.Text = "Tên Laptop";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 16);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 0;
            label6.Text = "Tìm kiếm:";
            // 
            // LaptopManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 614);
            Controls.Add(tableLayoutPanel1);
            Name = "LaptopManagement";
            Text = "LaptopManagement";
            Load += LaptopManagement_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLaptop).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}