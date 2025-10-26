namespace QuanLyLaptop
{
    partial class Administration
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
            btnMainMenu = new Button();
            groupBox1 = new GroupBox();
            btnProduct = new Button();
            btnReceipt = new Button();
            btnAccount = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(28, 28, 28);
            groupBox2.Controls.Add(btnMainMenu);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(179, 179, 179);
            groupBox2.Location = new Point(403, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(181, 214);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.DarkGray;
            btnMainMenu.Dock = DockStyle.Top;
            btnMainMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMainMenu.ForeColor = Color.White;
            btnMainMenu.Location = new Point(3, 23);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(175, 60);
            btnMainMenu.TabIndex = 0;
            btnMainMenu.Text = "Màn Hình Chính";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(28, 28, 28);
            groupBox1.Controls.Add(btnProduct);
            groupBox1.Controls.Add(btnReceipt);
            groupBox1.Controls.Add(btnAccount);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(179, 179, 179);
            groupBox1.Location = new Point(216, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 214);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản Lý";
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Red;
            btnProduct.Dock = DockStyle.Top;
            btnProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProduct.ForeColor = Color.White;
            btnProduct.Location = new Point(3, 143);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(175, 60);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Sản Phẩm";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnReceipt
            // 
            btnReceipt.BackColor = Color.Red;
            btnReceipt.Dock = DockStyle.Top;
            btnReceipt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReceipt.ForeColor = Color.White;
            btnReceipt.Location = new Point(3, 83);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(175, 60);
            btnReceipt.TabIndex = 0;
            btnReceipt.Text = "Hóa Đơn";
            btnReceipt.UseVisualStyleBackColor = false;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.Red;
            btnAccount.Dock = DockStyle.Top;
            btnAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAccount.ForeColor = Color.White;
            btnAccount.Location = new Point(3, 23);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(175, 60);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "Tài Khoản";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // Administration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Administration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Code Cool";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnMainMenu;
        private GroupBox groupBox1;
        private Button btnProduct;
        private Button btnReceipt;
        private Button btnAccount;
    }
}