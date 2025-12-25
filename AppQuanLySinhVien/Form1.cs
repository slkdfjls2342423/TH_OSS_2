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
        private MonHocCtr monHocCtr;
        private int rowSelected;
   
        private int rowIndexMH = -1;
        private string maMH = "";
     

        public Form1()
        {
            InitializeComponent();
            hocSinhCtr = new HocSinhCtr(Program.connectionString);
            monHocCtr = new MonHocCtr(Program.connectionString);
        }
        //Load form MONHOC
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = hocSinhCtr.LayDanhSachHocSinh();
            dgvHocSinh.DataSource = dt;

            DataTable dtmh = monHocCtr.LayDanhSachMonHoc();
            dgvMonHoc.DataSource = dtmh;
        }

        //Lam moi form MONHOC
        private void btnReloadMon_Click(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = monHocCtr.LayDanhSachMonHoc();
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = dgvMonHoc.CurrentRow.Index;
           
            MessageBox.Show(rowSelected.ToString());
            if (e.RowIndex >= 0)
            {
                rowIndexMH = e.RowIndex;

                // Lấy mã lớp từ cột MaLop
                maMH = dgvMonHoc.Rows[rowIndexMH].Cells[0].Value.ToString();

        
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            frThemMH fr = new frThemMH();
            fr.ShowDialog();
        
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            if (rowIndexMH >= 0)
            {
                frSuaMH fr = new frSuaMH(maMH);
                fr.ShowDialog();
                
                if (fr.DialogResult == DialogResult.OK)
                {
                    dgvMonHoc.DataSource = monHocCtr.LayDanhSachMonHoc();
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

        }
    }
}
