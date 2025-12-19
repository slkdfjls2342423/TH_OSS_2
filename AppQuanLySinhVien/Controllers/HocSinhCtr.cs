using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLySinhVien.Models;

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
        public int ThemHocSinh( SinhVien sinhVien)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO SINHVIEN (MaSv, Ten, NgaySinh, phai, DiaChi, MaLop) VALUES (@MaSinhVien, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @MaLop)", con);
                cmd.Parameters.AddWithValue("@MaSinhVien", sinhVien.MaSinhVien);
                cmd.Parameters.AddWithValue("@HoTen", sinhVien.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", sinhVien.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", sinhVien.GioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", sinhVien.DiaChi);
                cmd.Parameters.AddWithValue("@MaLop", sinhVien.MaLop);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 0)
                {
                    MessageBox.Show("Thêm học sinh thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm học sinh thất bại!");
                }
                return rowsAffected ;
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm học sinh thất bại!");
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
