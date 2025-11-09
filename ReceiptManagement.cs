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

            dgvQuanLyHoaDon.Columns["TongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvQuanLyHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "#,##0 VND";

            cmbLoaiTimKiem.SelectedIndex = 0;

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
                    case "Mã tài khoản":
                        filtered = MainMenu.Receipts.Where(p => p.AccountID.ToString().Contains(filterText)).ToList();
                        break;
                    case "Tên tài khoản":
                        filtered = MainMenu.Receipts.Where(p => p.AccountName.ToLower().Contains(filterText)).ToList();
                        break;
                    case "Mã laptop":
                        filtered = MainMenu.Receipts.Where(p => p.LaptopID.ToString().Contains(filterText)).ToList();
                        break;
                    case "Tên laptop":
                        filtered = MainMenu.Receipts.Where(p => p.LaptopName.ToLower().Contains(filterText)).ToList();
                        break;
                    case "Tất cả":
                        filtered = MainMenu.Receipts.Where(p =>
                            p.ReceiptID.ToString().Contains(filterText) ||
                            p.AccountID.ToString().Contains(filterText) ||
                            p.AccountName.ToLower().Contains(filterText) ||
                            p.LaptopID.ToString().Contains(filterText) ||
                            p.LaptopName.ToLower().Contains(filterText)
                        ).ToList();
                        break;
                }
                dgvQuanLyHoaDon.DataSource = filtered;
            }
        }

        private void dgvQuanLyHoaDon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuanLyHoaDon.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvQuanLyHoaDon.CurrentRow.Cells["MaNguoiDung"].Value);
                Receipt rcp = MainMenu.Receipts.First(r => r.PersonID == id);
                lblHoTen.Text = rcp.LastName + " " + rcp.FirstName;
                lblGioiTinh.Text = rcp.Gender;
                lblThanhPho.Text = rcp.City;
                lblNgaySinh.Text = rcp.DOB.ToString("dd/MM/yyyy");
                lblSDT.Text = rcp.PhoneNumber;
                lblEmail.Text = rcp.Email;
                lblCCCD.Text = rcp.IdCard;
            }
        }

        private void dgvQuanLyHoaDon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvQuanLyHoaDon.Rows)
            {
                if (!row.IsNewRow)
                    row.Cells["STT"].Value = row.Index + 1;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
