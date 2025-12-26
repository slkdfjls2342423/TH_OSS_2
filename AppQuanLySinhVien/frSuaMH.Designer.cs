namespace AppQuanLySinhVien
{
    partial class frSuaMH
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.numLT = new System.Windows.Forms.NumericUpDown();
            this.numTH = new System.Windows.Forms.NumericUpDown();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLT = new System.Windows.Forms.Label();
            this.lblTH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTH)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelTitle.Location = new System.Drawing.Point(0, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(450, 40);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "CẬP NHẬT MÔN HỌC";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaMH
            // 
            this.txtMaMH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaMH.Location = new System.Drawing.Point(170, 80);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.ReadOnly = true;
            this.txtMaMH.Size = new System.Drawing.Size(210, 27);
            this.txtMaMH.TabIndex = 9;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(170, 125);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(210, 27);
            this.txtTenMH.TabIndex = 8;
            // 
            // numLT
            // 
            this.numLT.Location = new System.Drawing.Point(191, 171);
            this.numLT.Name = "numLT";
            this.numLT.Size = new System.Drawing.Size(100, 27);
            this.numLT.TabIndex = 7;
            // 
            // numTH
            // 
            this.numTH.Location = new System.Drawing.Point(191, 211);
            this.numTH.Name = "numTH";
            this.numTH.Size = new System.Drawing.Size(100, 27);
            this.numTH.TabIndex = 6;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(100, 280);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 35);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Cập Nhật";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(230, 280);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(50, 83);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(98, 20);
            this.lblMa.TabIndex = 3;
            this.lblMa.Text = "Mã Môn Học:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(50, 128);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(100, 20);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên Môn Học:";
            // 
            // lblLT
            // 
            this.lblLT.AutoSize = true;
            this.lblLT.Location = new System.Drawing.Point(50, 173);
            this.lblLT.Name = "lblLT";
            this.lblLT.Size = new System.Drawing.Size(123, 20);
            this.lblLT.TabIndex = 1;
            this.lblLT.Text = "Số Tiết Lý Thuyết:";
            // 
            // lblTH
            // 
            this.lblTH.AutoSize = true;
            this.lblTH.Location = new System.Drawing.Point(50, 218);
            this.lblTH.Name = "lblTH";
            this.lblTH.Size = new System.Drawing.Size(133, 20);
            this.lblTH.TabIndex = 0;
            this.lblTH.Text = "Số Tiết Thực Hành:";
            // 
            // frSuaMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.lblTH);
            this.Controls.Add(this.lblLT);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.numTH);
            this.Controls.Add(this.numLT);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frSuaMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Môn Học";
            ((System.ComponentModel.ISupportInitialize)(this.numLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle, lblMa, lblTen, lblLT, lblTH;
        private System.Windows.Forms.TextBox txtMaMH, txtTenMH;
        private System.Windows.Forms.NumericUpDown numLT, numTH;
        private System.Windows.Forms.Button btnLuu, btnHuy;
    }
}