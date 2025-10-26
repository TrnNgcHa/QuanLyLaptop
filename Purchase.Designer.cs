namespace QuanLyLaptop
{
    partial class Purchase
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
            groupBox1 = new GroupBox();
            btnHuy = new Button();
            btnThanhToan = new Button();
            groupBox3 = new GroupBox();
            ckbNuocRua = new CheckBox();
            ckbTuiDung = new CheckBox();
            ckbLotChuot = new CheckBox();
            ckbUSB = new CheckBox();
            lblGiaThem = new Label();
            lblGiaLaptop = new Label();
            lblTenLaptop = new Label();
            label8 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lblNgayLapHoaDon = new Label();
            lblTenKhachHang = new Label();
            lblTenTaiKhoan = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            lblThanhTien = new Label();
            lblSoDu = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(28, 28, 28);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnThanhToan);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblThanhTien);
            groupBox1.ForeColor = Color.FromArgb(179, 179, 179);
            groupBox1.Location = new Point(33, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 514);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.DarkGray;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(6, 447);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(81, 49);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.Red;
            btnThanhToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(245, 447);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(140, 49);
            btnThanhToan.TabIndex = 6;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ckbNuocRua);
            groupBox3.Controls.Add(ckbTuiDung);
            groupBox3.Controls.Add(ckbLotChuot);
            groupBox3.Controls.Add(ckbUSB);
            groupBox3.Controls.Add(lblGiaThem);
            groupBox3.Controls.Add(lblGiaLaptop);
            groupBox3.Controls.Add(lblTenLaptop);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(6, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(385, 198);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // ckbNuocRua
            // 
            ckbNuocRua.AutoSize = true;
            ckbNuocRua.Location = new Point(94, 123);
            ckbNuocRua.Name = "ckbNuocRua";
            ckbNuocRua.Size = new Size(126, 24);
            ckbNuocRua.TabIndex = 5;
            ckbNuocRua.Text = "Nước rửa màn";
            ckbNuocRua.UseVisualStyleBackColor = true;
            ckbNuocRua.CheckedChanged += ckbNuocRua_CheckedChanged;
            // 
            // ckbTuiDung
            // 
            ckbTuiDung.AutoSize = true;
            ckbTuiDung.Location = new Point(226, 93);
            ckbTuiDung.Name = "ckbTuiDung";
            ckbTuiDung.Size = new Size(138, 24);
            ckbTuiDung.TabIndex = 5;
            ckbTuiDung.Text = "Túi đựng laptop";
            ckbTuiDung.UseVisualStyleBackColor = true;
            ckbTuiDung.CheckedChanged += ckbTuiDung_CheckedChanged;
            // 
            // ckbLotChuot
            // 
            ckbLotChuot.AutoSize = true;
            ckbLotChuot.Location = new Point(226, 123);
            ckbLotChuot.Name = "ckbLotChuot";
            ckbLotChuot.Size = new Size(93, 24);
            ckbLotChuot.TabIndex = 5;
            ckbLotChuot.Text = "Lót chuột";
            ckbLotChuot.UseVisualStyleBackColor = true;
            ckbLotChuot.CheckedChanged += ckbLotChuot_CheckedChanged;
            // 
            // ckbUSB
            // 
            ckbUSB.AutoSize = true;
            ckbUSB.Location = new Point(94, 93);
            ckbUSB.Name = "ckbUSB";
            ckbUSB.Size = new Size(107, 24);
            ckbUSB.TabIndex = 5;
            ckbUSB.Text = "USB (16GB)";
            ckbUSB.UseVisualStyleBackColor = true;
            ckbUSB.CheckedChanged += ckbUSB_CheckedChanged;
            // 
            // lblGiaThem
            // 
            lblGiaThem.BorderStyle = BorderStyle.Fixed3D;
            lblGiaThem.ForeColor = Color.White;
            lblGiaThem.Location = new Point(156, 160);
            lblGiaThem.Name = "lblGiaThem";
            lblGiaThem.Size = new Size(223, 25);
            lblGiaThem.TabIndex = 3;
            // 
            // lblGiaLaptop
            // 
            lblGiaLaptop.BorderStyle = BorderStyle.Fixed3D;
            lblGiaLaptop.ForeColor = Color.White;
            lblGiaLaptop.Location = new Point(156, 55);
            lblGiaLaptop.Name = "lblGiaLaptop";
            lblGiaLaptop.Size = new Size(223, 25);
            lblGiaLaptop.TabIndex = 3;
            // 
            // lblTenLaptop
            // 
            lblTenLaptop.BorderStyle = BorderStyle.Fixed3D;
            lblTenLaptop.ForeColor = Color.White;
            lblTenLaptop.Location = new Point(156, 22);
            lblTenLaptop.Name = "lblTenLaptop";
            lblTenLaptop.Size = new Size(223, 25);
            lblTenLaptop.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 95);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 4;
            label8.Text = "Thêm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 23);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên laptop:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblNgayLapHoaDon);
            groupBox2.Controls.Add(lblTenKhachHang);
            groupBox2.Controls.Add(lblTenTaiKhoan);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(6, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 130);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // lblNgayLapHoaDon
            // 
            lblNgayLapHoaDon.BorderStyle = BorderStyle.Fixed3D;
            lblNgayLapHoaDon.ForeColor = Color.White;
            lblNgayLapHoaDon.Location = new Point(156, 94);
            lblNgayLapHoaDon.Name = "lblNgayLapHoaDon";
            lblNgayLapHoaDon.Size = new Size(223, 25);
            lblNgayLapHoaDon.TabIndex = 3;
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.BorderStyle = BorderStyle.Fixed3D;
            lblTenKhachHang.ForeColor = Color.White;
            lblTenKhachHang.Location = new Point(156, 58);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(223, 25);
            lblTenKhachHang.TabIndex = 3;
            // 
            // lblTenTaiKhoan
            // 
            lblTenTaiKhoan.BorderStyle = BorderStyle.Fixed3D;
            lblTenTaiKhoan.ForeColor = Color.White;
            lblTenTaiKhoan.Location = new Point(156, 21);
            lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            lblTenTaiKhoan.Size = new Size(223, 25);
            lblTenTaiKhoan.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 23);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 1;
            label3.Text = "Tài khoản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 59);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 1;
            label4.Text = "Tên khách hàng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 95);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 2;
            label5.Text = "Ngày lập hóa đơn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 401);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 3;
            label6.Text = "Thành tiền:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(139, 23);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 0;
            label1.Text = "HÓA ĐƠN";
            // 
            // lblThanhTien
            // 
            lblThanhTien.BorderStyle = BorderStyle.Fixed3D;
            lblThanhTien.ForeColor = Color.White;
            lblThanhTien.Location = new Point(162, 400);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(223, 25);
            lblThanhTien.TabIndex = 3;
            // 
            // lblSoDu
            // 
            lblSoDu.AutoSize = true;
            lblSoDu.BackColor = Color.Transparent;
            lblSoDu.ForeColor = Color.Gold;
            lblSoDu.Location = new Point(147, 8);
            lblSoDu.Name = "lblSoDu";
            lblSoDu.Size = new Size(183, 20);
            lblSoDu.TabIndex = 1;
            lblSoDu.Text = "*Số dư của quý khách còn ";
            // 
            // Purchase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(465, 572);
            Controls.Add(lblSoDu);
            Controls.Add(groupBox1);
            Name = "Purchase";
            Text = "Purchase";
            Load += Purchase_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label8;
        private Label lblTenLaptop;
        private Label lblNgayLapHoaDon;
        private Label lblTenKhachHang;
        private Label lblTenTaiKhoan;
        private CheckBox ckbNuocRua;
        private CheckBox ckbTuiDung;
        private CheckBox ckbLotChuot;
        private CheckBox ckbUSB;
        private Label lblGiaLaptop;
        private Label label6;
        private Label lblGiaThem;
        private Label lblThanhTien;
        private Button btnHuy;
        private Button btnThanhToan;
        private Label lblSoDu;
    }
}