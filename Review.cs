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
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        private void ckbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTatCa.Checked)
            {
                ckbMotSao.Checked = false;
                ckbHaiSao.Checked = false;
                ckbBaSao.Checked = false;
                ckbBonSao.Checked = false;
                ckbNamSao.Checked = false;
            }
        }

        private void ckbMotSao_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMotSao.Checked)
            {
                ckbTatCa.Checked = false;
                ckbHaiSao.Checked = false;
                ckbBaSao.Checked = false;
                ckbBonSao.Checked = false;
                ckbNamSao.Checked = false;
            }
        }

        private void ckbHaiSao_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHaiSao.Checked)
            {
                ckbMotSao.Checked = false;
                ckbTatCa.Checked = false;
                ckbBaSao.Checked = false;
                ckbBonSao.Checked = false;
                ckbNamSao.Checked = false;
            }
        }

        private void ckbBaSao_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBaSao.Checked)
            {
                ckbMotSao.Checked = false;
                ckbHaiSao.Checked = false;
                ckbTatCa.Checked = false;
                ckbBonSao.Checked = false;
                ckbNamSao.Checked = false;
            }
        }

        private void ckbBonSao_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBonSao.Checked)
            {
                ckbMotSao.Checked = false;
                ckbHaiSao.Checked = false;
                ckbBaSao.Checked = false;
                ckbTatCa.Checked = false;
                ckbNamSao.Checked = false;
            }
        }

        private void ckbNamSao_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNamSao.Checked)
            {
                ckbMotSao.Checked = false;
                ckbHaiSao.Checked = false;
                ckbBaSao.Checked = false;
                ckbBonSao.Checked = false;
                ckbTatCa.Checked = false;
            }
        }
    }
}
