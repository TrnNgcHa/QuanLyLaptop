namespace QuanLyLaptop
{
    partial class ReviewPost
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
            groupBox2 = new GroupBox();
            ckbNamSao = new CheckBox();
            ckbBonSao = new CheckBox();
            ckbBaSao = new CheckBox();
            ckbHaiSao = new CheckBox();
            ckbMotSao = new CheckBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnDanhGia = new Button();
            lblTenLaptop = new Label();
            lblTenTK = new Label();
            btnThoat = new Button();
            cmbSoSao = new ComboBox();
            txtDanhGia = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDanhSachDanhGia = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(ckbNamSao);
            groupBox2.Controls.Add(ckbBonSao);
            groupBox2.Controls.Add(ckbBaSao);
            groupBox2.Controls.Add(ckbHaiSao);
            groupBox2.Controls.Add(ckbMotSao);
            groupBox2.Controls.Add(label3);
            groupBox2.ForeColor = Color.FromArgb(26, 26, 26);
            groupBox2.Location = new Point(451, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(424, 43);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // ckbNamSao
            // 
            ckbNamSao.AutoSize = true;
            ckbNamSao.Checked = true;
            ckbNamSao.CheckState = CheckState.Checked;
            ckbNamSao.Cursor = Cursors.Hand;
            ckbNamSao.ForeColor = Color.FromArgb(26, 26, 26);
            ckbNamSao.Location = new Point(366, 15);
            ckbNamSao.Name = "ckbNamSao";
            ckbNamSao.Size = new Size(56, 24);
            ckbNamSao.TabIndex = 1;
            ckbNamSao.Text = "5 ★";
            ckbNamSao.UseVisualStyleBackColor = true;
            ckbNamSao.CheckedChanged += this.ChonLoaiDanhGia;
            // 
            // ckbBonSao
            // 
            ckbBonSao.AutoSize = true;
            ckbBonSao.Checked = true;
            ckbBonSao.CheckState = CheckState.Checked;
            ckbBonSao.Cursor = Cursors.Hand;
            ckbBonSao.ForeColor = Color.FromArgb(26, 26, 26);
            ckbBonSao.Location = new Point(304, 15);
            ckbBonSao.Name = "ckbBonSao";
            ckbBonSao.Size = new Size(56, 24);
            ckbBonSao.TabIndex = 1;
            ckbBonSao.Text = "4 ★";
            ckbBonSao.UseVisualStyleBackColor = true;
            ckbBonSao.CheckedChanged += this.ChonLoaiDanhGia;
            // 
            // ckbBaSao
            // 
            ckbBaSao.AutoSize = true;
            ckbBaSao.Checked = true;
            ckbBaSao.CheckState = CheckState.Checked;
            ckbBaSao.Cursor = Cursors.Hand;
            ckbBaSao.ForeColor = Color.FromArgb(26, 26, 26);
            ckbBaSao.Location = new Point(242, 15);
            ckbBaSao.Name = "ckbBaSao";
            ckbBaSao.Size = new Size(56, 24);
            ckbBaSao.TabIndex = 1;
            ckbBaSao.Text = "3 ★";
            ckbBaSao.UseVisualStyleBackColor = true;
            ckbBaSao.CheckedChanged += this.ChonLoaiDanhGia;
            // 
            // ckbHaiSao
            // 
            ckbHaiSao.AutoSize = true;
            ckbHaiSao.Checked = true;
            ckbHaiSao.CheckState = CheckState.Checked;
            ckbHaiSao.Cursor = Cursors.Hand;
            ckbHaiSao.ForeColor = Color.FromArgb(26, 26, 26);
            ckbHaiSao.Location = new Point(180, 15);
            ckbHaiSao.Name = "ckbHaiSao";
            ckbHaiSao.Size = new Size(56, 24);
            ckbHaiSao.TabIndex = 1;
            ckbHaiSao.Text = "2 ★";
            ckbHaiSao.UseVisualStyleBackColor = true;
            ckbHaiSao.CheckedChanged += this.ChonLoaiDanhGia;
            // 
            // ckbMotSao
            // 
            ckbMotSao.AutoSize = true;
            ckbMotSao.Checked = true;
            ckbMotSao.CheckState = CheckState.Checked;
            ckbMotSao.Cursor = Cursors.Hand;
            ckbMotSao.ForeColor = Color.FromArgb(26, 26, 26);
            ckbMotSao.Location = new Point(118, 15);
            ckbMotSao.Name = "ckbMotSao";
            ckbMotSao.Size = new Size(56, 24);
            ckbMotSao.TabIndex = 1;
            ckbMotSao.Text = "1 ★";
            ckbMotSao.UseVisualStyleBackColor = true;
            ckbMotSao.CheckedChanged += this.ChonLoaiDanhGia;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(26, 26, 26);
            label3.Location = new Point(6, 17);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 0;
            label3.Text = "Loại đánh giá:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(btnDanhGia);
            groupBox1.Controls.Add(lblTenLaptop);
            groupBox1.Controls.Add(lblTenTK);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(cmbSoSao);
            groupBox1.Controls.Add(txtDanhGia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.FromArgb(26, 26, 26);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 376);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnDanhGia
            // 
            btnDanhGia.BackColor = Color.Maroon;
            btnDanhGia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDanhGia.ForeColor = Color.White;
            btnDanhGia.Location = new Point(189, 329);
            btnDanhGia.Name = "btnDanhGia";
            btnDanhGia.Size = new Size(94, 37);
            btnDanhGia.TabIndex = 7;
            btnDanhGia.Text = "Đánh giá";
            btnDanhGia.UseVisualStyleBackColor = false;
            btnDanhGia.Click += btnDanhGia_Click;
            // 
            // lblTenLaptop
            // 
            lblTenLaptop.AutoSize = true;
            lblTenLaptop.Location = new Point(125, 59);
            lblTenLaptop.Name = "lblTenLaptop";
            lblTenLaptop.Size = new Size(0, 20);
            lblTenLaptop.TabIndex = 6;
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Location = new Point(125, 23);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(0, 20);
            lblTenTK.TabIndex = 6;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.DarkGray;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(6, 330);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(82, 34);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // cmbSoSao
            // 
            cmbSoSao.FormattingEnabled = true;
            cmbSoSao.Items.AddRange(new object[] { "1 ★", "2 ★", "3 ★", "4 ★", "5 ★" });
            cmbSoSao.Location = new Point(84, 97);
            cmbSoSao.Name = "cmbSoSao";
            cmbSoSao.Size = new Size(52, 28);
            cmbSoSao.TabIndex = 3;
            cmbSoSao.Text = "5 ★";
            // 
            // txtDanhGia
            // 
            txtDanhGia.Location = new Point(6, 131);
            txtDanhGia.Multiline = true;
            txtDanhGia.Name = "txtDanhGia";
            txtDanhGia.Size = new Size(277, 191);
            txtDanhGia.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(26, 26, 26);
            label4.Location = new Point(6, 100);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 1;
            label4.Text = "Mức sao:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(26, 26, 26);
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên Laptop:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(26, 26, 26);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản:";
            // 
            // txtDanhSachDanhGia
            // 
            txtDanhSachDanhGia.Location = new Point(390, 82);
            txtDanhSachDanhGia.Multiline = true;
            txtDanhSachDanhGia.Name = "txtDanhSachDanhGia";
            txtDanhSachDanhGia.ReadOnly = true;
            txtDanhSachDanhGia.Size = new Size(571, 400);
            txtDanhSachDanhGia.TabIndex = 3;
            // 
            // ReviewPost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(967, 551);
            Controls.Add(txtDanhSachDanhGia);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ReviewPost";
            Text = "Review";
            Load += Review_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private CheckBox ckbMotSao;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnThoat;
        private ComboBox cmbSoSao;
        private TextBox txtDanhGia;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblTenLaptop;
        private Label lblTenTK;
        private TextBox txtDanhSachDanhGia;
        private Button btnDanhGia;
        private CheckBox ckbNamSao;
        private CheckBox ckbBonSao;
        private CheckBox ckbBaSao;
        private CheckBox ckbHaiSao;
    }
}