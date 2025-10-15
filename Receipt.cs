using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLaptop
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }



        private void UpdateThanhTien()
        {
            if (decimal.TryParse(txtGiaTien.Text, out decimal gia))
            {
                decimal sl = nudSoLuong.Value;
                txtThanhTien.Text = (gia * sl).ToString("N0") + " VND";
            }
            else
            {
                txtThanhTien.Text = "0 VND";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hóa đơn đã được lưu!", "Thông báo");
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng in (demo).", "In hóa đơn");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            UpdateThanhTien();
        }
    }
}
