namespace AppQuanLySinhVien
{
    partial class frSuaLop
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
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelTitle.Location = new System.Drawing.Point(0, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(450, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "CẬP NHẬT THÔNG TIN LỚP"; // Đổi tiêu đề
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaLop
            // 
            this.txtMaLop.BackColor = System.Drawing.SystemColors.ControlLight; // Màu nền xám
            this.txtMaLop.Location = new System.Drawing.Point(160, 80);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true; // QUAN TRỌNG: Không cho sửa Mã
            this.txtMaLop.Size = new System.Drawing.Size(220, 23);
            this.txtMaLop.TabIndex = 2;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(160, 125);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(220, 23);
            this.txtTenLop.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DodgerBlue; // Đổi màu xanh dương cho khác nút Thêm
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(100, 180);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 35);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Cập Nhật";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(230, 180);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(50, 83);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(75, 15);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã Lớp Học:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(50, 128);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(76, 15);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Tên Lớp Học:";
            // 
            // frSuaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frSuaLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Thông Tin Lớp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTen;
    }
}