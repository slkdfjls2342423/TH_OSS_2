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
        private string maSinhVien = "";
        private int rowIndex = -1;

        private LopCtr lopCtr;
        private int rowSelected;

        public Form1()
        {
            InitializeComponent();
            hocSinhCtr = new HocSinhCtr(Program.connectionString);
            lopCtr = new LopCtr(Program.connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = hocSinhCtr.LayDanhSachHocSinh();
            dgvHocSinh.DataSource = dt;

            DataTable dtlop = lopCtr.LayDanhSachLop();
            dgvLop.DataSource = dtlop;

            
        }
      

        private void btnReloadLop_Click(object sender, EventArgs e)
        {
            dgvLop.DataSource = lopCtr.LayDanhSachLop();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = dgvLop.CurrentRow.Index;
            MessageBox.Show(rowSelected.ToString());
        }

        private void btnReloadHocSinh_Click(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = hocSinhCtr.LayDanhSachHocSinh();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            maSinhVien = dgvHocSinh.Rows[rowIndex].Cells["MaSV"].Value.ToString();
            MessageBox.Show("Row index: " + rowIndex+ "mssv: "+maSinhVien);
        }

        private void btnXoaHocSinh_Click(object sender, EventArgs e)
        {
            if(rowIndex >= 0)
            {
                int result = hocSinhCtr.XoaHocSinh(maSinhVien);
                if (result > 0)
                {
                    dgvHocSinh.DataSource = hocSinhCtr.LayDanhSachHocSinh();
                    rowIndex = -1;
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
        }

        private void btnSuaHocSinh_Click(object sender, EventArgs e)
        {
            if (rowIndex >= 0)
            {
                frSuaSV fr = new frSuaSV(hocSinhCtr.Get(maSinhVien));
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học sinh để sửa.");
            }

        }
    }
}
