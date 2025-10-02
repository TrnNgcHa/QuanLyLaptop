namespace QuanLyLaptop
{
    partial class frmQuanLyLaptop_QTV
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvDanhSachLaptop = new DataGridView();
            dataGridView2 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            MaLaptop = new DataGridViewTextBoxColumn();
            TenLaptop = new DataGridViewTextBoxColumn();
            HangLaptop = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            SoTon = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            GiaLaptop = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLaptop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(dgvDanhSachLaptop, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1070, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDanhSachLaptop
            // 
            dgvDanhSachLaptop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachLaptop.Columns.AddRange(new DataGridViewColumn[] { MaLaptop, TenLaptop, HangLaptop, NgayNhap, SoTon, SoLuong, GiaLaptop });
            dgvDanhSachLaptop.Dock = DockStyle.Fill;
            dgvDanhSachLaptop.Location = new Point(3, 93);
            dgvDanhSachLaptop.Name = "dgvDanhSachLaptop";
            dgvDanhSachLaptop.RowHeadersWidth = 51;
            dgvDanhSachLaptop.Size = new Size(743, 354);
            dgvDanhSachLaptop.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(752, 93);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(315, 354);
            dataGridView2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 84);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(752, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 84);
            panel2.TabIndex = 3;
            // 
            // MaLaptop
            // 
            MaLaptop.DataPropertyName = "MaLaptop";
            MaLaptop.HeaderText = "Mã Laptop";
            MaLaptop.MinimumWidth = 6;
            MaLaptop.Name = "MaLaptop";
            MaLaptop.Width = 125;
            // 
            // TenLaptop
            // 
            TenLaptop.DataPropertyName = "TenLaptop";
            TenLaptop.HeaderText = "Tên Laptop";
            TenLaptop.MinimumWidth = 6;
            TenLaptop.Name = "TenLaptop";
            TenLaptop.Width = 125;
            // 
            // HangLaptop
            // 
            HangLaptop.DataPropertyName = "HangSanXuat";
            HangLaptop.HeaderText = "Hãng Laptop";
            HangLaptop.MinimumWidth = 6;
            HangLaptop.Name = "HangLaptop";
            HangLaptop.Width = 125;
            // 
            // NgayNhap
            // 
            NgayNhap.DataPropertyName = "NgayNhap";
            NgayNhap.HeaderText = "Ngày Nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.Width = 125;
            // 
            // SoTon
            // 
            SoTon.DataPropertyName = "SoTon";
            SoTon.HeaderText = "Số Tồn";
            SoTon.MinimumWidth = 6;
            SoTon.Name = "SoTon";
            SoTon.Width = 125;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 125;
            // 
            // GiaLaptop
            // 
            GiaLaptop.DataPropertyName = "GiaLaptop";
            GiaLaptop.HeaderText = "Giá Tiền";
            GiaLaptop.MinimumWidth = 6;
            GiaLaptop.Name = "GiaLaptop";
            GiaLaptop.Width = 125;
            // 
            // frmQuanLyLaptop_QTV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmQuanLyLaptop_QTV";
            Text = "frmQuanLyLaptop";
            WindowState = FormWindowState.Maximized;
            Load += frmQuanLyLaptop_QTV_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLaptop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvDanhSachLaptop;
        private DataGridView dataGridView2;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn MaLaptop;
        private DataGridViewTextBoxColumn TenLaptop;
        private DataGridViewTextBoxColumn HangLaptop;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn SoTon;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaLaptop;
    }
}