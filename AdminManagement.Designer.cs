namespace QuanLyLaptop
{
    partial class AdminManagement
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
            groupBox2.Controls.Add(btnMainMenu);
            groupBox2.Location = new Point(403, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(181, 214);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnMainMenu
            // 
            btnMainMenu.Dock = DockStyle.Top;
            btnMainMenu.Location = new Point(3, 23);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(175, 60);
            btnMainMenu.TabIndex = 0;
            btnMainMenu.Text = "Màn Hình Chính";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnProduct);
            groupBox1.Controls.Add(btnReceipt);
            groupBox1.Controls.Add(btnAccount);
            groupBox1.Location = new Point(216, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 214);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản Lý";
            // 
            // btnProduct
            // 
            btnProduct.Dock = DockStyle.Top;
            btnProduct.Location = new Point(3, 143);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(175, 60);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Sản Phẩm";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnReceipt
            // 
            btnReceipt.Dock = DockStyle.Top;
            btnReceipt.Location = new Point(3, 83);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(175, 60);
            btnReceipt.TabIndex = 0;
            btnReceipt.Text = "Hóa Đơn";
            btnReceipt.UseVisualStyleBackColor = true;
            // 
            // btnAccount
            // 
            btnAccount.Dock = DockStyle.Top;
            btnAccount.Location = new Point(3, 23);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(175, 60);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "Tài Khoản";
            btnAccount.UseVisualStyleBackColor = true;
            // 
            // AdminManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AdminManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManagement";
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