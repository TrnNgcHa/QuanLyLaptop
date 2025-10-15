namespace QuanLyLaptop
{
    partial class AdminVerification
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
            groupBox1.Controls.Add(btnConfirm);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 255);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(78, 198);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(167, 42);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(95, 149);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 152);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 106);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 23);
            label1.Name = "label1";
            label1.Size = new Size(234, 56);
            label1.TabIndex = 0;
            label1.Text = "XÁC NHẬN\r\nQUYỀN QUẢN TRỊ VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Verification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 279);
            Controls.Add(groupBox1);
            Name = "Verification";
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
    }
}