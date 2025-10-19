namespace QuanLyLaptop
{
    partial class AccountManagement
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
            dgvQuanLyTaiKhoan = new DataGridView();
            MaNguoi = new DataGridViewTextBoxColumn();
            MaTaiKhoan = new DataGridViewTextBoxColumn();
            TenTaiKhoan = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            SoDu = new DataGridViewTextBoxColumn();
            HoNguoi = new DataGridViewTextBoxColumn();
            TenNguoi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            ThanhPho = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            CCCD = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
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
            panel2 = new Panel();
            btnTimKiem = new Button();
            txtFilter = new TextBox();
            cmbLoaiTimKiem = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyTaiKhoan).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvQuanLyTaiKhoan
            // 
            dgvQuanLyTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuanLyTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { MaNguoi, MaTaiKhoan, TenTaiKhoan, MatKhau, SoDu, HoNguoi, TenNguoi, GioiTinh, NgaySinh, ThanhPho, SoDienThoai, Email, CCCD });
            dgvQuanLyTaiKhoan.Dock = DockStyle.Fill;
            dgvQuanLyTaiKhoan.Location = new Point(3, 63);
            dgvQuanLyTaiKhoan.Name = "dgvQuanLyTaiKhoan";
            dgvQuanLyTaiKhoan.RowHeadersWidth = 51;
            dgvQuanLyTaiKhoan.Size = new Size(725, 539);
            dgvQuanLyTaiKhoan.TabIndex = 0;
            dgvQuanLyTaiKhoan.CellEnter += dgvQuanLyTaiKhoan_CellEnter;
            // 
            // MaNguoi
            // 
            MaNguoi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaNguoi.DataPropertyName = "PersonID";
            MaNguoi.HeaderText = "Mã Người Dùng";
            MaNguoi.MinimumWidth = 6;
            MaNguoi.Name = "MaNguoi";
            MaNguoi.Width = 145;
            // 
            // MaTaiKhoan
            // 
            MaTaiKhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaTaiKhoan.DataPropertyName = "AccountID";
            MaTaiKhoan.HeaderText = "Mã Tài Khoản";
            MaTaiKhoan.MinimumWidth = 6;
            MaTaiKhoan.Name = "MaTaiKhoan";
            MaTaiKhoan.Width = 127;
            // 
            // TenTaiKhoan
            // 
            TenTaiKhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenTaiKhoan.DataPropertyName = "AccountName";
            TenTaiKhoan.HeaderText = "Tên Tài Khoản";
            TenTaiKhoan.MinimumWidth = 6;
            TenTaiKhoan.Name = "TenTaiKhoan";
            TenTaiKhoan.Width = 129;
            // 
            // MatKhau
            // 
            MatKhau.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MatKhau.DataPropertyName = "Password";
            MatKhau.HeaderText = "Mật Khẩu";
            MatKhau.MinimumWidth = 6;
            MatKhau.Name = "MatKhau";
            MatKhau.Width = 101;
            // 
            // SoDu
            // 
            SoDu.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SoDu.DataPropertyName = "Balance";
            SoDu.HeaderText = "Số Dư";
            SoDu.MinimumWidth = 6;
            SoDu.Name = "SoDu";
            SoDu.Width = 79;
            // 
            // HoNguoi
            // 
            HoNguoi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HoNguoi.DataPropertyName = "FirstName";
            HoNguoi.HeaderText = "Họ";
            HoNguoi.MinimumWidth = 6;
            HoNguoi.Name = "HoNguoi";
            HoNguoi.Width = 58;
            // 
            // TenNguoi
            // 
            TenNguoi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenNguoi.DataPropertyName = "LastName";
            TenNguoi.HeaderText = "Tên";
            TenNguoi.MinimumWidth = 6;
            TenNguoi.Name = "TenNguoi";
            TenNguoi.Width = 61;
            // 
            // GioiTinh
            // 
            GioiTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GioiTinh.DataPropertyName = "Gender";
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Visible = false;
            GioiTinh.Width = 125;
            // 
            // NgaySinh
            // 
            NgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NgaySinh.DataPropertyName = "DOB";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Visible = false;
            NgaySinh.Width = 125;
            // 
            // ThanhPho
            // 
            ThanhPho.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ThanhPho.DataPropertyName = "City";
            ThanhPho.HeaderText = "Thành Phố";
            ThanhPho.MinimumWidth = 6;
            ThanhPho.Name = "ThanhPho";
            ThanhPho.Visible = false;
            ThanhPho.Width = 125;
            // 
            // SoDienThoai
            // 
            SoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SoDienThoai.DataPropertyName = "PhoneNumber";
            SoDienThoai.HeaderText = "SDT";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.Visible = false;
            SoDienThoai.Width = 125;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Visible = false;
            Email.Width = 125;
            // 
            // CCCD
            // 
            CCCD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CCCD.DataPropertyName = "IdCard";
            CCCD.HeaderText = "CCCD";
            CCCD.MinimumWidth = 6;
            CCCD.Name = "CCCD";
            CCCD.Visible = false;
            CCCD.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(dgvQuanLyTaiKhoan, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(1045, 605);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(734, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 539);
            panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.Location = new Point(198, 342);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(101, 44);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label1);
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
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 321);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin người dùng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 36);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            // 
            // lblCCCD
            // 
            lblCCCD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCCCD.BorderStyle = BorderStyle.Fixed3D;
            lblCCCD.Location = new Point(130, 265);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(140, 30);
            lblCCCD.TabIndex = 2;
            lblCCCD.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 75);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Giới tính:";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.BorderStyle = BorderStyle.Fixed3D;
            lblEmail.Location = new Point(130, 226);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(140, 30);
            lblEmail.TabIndex = 2;
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 114);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày sinh:";
            // 
            // lblSDT
            // 
            lblSDT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSDT.BorderStyle = BorderStyle.Fixed3D;
            lblSDT.Location = new Point(130, 187);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(140, 30);
            lblSDT.TabIndex = 2;
            lblSDT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 153);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 1;
            label4.Text = "Thành phố:";
            // 
            // lblThanhPho
            // 
            lblThanhPho.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblThanhPho.BorderStyle = BorderStyle.Fixed3D;
            lblThanhPho.Location = new Point(130, 148);
            lblThanhPho.Name = "lblThanhPho";
            lblThanhPho.Size = new Size(140, 30);
            lblThanhPho.TabIndex = 2;
            lblThanhPho.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 192);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 1;
            label5.Text = "SDT:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNgaySinh.BorderStyle = BorderStyle.Fixed3D;
            lblNgaySinh.Location = new Point(130, 109);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(140, 30);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 231);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 1;
            label6.Text = "Email:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblGioiTinh.BorderStyle = BorderStyle.Fixed3D;
            lblGioiTinh.Location = new Point(130, 70);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(140, 30);
            lblGioiTinh.TabIndex = 2;
            lblGioiTinh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 270);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 1;
            label7.Text = "CCCD:";
            // 
            // lblHoTen
            // 
            lblHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHoTen.BorderStyle = BorderStyle.Fixed3D;
            lblHoTen.Location = new Point(130, 31);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(140, 30);
            lblHoTen.TabIndex = 2;
            lblHoTen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(txtFilter);
            panel2.Controls.Add(cmbLoaiTimKiem);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(725, 54);
            panel2.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(493, 16);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(30, 29);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "⌕";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(229, 16);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(258, 27);
            txtFilter.TabIndex = 6;
            txtFilter.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbLoaiTimKiem
            // 
            cmbLoaiTimKiem.FormattingEnabled = true;
            cmbLoaiTimKiem.Items.AddRange(new object[] { "Tên người dùng", "Mã người dùng", "Tên tài khoản", "Mã tài khoản" });
            cmbLoaiTimKiem.Location = new Point(88, 16);
            cmbLoaiTimKiem.Name = "cmbLoaiTimKiem";
            cmbLoaiTimKiem.Size = new Size(135, 28);
            cmbLoaiTimKiem.TabIndex = 5;
            cmbLoaiTimKiem.Text = "Tên người dùng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 19);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 4;
            label8.Text = "Tìm kiếm:";
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 605);
            Controls.Add(tableLayoutPanel1);
            Name = "AccountManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountManagement";
            WindowState = FormWindowState.Maximized;
            Load += AccountManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyTaiKhoan).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvQuanLyTaiKhoan;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblHoTen;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblCCCD;
        private Label lblEmail;
        private Label lblSDT;
        private Label lblThanhPho;
        private Label lblNgaySinh;
        private Label lblGioiTinh;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn MaNguoi;
        private DataGridViewTextBoxColumn MaTaiKhoan;
        private DataGridViewTextBoxColumn TenTaiKhoan;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn SoDu;
        private DataGridViewTextBoxColumn HoNguoi;
        private DataGridViewTextBoxColumn TenNguoi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn ThanhPho;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn CCCD;
        private Button btnThoat;
        private Panel panel2;
        private Button btnTimKiem;
        private TextBox txtFilter;
        private ComboBox cmbLoaiTimKiem;
        private Label label8;
    }
}