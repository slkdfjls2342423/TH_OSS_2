using System;
using System.Windows.Forms;
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
        // 2. Lấy thông tin 1 lớp dựa vào Mã Lớp (Dùng khi muốn sửa)
        public Lop GetLop(string maLop)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE MaLop = @MaLop", con);
            cmd.Parameters.AddWithValue("@MaLop", maLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                Lop lop = new Lop()
                {
                    MaLop = dr["MaLop"].ToString(),
                    TenLop = dr["TenLop"].ToString()
                };
                return lop;
            }
            return null;
        }

        // 3. Thêm lớp mới
        public int ThemLop(Lop lop)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Kiểm tra trùng mã trước khi thêm (Optional nhưng nên có)
                string checkQuery = "SELECT COUNT(*) FROM LOP WHERE MaLop = @MaLop";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
                int exist = (int)checkCmd.ExecuteScalar();

                if (exist > 0)
                {
                    MessageBox.Show("Mã lớp này đã tồn tại!");
                    return 0;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO LOP (MaLop, TenLop) VALUES (@MaLop, @TenLop)", con);
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
                cmd.Parameters.AddWithValue("@TenLop", lop.TenLop);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm lớp thất bại: " + ex.Message);
                return 0;
            }
        }

        // 4. Sửa thông tin lớp
        public int SuaLop(string maLopGoc, Lop lopMoi)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE LOP SET TenLop = @TenLop WHERE MaLop = @MaLop", con);
                // MaLop ở WHERE là mã gốc để tìm dòng cần sửa
                cmd.Parameters.AddWithValue("@MaLop", maLopGoc);
                // TenLop là dữ liệu mới
                cmd.Parameters.AddWithValue("@TenLop", lopMoi.TenLop);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show("Cập nhật lớp thành công!");
                else
                    MessageBox.Show("Cập nhật lớp thất bại!");

                return rowsAffected;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa lớp thất bại: " + ex.Message);
                return 0;
            }
        }

        // 5. Xóa lớp
        public int XoaLop(string maLop)
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM LOP WHERE MALOP = @MaLop", con);
                cmd.Parameters.AddWithValue("@MaLop", maLop);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected != 0)
                {

                    MessageBox.Show("Xóa lớp thành công!");
                }
                else
                    MessageBox.Show("Xóa lớp thất bại (Không tìm thấy mã lớp)!");

                return rowsAffected;
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) // Lỗi vi phạm khóa ngoại
                {
                    MessageBox.Show("Không thể xóa lớp này vì đang có sinh viên theo học!");
                }
                else
                {
                    MessageBox.Show("Lỗi SQL: ");
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa lớp thất bại: " );
                return 0;
            }
        }
    }
}