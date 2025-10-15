namespace QuanLyLaptop
{
    partial class Receipt
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
            btnThoat = new Button();
            btnIn = new Button();
            btnLuu = new Button();
            txtThanhTien = new TextBox();
            nudSoLuong = new NumericUpDown();
            txtGiaTien = new TextBox();
            txtTenLaptop = new TextBox();
            txtTenKH = new TextBox();
            dtpNgayLap = new DateTimePicker();
            txtMaHD = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(510, 321);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 30);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnIn
            // 
            btnIn.Location = new Point(288, 321);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(90, 30);
            btnIn.TabIndex = 20;
            btnIn.Text = "In hóa đơn";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(184, 321);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(90, 30);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(184, 281);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(436, 27);
            txtThanhTien.TabIndex = 18;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(400, 241);
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(80, 27);
            nudSoLuong.TabIndex = 17;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.ValueChanged += nudSoLuong_ValueChanged;
            // 
            // txtGiaTien
            // 
            txtGiaTien.Location = new Point(184, 241);
            txtGiaTien.Name = "txtGiaTien";
            txtGiaTien.ReadOnly = true;
            txtGiaTien.Size = new Size(200, 27);
            txtGiaTien.TabIndex = 16;
            // 
            // txtTenLaptop
            // 
            txtTenLaptop.Location = new Point(184, 206);
            txtTenLaptop.Name = "txtTenLaptop";
            txtTenLaptop.ReadOnly = true;
            txtTenLaptop.Size = new Size(436, 27);
            txtTenLaptop.TabIndex = 15;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(184, 171);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.PlaceholderText = "Tên khách hàng";
            txtTenKH.Size = new Size(436, 27);
            txtTenKH.TabIndex = 14;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Location = new Point(400, 133);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(220, 27);
            dtpNgayLap.TabIndex = 13;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(184, 133);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.ReadOnly = true;
            txtMaHD.Size = new Size(200, 27);
            txtMaHD.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(180, 100);
            label1.Name = "label1";
            label1.Size = new Size(242, 28);
            label1.TabIndex = 11;
            label1.Text = "HÓA ĐƠN MUA LAPTOP";
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnIn);
            Controls.Add(btnLuu);
            Controls.Add(txtThanhTien);
            Controls.Add(nudSoLuong);
            Controls.Add(txtGiaTien);
            Controls.Add(txtTenLaptop);
            Controls.Add(txtTenKH);
            Controls.Add(dtpNgayLap);
            Controls.Add(txtMaHD);
            Controls.Add(label1);
            Name = "Receipt";
            Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnIn;
        private Button btnLuu;
        private TextBox txtThanhTien;
        private NumericUpDown nudSoLuong;
        private TextBox txtGiaTien;
        private TextBox txtTenLaptop;
        private TextBox txtTenKH;
        private DateTimePicker dtpNgayLap;
        private TextBox txtMaHD;
        private Label label1;
    }
}