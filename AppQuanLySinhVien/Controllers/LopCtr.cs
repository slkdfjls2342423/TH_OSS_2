using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQuanLySinhVien.Models;

namespace AppQuanLySinhVien.Controllers
{
    internal class LopCtr
    {
        private SqlConnection con;
        public LopCtr(string connectionString)
        {
            con = new SqlConnection(connectionString);
        }

        public DataTable LayDanhSachLop()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
