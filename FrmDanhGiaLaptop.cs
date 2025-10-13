using System;
using System.IO;
using System.Windows.Forms;

namespace DanhGiaLaptopApp
{
    public partial class FrmDanhGiaLaptop : Form
    {
        private readonly string dataFilePath;

        public FrmDanhGiaLaptop()
        {
            InitializeComponent();
            dataFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "danhgia.txt");
        }

        private void FrmDanhGiaLaptop_Load(object sender, EventArgs e)
        {
            cboHang.Items.AddRange(new string[] { "Dell", "Asus", "HP", "Lenovo", "Acer", "MSI", "Apple" });
            numSao.Minimum = 1;
            numSao.Maximum = 5;

            // Load existing reviews if file exists
            if (File.Exists(dataFilePath))
            {
                var lines = File.ReadAllLines(dataFilePath);
                foreach (var line in lines)
                    if (!string.IsNullOrWhiteSpace(line))
                        lstDanhGia.Items.Add(line);
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLaptop.Text))
            {
                MessageBox.Show("Vui lòng nhập tên laptop!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboHang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hãng sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ten = txtTenLaptop.Text.Trim();
            string hang = cboHang.SelectedItem.ToString();
            int sao = (int)numSao.Value;
            string nhanxet = txtNhanXet.Text.Trim();

            string ketqua = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {ten} ({hang}) - {sao} sao - Nhận xét: {nhanxet}";
            lstDanhGia.Items.Add(ketqua);

            // Append to file
            try
            {
                File.AppendAllText(dataFilePath, ketqua + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu vào file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Gửi đánh giá thành công!", "Cảm ơn bạn", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear inputs
            txtTenLaptop.Clear();
            cboHang.SelectedIndex = -1;
            numSao.Value = 1;
            txtNhanXet.Clear();
        }
    }
}
