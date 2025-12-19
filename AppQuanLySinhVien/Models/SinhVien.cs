using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLySinhVien.Models
{
    internal class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string MaLop { get; set; }
        public Lop LopHoc { get; set; }

        public SinhVien(string maSinhVien, string hoTen, DateTime ngaySinh, bool gioiTinh, string diaChi, string maLop, Lop lopHoc)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            MaLop = maLop;
            LopHoc = lopHoc;
        }
    }
}
