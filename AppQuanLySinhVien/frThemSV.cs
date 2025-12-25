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
    public partial class frThemSV : Form
    {
        private HocSinhCtr hocSinhCtr;
        private LopCtr lopCtr;
        public frThemSV()
        {
            InitializeComponent();
            hocSinhCtr = new HocSinhCtr(Program.connectionString);
            lopCtr = new LopCtr(Program.connectionString);
            cboLop.DataSource = lopCtr.LayDanhSachLop();
            cboLop.DisplayMember = "TenLop"; // Hiển thị tên lớp
            cboLop.ValueMember = "MaLop";   // Giá trị là mã lớp
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra sơ bộ dữ liệu (Validation)
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(DateTime.Now.Year - dtpNgaySinh.Value.Year < 15)
            {
                MessageBox.Show("không đủ điều kiện nhập học (tuổi > 15 tính theo năm)");
                return;
            }
            
             string maLopChon = cboLop.SelectedValue.ToString();

            if (maLopChon == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Khởi tạo đối tượng SinhVien sử dụng Constructor đã định nghĩa
            SinhVien sv = new SinhVien(
                txtMaSV.Text,           // maSinhVien
                txtHoTen.Text,          // hoTen
                dtpNgaySinh.Value,      // ngaySinh
                rbNam.Checked?"nam":"nu",          // gioiTinh (True nếu chọn Nam)
                txtNoiSinh.Text,        // noiSinh
                txtDiaChi.Text,         // diaChi
                maLopChon    // maLop (Lấy từ object Lop)
            );

            if(hocSinhCtr.ThemHocSinh(sv) > 0)
            {
                this.Close(); // Đóng form sau khi lưu
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
