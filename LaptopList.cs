using DanhGiaLaptopApp;
using MuaLaptopApp;
using QuanLyLaptop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLaptop
{
    public partial class LaptopList : Form
    {
        public LaptopList()
        {
            InitializeComponent();
        }

        List<Laptop> laptopList = new List<Laptop>();

        private void DanhSachLaptop_Load(object sender, EventArgs e)
        {
            Laptop lt = new Laptop();
            laptopList = lt.GetList();
            dgvDanhSachLaptop.DataSource = laptopList;


            dgvDanhSachLaptop.Columns["GiaTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDanhSachLaptop.Columns["GiaTien"].DefaultCellStyle.Format = "#,##0 VND";

            
        }

        private void dgvDanhSachLaptop_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDanhSachLaptop.Rows)
            {
                if (!row.IsNewRow)
                    row.Cells["STT1"].Value = row.Index + 1;
            }
        }

        private void dgvDanhSachLaptop_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSachLaptop.CurrentRow != null)
            {
                lblTenLaptop.Text = dgvDanhSachLaptop.CurrentRow.Cells["TenLaptop"].Value.ToString();
                lblCPUInfo.Text = dgvDanhSachLaptop.CurrentRow.Cells["CPU"].Value.ToString();
                lblGPUInfo.Text = dgvDanhSachLaptop.CurrentRow.Cells["GPU"].Value.ToString();
                lblRAMInfo.Text = dgvDanhSachLaptop.CurrentRow.Cells["RAM"].Value.ToString();
                lblHardwareInfo.Text = dgvDanhSachLaptop.CurrentRow.Cells["OCung"].Value.ToString();
            }
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            var form = new FrmDanhGiaLaptop();
            form.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            var form = new FrmMuaLaptop();
            form.Show();
        }
    }
}
