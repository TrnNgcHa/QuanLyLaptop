namespace QuanLyLaptop
{
    partial class AccountAuthentication
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
            grbDangKy = new GroupBox();
            groupBox3 = new GroupBox();
            llbDangNhap = new LinkLabel();
            btnDangKy = new Button();
            label10 = new Label();
            label9 = new Label();
            txtMatKhauDK = new TextBox();
            txtTenDK = new TextBox();
            groupBox2 = new GroupBox();
            cmbTinhThanh = new ComboBox();
            ckbNu = new CheckBox();
            ckbNam = new CheckBox();
            dtpNgaySinh = new DateTimePicker();
            txtCCCD = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grbDangNhap = new GroupBox();
            groupBox5 = new GroupBox();
            llbDangKy = new LinkLabel();
            btnDangNhap = new Button();
            label12 = new Label();
            label13 = new Label();
            txtMatKhauDN = new TextBox();
            txtTenDN = new TextBox();
            label11 = new Label();
            grbDangKy.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            grbDangNhap.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // grbDangKy
            // 
            grbDangKy.BackColor = Color.LightGray;
            grbDangKy.Controls.Add(groupBox3);
            grbDangKy.Controls.Add(groupBox2);
            grbDangKy.Controls.Add(label1);
            grbDangKy.ForeColor = Color.White;
            grbDangKy.Location = new Point(39, 12);
            grbDangKy.Name = "grbDangKy";
            grbDangKy.Size = new Size(335, 559);
            grbDangKy.TabIndex = 2;
            grbDangKy.TabStop = false;
            grbDangKy.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(llbDangNhap);
            groupBox3.Controls.Add(btnDangKy);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtMatKhauDK);
            groupBox3.Controls.Add(txtTenDK);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.DimGray;
            groupBox3.Location = new Point(15, 358);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 192);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin đăng ký";
            // 
            // llbDangNhap
            // 
            llbDangNhap.AutoSize = true;
            llbDangNhap.Cursor = Cursors.Hand;
            llbDangNhap.DisabledLinkColor = Color.Transparent;
            llbDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbDangNhap.ForeColor = Color.White;
            llbDangNhap.LinkColor = Color.Blue;
            llbDangNhap.Location = new Point(177, 162);
            llbDangNhap.Name = "llbDangNhap";
            llbDangNhap.Size = new Size(120, 20);
            llbDangNhap.TabIndex = 11;
            llbDangNhap.TabStop = true;
            llbDangNhap.Text = "Đã có tài khoản?";
            llbDangNhap.LinkClicked += llbDangNhap_LinkClicked;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Maroon;
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(67, 111);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(171, 44);
            btnDangKy.TabIndex = 10;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(6, 73);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 0;
            label10.Text = "Mật khẩu:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(5, 39);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 0;
            label9.Text = "Tài khoản:";
            // 
            // txtMatKhauDK
            // 
            txtMatKhauDK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhauDK.ForeColor = Color.FromArgb(28, 28, 28);
            txtMatKhauDK.Location = new Point(86, 70);
            txtMatKhauDK.Name = "txtMatKhauDK";
            txtMatKhauDK.PasswordChar = '*';
            txtMatKhauDK.Size = new Size(174, 27);
            txtMatKhauDK.TabIndex = 9;
            // 
            // txtTenDK
            // 
            txtTenDK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDK.ForeColor = Color.FromArgb(28, 28, 28);
            txtTenDK.Location = new Point(86, 36);
            txtTenDK.Name = "txtTenDK";
            txtTenDK.Size = new Size(174, 27);
            txtTenDK.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(cmbTinhThanh);
            groupBox2.Controls.Add(ckbNu);
            groupBox2.Controls.Add(ckbNam);
            groupBox2.Controls.Add(dtpNgaySinh);
            groupBox2.Controls.Add(txtCCCD);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtSDT);
            groupBox2.Controls.Add(txtHoTen);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.DimGray;
            groupBox2.Location = new Point(15, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 295);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin cá nhân";
            // 
            // cmbTinhThanh
            // 
            cmbTinhThanh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTinhThanh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTinhThanh.ForeColor = Color.FromArgb(28, 28, 28);
            cmbTinhThanh.FormattingEnabled = true;
            cmbTinhThanh.Items.AddRange(new object[] { "An Giang", "", "Bà Rịa – Vũng Tàu", "", "Bắc Giang", "", "Bắc Kạn", "", "Bạc Liêu", "", "Bắc Ninh", "", "Bến Tre", "", "Bình Định", "", "Bình Dương", "", "Bình Phước", "", "Bình Thuận", "", "Cà Mau", "", "Cao Bằng", "", "Cần Thơ", "", "Đà Nẵng", "", "Đắk Lắk", "", "Đắk Nông", "", "Điện Biên", "", "Đồng Nai", "", "Đồng Tháp", "", "Gia Lai", "", "Hà Giang", "", "Hà Nam", "", "Hà Nội", "", "Hà Tĩnh", "", "Hải Dương", "", "Hải Phòng", "", "Hậu Giang", "", "Hòa Bình", "", "Hưng Yên", "", "Khánh Hòa", "", "Kiên Giang", "", "Kon Tum", "", "Lai Châu", "", "Lâm Đồng", "", "Lạng Sơn", "", "Lào Cai", "", "Long An", "", "Nam Định", "", "Nghệ An", "", "Ninh Bình", "", "Ninh Thuận", "", "Phú Thọ", "", "Phú Yên", "", "Quảng Bình", "", "Quảng Nam", "", "Quảng Ngãi", "", "Quảng Ninh", "", "Quảng Trị", "", "Sóc Trăng", "", "Sơn La", "", "Tây Ninh", "", "Thái Bình", "", "Thái Nguyên", "", "Thanh Hóa", "", "Thừa Thiên Huế", "", "Tiền Giang", "", "TP. Hồ Chí Minh", "", "Trà Vinh", "", "Tuyên Quang", "", "Vĩnh Long", "", "Vĩnh Phúc", "", "Yên Bái" });
            cmbTinhThanh.Location = new Point(130, 148);
            cmbTinhThanh.Name = "cmbTinhThanh";
            cmbTinhThanh.Size = new Size(167, 28);
            cmbTinhThanh.TabIndex = 4;
            // 
            // ckbNu
            // 
            ckbNu.AutoSize = true;
            ckbNu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbNu.ForeColor = Color.Black;
            ckbNu.Location = new Point(209, 75);
            ckbNu.Name = "ckbNu";
            ckbNu.Size = new Size(51, 24);
            ckbNu.TabIndex = 2;
            ckbNu.Text = "Nữ";
            ckbNu.UseVisualStyleBackColor = true;
            ckbNu.CheckedChanged += ckbNu_CheckedChanged;
            // 
            // ckbNam
            // 
            ckbNam.AutoSize = true;
            ckbNam.Checked = true;
            ckbNam.CheckState = CheckState.Checked;
            ckbNam.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbNam.ForeColor = Color.Black;
            ckbNam.Location = new Point(130, 75);
            ckbNam.Name = "ckbNam";
            ckbNam.Size = new Size(63, 24);
            ckbNam.TabIndex = 2;
            ckbNam.Text = "Nam";
            ckbNam.UseVisualStyleBackColor = true;
            ckbNam.CheckedChanged += ckbNam_CheckedChanged;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CalendarForeColor = Color.FromArgb(28, 28, 28);
            dtpNgaySinh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(130, 110);
            dtpNgaySinh.MaxDate = new DateTime(2007, 12, 31, 0, 0, 0, 0);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(167, 27);
            dtpNgaySinh.TabIndex = 3;
            dtpNgaySinh.Value = new DateTime(2007, 12, 31, 0, 0, 0, 0);
            // 
            // txtCCCD
            // 
            txtCCCD.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCCCD.ForeColor = Color.FromArgb(28, 28, 28);
            txtCCCD.Location = new Point(130, 256);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(167, 27);
            txtCCCD.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(28, 28, 28);
            txtEmail.Location = new Point(130, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(167, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSDT.ForeColor = Color.FromArgb(28, 28, 28);
            txtSDT.Location = new Point(130, 184);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(167, 27);
            txtSDT.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.ForeColor = Color.FromArgb(28, 28, 28);
            txtHoTen.Location = new Point(130, 40);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(167, 27);
            txtHoTen.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(72, 259);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 0;
            label8.Text = "CCCD:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(73, 223);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 0;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(83, 187);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 0;
            label6.Text = "SĐT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(6, 151);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 0;
            label5.Text = "Tỉnh/Thành phố:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(45, 115);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 0;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(54, 79);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Giới tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(65, 43);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 0;
            label2.Text = "Họ tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(109, 18);
            label1.Name = "label1";
            label1.Size = new Size(116, 31);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG KÝ";
            // 
            // grbDangNhap
            // 
            grbDangNhap.BackColor = Color.LightGray;
            grbDangNhap.Controls.Add(groupBox5);
            grbDangNhap.Controls.Add(label11);
            grbDangNhap.Location = new Point(423, 12);
            grbDangNhap.Name = "grbDangNhap";
            grbDangNhap.Size = new Size(335, 264);
            grbDangNhap.TabIndex = 3;
            grbDangNhap.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(llbDangKy);
            groupBox5.Controls.Add(btnDangNhap);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(txtMatKhauDN);
            groupBox5.Controls.Add(txtTenDN);
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.DimGray;
            groupBox5.Location = new Point(15, 57);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(304, 192);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thông tin đăng nhập";
            // 
            // llbDangKy
            // 
            llbDangKy.AutoSize = true;
            llbDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbDangKy.LinkColor = Color.Blue;
            llbDangKy.Location = new Point(164, 162);
            llbDangKy.Name = "llbDangKy";
            llbDangKy.Size = new Size(135, 20);
            llbDangKy.TabIndex = 4;
            llbDangKy.TabStop = true;
            llbDangKy.Text = "Chưa có tài khoản?";
            llbDangKy.LinkClicked += llbDangKy_LinkClicked;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Maroon;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(67, 105);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(171, 44);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(6, 73);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 0;
            label12.Text = "Mật khẩu:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(5, 39);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 0;
            label13.Text = "Tài khoản:";
            // 
            // txtMatKhauDN
            // 
            txtMatKhauDN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhauDN.ForeColor = Color.FromArgb(28, 28, 28);
            txtMatKhauDN.Location = new Point(86, 70);
            txtMatKhauDN.Name = "txtMatKhauDN";
            txtMatKhauDN.PasswordChar = '*';
            txtMatKhauDN.Size = new Size(174, 27);
            txtMatKhauDN.TabIndex = 2;
            // 
            // txtTenDN
            // 
            txtTenDN.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDN.ForeColor = Color.FromArgb(28, 28, 28);
            txtTenDN.Location = new Point(86, 36);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(174, 27);
            txtTenDN.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(91, 18);
            label11.Name = "label11";
            label11.Size = new Size(153, 31);
            label11.TabIndex = 1;
            label11.Text = "ĐĂNG NHẬP";
            // 
            // AccountAuthentication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(771, 621);
            Controls.Add(grbDangNhap);
            Controls.Add(grbDangKy);
            Name = "AccountAuthentication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            FormClosing += AccountAuthentication_FormClosing;
            Load += Authentication_Load;
            grbDangKy.ResumeLayout(false);
            grbDangKy.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grbDangNhap.ResumeLayout(false);
            grbDangNhap.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDangKy;
        private GroupBox groupBox3;
        private LinkLabel llbDangNhap;
        private Button btnDangKy;
        private Label label10;
        private Label label9;
        private TextBox txtMatKhauDK;
        private TextBox txtTenDK;
        private GroupBox groupBox2;
        private ComboBox cmbTinhThanh;
        private CheckBox ckbNu;
        private CheckBox ckbNam;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtCCCD;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grbDangNhap;
        private GroupBox groupBox5;
        private LinkLabel llbDangKy;
        private Button btnDangNhap;
        private Label label12;
        private Label label13;
        private TextBox txtMatKhauDN;
        private TextBox txtTenDN;
        private Label label11;
    }
}