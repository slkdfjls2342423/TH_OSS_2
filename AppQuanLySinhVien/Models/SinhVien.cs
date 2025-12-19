using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLySinhVien.Models
{
    public class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string MaLop { get; set; }
        public Lop LopHoc { get; set; }

        public SinhVien(string maSinhVien, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string maLop)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            MaLop = maLop;
        }

        public SinhVien()
        {
        }
    }
}
