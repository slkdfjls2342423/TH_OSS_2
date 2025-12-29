using System;
using System.Windows.Forms;
using AppQuanLySinhVien.Controllers;
using AppQuanLySinhVien.Models;

namespace AppQuanLySinhVien
{
    public partial class frSuaMH : Form
    {
        private MonHocCtr mhCtr;
        private string maMhHienTai;

        public frSuaMH(string maMh)
        {
            InitializeComponent();
            mhCtr = new MonHocCtr(Program.connectionString); // Đảm bảo Program.connectionString tồn tại
            this.maMhHienTai = maMh;
            LoadData();
        }

        private void LoadData()
        {
            MonHoc mh = mhCtr.GetMonHoc(maMhHienTai);
            if (mh != null)
            {
                // SỬA TÊN THUỘC TÍNH Ở ĐÂY
                txtMaMH.Text = mh.MaMonHoc;    // Sửa MaMH -> MaMonHoc
                txtTenMH.Text = mh.TenMonHoc;  // Sửa TenMH -> TenMonHoc
                numLT.Value = mh.Sotietlt;     // Sửa SoTietLT -> Sotietlt
                numTH.Value = mh.Sotietth;     // Sửa SoTietTH -> Sotietth
            }
            else
            {
                MessageBox.Show("Không tìm thấy môn học!");
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Tên môn học không được để trống!");
                return;
            }

            // SỬA TÊN THUỘC TÍNH Ở ĐÂY
            MonHoc mhMoi = new MonHoc()
            {
                MaMonHoc = maMhHienTai,       // Sửa MaMH -> MaMonHoc
                TenMonHoc = txtTenMH.Text.Trim(), // Sửa TenMH -> TenMonHoc
                Sotietlt = (int)numLT.Value,  // Sửa SoTietLT -> Sotietlt
                Sotietth = (int)numTH.Value   // Sửa SoTietTH -> Sotietth
            };

            // Gọi hàm SuaMonHoc (Bạn cần đảm bảo hàm này đã có trong Controller)
            if (mhCtr.SuaMonHoc(maMhHienTai, mhMoi)) // Giả sử hàm trả về bool
            {
                MessageBox.Show("Cập nhật thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}