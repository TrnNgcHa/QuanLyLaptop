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
    public partial class frmQuanLyLaptop_QTV : Form
    {
        List<Laptop> laptops = new List<Laptop>();
        public frmQuanLyLaptop_QTV()
        {
            InitializeComponent();
            dgvDanhSachLaptop.AutoGenerateColumns = false;
        }

        private void frmQuanLyLaptop_QTV_Load(object sender, EventArgs e)
        {
            Laptop lt = new Laptop();
            laptops = lt.GetList();
            dgvDanhSachLaptop.DataSource = laptops;

            

            dgvDanhSachLaptop.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDanhSachLaptop.RowsDefaultCellStyle.BackColor = Color.White;
            dgvDanhSachLaptop.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

        }

        private void dgvDanhSachLaptop_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvDanhSachLaptop.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["STT1"].Value = row.Index + 1;
                }
            }
        }

    }
}
