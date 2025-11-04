namespace QuanLyLaptop
{
    partial class AdminAuthentication
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
            btnThoat = new Button();
            btnConfirm = new Button();
            txtPassword = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnConfirm);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(67, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 255);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Gray;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(19, 198);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 42);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Maroon;
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(130, 198);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(167, 42);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(95, 149);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(97, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(19, 152);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(19, 106);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(33, 23);
            label1.Name = "label1";
            label1.Size = new Size(234, 56);
            label1.TabIndex = 0;
            label1.Text = "XÁC NHẬN\r\nQUYỀN QUẢN TRỊ VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminAuthentication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(457, 304);
            Controls.Add(groupBox1);
            Name = "AdminAuthentication";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += Verification_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPassword;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnConfirm;
        private Button btnThoat;
    }
}