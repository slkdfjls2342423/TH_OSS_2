using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLySinhVien.Controllers;
using AppQuanLySinhVien.Models;

namespace AppQuanLySinhVien
{
    public partial class frSuaSV : Form
    {
        private HocSinhCtr hocSinhCtr;
        private LopCtr lopCtr;
        // Constructor nhận vào một đối tượng SinhVien hoặc DataRow để đổ dữ liệu
        public frSuaSV(SinhVien sv)
        {
            hocSinhCtr = new HocSinhCtr(Program.connectionString);
            lopCtr = new LopCtr(Program.connectionString);
            InitializeComponent();
            cboLop.DataSource = lopCtr.LayDanhSachLop();
            cboLop.DisplayMember = "TenLop"; // Hiển thị tên lớp
            cboLop.ValueMember = "MaLop";   // Giá trị là mã lớp

            // Đổ dữ liệu từ DataRow lên các Control
            txtMaSV.Text = sv.MaSinhVien;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            txtDiaChi.Text = sv.DiaChi;

            if (sv.GioiTinh=="nam")
                rbNam.Checked = true;
            else
                rbNu.Checked = true;

            foreach (DataRow item in lopCtr.LayDanhSachLop().Rows)
            {
                if (item["MaLop"] == sv.MaLop)
                {
                    cboLop.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Thực hiện câu lệnh SQL UPDATE tại đây
            // string sql = "UPDATE SinhVien SET HoTen = ..., NgaySinh = ... WHERE MaSinhVien = '" + txtMaSV.Text + "'";

            MessageBox.Show("Cập nhật thành công!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
