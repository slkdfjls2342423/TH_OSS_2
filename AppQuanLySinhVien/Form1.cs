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

        private string maLop = "";

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
          
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;

            
                maLop = dgvLop.Rows[rowIndex].Cells["MaLop"].Value.ToString();

               
            }
        }
        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if(rowIndex >= 0)
            {
                int result = lopCtr.XoaLop(maLop);
                if(result >0)
                {
                    dgvLop.DataSource = lopCtr.LayDanhSachLop();
                    rowIndex = -1;
                    maLop = "";
                }
                else
                {
                    MessageBox.Show("Vui long chon mot lop de xoa");
                }
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            frThemLop fr = new frThemLop();
            fr.ShowDialog();
            dgvLop.DataSource = lopCtr.LayDanhSachLop();//them lam moi
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (rowIndex >= 0)
            {
                frSuaLop fr = new frSuaLop(maLop);
                fr.ShowDialog();
                dgvLop.DataSource = lopCtr.LayDanhSachLop();
                if (fr.DialogResult == DialogResult.OK)
                {
                   
                    rowIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lop để sửa.");
            }

        }

        private void btnReloadHocSinh_Click(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = hocSinhCtr.LayDanhSachHocSinh();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            maSinhVien = dgvHocSinh.Rows[rowIndex].Cells["MaSV"].Value.ToString();
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
            if (fr.DialogResult == DialogResult.OK)
            {
                dgvHocSinh.DataSource = hocSinhCtr.LayDanhSachHocSinh();
                rowIndex = -1;
            }
        }

        private void btnSuaHocSinh_Click(object sender, EventArgs e)
        {
            if (rowIndex >= 0)
            {
                frSuaSV fr = new frSuaSV(maSinhVien);
                fr.ShowDialog();
                if (fr.DialogResult == DialogResult.OK)
                {
                    dgvHocSinh.DataSource = hocSinhCtr.LayDanhSachHocSinh();
                    rowIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học sinh để sửa.");
            }

        }
    }
    }

