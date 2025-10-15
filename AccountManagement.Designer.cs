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
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // dgvQuanLyTaiKhoan
            // 
            dgvQuanLyTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuanLyTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { MaNguoi, MaTaiKhoan, TenTaiKhoan, MatKhau, SoDu, HoNguoi, TenNguoi, GioiTinh, NgaySinh, ThanhPho, SoDienThoai, Email, CCCD });
            dgvQuanLyTaiKhoan.Dock = DockStyle.Fill;
            dgvQuanLyTaiKhoan.Location = new Point(0, 0);
            dgvQuanLyTaiKhoan.Name = "dgvQuanLyTaiKhoan";
            dgvQuanLyTaiKhoan.RowHeadersWidth = 51;
            dgvQuanLyTaiKhoan.Size = new Size(800, 450);
            dgvQuanLyTaiKhoan.TabIndex = 0;
            // 
            // MaNguoi
            // 
            MaNguoi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaNguoi.DataPropertyName = "PersonID";
            MaNguoi.HeaderText = "Mã Người";
            MaNguoi.MinimumWidth = 6;
            MaNguoi.Name = "MaNguoi";
            MaNguoi.Width = 105;
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
            GioiTinh.Width = 97;
            // 
            // NgaySinh
            // 
            NgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NgaySinh.DataPropertyName = "DOB";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Width = 105;
            // 
            // ThanhPho
            // 
            ThanhPho.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ThanhPho.DataPropertyName = "City";
            ThanhPho.HeaderText = "Thành Phố";
            ThanhPho.MinimumWidth = 6;
            ThanhPho.Name = "ThanhPho";
            ThanhPho.Width = 107;
            // 
            // SoDienThoai
            // 
            SoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SoDienThoai.DataPropertyName = "PhoneNumber";
            SoDienThoai.HeaderText = "SDT";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.Width = 64;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 75;
            // 
            // CCCD
            // 
            CCCD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CCCD.DataPropertyName = "IdCard";
            CCCD.HeaderText = "CCCD";
            CCCD.MinimumWidth = 6;
            CCCD.Name = "CCCD";
            CCCD.Width = 76;
            // 
            // AccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvQuanLyTaiKhoan);
            Name = "AccountManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountManagement";
            WindowState = FormWindowState.Maximized;
            Load += AccountManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvQuanLyTaiKhoan;
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
    }
}