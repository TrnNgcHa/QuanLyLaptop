namespace QuanLyLaptop
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnAdmin = new Button();
            btnCustomer = new Button();
            groupBox2 = new GroupBox();
            btnCapNhat = new Button();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(btnAdmin);
            groupBox1.Controls.Add(btnCustomer);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox1.Location = new Point(63, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giao Diện";
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Maroon;
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(3, 83);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(175, 60);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Quản Trị Viên";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.Maroon;
            btnCustomer.Cursor = Cursors.Hand;
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Location = new Point(3, 23);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(175, 60);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Khách";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.BackColor = Color.FromArgb(224, 224, 224);
            groupBox2.Controls.Add(btnCapNhat);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(64, 64, 64);
            groupBox2.Location = new Point(252, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(181, 161);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Gray;
            btnCapNhat.Dock = DockStyle.Top;
            btnCapNhat.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(3, 83);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(175, 60);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Gray;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Top;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(3, 23);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(175, 60);
            btnClose.TabIndex = 0;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(497, 358);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            FormClosing += MainMenu_FormClosing;
            Load += MainMenu_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCustomer;
        private Button btnAdmin;
        private GroupBox groupBox2;
        private Button btnClose;
        private Button btnCapNhat;
    }
}
