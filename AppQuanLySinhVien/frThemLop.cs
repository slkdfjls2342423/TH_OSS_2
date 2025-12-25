using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLySinhVien.Models;
using AppQuanLySinhVien.Controllers;

namespace AppQuanLySinhVien
{
    public partial class frThemLop : Form
    {
        private LopCtr lopCtr;

        public frThemLop()
        {
            InitializeComponent();
            // Khởi tạo controller xử lý nghiệp vụ Lớp
            lopCtr = new LopCtr(Program.connectionString);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra sơ bộ dữ liệu (Validation)
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Lớp và Tên Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Khởi tạo đối tượng Lop
                // Giả định Class Lop trong Models có constructor: public Lop(string maLop, string tenLop)
                Lop lop = new Lop(
                    txtMaLop.Text.Trim(),  // Mã lớp
                    txtTenLop.Text.Trim()  // Tên lớp
                );

                // 3. Gọi Controller để thêm xuống CSDL
                // Giả định LopCtr có hàm ThemLop(Lop l) trả về số dòng bị ảnh hưởng (>0 là thành công)
                if (lopCtr.ThemLop(lop) > 0)
                {
                    MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi lưu thành công
                }
                else
                {
                    MessageBox.Show("Thêm lớp thất bại! (Có thể Mã lớp đã tồn tại)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}