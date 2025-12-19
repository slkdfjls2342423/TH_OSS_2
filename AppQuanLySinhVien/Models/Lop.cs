using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLySinhVien.Models
{
    internal class Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        List<SinhVien> DanhSachSinhVien { get; set; }

        public Lop()
        {
            DanhSachSinhVien = new List<SinhVien>();
        }
    }
}
