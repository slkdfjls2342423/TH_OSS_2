using System;
using System.Windows.Forms;
using AppQuanLySinhVien.Controllers;
using AppQuanLySinhVien.Models;

namespace AppQuanLySinhVien
{
    public partial class frThemMH : Form
    {
        private MonHocCtr mhCtr;

        public frThemMH()
        {
            InitializeComponent();
            mhCtr = new MonHocCtr(Program.connectionString);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên môn học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // --- ĐOẠN CẦN SỬA ---
                MonHoc mh = new MonHoc()
                {
                    // Bên trái là tên trong Model (Chính xác 100%) = Bên phải là dữ liệu từ Form
                    MaMonHoc = txtMaMH.Text.Trim(),   // Sửa MaMH -> MaMonHoc
                    TenMonHoc = txtTenMH.Text.Trim(), // Sửa TenMH -> TenMonHoc
                    Sotietlt = (int)numLT.Value,      // Sửa SoTietLT -> Sotietlt
                    Sotietth = (int)numTH.Value       // Sửa SoTietTH -> Sotietth
                };
                // --------------------

                // Lưu ý: Code này chạy đúng nếu hàm ThemMonHoc của bạn trả về int (kiểu cũ).
                // Nếu bạn đã đổi hàm ThemMonHoc trả về string (kiểu mới mình gợi ý), hãy sửa câu if bên dưới.
                if (mhCtr.ThemMonHoc(mh) > 0)
                {
                    MessageBox.Show("Thêm môn học thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại (Có thể trùng mã hoặc lỗi SQL).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}