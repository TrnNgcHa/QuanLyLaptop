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
            lblHardwareInfo = new Label();
            lblGPUInfo = new Label();
            lblCPUInfo = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnReview = new Button();
            btnPurchase = new Button();
            panel2 = new Panel();
            lblMatKhau = new Label();
            lblTaiKhoan = new Label();
            label6 = new Label();
            label5 = new Label();
            btnSign_up = new Button();
            btnSign_in = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLaptop).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1280F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 640F));
            tableLayoutPanel1.Controls.Add(dgvDanhSachLaptop, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1899, 1033);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDanhSachLaptop
            // 
            dgvDanhSachLaptop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachLaptop.Columns.AddRange(new DataGridViewColumn[] { STT1, MaLaptop, TenLaptop, TenHang, NgayNhap, SoTon, CPU, GPU, OCung, RAM, GiaTien });
            dgvDanhSachLaptop.Dock = DockStyle.Fill;
            dgvDanhSachLaptop.Location = new Point(3, 63);
            dgvDanhSachLaptop.Name = "dgvDanhSachLaptop";
            dgvDanhSachLaptop.RowHeadersWidth = 51;
            dgvDanhSachLaptop.Size = new Size(1274, 967);
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
            OCung.DataPropertyName = "Hardware";
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
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PapayaWhip;
            panel1.Controls.Add(lblTenLaptop);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(1283, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 967);
            panel1.TabIndex = 1;
            // 
            // lblTenLaptop
            // 
            lblTenLaptop.Anchor = AnchorStyles.Left;
            lblTenLaptop.BorderStyle = BorderStyle.FixedSingle;
            lblTenLaptop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenLaptop.Location = new Point(329, 150);
            lblTenLaptop.Name = "lblTenLaptop";
            lblTenLaptop.Size = new Size(209, 31);
            lblTenLaptop.TabIndex = 2;
            lblTenLaptop.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Cornsilk;
            groupBox2.Controls.Add(lblRAMInfo);
            groupBox2.Controls.Add(lblHardwareInfo);
            groupBox2.Controls.Add(lblGPUInfo);
            groupBox2.Controls.Add(lblCPUInfo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(3, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(541, 234);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi Tiết Sản Phẩm";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblRAMInfo
            // 
            lblRAMInfo.Anchor = AnchorStyles.None;
            lblRAMInfo.BorderStyle = BorderStyle.Fixed3D;
            lblRAMInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRAMInfo.Location = new Point(74, 192);
            lblRAMInfo.Name = "lblRAMInfo";
            lblRAMInfo.Size = new Size(257, 25);
            lblRAMInfo.TabIndex = 1;
            lblRAMInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHardwareInfo
            // 
            lblHardwareInfo.Anchor = AnchorStyles.None;
            lblHardwareInfo.BorderStyle = BorderStyle.Fixed3D;
            lblHardwareInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHardwareInfo.Location = new Point(74, 145);
            lblHardwareInfo.Name = "lblHardwareInfo";
            lblHardwareInfo.Size = new Size(257, 25);
            lblHardwareInfo.TabIndex = 1;
            lblHardwareInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGPUInfo
            // 
            lblGPUInfo.Anchor = AnchorStyles.None;
            lblGPUInfo.BorderStyle = BorderStyle.Fixed3D;
            lblGPUInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGPUInfo.Location = new Point(74, 106);
            lblGPUInfo.Name = "lblGPUInfo";
            lblGPUInfo.Size = new Size(257, 25);
            lblGPUInfo.TabIndex = 1;
            lblGPUInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCPUInfo
            // 
            lblCPUInfo.Anchor = AnchorStyles.None;
            lblCPUInfo.BorderStyle = BorderStyle.Fixed3D;
            lblCPUInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCPUInfo.Location = new Point(74, 60);
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
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnReview);
            groupBox1.Controls.Add(btnPurchase);
            groupBox1.Location = new Point(3, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // btnReview
            // 
            btnReview.Anchor = AnchorStyles.None;
            btnReview.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReview.Location = new Point(189, 40);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(120, 40);
            btnReview.TabIndex = 0;
            btnReview.Text = "Đánh Giá";
            btnReview.UseVisualStyleBackColor = true;
            btnReview.Click += btnReview_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.Anchor = AnchorStyles.None;
            btnPurchase.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.Location = new Point(63, 40);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(120, 40);
            btnPurchase.TabIndex = 0;
            btnPurchase.Text = "Mua";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(lblMatKhau);
            panel2.Controls.Add(lblTaiKhoan);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnSign_up);
            panel2.Controls.Add(btnSign_in);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1283, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(634, 54);
            panel2.TabIndex = 2;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Location = new Point(270, 18);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(98, 25);
            lblMatKhau.TabIndex = 2;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.Location = new Point(88, 18);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(98, 25);
            lblTaiKhoan.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(192, 18);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 1;
            label6.Text = "Mật Khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 18);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 1;
            label5.Text = "Tài Khoản";
            // 
            // btnSign_up
            // 
            btnSign_up.Location = new Point(413, 9);
            btnSign_up.Name = "btnSign_up";
            btnSign_up.Size = new Size(94, 29);
            btnSign_up.TabIndex = 0;
            btnSign_up.Text = "Đăng Ký";
            btnSign_up.UseVisualStyleBackColor = true;
            // 
            // btnSign_in
            // 
            btnSign_in.Location = new Point(513, 9);
            btnSign_in.Name = "btnSign_in";
            btnSign_in.Size = new Size(94, 29);
            btnSign_in.TabIndex = 0;
            btnSign_in.Text = "Đăng Nhập";
            btnSign_in.UseVisualStyleBackColor = true;
            btnSign_in.Click += btnSign_in_Click;
            // 
            // LaptopList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tableLayoutPanel1);
            Name = "LaptopList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh Sách Laptop";
            WindowState = FormWindowState.Maximized;
            Load += DanhSachLaptop_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLaptop).EndInit();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label lblHardwareInfo;
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
        private Button btnSign_up;
        private Button btnSign_in;
        private Label lblTaiKhoan;
        private Label label6;
        private Label label5;
        private Label lblMatKhau;
    }
}