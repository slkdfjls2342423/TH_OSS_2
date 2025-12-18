namespace AppQuanLySinhVien
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageHocSinh = new System.Windows.Forms.TabPage();
            this.btnXoaHocSinh = new System.Windows.Forms.Button();
            this.btnSuaHocSinh = new System.Windows.Forms.Button();
            this.btnThemHocSinh = new System.Windows.Forms.Button();
            this.lblTitleHocSinh = new System.Windows.Forms.Label();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.tabPageLop = new System.Windows.Forms.TabPage();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.lblTitleLop = new System.Windows.Forms.Label();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.tabPageMonHoc = new System.Windows.Forms.TabPage();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.lblTitleMon = new System.Windows.Forms.Label();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.tabPageLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.tabPageMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageHocSinh);
            this.tabControlMain.Controls.Add(this.tabPageLop);
            this.tabControlMain.Controls.Add(this.tabPageMonHoc);
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(12, 83);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(990, 504);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageHocSinh
            // 
            this.tabPageHocSinh.BackColor = System.Drawing.Color.White;
            this.tabPageHocSinh.Controls.Add(this.btnXoaHocSinh);
            this.tabPageHocSinh.Controls.Add(this.btnSuaHocSinh);
            this.tabPageHocSinh.Controls.Add(this.btnThemHocSinh);
            this.tabPageHocSinh.Controls.Add(this.lblTitleHocSinh);
            this.tabPageHocSinh.Controls.Add(this.dgvHocSinh);
            this.tabPageHocSinh.Location = new System.Drawing.Point(4, 26);
            this.tabPageHocSinh.Name = "tabPageHocSinh";
            this.tabPageHocSinh.Size = new System.Drawing.Size(982, 474);
            this.tabPageHocSinh.TabIndex = 0;
            this.tabPageHocSinh.Text = "🎓 Học Sinh";
            // 
            // btnXoaHocSinh
            // 
            this.btnXoaHocSinh.Location = new System.Drawing.Point(841, 216);
            this.btnXoaHocSinh.Name = "btnXoaHocSinh";
            this.btnXoaHocSinh.Size = new System.Drawing.Size(138, 65);
            this.btnXoaHocSinh.TabIndex = 2;
            this.btnXoaHocSinh.Text = "Xóa";
            // 
            // btnSuaHocSinh
            // 
            this.btnSuaHocSinh.Location = new System.Drawing.Point(841, 145);
            this.btnSuaHocSinh.Name = "btnSuaHocSinh";
            this.btnSuaHocSinh.Size = new System.Drawing.Size(138, 65);
            this.btnSuaHocSinh.TabIndex = 1;
            this.btnSuaHocSinh.Text = "Sửa";
            // 
            // btnThemHocSinh
            // 
            this.btnThemHocSinh.Location = new System.Drawing.Point(841, 74);
            this.btnThemHocSinh.Name = "btnThemHocSinh";
            this.btnThemHocSinh.Size = new System.Drawing.Size(138, 65);
            this.btnThemHocSinh.TabIndex = 0;
            this.btnThemHocSinh.Text = "Thêm";
            // 
            // lblTitleHocSinh
            // 
            this.lblTitleHocSinh.AutoSize = true;
            this.lblTitleHocSinh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleHocSinh.Location = new System.Drawing.Point(15, 15);
            this.lblTitleHocSinh.Name = "lblTitleHocSinh";
            this.lblTitleHocSinh.Size = new System.Drawing.Size(184, 25);
            this.lblTitleHocSinh.TabIndex = 0;
            this.lblTitleHocSinh.Text = "Danh sách Học sinh";
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinh.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHocSinh.Location = new System.Drawing.Point(15, 74);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(820, 370);
            this.dgvHocSinh.TabIndex = 1;
            // 
            // tabPageLop
            // 
            this.tabPageLop.BackColor = System.Drawing.Color.White;
            this.tabPageLop.Controls.Add(this.btnSuaLop);
            this.tabPageLop.Controls.Add(this.btnThemLop);
            this.tabPageLop.Controls.Add(this.btnXoaLop);
            this.tabPageLop.Controls.Add(this.lblTitleLop);
            this.tabPageLop.Controls.Add(this.dgvLop);
            this.tabPageLop.Location = new System.Drawing.Point(4, 26);
            this.tabPageLop.Name = "tabPageLop";
            this.tabPageLop.Size = new System.Drawing.Size(982, 474);
            this.tabPageLop.TabIndex = 1;
            this.tabPageLop.Text = "📁 Lớp Học";
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Location = new System.Drawing.Point(841, 145);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(138, 65);
            this.btnSuaLop.TabIndex = 1;
            this.btnSuaLop.Text = "Sửa";
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(841, 74);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(138, 65);
            this.btnThemLop.TabIndex = 0;
            this.btnThemLop.Text = "Thêm";
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(841, 216);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(138, 65);
            this.btnXoaLop.TabIndex = 2;
            this.btnXoaLop.Text = "Xóa";
            // 
            // lblTitleLop
            // 
            this.lblTitleLop.AutoSize = true;
            this.lblTitleLop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleLop.Location = new System.Drawing.Point(15, 15);
            this.lblTitleLop.Name = "lblTitleLop";
            this.lblTitleLop.Size = new System.Drawing.Size(178, 25);
            this.lblTitleLop.TabIndex = 0;
            this.lblTitleLop.Text = "Danh sách Lớp học";
            // 
            // dgvLop
            // 
            this.dgvLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLop.Location = new System.Drawing.Point(15, 74);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.Size = new System.Drawing.Size(820, 370);
            this.dgvLop.TabIndex = 1;
            // 
            // tabPageMonHoc
            // 
            this.tabPageMonHoc.BackColor = System.Drawing.Color.White;
            this.tabPageMonHoc.Controls.Add(this.btnXoaMon);
            this.tabPageMonHoc.Controls.Add(this.btnSuaMon);
            this.tabPageMonHoc.Controls.Add(this.btnThemMon);
            this.tabPageMonHoc.Controls.Add(this.lblTitleMon);
            this.tabPageMonHoc.Controls.Add(this.dgvMonHoc);
            this.tabPageMonHoc.Location = new System.Drawing.Point(4, 26);
            this.tabPageMonHoc.Name = "tabPageMonHoc";
            this.tabPageMonHoc.Size = new System.Drawing.Size(982, 474);
            this.tabPageMonHoc.TabIndex = 2;
            this.tabPageMonHoc.Text = "📚 Môn Học";
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Location = new System.Drawing.Point(841, 216);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(138, 65);
            this.btnXoaMon.TabIndex = 2;
            this.btnXoaMon.Text = "Xóa";
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.Location = new System.Drawing.Point(841, 145);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(138, 65);
            this.btnSuaMon.TabIndex = 1;
            this.btnSuaMon.Text = "Sửa";
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(841, 74);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(138, 65);
            this.btnThemMon.TabIndex = 0;
            this.btnThemMon.Text = "Thêm";
            // 
            // lblTitleMon
            // 
            this.lblTitleMon.AutoSize = true;
            this.lblTitleMon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleMon.Location = new System.Drawing.Point(15, 15);
            this.lblTitleMon.Name = "lblTitleMon";
            this.lblTitleMon.Size = new System.Drawing.Size(186, 25);
            this.lblTitleMon.TabIndex = 0;
            this.lblTitleMon.Text = "Danh mục Môn học";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMonHoc.Location = new System.Drawing.Point(15, 74);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.Size = new System.Drawing.Size(820, 370);
            this.dgvMonHoc.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1014, 80);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "HỆ THỐNG QUẢN LÝ ĐÀO TẠO";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1014, 599);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên Pro - Dashboard";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageHocSinh.ResumeLayout(false);
            this.tabPageHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.tabPageLop.ResumeLayout(false);
            this.tabPageLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.tabPageMonHoc.ResumeLayout(false);
            this.tabPageMonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        // Hàm hỗ trợ làm đẹp button
        private void StyleButton(System.Windows.Forms.Button btn, string text, int top, System.Drawing.Color backColor)
        {
            btn.Text = text;
            btn.BackColor = backColor;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btn.Location = new System.Drawing.Point(20, top);
            btn.Size = new System.Drawing.Size(205, 45);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
        }

        #endregion

        // Khai báo các thành phần UI
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tabControlMain;

        // Tab Lớp
        private System.Windows.Forms.TabPage tabPageLop;
        private System.Windows.Forms.Label lblTitleLop;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnSuaLop;

        // Tab Môn Học
        private System.Windows.Forms.TabPage tabPageMonHoc;
        private System.Windows.Forms.Label lblTitleMon;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnSuaMon;

        // Tab Học Sinh
        private System.Windows.Forms.TabPage tabPageHocSinh;
        private System.Windows.Forms.Label lblTitleHocSinh;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Button btnThemHocSinh;
        private System.Windows.Forms.Button btnXoaHocSinh;
        private System.Windows.Forms.Button btnSuaHocSinh;


    }
}