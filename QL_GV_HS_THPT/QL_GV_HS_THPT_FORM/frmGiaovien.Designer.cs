namespace QL_GV_HS_THPT_FORM
{
    partial class frmGiaovien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboMaMon = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblDanToc = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLamMoiDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.grbThongTinGiaoVien = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.lblHo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtTimMaHS = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimHoHS = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimTenHS = new System.Windows.Forms.ToolStripTextBox();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTimDanToc = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.grbThongTinGiaoVien.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaMon
            // 
            this.cboMaMon.Enabled = false;
            this.cboMaMon.FormattingEnabled = true;
            this.cboMaMon.Items.AddRange(new object[] {
            "AV",
            "CN",
            "DL",
            "GDCD",
            "HH",
            "LS",
            "NV",
            "SH",
            "T",
            "TD",
            "TH",
            "VL"});
            this.cboMaMon.Location = new System.Drawing.Point(364, 19);
            this.cboMaMon.Name = "cboMaMon";
            this.cboMaMon.Size = new System.Drawing.Size(121, 21);
            this.cboMaMon.TabIndex = 16;
            this.cboMaMon.Text = "-- Chọn mã môn";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(364, 100);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 39);
            this.txtDiaChi.TabIndex = 15;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Location = new System.Drawing.Point(75, 119);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 14;
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(75, 71);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 20);
            this.txtTen.TabIndex = 11;
            // 
            // txtHo
            // 
            this.txtHo.Enabled = false;
            this.txtHo.Location = new System.Drawing.Point(75, 45);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(130, 20);
            this.txtHo.TabIndex = 10;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Enabled = false;
            this.txtMaGV.Location = new System.Drawing.Point(75, 19);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(80, 20);
            this.txtMaGV.TabIndex = 9;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(304, 22);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(45, 13);
            this.lblMaLop.TabIndex = 8;
            this.lblMaLop.Text = "Mã môn";
            // 
            // lblDanToc
            // 
            this.lblDanToc.AutoSize = true;
            this.lblDanToc.Location = new System.Drawing.Point(304, 48);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(37, 13);
            this.lblDanToc.TabIndex = 6;
            this.lblDanToc.Text = "Lương";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(304, 103);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 122);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(15, 99);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(22, 13);
            this.lblGT.TabIndex = 3;
            this.lblGT.Text = "GT";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(15, 74);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 13);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(15, 22);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(44, 13);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.Text = "Mã GV*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnLuu,
            this.btnXoa,
            this.btnLamMoiDuLieu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 175);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
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
            // grbThongTinGiaoVien
            // 
            this.grbThongTinGiaoVien.Controls.Add(this.txtSDT);
            this.grbThongTinGiaoVien.Controls.Add(this.label1);
            this.grbThongTinGiaoVien.Controls.Add(this.cboGioiTinh);
            this.grbThongTinGiaoVien.Controls.Add(this.txtLuong);
            this.grbThongTinGiaoVien.Controls.Add(this.cboMaMon);
            this.grbThongTinGiaoVien.Controls.Add(this.txtDiaChi);
            this.grbThongTinGiaoVien.Controls.Add(this.dtpNgaySinh);
            this.grbThongTinGiaoVien.Controls.Add(this.txtTen);
            this.grbThongTinGiaoVien.Controls.Add(this.txtHo);
            this.grbThongTinGiaoVien.Controls.Add(this.txtMaGV);
            this.grbThongTinGiaoVien.Controls.Add(this.lblMaLop);
            this.grbThongTinGiaoVien.Controls.Add(this.lblDanToc);
            this.grbThongTinGiaoVien.Controls.Add(this.lblDiaChi);
            this.grbThongTinGiaoVien.Controls.Add(this.lblNgaySinh);
            this.grbThongTinGiaoVien.Controls.Add(this.lblGT);
            this.grbThongTinGiaoVien.Controls.Add(this.lblTen);
            this.grbThongTinGiaoVien.Controls.Add(this.lblHo);
            this.grbThongTinGiaoVien.Controls.Add(this.lblMaHS);
            this.grbThongTinGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongTinGiaoVien.Location = new System.Drawing.Point(0, 25);
            this.grbThongTinGiaoVien.Name = "grbThongTinGiaoVien";
            this.grbThongTinGiaoVien.Size = new System.Drawing.Size(987, 150);
            this.grbThongTinGiaoVien.TabIndex = 4;
            this.grbThongTinGiaoVien.TabStop = false;
            this.grbThongTinGiaoVien.Text = "Thông tin giáo viên";
            this.grbThongTinGiaoVien.Enter += new System.EventHandler(this.grbThongTinGiaoVien_Enter);
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(364, 71);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(121, 20);
            this.txtSDT.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "SDT";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Enabled = false;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(75, 95);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cboGioiTinh.TabIndex = 18;
            this.cboGioiTinh.Text = "-- Chọn giới tính";
            // 
            // txtLuong
            // 
            this.txtLuong.Enabled = false;
            this.txtLuong.Location = new System.Drawing.Point(364, 45);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(121, 20);
            this.txtLuong.TabIndex = 17;
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(16, 48);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(21, 13);
            this.lblHo.TabIndex = 1;
            this.lblHo.Text = "Họ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtTimMaHS,
            this.txtTimHoHS,
            this.txtTimTenHS,
            this.cboTimDanToc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(987, 25);
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
            this.txtTimMaHS.Text = "-- Mã GV";
            this.txtTimMaHS.Click += new System.EventHandler(this.txtTimMaHS_Click);
            this.txtTimMaHS.TextChanged += new System.EventHandler(this.txtTimMaHS_TextChanged);
            // 
            // txtTimHoHS
            // 
            this.txtTimHoHS.Name = "txtTimHoHS";
            this.txtTimHoHS.Size = new System.Drawing.Size(176, 25);
            this.txtTimHoHS.Text = "-- Họ GV";
            // 
            // txtTimTenHS
            // 
            this.txtTimTenHS.Name = "txtTimTenHS";
            this.txtTimTenHS.Size = new System.Drawing.Size(100, 25);
            this.txtTimTenHS.Text = "-- Tên GV";
            // 
            // dgvGiaoVien
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaGV,
            this.colHo,
            this.colTen,
            this.colLuong,
            this.colMaMon,
            this.colSDT,
            this.colGT,
            this.colNgaySinh,
            this.colDiaChi});
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGiaoVien.Location = new System.Drawing.Point(0, 202);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.Size = new System.Drawing.Size(987, 283);
            this.dgvGiaoVien.TabIndex = 7;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            this.dgvGiaoVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellContentClick);
            // 
            // colMaGV
            // 
            this.colMaGV.DataPropertyName = "MaGV";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaGV.DefaultCellStyle = dataGridViewCellStyle32;
            this.colMaGV.HeaderText = "Mã GV";
            this.colMaGV.MinimumWidth = 50;
            this.colMaGV.Name = "colMaGV";
            // 
            // colHo
            // 
            this.colHo.DataPropertyName = "Ho";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colHo.DefaultCellStyle = dataGridViewCellStyle33;
            this.colHo.HeaderText = "Họ";
            this.colHo.Name = "colHo";
            this.colHo.Width = 180;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "Ten";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colTen.DefaultCellStyle = dataGridViewCellStyle34;
            this.colTen.HeaderText = "Tên";
            this.colTen.Name = "colTen";
            // 
            // colLuong
            // 
            this.colLuong.DataPropertyName = "Luong";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colLuong.DefaultCellStyle = dataGridViewCellStyle35;
            this.colLuong.HeaderText = "Lương";
            this.colLuong.Name = "colLuong";
            this.colLuong.Width = 80;
            // 
            // colMaMon
            // 
            this.colMaMon.DataPropertyName = "MaMon";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaMon.DefaultCellStyle = dataGridViewCellStyle36;
            this.colMaMon.HeaderText = "Mã môn";
            this.colMaMon.Name = "colMaMon";
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSDT.DefaultCellStyle = dataGridViewCellStyle37;
            this.colSDT.HeaderText = "SDT";
            this.colSDT.Name = "colSDT";
            // 
            // colGT
            // 
            this.colGT.DataPropertyName = "GT";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colGT.DefaultCellStyle = dataGridViewCellStyle38;
            this.colGT.HeaderText = "GT";
            this.colGT.Name = "colGT";
            this.colGT.Width = 80;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNgaySinh.DefaultCellStyle = dataGridViewCellStyle39;
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Width = 150;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDiaChi.DefaultCellStyle = dataGridViewCellStyle40;
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            // 
            // cboTimDanToc
            // 
            this.cboTimDanToc.Name = "cboTimDanToc";
            this.cboTimDanToc.Size = new System.Drawing.Size(100, 25);
            this.cboTimDanToc.Text = "-- Mã Môn";
            // 
            // frmGiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 485);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grbThongTinGiaoVien);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvGiaoVien);
            this.Name = "frmGiaovien";
            this.Text = "frmGiaoVien";
            this.Load += new System.EventHandler(this.frmGiaovien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbThongTinGiaoVien.ResumeLayout(false);
            this.grbThongTinGiaoVien.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMaMon;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblDanToc;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnLuu;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ToolStripMenuItem btnLamMoiDuLieu;
        private System.Windows.Forms.GroupBox grbThongTinGiaoVien;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtTimMaHS;
        private System.Windows.Forms.ToolStripTextBox txtTimHoHS;
        private System.Windows.Forms.ToolStripTextBox txtTimTenHS;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripComboBox cboTimDanToc;
    }
}