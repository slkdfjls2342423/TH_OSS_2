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
        List<SinhVien> DanhSachSinhVien { get; set; }

        public MonHoc(string maMonHoc, string tenMonHoc)
        {
            MaMonHoc = maMonHoc;
            TenMonHoc = tenMonHoc;
            DanhSachSinhVien = new List<SinhVien>();

        }
    }
   
}
