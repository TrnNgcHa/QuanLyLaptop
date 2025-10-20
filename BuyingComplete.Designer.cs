namespace QuanLyLaptop
{
    partial class BuyingComplete
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
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            lblNgayLapHoaDon = new Label();
            lblTenKhachHang = new Label();
            lblTenTaiKhoan = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 684);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(304, 629);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(81, 49);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Đóng";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(6, 190);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(385, 409);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
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
            lblNgayLapHoaDon.Location = new Point(156, 94);
            lblNgayLapHoaDon.Name = "lblNgayLapHoaDon";
            lblNgayLapHoaDon.Size = new Size(223, 25);
            lblNgayLapHoaDon.TabIndex = 3;
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.BorderStyle = BorderStyle.Fixed3D;
            lblTenKhachHang.Location = new Point(156, 58);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(223, 25);
            lblTenKhachHang.TabIndex = 3;
            // 
            // lblTenTaiKhoan
            // 
            lblTenTaiKhoan.BorderStyle = BorderStyle.Fixed3D;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 23);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 0;
            label1.Text = "HÓA ĐƠN";
            // 
            // PayingCompleted
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 708);
            Controls.Add(groupBox1);
            Name = "PayingCompleted";
            Text = "PayingCompleted";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnHuy;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label lblNgayLapHoaDon;
        private Label lblTenKhachHang;
        private Label lblTenTaiKhoan;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
    }
}