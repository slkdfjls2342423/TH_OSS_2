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
        }
    }
}
