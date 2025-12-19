using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public int ThemHocSinh(string maSinhVien, string hoTen, DateTime ngaySinh, bool gioiTinh, string diaChi, string maLop)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO SINHVIEN (MaSinhVien, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop) VALUES (@MaSinhVien, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @MaLop)", con);
                cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected ;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int XoaHocSinh(string maSinhVien)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM SINHVIEN WHERE MASV = @MaSinhVien", con);
                cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                int rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected != 0)
                {
                    MessageBox.Show("Xóa học sinh thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa học sinh thất bại!");
                }
                return rowsAffected;
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa học sinh thất bại!");
                return 0;
            }
        }
    }
}
