namespace QL_GV_HS_THPT_FORM
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuongdan = new System.Windows.Forms.Button();
            this.btnTkb = new System.Windows.Forms.Button();
            this.btnGiaovien = new System.Windows.Forms.Button();
            this.btnHocsinh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýGiảngDạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnHuongdan);
            this.panel1.Controls.Add(this.btnTkb);
            this.panel1.Controls.Add(this.btnGiaovien);
            this.panel1.Controls.Add(this.btnHocsinh);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 332);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHuongdan
            // 
            this.btnHuongdan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongdan.Image")));
            this.btnHuongdan.Location = new System.Drawing.Point(365, 185);
            this.btnHuongdan.Name = "btnHuongdan";
            this.btnHuongdan.Size = new System.Drawing.Size(109, 90);
            this.btnHuongdan.TabIndex = 4;
            this.btnHuongdan.Text = "Hướng dẫn";
            this.btnHuongdan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuongdan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuongdan.UseVisualStyleBackColor = true;
            // 
            // btnTkb
            // 
            this.btnTkb.Image = ((System.Drawing.Image)(resources.GetObject("btnTkb.Image")));
            this.btnTkb.Location = new System.Drawing.Point(365, 79);
            this.btnTkb.Name = "btnTkb";
            this.btnTkb.Size = new System.Drawing.Size(109, 87);
            this.btnTkb.TabIndex = 3;
            this.btnTkb.Text = "Thông tin giảng dạy";
            this.btnTkb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTkb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTkb.UseVisualStyleBackColor = true;
            this.btnTkb.Click += new System.EventHandler(this.btnTkb_Click);
            // 
            // btnGiaovien
            // 
            this.btnGiaovien.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaovien.Image")));
            this.btnGiaovien.Location = new System.Drawing.Point(121, 185);
            this.btnGiaovien.Name = "btnGiaovien";
            this.btnGiaovien.Size = new System.Drawing.Size(109, 90);
            this.btnGiaovien.TabIndex = 2;
            this.btnGiaovien.Text = "Quản lý giáo viên";
            this.btnGiaovien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiaovien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGiaovien.UseVisualStyleBackColor = true;
            this.btnGiaovien.Click += new System.EventHandler(this.btnGiaovien_Click);
            // 
            // btnHocsinh
            // 
            this.btnHocsinh.BackColor = System.Drawing.SystemColors.Control;
            this.btnHocsinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHocsinh.Image = ((System.Drawing.Image)(resources.GetObject("btnHocsinh.Image")));
            this.btnHocsinh.Location = new System.Drawing.Point(121, 79);
            this.btnHocsinh.Name = "btnHocsinh";
            this.btnHocsinh.Size = new System.Drawing.Size(109, 87);
            this.btnHocsinh.TabIndex = 1;
            this.btnHocsinh.Text = "Quản lý học sinh";
            this.btnHocsinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHocsinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHocsinh.UseVisualStyleBackColor = true;
            this.btnHocsinh.Click += new System.EventHandler(this.btnHocsinh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHọcSinhToolStripMenuItem,
            this.quảnLýGiáoViênToolStripMenuItem,
            this.đăngKýGiảngDạyToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýHọcSinhToolStripMenuItem
            // 
            this.quảnLýHọcSinhToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýHọcSinhToolStripMenuItem.Image")));
            this.quảnLýHọcSinhToolStripMenuItem.Name = "quảnLýHọcSinhToolStripMenuItem";
            this.quảnLýHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.quảnLýHọcSinhToolStripMenuItem.Text = "Học sinh";
            // 
            // quảnLýGiáoViênToolStripMenuItem
            // 
            this.quảnLýGiáoViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýGiáoViênToolStripMenuItem.Image")));
            this.quảnLýGiáoViênToolStripMenuItem.Name = "quảnLýGiáoViênToolStripMenuItem";
            this.quảnLýGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.quảnLýGiáoViênToolStripMenuItem.Text = "Giáo viên";
            // 
            // đăngKýGiảngDạyToolStripMenuItem
            // 
            this.đăngKýGiảngDạyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngKýGiảngDạyToolStripMenuItem.Image")));
            this.đăngKýGiảngDạyToolStripMenuItem.Name = "đăngKýGiảngDạyToolStripMenuItem";
            this.đăngKýGiảngDạyToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.đăngKýGiảngDạyToolStripMenuItem.Text = "Thông tin giảng dạy";
            this.đăngKýGiảngDạyToolStripMenuItem.Click += new System.EventHandler(this.đăngKýGiảngDạyToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuátToolStripMenuItem,
            this.thayMậtKhẩuToolStripMenuItem,
            this.tạoTàiKhoảnToolStripMenuItem,
            this.phânQuyềnToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tàiKhoảnToolStripMenuItem.Image")));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuátToolStripMenuItem
            // 
            this.đăngXuátToolStripMenuItem.Name = "đăngXuátToolStripMenuItem";
            this.đăngXuátToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.đăngXuátToolStripMenuItem.Text = "Đăng xuát";
            // 
            // thayMậtKhẩuToolStripMenuItem
            // 
            this.thayMậtKhẩuToolStripMenuItem.Name = "thayMậtKhẩuToolStripMenuItem";
            this.thayMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.thayMậtKhẩuToolStripMenuItem.Text = "Thay mật khẩu";
            // 
            // tạoTàiKhoảnToolStripMenuItem
            // 
            this.tạoTàiKhoảnToolStripMenuItem.Name = "tạoTàiKhoảnToolStripMenuItem";
            this.tạoTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tạoTàiKhoảnToolStripMenuItem.Text = "Tạo tài khoản";
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.phânQuyềnToolStripMenuItem.Text = "Phân quyền";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hướngDẫnToolStripMenuItem.Image")));
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 332);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý học sinh - giáo viên THPT";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHọcSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýGiảngDạyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private System.Windows.Forms.Button btnHuongdan;
        private System.Windows.Forms.Button btnTkb;
        private System.Windows.Forms.Button btnGiaovien;
        private System.Windows.Forms.Button btnHocsinh;
    }
}