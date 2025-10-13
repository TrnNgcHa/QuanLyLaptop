using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MuaLaptopApp
{
    public partial class FrmMuaLaptop : Form
    {
        private Dictionary<string, Dictionary<string, decimal>> laptops;

        public FrmMuaLaptop()
        {
            InitializeComponent();
            NapDuLieu();
        }

        private void NapDuLieu()
        {
            laptops = new Dictionary<string, Dictionary<string, decimal>>
            {
                ["Dell"] = new Dictionary<string, decimal>
                {
                    ["Dell Inspiron 15"] = 16500000,
                    ["Dell XPS 13"] = 32500000,
                    ["Dell Latitude 7420"] = 28000000
                },
                ["Asus"] = new Dictionary<string, decimal>
                {
                    ["Asus Vivobook 14"] = 15500000,
                    ["Asus TUF Gaming F15"] = 27000000,
                    ["Asus Zenbook 13"] = 29500000
                },
                ["HP"] = new Dictionary<string, decimal>
                {
                    ["HP Pavilion 14"] = 14500000,
                    ["HP Envy 13"] = 27500000,
                    ["HP Omen 16"] = 33500000
                }
            };

            cboHang.Items.AddRange(new string[] { "Dell", "Asus", "HP" });
            numSoLuong.Minimum = 1;
            numSoLuong.Maximum = 10;
        }

        private void cboHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLaptop.Items.Clear();
            txtGia.Clear();
            txtThanhTien.Clear();

            if (cboHang.SelectedIndex == -1) return;

            string hang = cboHang.SelectedItem.ToString();
            foreach (var item in laptops[hang].Keys)
                cboLaptop.Items.Add(item);
        }

        private void cboLaptop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLaptop.SelectedIndex == -1) return;

            string hang = cboHang.SelectedItem.ToString();
            string ten = cboLaptop.SelectedItem.ToString();
            txtGia.Text = laptops[hang][ten].ToString("N0");
            CapNhatThanhTien();
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void CapNhatThanhTien()
        {
            if (decimal.TryParse(txtGia.Text, out decimal gia))
            {
                decimal thanhTien = gia * numSoLuong.Value;
                txtThanhTien.Text = thanhTien.ToString("N0");
            }
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            if (cboHang.SelectedIndex == -1 || cboLaptop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hãng và laptop!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hang = cboHang.SelectedItem.ToString();
            string ten = cboLaptop.SelectedItem.ToString();
            decimal gia = decimal.Parse(txtGia.Text.Replace(",", ""));
            int soLuong = (int)numSoLuong.Value;
            decimal thanhTien = gia * soLuong;

            string donHang = $"{DateTime.Now:HH:mm:ss} - {ten} ({hang}) x{soLuong} = {thanhTien:N0} VNĐ";

            MessageBox.Show("Đặt mua thành công!", "Cảm ơn bạn", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cboHang.SelectedIndex = -1;
            cboLaptop.Items.Clear();
            txtGia.Clear();
            numSoLuong.Value = 1;
            txtThanhTien.Clear();
        }
    }
}
