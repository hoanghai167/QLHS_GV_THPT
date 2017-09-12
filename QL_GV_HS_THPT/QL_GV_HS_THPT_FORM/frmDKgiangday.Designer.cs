namespace QL_GV_HS_THPT_FORM
{
    partial class frmDKgiangday
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.dtpNgayDay = new System.Windows.Forms.DateTimePicker();
            this.txtTiet = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.grbThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLamMoiDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtTimMaHS = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimHoHS = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimTenHS = new System.Windows.Forms.ToolStripTextBox();
            this.cboTimMaLop = new System.Windows.Forms.ToolStripComboBox();
            this.cboTimDanToc = new System.Windows.Forms.ToolStripComboBox();
            this.cboTimTonGiao = new System.Windows.Forms.ToolStripComboBox();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTietday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.grbThongTinHocSinh.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMaGV
            // 
            this.cboMaGV.Enabled = false;
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboMaGV.Location = new System.Drawing.Point(75, 22);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(121, 21);
            this.cboMaGV.TabIndex = 19;
            this.cboMaGV.Text = "-- Chọn mã giáo viên";
            this.cboMaGV.SelectedIndexChanged += new System.EventHandler(this.cboMaGV_SelectedIndexChanged);
            // 
            // cboMaLop
            // 
            this.cboMaLop.Enabled = false;
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Items.AddRange(new object[] {
            "10a",
            "10b",
            "10c",
            "11a",
            "11b",
            "11c",
            "12a",
            "12b",
            "12c"});
            this.cboMaLop.Location = new System.Drawing.Point(75, 49);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(121, 21);
            this.cboMaLop.TabIndex = 16;
            this.cboMaLop.Text = "-- Chọn mã lớp";
            // 
            // dtpNgayDay
            // 
            this.dtpNgayDay.Enabled = false;
            this.dtpNgayDay.Location = new System.Drawing.Point(75, 102);
            this.dtpNgayDay.Name = "dtpNgayDay";
            this.dtpNgayDay.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayDay.TabIndex = 14;
            // 
            // txtTiet
            // 
            this.txtTiet.Enabled = false;
            this.txtTiet.Location = new System.Drawing.Point(75, 76);
            this.txtTiet.Name = "txtTiet";
            this.txtTiet.Size = new System.Drawing.Size(80, 20);
            this.txtTiet.TabIndex = 9;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(15, 52);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(39, 13);
            this.lblMaLop.TabIndex = 8;
            this.lblMaLop.Text = "Mã lớp";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 105);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày Dạy";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(15, 25);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(22, 13);
            this.lblGT.TabIndex = 3;
            this.lblGT.Text = "GT";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(15, 79);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(25, 13);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.Text = "Tiết";
            // 
            // grbThongTinHocSinh
            // 
            this.grbThongTinHocSinh.Controls.Add(this.cboMaGV);
            this.grbThongTinHocSinh.Controls.Add(this.cboMaLop);
            this.grbThongTinHocSinh.Controls.Add(this.dtpNgayDay);
            this.grbThongTinHocSinh.Controls.Add(this.txtTiet);
            this.grbThongTinHocSinh.Controls.Add(this.lblMaLop);
            this.grbThongTinHocSinh.Controls.Add(this.lblNgaySinh);
            this.grbThongTinHocSinh.Controls.Add(this.lblGT);
            this.grbThongTinHocSinh.Controls.Add(this.lblMaHS);
            this.grbThongTinHocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongTinHocSinh.Location = new System.Drawing.Point(0, 25);
            this.grbThongTinHocSinh.Name = "grbThongTinHocSinh";
            this.grbThongTinHocSinh.Size = new System.Drawing.Size(877, 150);
            this.grbThongTinHocSinh.TabIndex = 4;
            this.grbThongTinHocSinh.TabStop = false;
            this.grbThongTinHocSinh.Text = "Thông tin học sinh";
            this.grbThongTinHocSinh.Enter += new System.EventHandler(this.grbThongTinHocSinh_Enter);
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 5;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtTimMaHS,
            this.txtTimHoHS,
            this.txtTimTenHS,
            this.cboTimMaLop,
            this.cboTimDanToc,
            this.cboTimTonGiao});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(877, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel1.Text = "Tìm kiếm";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtTimMaHS
            // 
            this.txtTimMaHS.Name = "txtTimMaHS";
            this.txtTimMaHS.Size = new System.Drawing.Size(75, 25);
            this.txtTimMaHS.Text = "-- Mã HS";
            // 
            // txtTimHoHS
            // 
            this.txtTimHoHS.Name = "txtTimHoHS";
            this.txtTimHoHS.Size = new System.Drawing.Size(176, 25);
            this.txtTimHoHS.Text = "-- Họ HS";
            // 
            // txtTimTenHS
            // 
            this.txtTimTenHS.Name = "txtTimTenHS";
            this.txtTimTenHS.Size = new System.Drawing.Size(100, 25);
            this.txtTimTenHS.Text = "-- Tên HS";
            // 
            // cboTimMaLop
            // 
            this.cboTimMaLop.Name = "cboTimMaLop";
            this.cboTimMaLop.Size = new System.Drawing.Size(80, 25);
            this.cboTimMaLop.Text = "-- Mã lớp";
            // 
            // cboTimDanToc
            // 
            this.cboTimDanToc.Name = "cboTimDanToc";
            this.cboTimDanToc.Size = new System.Drawing.Size(100, 25);
            this.cboTimDanToc.Text = "-- Dân tộc";
            // 
            // cboTimTonGiao
            // 
            this.cboTimTonGiao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTimTonGiao.Name = "cboTimTonGiao";
            this.cboTimTonGiao.Size = new System.Drawing.Size(100, 25);
            this.cboTimTonGiao.Text = "-- Tôn giáo";
            // 
            // dgvHocSinh
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaGV,
            this.colMaLop,
            this.colNgayDay,
            this.colTietday});
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHocSinh.Location = new System.Drawing.Point(0, 205);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(877, 228);
            this.dgvHocSinh.TabIndex = 7;
            this.dgvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellClick);
            this.dgvHocSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellContentClick);
            // 
            // colMaGV
            // 
            this.colMaGV.DataPropertyName = "MaGV";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.colMaGV.HeaderText = "Mã GV";
            this.colMaGV.MinimumWidth = 50;
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.Width = 200;
            // 
            // colMaLop
            // 
            this.colMaLop.DataPropertyName = "MaLop";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaLop.DefaultCellStyle = dataGridViewCellStyle13;
            this.colMaLop.HeaderText = "Mã lớp";
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.Width = 200;
            // 
            // colNgayDay
            // 
            this.colNgayDay.DataPropertyName = "Ngayday";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colNgayDay.DefaultCellStyle = dataGridViewCellStyle14;
            this.colNgayDay.HeaderText = "Ngày dạy";
            this.colNgayDay.Name = "colNgayDay";
            this.colNgayDay.Width = 300;
            // 
            // colTietday
            // 
            this.colTietday.DataPropertyName = "Tietday";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colTietday.DefaultCellStyle = dataGridViewCellStyle15;
            this.colTietday.HeaderText = "Tiết dạy";
            this.colTietday.Name = "colTietday";
            this.colTietday.Width = 200;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(877, 6);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 175);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(877, 30);
            this.toolStripContainer1.TabIndex = 8;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // frmDKgiangday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 433);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.grbThongTinHocSinh);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvHocSinh);
            this.Name = "frmDKgiangday";
            this.Text = "frmGiangday";
            this.Load += new System.EventHandler(this.frmDKgiangday_Load);
            this.grbThongTinHocSinh.ResumeLayout(false);
            this.grbThongTinHocSinh.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaGV;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.DateTimePicker dtpNgayDay;
        private System.Windows.Forms.TextBox txtTiet;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.GroupBox grbThongTinHocSinh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnLuu;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ToolStripMenuItem btnLamMoiDuLieu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtTimMaHS;
        private System.Windows.Forms.ToolStripTextBox txtTimHoHS;
        private System.Windows.Forms.ToolStripTextBox txtTimTenHS;
        private System.Windows.Forms.ToolStripComboBox cboTimMaLop;
        private System.Windows.Forms.ToolStripComboBox cboTimDanToc;
        private System.Windows.Forms.ToolStripComboBox cboTimTonGiao;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTietday;
    }
}