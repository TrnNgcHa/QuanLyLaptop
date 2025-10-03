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
            STT1 = new DataGridViewTextBoxColumn();
            MaLaptop = new DataGridViewTextBoxColumn();
            TenLaptop = new DataGridViewTextBoxColumn();
            HangLaptop = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            SoTon = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            GiaLaptop = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            dgvDanhSachLinhKien = new DataGridView();
            dataGridView2 = new DataGridView();
            subMaLaptop = new DataGridViewTextBoxColumn();
            subTenCPU = new DataGridViewTextBoxColumn();
            subTenGPU = new DataGridViewTextBoxColumn();
            subTenOCung = new DataGridViewTextBoxColumn();
            subTenRAM = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLaptop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLinhKien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.8130836F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.1869164F));
            tableLayoutPanel1.Controls.Add(dgvDanhSachLaptop, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(splitContainer1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel1.Size = new Size(1070, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDanhSachLaptop
            // 
            dgvDanhSachLaptop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachLaptop.Columns.AddRange(new DataGridViewColumn[] { STT1, MaLaptop, TenLaptop, HangLaptop, NgayNhap, SoTon, SoLuong, GiaLaptop });
            dgvDanhSachLaptop.Dock = DockStyle.Fill;
            dgvDanhSachLaptop.Location = new Point(3, 77);
            dgvDanhSachLaptop.Name = "dgvDanhSachLaptop";
            dgvDanhSachLaptop.RowHeadersWidth = 51;
            dgvDanhSachLaptop.Size = new Size(634, 370);
            dgvDanhSachLaptop.TabIndex = 0;
            dgvDanhSachLaptop.DataBindingComplete += dgvDanhSachLaptop_DataBindingComplete;
            // 
            // STT1
            // 
            STT1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            STT1.HeaderText = "STT";
            STT1.MinimumWidth = 6;
            STT1.Name = "STT1";
            STT1.Width = 62;
            // 
            // MaLaptop
            // 
            MaLaptop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            MaLaptop.DataPropertyName = "MaLaptop";
            MaLaptop.HeaderText = "Mã Laptop";
            MaLaptop.MinimumWidth = 6;
            MaLaptop.Name = "MaLaptop";
            MaLaptop.Width = 24;
            // 
            // TenLaptop
            // 
            TenLaptop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            TenLaptop.DataPropertyName = "TenLaptop";
            TenLaptop.HeaderText = "Tên Laptop";
            TenLaptop.MinimumWidth = 6;
            TenLaptop.Name = "TenLaptop";
            TenLaptop.Width = 24;
            // 
            // HangLaptop
            // 
            HangLaptop.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            HangLaptop.DataPropertyName = "HangSanXuat";
            HangLaptop.HeaderText = "Hãng Laptop";
            HangLaptop.MinimumWidth = 6;
            HangLaptop.Name = "HangLaptop";
            HangLaptop.Width = 24;
            // 
            // NgayNhap
            // 
            NgayNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            NgayNhap.DataPropertyName = "NgayNhap";
            NgayNhap.HeaderText = "Ngày Nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.Width = 24;
            // 
            // SoTon
            // 
            SoTon.DataPropertyName = "SoTon";
            SoTon.HeaderText = "Số Tồn";
            SoTon.MinimumWidth = 6;
            SoTon.Name = "SoTon";
            SoTon.Width = 50;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 50;
            // 
            // GiaLaptop
            // 
            GiaLaptop.DataPropertyName = "GiaLaptop";
            GiaLaptop.HeaderText = "Giá Tiền";
            GiaLaptop.MinimumWidth = 6;
            GiaLaptop.Name = "GiaLaptop";
            GiaLaptop.Width = 125;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 68);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(643, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 68);
            panel2.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(643, 77);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDanhSachLinhKien);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Size = new Size(424, 370);
            splitContainer1.SplitterDistance = 162;
            splitContainer1.TabIndex = 4;
            // 
            // dgvDanhSachLinhKien
            // 
            dgvDanhSachLinhKien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachLinhKien.Columns.AddRange(new DataGridViewColumn[] { subMaLaptop, subTenCPU, subTenGPU, subTenOCung, subTenRAM });
            dgvDanhSachLinhKien.Dock = DockStyle.Fill;
            dgvDanhSachLinhKien.Location = new Point(0, 0);
            dgvDanhSachLinhKien.Name = "dgvDanhSachLinhKien";
            dgvDanhSachLinhKien.RowHeadersWidth = 51;
            dgvDanhSachLinhKien.Size = new Size(424, 162);
            dgvDanhSachLinhKien.TabIndex = 0;
            dgvDanhSachLinhKien.CellEnter += dgvDanhSachLinhKien_CellEnter;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(424, 204);
            dataGridView2.TabIndex = 0;
            // 
            // subMaLaptop
            // 
            subMaLaptop.DataPropertyName = "MaLaptop";
            subMaLaptop.HeaderText = "Mã Laptop";
            subMaLaptop.MinimumWidth = 6;
            subMaLaptop.Name = "subMaLaptop";
            subMaLaptop.Width = 125;
            // 
            // subTenCPU
            // 
            subTenCPU.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            subTenCPU.DataPropertyName = "TenCPU";
            subTenCPU.HeaderText = "Tên CPU";
            subTenCPU.MinimumWidth = 6;
            subTenCPU.Name = "subTenCPU";
            subTenCPU.Width = 24;
            // 
            // subTenGPU
            // 
            subTenGPU.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            subTenGPU.DataPropertyName = "TenGPU";
            subTenGPU.HeaderText = "Tên GPU";
            subTenGPU.MinimumWidth = 6;
            subTenGPU.Name = "subTenGPU";
            subTenGPU.Width = 24;
            // 
            // subTenOCung
            // 
            subTenOCung.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            subTenOCung.DataPropertyName = "TenOCung";
            subTenOCung.HeaderText = "Tên Ổ Cứng";
            subTenOCung.MinimumWidth = 6;
            subTenOCung.Name = "subTenOCung";
            subTenOCung.Width = 24;
            // 
            // subTenRAM
            // 
            subTenRAM.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            subTenRAM.DataPropertyName = "TenRAM";
            subTenRAM.HeaderText = "Tên RAM";
            subTenRAM.MinimumWidth = 6;
            subTenRAM.Name = "subTenRAM";
            subTenRAM.Width = 24;
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachLinhKien).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvDanhSachLaptop;
        private Panel panel1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private DataGridView dgvDanhSachLinhKien;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn STT1;
        private DataGridViewTextBoxColumn MaLaptop;
        private DataGridViewTextBoxColumn TenLaptop;
        private DataGridViewTextBoxColumn HangLaptop;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn SoTon;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaLaptop;
        private DataGridViewTextBoxColumn subMaLaptop;
        private DataGridViewTextBoxColumn subTenCPU;
        private DataGridViewTextBoxColumn subTenGPU;
        private DataGridViewTextBoxColumn subTenOCung;
        private DataGridViewTextBoxColumn subTenRAM;
    }
}