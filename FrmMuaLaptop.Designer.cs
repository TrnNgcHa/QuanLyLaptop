namespace MuaLaptopApp
{
    partial class FrmMuaLaptop
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.ComboBox cboHang;
        private System.Windows.Forms.Label lblLaptop;
        private System.Windows.Forms.ComboBox cboLaptop;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnMua;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblHang = new Label();
            cboHang = new ComboBox();
            lblLaptop = new Label();
            cboLaptop = new ComboBox();
            lblGia = new Label();
            txtGia = new TextBox();
            lblSoLuong = new Label();
            numSoLuong = new NumericUpDown();
            lblThanhTien = new Label();
            txtThanhTien = new TextBox();
            btnMua = new Button();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(14, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(151, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mua Laptop";
            // 
            // lblHang
            // 
            lblHang.AutoSize = true;
            lblHang.Location = new Point(18, 67);
            lblHang.Name = "lblHang";
            lblHang.Size = new Size(48, 20);
            lblHang.TabIndex = 1;
            lblHang.Text = "Hãng:";
            // 
            // cboHang
            // 
            cboHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHang.FormattingEnabled = true;
            cboHang.Location = new Point(126, 63);
            cboHang.Margin = new Padding(3, 4, 3, 4);
            cboHang.Name = "cboHang";
            cboHang.Size = new Size(228, 28);
            cboHang.TabIndex = 2;
            cboHang.SelectedIndexChanged += cboHang_SelectedIndexChanged;
            // 
            // lblLaptop
            // 
            lblLaptop.AutoSize = true;
            lblLaptop.Location = new Point(18, 113);
            lblLaptop.Name = "lblLaptop";
            lblLaptop.Size = new Size(86, 20);
            lblLaptop.TabIndex = 3;
            lblLaptop.Text = "Tên Laptop:";
            // 
            // cboLaptop
            // 
            cboLaptop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLaptop.FormattingEnabled = true;
            cboLaptop.Location = new Point(126, 109);
            cboLaptop.Margin = new Padding(3, 4, 3, 4);
            cboLaptop.Name = "cboLaptop";
            cboLaptop.Size = new Size(285, 28);
            cboLaptop.TabIndex = 4;
            cboLaptop.SelectedIndexChanged += cboLaptop_SelectedIndexChanged;
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(18, 160);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(79, 20);
            lblGia.TabIndex = 5;
            lblGia.Text = "Giá (VNĐ):";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(126, 156);
            txtGia.Margin = new Padding(3, 4, 3, 4);
            txtGia.Name = "txtGia";
            txtGia.ReadOnly = true;
            txtGia.Size = new Size(171, 27);
            txtGia.TabIndex = 6;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(18, 207);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(72, 20);
            lblSoLuong.TabIndex = 7;
            lblSoLuong.Text = "Số lượng:";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(126, 204);
            numSoLuong.Margin = new Padding(3, 4, 3, 4);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(69, 27);
            numSoLuong.TabIndex = 8;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.ValueChanged += numSoLuong_ValueChanged;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Location = new Point(18, 253);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(126, 20);
            lblThanhTien.TabIndex = 9;
            lblThanhTien.Text = "Thành tiền (VNĐ):";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(126, 249);
            txtThanhTien.Margin = new Padding(3, 4, 3, 4);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(171, 27);
            txtThanhTien.TabIndex = 10;
            // 
            // btnMua
            // 
            btnMua.Location = new Point(126, 300);
            btnMua.Margin = new Padding(3, 4, 3, 4);
            btnMua.Name = "btnMua";
            btnMua.Size = new Size(114, 40);
            btnMua.TabIndex = 11;
            btnMua.Text = "Mua hàng";
            btnMua.UseVisualStyleBackColor = true;
            btnMua.Click += btnMua_Click;
            // 
            // FrmMuaLaptop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 368);
            Controls.Add(btnMua);
            Controls.Add(txtThanhTien);
            Controls.Add(lblThanhTien);
            Controls.Add(numSoLuong);
            Controls.Add(lblSoLuong);
            Controls.Add(txtGia);
            Controls.Add(lblGia);
            Controls.Add(cboLaptop);
            Controls.Add(lblLaptop);
            Controls.Add(cboHang);
            Controls.Add(lblHang);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMuaLaptop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MuaLaptopApp";
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
