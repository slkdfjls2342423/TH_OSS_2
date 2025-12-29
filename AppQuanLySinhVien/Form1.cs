using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLySinhVien.Controllers;

namespace AppQuanLySinhVien
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private HocSinhCtr hocSinhCtr;
        private LopCtr lopCtr;
        private MonHocCtr monHocCtr;
        private string maSinhVien = "";
        private string maLop = "";
        private string maMH = "";
        private int rowIndexHS = -1;
        private int rowIndexLop = -1;
        private int rowIndexMH = -1;

        public Form1()
        {
            InitializeComponent();
            hocSinhCtr = new HocSinhCtr(Program.connectionString);
            lopCtr = new LopCtr(Program.connectionString);
            monHocCtr = new MonHocCtr(Program.connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load danh sách học sinh
            DataTable dt = hocSinhCtr.LayDanhSachHocSinh();
            dgvHocSinh.DataSource = dt;

            // Load danh sách lớp
            DataTable dtlop = lopCtr.LayDanhSachLop();
            dgvLop.DataSource = dtlop;

            // Load danh sách môn học
            DataTable dtmh = monHocCtr.LayDanhSachMonHoc();
            dgvMonHoc.DataSource = dtmh;
        }

        #region Xử lý phần Lớp
        private void btnReloadLop_Click(object sender, EventArgs e)
        {
            dgvLop.DataSource = lopCtr.LayDanhSachLop();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndexLop = e.RowIndex;
                maLop = dgvLop.Rows[rowIndexLop].Cells["MaLop"].Value.ToString();
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (rowIndexLop >= 0)
            {
                int result = lopCtr.XoaLop(maLop);
                if (result > 0)
                {
                    dgvLop.DataSource = lopCtr.LayDanhSachLop();
                    rowIndexLop = -1;
                    maLop = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lớp để xóa");
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            frThemLop fr = new frThemLop();
            fr.ShowDialog();
            dgvLop.DataSource = lopCtr.LayDanhSachLop(); // Làm mới danh sách
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (rowIndexLop >= 0)
            {
                frSuaLop fr = new frSuaLop(maLop);
                fr.ShowDialog();
                dgvLop.DataSource = lopCtr.LayDanhSachLop();
                if (fr.DialogResult == DialogResult.OK)
                {
                    rowIndexLop = -1;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lớp để sửa.");
            }
        }
        #endregion

        #region Xử lý phần Học sinh
        private void btnReloadHocSinh_Click(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = hocSinhCtr.LayDanhSachHocSinh();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndexHS = e.RowIndex;
                maSinhVien = dgvHocSinh.Rows[rowIndexHS].Cells["MaSV"].Value.ToString();
            }
        }

        private void btnXoaHocSinh_Click(object sender, EventArgs e)
        {
            if (rowIndexHS >= 0)
            {
                int result = hocSinhCtr.XoaHocSinh(maSinhVien);
                if (result > 0)
                {
                    dgvHocSinh.DataSource = hocSinhCtr.LayDanhSachHocSinh();
                    rowIndexHS = -1;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học sinh để xóa.");
            }
        }

        private void btnThemHocSinh_Click(object sender, EventArgs e)
        {
            frThemSV fr = new frThemSV();
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                dgvHocSinh.DataSource = hocSinhCtr.LayDanhSachHocSinh();
                rowIndexHS = -1;
            }
        }

        private void btnSuaHocSinh_Click(object sender, EventArgs e)
        {
            if (rowIndexHS >= 0)
            {
                frSuaSV fr = new frSuaSV(maSinhVien);
                fr.ShowDialog();
                if (fr.DialogResult == DialogResult.OK)
                {
                    dgvHocSinh.DataSource = hocSinhCtr.LayDanhSachHocSinh();
                    rowIndexHS = -1;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học sinh để sửa.");
            }
        }
        #endregion

        #region Xử lý phần Môn học
        private void btnReloadMon_Click(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = monHocCtr.LayDanhSachMonHoc();
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndexMH = e.RowIndex;
                maMH = dgvMonHoc.Rows[rowIndexMH].Cells[0].Value.ToString();
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            frThemMH fr = new frThemMH();
            fr.ShowDialog();
            dgvMonHoc.DataSource = monHocCtr.LayDanhSachMonHoc();
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            if (rowIndexMH >= 0)
            {
                frSuaMH fr = new frSuaMH(maMH);
                fr.ShowDialog();
                dgvMonHoc.DataSource = monHocCtr.LayDanhSachMonHoc();
                if (fr.DialogResult == DialogResult.OK)
                {
                    rowIndexMH = -1;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một môn học để sửa.");
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (rowIndexMH >= 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học: " + maMH + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    int result = monHocCtr.XoaMonHoc(maMH);
                    if (result > 0)
                    {
                        dgvMonHoc.DataSource = monHocCtr.LayDanhSachMonHoc();
                        rowIndexMH = -1;
                        maMH = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một môn học để xóa.", "Thông báo");
            }
        }
        #endregion
    }
}