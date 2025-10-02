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
            btn_GD_QTV = new Button();
            btn_GD_Khach = new Button();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(btn_GD_QTV);
            groupBox1.Controls.Add(btn_GD_Khach);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.Location = new Point(27, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(189, 198);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giao Diện";
            // 
            // btn_GD_QTV
            // 
            btn_GD_QTV.Dock = DockStyle.Top;
            btn_GD_QTV.Font = new Font("Segoe UI", 10F);
            btn_GD_QTV.Location = new Point(3, 91);
            btn_GD_QTV.Name = "btn_GD_QTV";
            btn_GD_QTV.Size = new Size(183, 52);
            btn_GD_QTV.TabIndex = 0;
            btn_GD_QTV.Text = "Quản Trị Viên";
            btn_GD_QTV.UseVisualStyleBackColor = true;
            btn_GD_QTV.Click += btn_GD_QTV_Click;
            // 
            // btn_GD_Khach
            // 
            btn_GD_Khach.Dock = DockStyle.Top;
            btn_GD_Khach.Font = new Font("Segoe UI", 10F);
            btn_GD_Khach.Location = new Point(3, 39);
            btn_GD_Khach.Name = "btn_GD_Khach";
            btn_GD_Khach.Size = new Size(183, 52);
            btn_GD_Khach.TabIndex = 0;
            btn_GD_Khach.Text = "Khách";
            btn_GD_Khach.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Font = new Font("Segoe UI", 16F);
            groupBox2.Location = new Point(270, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(187, 198);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnThoat
            // 
            btnThoat.Dock = DockStyle.Top;
            btnThoat.Font = new Font("Segoe UI", 10F);
            btnThoat.Location = new Point(3, 39);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(181, 52);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(481, 238);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Laptop";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_GD_QTV;
        private Button btn_GD_Khach;
        private GroupBox groupBox2;
        private Button btnThoat;
    }
}
