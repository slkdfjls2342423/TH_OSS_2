using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQuanLySinhVien.Models;

namespace AppQuanLySinhVien.Controllers
{
    class MonHocCtr
    {
        private SqlConnection con;
        public MonHocCtr(string connectionString)
        {
            con = new SqlConnection(connectionString);
        }
        public DataTable LayDanhSachMonHoc()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM MONHOC", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // 2. Lấy thông tin 1 môn học theo Mã (Map đúng tên cột từ ảnh)
        public MonHoc GetMonHoc(string maMH)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            // Sửa tên cột khóa chính thành MAMH
            SqlCommand cmd = new SqlCommand("SELECT * FROM MONHOC WHERE MAMH = @MaMH", con);
            cmd.Parameters.AddWithValue("@MaMH", maMH);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                // Lấy giá trị xử lý trường hợp NULL trong DB (vì cột int cho phép null)
                int soTietLT = dr["SOTIET_LT"] != DBNull.Value ? Convert.ToInt32(dr["SOTIET_LT"]) : 0;
                int soTietTH = dr["SOTIET_TH"] != DBNull.Value ? Convert.ToInt32(dr["SOTIET_TH"]) : 0;

                // Khởi tạo đối tượng MonHoc với dữ liệu lấy từ cột MAMH, TENMH, SOTIET_LT, SOTIET_TH
                MonHoc mh = new MonHoc(
                    dr["MAMH"].ToString(),
                    dr["TENMH"].ToString(),
                    soTietLT,
                    soTietTH
                );
                return mh;
            }
            return null;
        }

        // 3. Thêm môn học mới
        public int ThemMonHoc(MonHoc mh)
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                // Kiểm tra trùng mã: Cột MAMH
                string checkQuery = "SELECT COUNT(*) FROM MONHOC WHERE MAMH = @MaMH";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@MaMH", mh.MaMonHoc);

                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Mã môn học này đã tồn tại!", "Cảnh báo");
                    return 0;
                }

                // Cập nhật câu lệnh INSERT với tên cột chính xác: SOTIET_LT, SOTIET_TH
                string sql = "INSERT INTO MONHOC (MAMH, TENMH, SOTIET_LT, SOTIET_TH) VALUES (@Ma, @Ten, @LT, @TH)";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Ma", mh.MaMonHoc);
                cmd.Parameters.AddWithValue("@Ten", mh.TenMonHoc);
                cmd.Parameters.AddWithValue("@LT", mh.Sotietlt);
                cmd.Parameters.AddWithValue("@TH", mh.Sotietth);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message);
                return 0;
            }
        }
        public bool SuaMonHoc(string maMHCu, MonHoc mhMoi)
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                // Câu lệnh Update
                string sql = "UPDATE MONHOC SET TENMH = @Ten, SOTIET_LT = @LT, SOTIET_TH = @TH WHERE MAMH = @MaCu";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaCu", maMHCu);
                cmd.Parameters.AddWithValue("@Ten", mhMoi.TenMonHoc);
                cmd.Parameters.AddWithValue("@LT", mhMoi.Sotietlt);
                cmd.Parameters.AddWithValue("@TH", mhMoi.Sotietth);

                int row = cmd.ExecuteNonQuery();
                return row > 0; // Trả về true nếu sửa thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa môn học: " + ex.Message);
                return false;
            }
        }
        public int XoaMonHoc(string maMH)
        {
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                // Cột MAMH
                SqlCommand cmd = new SqlCommand("DELETE FROM MONHOC WHERE MAMH = @MaMH", con);
                cmd.Parameters.AddWithValue("@MaMH", maMH);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) MessageBox.Show("Xóa thành công!");
                else MessageBox.Show("Không tìm thấy mã môn để xóa!");

                return rows;
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547)
                    MessageBox.Show("Không thể xóa vì môn học này đang có dữ liệu liên quan!");
                else
                    MessageBox.Show("Lỗi SQL: " + sqlEx.Message);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return 0;
            }
        }

    }
}
