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
            TableSplit = new TableLayoutPanel();
            dgvQuanLyHoaDon = new DataGridView();
            MaHoaDon = new DataGridViewTextBoxColumn();
            NgayLapHoaDon = new DataGridViewTextBoxColumn();
            MaTaiKhoan = new DataGridViewTextBoxColumn();
            TenTaiKhoan = new DataGridViewTextBoxColumn();
            MaNguoiDung = new DataGridViewTextBoxColumn();
            TenNguoiDung = new DataGridViewTextBoxColumn();
            MaLaptop = new DataGridViewTextBoxColumn();
            TenLaptop = new DataGridViewTextBoxColumn();
            GiaLaptop = new DataGridViewTextBoxColumn();
            PhuKien = new DataGridViewTextBoxColumn();
            GiaPhuKien = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnTimKiem = new Button();
            txtFilter = new TextBox();
            cmbLoaiTimKiem = new ComboBox();
            label9 = new Label();
            panel3 = new Panel();
            TableSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyHoaDon).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // dgvQuanLyHoaDon
            // 
            dgvQuanLyHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuanLyHoaDon.Columns.AddRange(new DataGridViewColumn[] { MaHoaDon, NgayLapHoaDon, MaTaiKhoan, TenTaiKhoan, MaNguoiDung, TenNguoiDung, MaLaptop, TenLaptop, GiaLaptop, PhuKien, GiaPhuKien, TongTien });
            dgvQuanLyHoaDon.Dock = DockStyle.Fill;
            dgvQuanLyHoaDon.Location = new Point(3, 82);
            dgvQuanLyHoaDon.Name = "dgvQuanLyHoaDon";
            dgvQuanLyHoaDon.RowHeadersWidth = 51;
            dgvQuanLyHoaDon.Size = new Size(970, 642);
            dgvQuanLyHoaDon.TabIndex = 0;
            // 
            // MaHoaDon
            // 
            MaHoaDon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaHoaDon.DataPropertyName = "ReceiptID";
            MaHoaDon.HeaderText = "Mã Hóa Đơn";
            MaHoaDon.MinimumWidth = 6;
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.Width = 113;
            // 
            // NgayLapHoaDon
            // 
            NgayLapHoaDon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NgayLapHoaDon.DataPropertyName = "InvoiceDate";
            NgayLapHoaDon.HeaderText = "Ngày Lập Hóa Đơn";
            NgayLapHoaDon.MinimumWidth = 6;
            NgayLapHoaDon.Name = "NgayLapHoaDon";
            NgayLapHoaDon.Width = 126;
            // 
            // MaTaiKhoan
            // 
            MaTaiKhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaTaiKhoan.DataPropertyName = "AccountID";
            MaTaiKhoan.HeaderText = "Mã Tài Khoản";
            MaTaiKhoan.MinimumWidth = 6;
            MaTaiKhoan.Name = "MaTaiKhoan";
            MaTaiKhoan.Visible = false;
            MaTaiKhoan.Width = 125;
            // 
            // TenTaiKhoan
            // 
            TenTaiKhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenTaiKhoan.DataPropertyName = "AccountName";
            TenTaiKhoan.HeaderText = "Tên Tài Khoản";
            TenTaiKhoan.MinimumWidth = 6;
            TenTaiKhoan.Name = "TenTaiKhoan";
            TenTaiKhoan.Visible = false;
            TenTaiKhoan.Width = 125;
            // 
            // MaNguoiDung
            // 
            MaNguoiDung.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaNguoiDung.DataPropertyName = "PersonID";
            MaNguoiDung.HeaderText = "Mã Người Dùng";
            MaNguoiDung.MinimumWidth = 6;
            MaNguoiDung.Name = "MaNguoiDung";
            MaNguoiDung.Visible = false;
            MaNguoiDung.Width = 125;
            // 
            // TenNguoiDung
            // 
            TenNguoiDung.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenNguoiDung.DataPropertyName = "PersonName";
            TenNguoiDung.HeaderText = "Tên Người Dùng";
            TenNguoiDung.MinimumWidth = 6;
            TenNguoiDung.Name = "TenNguoiDung";
            TenNguoiDung.Width = 135;
            // 
            // MaLaptop
            // 
            MaLaptop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaLaptop.DataPropertyName = "LaptopID";
            MaLaptop.HeaderText = "Mã Laptop";
            MaLaptop.MinimumWidth = 6;
            MaLaptop.Name = "MaLaptop";
            MaLaptop.Visible = false;
            MaLaptop.Width = 125;
            // 
            // TenLaptop
            // 
            TenLaptop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenLaptop.DataPropertyName = "LaptopName";
            TenLaptop.HeaderText = "Tên Laptop";
            TenLaptop.MinimumWidth = 6;
            TenLaptop.Name = "TenLaptop";
            TenLaptop.Width = 103;
            // 
            // GiaLaptop
            // 
            GiaLaptop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GiaLaptop.DataPropertyName = "LaptopPrice";
            GiaLaptop.HeaderText = "Giá Laptop";
            GiaLaptop.MinimumWidth = 6;
            GiaLaptop.Name = "GiaLaptop";
            GiaLaptop.Visible = false;
            GiaLaptop.Width = 125;
            // 
            // PhuKien
            // 
            PhuKien.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PhuKien.DataPropertyName = "ExtraItems";
            PhuKien.HeaderText = "Phụ Kiện";
            PhuKien.MinimumWidth = 6;
            PhuKien.Name = "PhuKien";
            PhuKien.Width = 88;
            // 
            // GiaPhuKien
            // 
            GiaPhuKien.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GiaPhuKien.DataPropertyName = "ExtraPrices";
            GiaPhuKien.HeaderText = "Giá Phụ Kiện";
            GiaPhuKien.MinimumWidth = 6;
            GiaPhuKien.Name = "GiaPhuKien";
            GiaPhuKien.Visible = false;
            GiaPhuKien.Width = 125;
            // 
            // TongTien
            // 
            TongTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TongTien.DataPropertyName = "TotalAmount";
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.Width = 96;
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
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(108, 117, 125);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 132);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Tài khoản";
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.ForeColor = Color.White;
            label8.Location = new Point(339, 74);
            label8.Name = "label8";
            label8.Size = new Size(144, 25);
            label8.TabIndex = 1;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.ForeColor = Color.White;
            label6.Location = new Point(127, 74);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 1;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.ForeColor = Color.White;
            label7.Location = new Point(339, 34);
            label7.Name = "label7";
            label7.Size = new Size(144, 25);
            label7.TabIndex = 1;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.ForeColor = Color.White;
            label5.Location = new Point(127, 34);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 74);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 0;
            label4.Text = "Tên người dùng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 34);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã người dùng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã tài khoản:";
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(979, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(505, 73);
            panel3.TabIndex = 3;
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
            TableSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyHoaDon).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableSplit;
        private DataGridView dgvQuanLyHoaDon;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn NgayLapHoaDon;
        private DataGridViewTextBoxColumn MaTaiKhoan;
        private DataGridViewTextBoxColumn TenTaiKhoan;
        private DataGridViewTextBoxColumn MaNguoiDung;
        private DataGridViewTextBoxColumn TenNguoiDung;
        private DataGridViewTextBoxColumn MaLaptop;
        private DataGridViewTextBoxColumn TenLaptop;
        private DataGridViewTextBoxColumn GiaLaptop;
        private DataGridViewTextBoxColumn PhuKien;
        private DataGridViewTextBoxColumn GiaPhuKien;
        private DataGridViewTextBoxColumn TongTien;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Button btnTimKiem;
        private TextBox txtFilter;
        private ComboBox cmbLoaiTimKiem;
        private Label label9;
        private Panel panel3;
    }
}