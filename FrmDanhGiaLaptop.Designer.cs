namespace DanhGiaLaptopApp
{
    partial class FrmDanhGiaLaptop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenLaptop;
        private System.Windows.Forms.TextBox txtTenLaptop;
        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.ComboBox cboHang;
        private System.Windows.Forms.Label lblDanhGia;
        private System.Windows.Forms.NumericUpDown numSao;
        private System.Windows.Forms.Label lblNhanXet;
        private System.Windows.Forms.TextBox txtNhanXet;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.ListBox lstDanhGia;

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

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenLaptop = new System.Windows.Forms.Label();
            this.txtTenLaptop = new System.Windows.Forms.TextBox();
            this.lblHang = new System.Windows.Forms.Label();
            this.cboHang = new System.Windows.Forms.ComboBox();
            this.lblDanhGia = new System.Windows.Forms.Label();
            this.numSao = new System.Windows.Forms.NumericUpDown();
            this.lblNhanXet = new System.Windows.Forms.Label();
            this.txtNhanXet = new System.Windows.Forms.TextBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.lstDanhGia = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đánh giá Laptop";
            // 
            // lblTenLaptop
            // 
            this.lblTenLaptop.AutoSize = true;
            this.lblTenLaptop.Location = new System.Drawing.Point(16, 50);
            this.lblTenLaptop.Name = "lblTenLaptop";
            this.lblTenLaptop.Size = new System.Drawing.Size(69, 15);
            this.lblTenLaptop.TabIndex = 1;
            this.lblTenLaptop.Text = "Tên Laptop:";
            // 
            // txtTenLaptop
            // 
            this.txtTenLaptop.Location = new System.Drawing.Point(110, 47);
            this.txtTenLaptop.Name = "txtTenLaptop";
            this.txtTenLaptop.Size = new System.Drawing.Size(300, 23);
            this.txtTenLaptop.TabIndex = 2;
            // 
            // lblHang
            // 
            this.lblHang.AutoSize = true;
            this.lblHang.Location = new System.Drawing.Point(16, 85);
            this.lblHang.Name = "lblHang";
            this.lblHang.Size = new System.Drawing.Size(81, 15);
            this.lblHang.TabIndex = 3;
            this.lblHang.Text = "Hãng sản xuất:";
            // 
            // cboHang
            // 
            this.cboHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHang.FormattingEnabled = true;
            this.cboHang.Location = new System.Drawing.Point(110, 82);
            this.cboHang.Name = "cboHang";
            this.cboHang.Size = new System.Drawing.Size(200, 23);
            this.cboHang.TabIndex = 4;
            // 
            // lblDanhGia
            // 
            this.lblDanhGia.AutoSize = true;
            this.lblDanhGia.Location = new System.Drawing.Point(16, 120);
            this.lblDanhGia.Name = "lblDanhGia";
            this.lblDanhGia.Size = new System.Drawing.Size(73, 15);
            this.lblDanhGia.TabIndex = 5;
            this.lblDanhGia.Text = "Số sao (1–5):";
            // 
            // numSao
            // 
            this.numSao.Location = new System.Drawing.Point(110, 118);
            this.numSao.Name = "numSao";
            this.numSao.Size = new System.Drawing.Size(60, 23);
            this.numSao.TabIndex = 6;
            this.numSao.Value = new decimal(new int[] {1,0,0,0});
            // 
            // lblNhanXet
            // 
            this.lblNhanXet.AutoSize = true;
            this.lblNhanXet.Location = new System.Drawing.Point(16, 155);
            this.lblNhanXet.Name = "lblNhanXet";
            this.lblNhanXet.Size = new System.Drawing.Size(54, 15);
            this.lblNhanXet.TabIndex = 7;
            this.lblNhanXet.Text = "Nhận xét:";
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.Location = new System.Drawing.Point(110, 152);
            this.txtNhanXet.Multiline = true;
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.Size = new System.Drawing.Size(300, 100);
            this.txtNhanXet.TabIndex = 8;
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(110, 270);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(100, 30);
            this.btnGui.TabIndex = 9;
            this.btnGui.Text = "Gửi đánh giá";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // lstDanhGia
            // 
            this.lstDanhGia.FormattingEnabled = true;
            this.lstDanhGia.HorizontalScrollbar = true;
            this.lstDanhGia.ItemHeight = 15;
            this.lstDanhGia.Location = new System.Drawing.Point(440, 47);
            this.lstDanhGia.Name = "lstDanhGia";
            this.lstDanhGia.Size = new System.Drawing.Size(520, 334);
            this.lstDanhGia.TabIndex = 10;
            // 
            // FrmDanhGiaLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 420);
            this.Controls.Add(this.lstDanhGia);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.txtNhanXet);
            this.Controls.Add(this.lblNhanXet);
            this.Controls.Add(this.numSao);
            this.Controls.Add(this.lblDanhGia);
            this.Controls.Add(this.cboHang);
            this.Controls.Add(this.lblHang);
            this.Controls.Add(this.txtTenLaptop);
            this.Controls.Add(this.lblTenLaptop);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = true;
            this.Name = "FrmDanhGiaLaptop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhGiaLaptopApp";
            this.Load += new System.EventHandler(this.FrmDanhGiaLaptop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
