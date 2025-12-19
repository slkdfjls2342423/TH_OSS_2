using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLySinhVien.Controllers
{
    internal class HocSinhCtr
    {
        private SqlConnection con;
        public HocSinhCtr(string connectionString)
        {
            con = new SqlConnection(connectionString);
        }
        public DataTable LayDanhSachHocSinh()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM SINHVIEN", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
