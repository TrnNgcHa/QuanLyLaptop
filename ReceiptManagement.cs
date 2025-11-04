using QuanLyLaptop.Models;
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
    public partial class ReceiptManagement : Form
    {
        public ReceiptManagement()
        {
            InitializeComponent();
            dgvQuanLyHoaDon.AutoGenerateColumns = false;
        }

        private void ReceiptManagement_Load(object sender, EventArgs e)
        {
            dgvQuanLyHoaDon.DataSource = MainMenu.Receipts;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text.ToLower();
            if (string.IsNullOrEmpty(filterText))
            {
                dgvQuanLyHoaDon.DataSource = MainMenu.Receipts;
            }
            else
            {
                List<Receipt> filtered = new List<Receipt>();
                switch (cmbLoaiTimKiem.Text)
                {
                    case "Mã hóa đơn":
                        filtered = MainMenu.Receipts.Where(p => p.ReceiptID.ToString().Contains(filterText)).ToList();
                        break;

                }
                dgvQuanLyHoaDon.DataSource = filtered;
            }
        }

        private void dgvQuanLyHoaDon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvQuanLyHoaDon.CurrentRow != null)
            {
                lblMaTaiKhoan.Text = dgvQuanLyHoaDon.CurrentRow.Cells["AccountID"].Value.ToString();
                lblTenTaiKhoan.Text = dgvQuanLyHoaDon.CurrentRow.Cells["AccountName"].Value.ToString();
                lblMaNguoiDung.Text = dgvQuanLyHoaDon.CurrentRow.Cells["PersonID"].Value.ToString();
                lblTenNguoiDung.Text = dgvQuanLyHoaDon.CurrentRow.Cells["PersonName"].Value.ToString();
            }
        }
    }
}
