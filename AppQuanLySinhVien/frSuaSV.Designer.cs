namespace AppQuanLySinhVien
{
    partial class frSuaSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTitle.Location = new System.Drawing.Point(0, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(450, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "CHỈNH SỬA THÔNG TIN";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaSV (ReadOnly)
            // 
            this.txtMaSV.Location = new System.Drawing.Point(160, 77);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true; // Không cho sửa mã
            this.txtMaSV.Size = new System.Drawing.Size(220, 23);
            this.txtMaSV.BackColor = System.Drawing.Color.LightGray;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(100, 360);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(110, 35);
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            // ... (Các phần khác copy y hệt frThemSV nhưng đổi tên button thành btnCapNhat)
            // Để tiết kiệm không gian, các thuộc tính Location/Size giống hệt Form Thêm

            this.lblMa.Location = new System.Drawing.Point(50, 80);
            this.lblMa.Text = "Mã Sinh Viên:";
            this.lblTen.Location = new System.Drawing.Point(50, 125);
            this.lblTen.Text = "Họ và Tên:";
            this.txtHoTen.Location = new System.Drawing.Point(160, 122);
            this.txtHoTen.Size = new System.Drawing.Size(220, 23);
            this.lblNgaySinh.Location = new System.Drawing.Point(50, 170);
            this.lblNgaySinh.Text = "Ngày Sinh:";
            this.dtpNgaySinh.Location = new System.Drawing.Point(160, 167);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Size = new System.Drawing.Size(220, 23);
            this.lblGioiTinh.Location = new System.Drawing.Point(50, 215);
            this.lblGioiTinh.Text = "Giới Tính:";
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Location = new System.Drawing.Point(160, 215);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(51, 19);
            this.rbNam.TabIndex = 8;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(230, 215);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(41, 19);
            this.rbNu.TabIndex = 9;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            this.lblDiaChi.Location = new System.Drawing.Point(50, 260);
            this.lblDiaChi.Text = "Địa Chỉ:";
            this.txtDiaChi.Location = new System.Drawing.Point(160, 257);
            this.txtDiaChi.Size = new System.Drawing.Size(220, 23);
            this.lblLop.Location = new System.Drawing.Point(50, 305);
            this.lblLop.Text = "Lớp Học:";
            this.cboLop.Location = new System.Drawing.Point(160, 302);
            this.cboLop.Size = new System.Drawing.Size(220, 23);
            this.btnHuy.Location = new System.Drawing.Point(230, 360);
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.ClientSize = new System.Drawing.Size(450, 430);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.labelTitle, this.lblMa, this.txtMaSV, this.lblTen, this.txtHoTen,
                this.lblNgaySinh, this.dtpNgaySinh, this.lblGioiTinh, this.rbNam, this.rbNu,
                this.lblDiaChi, this.txtDiaChi, this.lblLop, this.cboLop, this.btnCapNhat, this.btnHuy
            });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Sinh Viên";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtMaSV, txtHoTen, txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rbNam, rbNu;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnCapNhat, btnHuy;
        private System.Windows.Forms.Label lblMa, lblTen, lblNgaySinh, lblGioiTinh, lblDiaChi, lblLop;
    }

    #endregion
}