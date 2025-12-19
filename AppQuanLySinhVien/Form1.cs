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
    }
}
