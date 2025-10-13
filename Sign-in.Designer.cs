namespace QuanLyLaptop
{
    partial class Sign_in
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
            linkTaoTaiKhoan = new LinkLabel();
            btnDangNhap = new Button();
            txtPassword = new TextBox();
            txtAccountName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblTitle = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // linkTaoTaiKhoan
            // 
            linkTaoTaiKhoan.AutoSize = true;
            linkTaoTaiKhoan.Font = new Font("Segoe UI", 9F);
            linkTaoTaiKhoan.Location = new Point(194, 269);
            linkTaoTaiKhoan.Name = "linkTaoTaiKhoan";
            linkTaoTaiKhoan.Size = new Size(135, 20);
            linkTaoTaiKhoan.TabIndex = 10;
            linkTaoTaiKhoan.TabStop = true;
            linkTaoTaiKhoan.Text = "Chưa có tài khoản?";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.DarkOrange;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(65, 200);
            btnDangNhap.Margin = new Padding(3, 4, 3, 4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(200, 47);
            btnDangNhap.TabIndex = 9;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(107, 131);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(222, 30);
            txtPassword.TabIndex = 8;
            // 
            // txtAccountName
            // 
            txtAccountName.Font = new Font("Segoe UI", 10F);
            txtAccountName.Location = new Point(107, 78);
            txtAccountName.Margin = new Padding(3, 4, 3, 4);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(222, 30);
            txtAccountName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 83);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 11;
            label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 136);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 11;
            label2.Text = "Mật Khẩu";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(txtAccountName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(linkTaoTaiKhoan);
            groupBox1.Location = new Point(74, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 309);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.BackColor = SystemColors.Control;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkOrange;
            lblTitle.Location = new Point(146, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(201, 53);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Đăng Nhập";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Sign_in
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 393);
            Controls.Add(lblTitle);
            Controls.Add(groupBox1);
            Name = "Sign_in";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign_in";
            FormClosing += Sign_in_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel linkTaoTaiKhoan;
        private Button btnDangNhap;
        private TextBox txtPassword;
        private TextBox txtAccountName;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblTitle;
    }
}