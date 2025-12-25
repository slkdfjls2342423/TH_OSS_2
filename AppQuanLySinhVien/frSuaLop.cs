using System;
using System.Windows.Forms;
using AppQuanLySinhVien.Controllers;
using AppQuanLySinhVien.Models;

namespace AppQuanLySinhVien
{
    public partial class frSuaLop : Form
    {
        private LopCtr lopCtr;
        private string maLopHienTai; // Biến lưu mã lớp được truyền từ Form Danh sách

        // Constructor nhận tham số mã lớp cần sửa
        public frSuaLop(string maLop)
        {
            InitializeComponent();
            lopCtr = new LopCtr(Program.connectionString);
            this.maLopHienTai = maLop;

            // Tải dữ liệu lên form ngay khi khởi tạo
            LoadData();
        }

        private void LoadData()
        {
            // Gọi Controller lấy thông tin lớp dựa vào mã
            Lop lop = lopCtr.GetLop(maLopHienTai);

            if (lop != null)
            {
                txtMaLop.Text = lop.MaLop;
                txtTenLop.Text = lop.TenLop;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin lớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Tên lớp không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng Lop mới với thông tin đã chỉnh sửa
            Lop lopMoi = new Lop(txtMaLop.Text, txtTenLop.Text);

            // Gọi hàm SuaLop trong Controller
            if (lopCtr.SuaLop(maLopHienTai, lopMoi) > 0)
            {
                // Đóng form sau khi sửa thành công
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}