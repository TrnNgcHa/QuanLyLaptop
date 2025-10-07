namespace QuanLyLaptop
{
    partial class Main
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
            btnClose = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdmin);
            groupBox1.Controls.Add(btnCustomer);
            groupBox1.Location = new Point(216, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giao Diện";
            // 
            // btnAdmin
            // 
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.Location = new Point(3, 83);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(175, 60);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Quản Trị Viên";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.Location = new Point(3, 23);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(175, 60);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Khách";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Location = new Point(403, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(181, 161);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Top;
            btnClose.Location = new Point(3, 23);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(175, 60);
            btnClose.TabIndex = 0;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
    }
}
