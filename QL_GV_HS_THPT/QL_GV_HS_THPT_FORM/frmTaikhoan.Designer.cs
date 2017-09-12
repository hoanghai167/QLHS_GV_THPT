namespace QL_GV_HS_THPT_FORM
{
    partial class frmTaikhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLamMoiDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.grbThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.cbquyen = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grbThongTinHocSinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHocSinh
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaGV,
            this.colUsername,
            this.colPassword,
            this.colQuyen});
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHocSinh.Location = new System.Drawing.Point(0, 197);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(809, 228);
            this.dgvHocSinh.TabIndex = 10;
            this.dgvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellClick);
            this.dgvHocSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnLuu,
            this.btnXoa,
            this.btnLamMoiDuLieu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 153);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnThem
            // 
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 20);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 20);
            this.btnSua.Text = "Thay đổi thông tin";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(39, 20);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 20);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoiDuLieu
            // 
            this.btnLamMoiDuLieu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLamMoiDuLieu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLamMoiDuLieu.Name = "btnLamMoiDuLieu";
            this.btnLamMoiDuLieu.Size = new System.Drawing.Size(105, 20);
            this.btnLamMoiDuLieu.Text = "Làm mới dữ liệu";
            this.btnLamMoiDuLieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLamMoiDuLieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // grbThongTinHocSinh
            // 
            this.grbThongTinHocSinh.Controls.Add(this.txtTen);
            this.grbThongTinHocSinh.Controls.Add(this.cbquyen);
            this.grbThongTinHocSinh.Controls.Add(this.cboMaGV);
            this.grbThongTinHocSinh.Controls.Add(this.txtPass);
            this.grbThongTinHocSinh.Controls.Add(this.lblMaLop);
            this.grbThongTinHocSinh.Controls.Add(this.lblNgaySinh);
            this.grbThongTinHocSinh.Controls.Add(this.lblGT);
            this.grbThongTinHocSinh.Controls.Add(this.lblMaHS);
            this.grbThongTinHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongTinHocSinh.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinHocSinh.Name = "grbThongTinHocSinh";
            this.grbThongTinHocSinh.Size = new System.Drawing.Size(809, 150);
            this.grbThongTinHocSinh.TabIndex = 8;
            this.grbThongTinHocSinh.TabStop = false;
            this.grbThongTinHocSinh.Text = "Thông tin taì khoản";
            this.grbThongTinHocSinh.Enter += new System.EventHandler(this.grbThongTinHocSinh_Enter);
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(104, 76);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(191, 20);
            this.txtPass.TabIndex = 9;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(15, 52);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(73, 13);
            this.lblMaLop.TabIndex = 8;
            this.lblMaLop.Text = "Tên tài khoản";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 105);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(38, 13);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Quyền";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(15, 25);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(40, 13);
            this.lblGT.TabIndex = 3;
            this.lblGT.Text = "Mã GV";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(15, 79);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(52, 13);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.Text = "Mật khẩu";
            // 
            // cboMaGV
            // 
            this.cboMaGV.Enabled = false;
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Location = new System.Drawing.Point(104, 22);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(156, 21);
            this.cboMaGV.TabIndex = 19;
            this.cboMaGV.Text = "-- Chọn mã giáo viên";
            // 
            // cbquyen
            // 
            this.cbquyen.Enabled = false;
            this.cbquyen.FormattingEnabled = true;
            this.cbquyen.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbquyen.Location = new System.Drawing.Point(104, 105);
            this.cbquyen.Name = "cbquyen";
            this.cbquyen.Size = new System.Drawing.Size(156, 21);
            this.cbquyen.TabIndex = 20;
            this.cbquyen.Text = "-- Chọn quyền";
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(104, 49);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(191, 20);
            this.txtTen.TabIndex = 21;
            // 
            // colMaGV
            // 
            this.colMaGV.DataPropertyName = "MaGV";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.colMaGV.HeaderText = "Mã GV";
            this.colMaGV.MinimumWidth = 50;
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.Width = 200;
            // 
            // colUsername
            // 
            this.colUsername.DataPropertyName = "Username";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colUsername.DefaultCellStyle = dataGridViewCellStyle8;
            this.colUsername.HeaderText = "Tên tài khoản";
            this.colUsername.Name = "colUsername";
            this.colUsername.Width = 200;
            // 
            // colPassword
            // 
            this.colPassword.DataPropertyName = "Password";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colPassword.DefaultCellStyle = dataGridViewCellStyle9;
            this.colPassword.HeaderText = "Mật khẩu";
            this.colPassword.Name = "colPassword";
            this.colPassword.Width = 150;
            // 
            // colQuyen
            // 
            this.colQuyen.DataPropertyName = "Quyen";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colQuyen.DefaultCellStyle = dataGridViewCellStyle10;
            this.colQuyen.HeaderText = "Quyền";
            this.colQuyen.Name = "colQuyen";
            this.colQuyen.Width = 200;
            // 
            // frmTaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 425);
            this.Controls.Add(this.dgvHocSinh);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grbThongTinHocSinh);
            this.Name = "frmTaikhoan";
            this.Text = "frmTaikhoan";
            this.Load += new System.EventHandler(this.frmTaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbThongTinHocSinh.ResumeLayout(false);
            this.grbThongTinHocSinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnLuu;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ToolStripMenuItem btnLamMoiDuLieu;
        private System.Windows.Forms.GroupBox grbThongTinHocSinh;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.ComboBox cbquyen;
        private System.Windows.Forms.ComboBox cboMaGV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuyen;
    }
}