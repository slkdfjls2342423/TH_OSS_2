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
        private string maSV;
        // Constructor nhận vào một đối tượng SinhVien hoặc DataRow để đổ dữ liệu
        public frSuaSV(string maSV)
        {
            this.maSV = maSV;
            hocSinhCtr = new HocSinhCtr(Program.connectionString);
            lopCtr = new LopCtr(Program.connectionString);
            SinhVien sv = hocSinhCtr.Get(maSV);
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
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DateTime.Now.Year - dtpNgaySinh.Value.Year < 15)
            {
                MessageBox.Show("không đủ điều kiện nhập học (tuổi > 15 tính theo năm)");
                return;
            }
            string maLop = cboLop.SelectedValue.ToString();
            if(maLop == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(hocSinhCtr.SuaHocSinh(maSV, new SinhVien(
                txtMaSV.Text,
                txtHoTen.Text,
                dtpNgaySinh.Value,
                rbNam.Checked ? "nam" : "nu",
                txtDiaChi.Text,
                maLop
                )) > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
