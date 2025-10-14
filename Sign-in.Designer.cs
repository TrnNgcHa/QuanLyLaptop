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
            btnDangNhap = new Button();
            txtPassword = new TextBox();
            txtAccountName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblTitle = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Controls.Add(txtAccountName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Location = new Point(30, 43);
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
            lblTitle.Location = new Point(94, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(201, 53);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Đăng Nhập";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(779, 92);
            label3.Name = "label3";
            label3.Size = new Size(201, 53);
            label3.TabIndex = 15;
            label3.Text = "Đăng Nhập";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(707, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 309);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(107, 78);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 30);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 136);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 11;
            label4.Text = "Mật Khẩu";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(107, 131);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(222, 30);
            textBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 83);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 11;
            label5.Text = "Tài Khoản";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(65, 200);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(200, 47);
            button1.TabIndex = 9;
            button1.Text = "ĐĂNG NHẬP";
            button1.UseVisualStyleBackColor = false;
            // 
            // Sign_in
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 490);
            Controls.Add(label3);
            Controls.Add(lblTitle);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Sign_in";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign_in";
            FormClosing += Sign_in_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDangNhap;
        private TextBox txtPassword;
        private TextBox txtAccountName;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblTitle;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Button button1;
    }
}