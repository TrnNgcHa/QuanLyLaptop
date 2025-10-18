namespace QuanLyLaptop
{
    partial class Review
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
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            ckbNamSao = new CheckBox();
            ckbBonSao = new CheckBox();
            ckbBaSao = new CheckBox();
            ckbHaiSao = new CheckBox();
            ckbTatCa = new CheckBox();
            ckbMotSao = new CheckBox();
            label3 = new Label();
            listView1 = new ListView();
            label4 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(listView1);
            splitContainer1.Size = new Size(803, 450);
            splitContainer1.SplitterDistance = 291;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 450);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên Laptop:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ckbNamSao);
            groupBox2.Controls.Add(ckbBonSao);
            groupBox2.Controls.Add(ckbBaSao);
            groupBox2.Controls.Add(ckbHaiSao);
            groupBox2.Controls.Add(ckbTatCa);
            groupBox2.Controls.Add(ckbMotSao);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(508, 43);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // ckbNamSao
            // 
            ckbNamSao.AutoSize = true;
            ckbNamSao.Cursor = Cursors.Hand;
            ckbNamSao.Location = new Point(440, 15);
            ckbNamSao.Name = "ckbNamSao";
            ckbNamSao.Size = new Size(56, 24);
            ckbNamSao.TabIndex = 1;
            ckbNamSao.Text = "5 ★";
            ckbNamSao.UseVisualStyleBackColor = true;
            ckbNamSao.CheckedChanged += ckbNamSao_CheckedChanged;
            // 
            // ckbBonSao
            // 
            ckbBonSao.AutoSize = true;
            ckbBonSao.Cursor = Cursors.Hand;
            ckbBonSao.Location = new Point(379, 15);
            ckbBonSao.Name = "ckbBonSao";
            ckbBonSao.Size = new Size(56, 24);
            ckbBonSao.TabIndex = 1;
            ckbBonSao.Text = "4 ★";
            ckbBonSao.UseVisualStyleBackColor = true;
            ckbBonSao.CheckedChanged += ckbBonSao_CheckedChanged;
            // 
            // ckbBaSao
            // 
            ckbBaSao.AutoSize = true;
            ckbBaSao.Cursor = Cursors.Hand;
            ckbBaSao.Location = new Point(318, 15);
            ckbBaSao.Name = "ckbBaSao";
            ckbBaSao.Size = new Size(56, 24);
            ckbBaSao.TabIndex = 1;
            ckbBaSao.Text = "3 ★";
            ckbBaSao.UseVisualStyleBackColor = true;
            ckbBaSao.CheckedChanged += ckbBaSao_CheckedChanged;
            // 
            // ckbHaiSao
            // 
            ckbHaiSao.AutoSize = true;
            ckbHaiSao.Cursor = Cursors.Hand;
            ckbHaiSao.Location = new Point(257, 15);
            ckbHaiSao.Name = "ckbHaiSao";
            ckbHaiSao.Size = new Size(56, 24);
            ckbHaiSao.TabIndex = 1;
            ckbHaiSao.Text = "2 ★";
            ckbHaiSao.UseVisualStyleBackColor = true;
            ckbHaiSao.CheckedChanged += ckbHaiSao_CheckedChanged;
            // 
            // ckbTatCa
            // 
            ckbTatCa.AutoSize = true;
            ckbTatCa.Checked = true;
            ckbTatCa.CheckState = CheckState.Checked;
            ckbTatCa.Cursor = Cursors.Hand;
            ckbTatCa.Location = new Point(119, 15);
            ckbTatCa.Name = "ckbTatCa";
            ckbTatCa.Size = new Size(71, 24);
            ckbTatCa.TabIndex = 1;
            ckbTatCa.Text = "Tất cả";
            ckbTatCa.UseVisualStyleBackColor = true;
            ckbTatCa.CheckedChanged += ckbTatCa_CheckedChanged;
            // 
            // ckbMotSao
            // 
            ckbMotSao.AutoSize = true;
            ckbMotSao.Cursor = Cursors.Hand;
            ckbMotSao.Location = new Point(196, 15);
            ckbMotSao.Name = "ckbMotSao";
            ckbMotSao.Size = new Size(56, 24);
            ckbMotSao.TabIndex = 1;
            ckbMotSao.Text = "1 ★";
            ckbMotSao.UseVisualStyleBackColor = true;
            ckbMotSao.CheckedChanged += ckbMotSao_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 17);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 0;
            label3.Text = "Loại đánh giá:";
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Bottom;
            listView1.Location = new Point(0, 37);
            listView1.Name = "listView1";
            listView1.Size = new Size(508, 413);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 100);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 1;
            label4.Text = "Đánh giá:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 131);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 237);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1 ★", "2 ★", "3 ★", "4 ★", "5 ★" });
            comboBox1.Location = new Point(84, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(52, 28);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "5 ★";
            // 
            // Review
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 450);
            Controls.Add(splitContainer1);
            Name = "Review";
            Text = "Review";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private ListView listView1;
        private CheckBox ckbNamSao;
        private CheckBox ckbBonSao;
        private CheckBox ckbBaSao;
        private CheckBox ckbHaiSao;
        private CheckBox ckbMotSao;
        private CheckBox ckbTatCa;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
    }
}