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
    public class HocSinhCtr
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
        public SinhVien Get(string MaSV)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            // Nên dùng Parameter để chống SQL Injection
            SqlCommand cmd = new SqlCommand("SELECT * FROM SINHVIEN WHERE MaSV = @MaSV", con);
            cmd.Parameters.AddWithValue("@MaSV", MaSV);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Kiểm tra nếu có dữ liệu thì mới chuyển đổi
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                // Tạo đối tượng Model từ dòng dữ liệu
                SinhVien sv = new SinhVien()
                {
                    MaSinhVien = dr["MaSV"].ToString(),
                    HoTen = dr["HoTen"].ToString(),
                    NgaySinh = Convert.ToDateTime(dr["NgaySinh"]),
                    GioiTinh = dr["phai"].ToString(),
                    NoiSinh = dr["NoiSinh"].ToString(),
                    DiaChi = dr["DiaChi"].ToString(),
                    MaLop = dr["MaLop"].ToString()
                };
                return sv;
            }
            MessageBox.Show("Không tìm thấy sinh viên với mã: " + MaSV);
            return null; // Trả về null nếu không tìm thấy sinh viên
        }
        public int ThemHocSinh( SinhVien sinhVien)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                if (Get(sinhVien.MaSinhVien)!=null)
                {
                    MessageBox.Show("Mã sinhvien này đã tồn tại trong hệ thống");
                    return -1;
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO SINHVIEN (MaSv, HoTen, NgaySinh, phai, noisinh, DiaChi, MaLop) VALUES (@MaSinhVien, @HoTen, @NgaySinh, @GioiTinh, @NoiSinh, @DiaChi, @MaLop)", con);
                cmd.Parameters.AddWithValue("@MaSinhVien", sinhVien.MaSinhVien);
                cmd.Parameters.AddWithValue("@HoTen", sinhVien.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", sinhVien.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", sinhVien.GioiTinh);
                cmd.Parameters.AddWithValue("@NoiSinh", sinhVien.NoiSinh);
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
            catch (Exception e)
            {
                MessageBox.Show("Thêm học sinh thất bại: "+e.Message);
                return -1;
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
            catch (Exception e)
            {
                MessageBox.Show("Xóa học sinh thất bại: "+e.Message);
                return -1;
            }
        }
        public int SuaHocSinh(string maSinhVien, SinhVien sinhVien)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE SINHVIEN SET HoTen = @HoTen, NgaySinh = @NgaySinh, phai = @GioiTinh, NoiSinh = @NoiSinh, DiaChi = @DiaChi, MaLop = @MaLop WHERE MaSV = @MaSinhVien", con);
                cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                cmd.Parameters.AddWithValue("@HoTen", sinhVien.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", sinhVien.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", sinhVien.GioiTinh);
                cmd.Parameters.AddWithValue("@NoiSinh", sinhVien.NoiSinh);
                cmd.Parameters.AddWithValue("@DiaChi", sinhVien.DiaChi);
                cmd.Parameters.AddWithValue("@MaLop", sinhVien.MaLop);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 0)
                {
                    MessageBox.Show("Cập nhật học sinh thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật học sinh thất bại!");

                }
                return rowsAffected;
            }
            catch (Exception e)
            {
                MessageBox.Show("Cập nhật học sinh thất bại!: "+e.Message);
                return -1;
            }
        }
    }
}
