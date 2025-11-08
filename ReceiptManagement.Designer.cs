namespace QuanLyLaptop
{
    partial class ReceiptManagement
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
            dgvQuanLyHoaDon = new DataGridView();
            label9 = new Label();
            cmbLoaiTimKiem = new ComboBox();
            txtFilter = new TextBox();
            btnTimKiem = new Button();
            panel2 = new Panel();
            TableSplit = new TableLayoutPanel();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label1 = new Label();
            lblSoDu = new Label();
            lblCCCD = new Label();
            label2 = new Label();
            lblEmail = new Label();
            label3 = new Label();
            lblSDT = new Label();
            label4 = new Label();
            lblThanhPho = new Label();
            label5 = new Label();
            lblNgaySinh = new Label();
            label6 = new Label();
            lblGioiTinh = new Label();
            label7 = new Label();
            lblHoTen = new Label();
            panel3 = new Panel();
            STT = new DataGridViewTextBoxColumn();
            MaHoaDon = new DataGridViewTextBoxColumn();
            NgayLapHoaDon = new DataGridViewTextBoxColumn();
            MaTaiKhoan = new DataGridViewTextBoxColumn();
            TenTaiKhoan = new DataGridViewTextBoxColumn();
            MaNguoiDung = new DataGridViewTextBoxColumn();
            TenNguoiDung = new DataGridViewTextBoxColumn();
            MaLaptop = new DataGridViewTextBoxColumn();
            TenLaptop = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyHoaDon).BeginInit();
            panel2.SuspendLayout();
            TableSplit.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvQuanLyHoaDon
            // 
            dgvQuanLyHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuanLyHoaDon.Columns.AddRange(new DataGridViewColumn[] { STT, MaHoaDon, NgayLapHoaDon, MaTaiKhoan, TenTaiKhoan, MaNguoiDung, TenNguoiDung, MaLaptop, TenLaptop, TongTien });
            dgvQuanLyHoaDon.Dock = DockStyle.Fill;
            dgvQuanLyHoaDon.Location = new Point(3, 82);
            dgvQuanLyHoaDon.Name = "dgvQuanLyHoaDon";
            dgvQuanLyHoaDon.RowHeadersWidth = 51;
            dgvQuanLyHoaDon.Size = new Size(970, 642);
            dgvQuanLyHoaDon.TabIndex = 0;
            dgvQuanLyHoaDon.CellEnter += dgvQuanLyHoaDon_CellEnter;
            dgvQuanLyHoaDon.DataBindingComplete += dgvQuanLyHoaDon_DataBindingComplete;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(16, 24);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 8;
            label9.Text = "Tìm kiếm:";
            // 
            // cmbLoaiTimKiem
            // 
            cmbLoaiTimKiem.BackColor = Color.White;
            cmbLoaiTimKiem.Font = new Font("Segoe UI", 9F);
            cmbLoaiTimKiem.ForeColor = Color.Black;
            cmbLoaiTimKiem.FormattingEnabled = true;
            cmbLoaiTimKiem.Location = new Point(95, 21);
            cmbLoaiTimKiem.Name = "cmbLoaiTimKiem";
            cmbLoaiTimKiem.Size = new Size(117, 28);
            cmbLoaiTimKiem.TabIndex = 9;
            cmbLoaiTimKiem.Text = "Mã hóa đơn";
            // 
            // txtFilter
            // 
            txtFilter.BackColor = Color.White;
            txtFilter.Font = new Font("Segoe UI", 9F);
            txtFilter.ForeColor = Color.Black;
            txtFilter.Location = new Point(218, 22);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(258, 27);
            txtFilter.TabIndex = 10;
            txtFilter.TextAlign = HorizontalAlignment.Right;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Maroon;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(482, 21);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(30, 29);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "⌕";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(txtFilter);
            panel2.Controls.Add(cmbLoaiTimKiem);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(970, 73);
            panel2.TabIndex = 2;
            // 
            // TableSplit
            // 
            TableSplit.BackColor = Color.WhiteSmoke;
            TableSplit.ColumnCount = 2;
            TableSplit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.63927F));
            TableSplit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.36073F));
            TableSplit.Controls.Add(dgvQuanLyHoaDon, 0, 1);
            TableSplit.Controls.Add(panel1, 1, 1);
            TableSplit.Controls.Add(panel2, 0, 0);
            TableSplit.Controls.Add(panel3, 1, 0);
            TableSplit.Dock = DockStyle.Fill;
            TableSplit.Location = new Point(0, 0);
            TableSplit.Name = "TableSplit";
            TableSplit.RowCount = 2;
            TableSplit.RowStyles.Add(new RowStyle(SizeType.Percent, 10.91618F));
            TableSplit.RowStyles.Add(new RowStyle(SizeType.Percent, 89.0838242F));
            TableSplit.Size = new Size(1487, 727);
            TableSplit.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(979, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 642);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblSoDu);
            groupBox1.Controls.Add(lblCCCD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblSDT);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblThanhPho);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblNgaySinh);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblGioiTinh);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblHoTen);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DimGray;
            groupBox1.Location = new Point(2, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(494, 360);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin người dùng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 317);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 5;
            label8.Text = "Số dư:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            // 
            // lblSoDu
            // 
            lblSoDu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSoDu.BorderStyle = BorderStyle.Fixed3D;
            lblSoDu.ForeColor = Color.DimGray;
            lblSoDu.Location = new Point(130, 312);
            lblSoDu.Name = "lblSoDu";
            lblSoDu.Size = new Size(302, 30);
            lblSoDu.TabIndex = 2;
            lblSoDu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCCCD
            // 
            lblCCCD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCCCD.BorderStyle = BorderStyle.Fixed3D;
            lblCCCD.ForeColor = Color.DimGray;
            lblCCCD.Location = new Point(130, 272);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(302, 30);
            lblCCCD.TabIndex = 2;
            lblCCCD.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 77);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Giới tính:";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.BorderStyle = BorderStyle.Fixed3D;
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(130, 232);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(302, 30);
            lblEmail.TabIndex = 2;
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 117);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh:";
            // 
            // lblSDT
            // 
            lblSDT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSDT.BorderStyle = BorderStyle.Fixed3D;
            lblSDT.ForeColor = Color.DimGray;
            lblSDT.Location = new Point(130, 192);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(302, 30);
            lblSDT.TabIndex = 2;
            lblSDT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 157);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 1;
            label4.Text = "Thành phố:";
            // 
            // lblThanhPho
            // 
            lblThanhPho.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblThanhPho.BorderStyle = BorderStyle.Fixed3D;
            lblThanhPho.ForeColor = Color.DimGray;
            lblThanhPho.Location = new Point(130, 152);
            lblThanhPho.Name = "lblThanhPho";
            lblThanhPho.Size = new Size(302, 30);
            lblThanhPho.TabIndex = 2;
            lblThanhPho.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 197);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 1;
            label5.Text = "SDT:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNgaySinh.BorderStyle = BorderStyle.Fixed3D;
            lblNgaySinh.ForeColor = Color.DimGray;
            lblNgaySinh.Location = new Point(130, 112);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(302, 30);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 237);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 1;
            label6.Text = "Email:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblGioiTinh.BorderStyle = BorderStyle.Fixed3D;
            lblGioiTinh.ForeColor = Color.DimGray;
            lblGioiTinh.Location = new Point(130, 72);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(302, 30);
            lblGioiTinh.TabIndex = 2;
            lblGioiTinh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 277);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 1;
            label7.Text = "CCCD:";
            // 
            // lblHoTen
            // 
            lblHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHoTen.BorderStyle = BorderStyle.Fixed3D;
            lblHoTen.ForeColor = Color.DimGray;
            lblHoTen.Location = new Point(130, 32);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(302, 30);
            lblHoTen.TabIndex = 2;
            lblHoTen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(979, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(505, 73);
            panel3.TabIndex = 3;
            // 
            // STT
            // 
            STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Width = 62;
            // 
            // MaHoaDon
            // 
            MaHoaDon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaHoaDon.DataPropertyName = "ReceiptID";
            MaHoaDon.HeaderText = "Mã Hóa Đơn";
            MaHoaDon.MinimumWidth = 6;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.ReadOnly = true;
            MaHoaDon.Width = 123;
            // 
            // NgayLapHoaDon
            // 
            NgayLapHoaDon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NgayLapHoaDon.DataPropertyName = "InvoiceDate";
            NgayLapHoaDon.HeaderText = "Ngày Lập Hóa Đơn";
            NgayLapHoaDon.MinimumWidth = 6;
            NgayLapHoaDon.Name = "NgayLapHoaDon";
            NgayLapHoaDon.ReadOnly = true;
            NgayLapHoaDon.Width = 126;
            // 
            // MaTaiKhoan
            // 
            MaTaiKhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaTaiKhoan.DataPropertyName = "AccountID";
            MaTaiKhoan.HeaderText = "Mã Tài Khoản";
            MaTaiKhoan.MinimumWidth = 6;
            MaTaiKhoan.Name = "MaTaiKhoan";
            MaTaiKhoan.ReadOnly = true;
            MaTaiKhoan.Width = 117;
            // 
            // TenTaiKhoan
            // 
            TenTaiKhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenTaiKhoan.DataPropertyName = "AccountName";
            TenTaiKhoan.HeaderText = "Tên Tài Khoản";
            TenTaiKhoan.MinimumWidth = 6;
            TenTaiKhoan.Name = "TenTaiKhoan";
            TenTaiKhoan.ReadOnly = true;
            TenTaiKhoan.Visible = false;
            TenTaiKhoan.Width = 119;
            // 
            // MaNguoiDung
            // 
            MaNguoiDung.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaNguoiDung.DataPropertyName = "PersonID";
            MaNguoiDung.HeaderText = "Mã Người Dùng";
            MaNguoiDung.MinimumWidth = 6;
            MaNguoiDung.Name = "MaNguoiDung";
            MaNguoiDung.ReadOnly = true;
            MaNguoiDung.Width = 133;
            // 
            // TenNguoiDung
            // 
            TenNguoiDung.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenNguoiDung.DataPropertyName = "PersonName";
            TenNguoiDung.HeaderText = "Tên Người Dùng";
            TenNguoiDung.MinimumWidth = 6;
            TenNguoiDung.Name = "TenNguoiDung";
            TenNguoiDung.ReadOnly = true;
            TenNguoiDung.Visible = false;
            TenNguoiDung.Width = 135;
            // 
            // MaLaptop
            // 
            MaLaptop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaLaptop.DataPropertyName = "LaptopID";
            MaLaptop.HeaderText = "Mã Laptop";
            MaLaptop.MinimumWidth = 6;
            MaLaptop.Name = "MaLaptop";
            MaLaptop.ReadOnly = true;
            MaLaptop.Width = 101;
            // 
            // TenLaptop
            // 
            TenLaptop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenLaptop.DataPropertyName = "LaptopName";
            TenLaptop.HeaderText = "Tên Laptop";
            TenLaptop.MinimumWidth = 6;
            TenLaptop.Name = "TenLaptop";
            TenLaptop.ReadOnly = true;
            TenLaptop.Width = 103;
            // 
            // TongTien
            // 
            TongTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TongTien.DataPropertyName = "Total";
            TongTien.HeaderText = "Thành Tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            TongTien.Width = 101;
            // 
            // ReceiptManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1487, 727);
            Controls.Add(TableSplit);
            Name = "ReceiptManagement";
            Text = "ReceiptManagement";
            Load += ReceiptManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyHoaDon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            TableSplit.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvQuanLyHoaDon;
        private Label label9;
        private ComboBox cmbLoaiTimKiem;
        private TextBox txtFilter;
        private Button btnTimKiem;
        private Panel panel2;
        private TableLayoutPanel TableSplit;
        private Panel panel1;
        private Panel panel3;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblCCCD;
        private Label label2;
        private Label lblEmail;
        private Label label3;
        private Label lblSDT;
        private Label label4;
        private Label lblThanhPho;
        private Label label5;
        private Label lblNgaySinh;
        private Label label6;
        private Label lblGioiTinh;
        private Label label7;
        private Label lblHoTen;
        private Label label8;
        private Label lblSoDu;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn NgayLapHoaDon;
        private DataGridViewTextBoxColumn MaTaiKhoan;
        private DataGridViewTextBoxColumn TenTaiKhoan;
        private DataGridViewTextBoxColumn MaNguoiDung;
        private DataGridViewTextBoxColumn TenNguoiDung;
        private DataGridViewTextBoxColumn MaLaptop;
        private DataGridViewTextBoxColumn TenLaptop;
        private DataGridViewTextBoxColumn TongTien;
    }
}