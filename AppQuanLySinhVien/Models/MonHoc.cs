using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLySinhVien.Models
{
    internal class MonHoc
    {
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public int Sotietlt { get; set; }
        public int Sotietth { get; set; }

      
        public List<SinhVien> DanhSachSinhVien { get; set; }

        public MonHoc() { }
        public MonHoc(string maMonHoc, string tenMonHoc, int sotietlt, int sotietth)
        {
            MaMonHoc = maMonHoc;
            TenMonHoc = tenMonHoc;

            Sotietlt = sotietlt;
            Sotietth = sotietth;

            DanhSachSinhVien = new List<SinhVien>();
        }
    }
}