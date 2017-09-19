﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_GV_HS_THPT_BUS;
using QL_GV_HS_THPT_DAL;
using QL_GV_HS_THPT_FORM;
using QL_QV_HS_THPT_Entity;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace QL_GV_HS_THPT_FORM
{
    public partial class frmHocsinh : Form
    {
        private bool _dangTimMa = false;
        private bool _dangTimHo = false;
        private bool _dangTimTen = false;
        private bool _dangTimMaLop = false;

        bool themmoi;
        BUS_tblHocSinh busHS = new BUS_tblHocSinh();
        EC_tblHocsinh ck = new EC_tblHocsinh();
        KetNoiDB cn = new KetNoiDB();
        public frmHocsinh()
        {
            InitializeComponent();
            // Bindingtxt();
        }

        public frmHocsinh(string action)
        {
            InitializeComponent();
            if (action == "TimKiem")
                grbThongTinHocSinh.Enabled = false;
            btnLamMoiDuLieu.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void setnull()
        {
            txtMaHS.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";

        }
        public void locktext()
        {
            txtMaHS.Enabled = false;
            txtHo.Enabled = false;
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            cboMaLop.Enabled = false;
            cboDanToc.Enabled = false;
            cboTonGiao.Enabled = false;
            cboGioitinh.Enabled = false;
            dtpNgaySinh.Enabled = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLamMoiDuLieu.Enabled = true;
        }
        public void un_locktext()
        {
            txtMaHS.Enabled = true;
            txtHo.Enabled = true;
            txtTen.Enabled = true;
            txtDiaChi.Enabled = true;
            cboMaLop.Enabled = true;
            cboDanToc.Enabled = true;
            cboTonGiao.Enabled = true;
            cboGioitinh.Enabled = true;
            dtpNgaySinh.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoiDuLieu.Enabled = false;
        }
        public void hienthi()
        {
            string sql = "SELECT  *  FROM tblHocSinh";
            dgvHocSinh.DataSource = cn.getDatatable(sql);

            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblGT_Click(object sender, EventArgs e)
        {

        }

        private void lblTonGiao_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTimMaHS_Click(object sender, EventArgs e)
        {
           
        }

        private void txtTimHoHS_Click(object sender, EventArgs e)
        {
          
        }

        private void txtTimTenHS_Click(object sender, EventArgs e)
        {
           
        }

        private void cboTimMaLop_Click(object sender, EventArgs e)
        {
           
        }

        /*private void cboTimDanToc_Click(object sender, EventArgs e)
        {
            cboTimDanToc.SelectionStart = cboTimDanToc.Text.Length;
            BUS_tblHocSinh busHs = new BUS_tblHocSinh();
            DataTable tb = busHs.getField("DanToc");
            cboTimDanToc.Items.Clear();
            cboTimDanToc.Items.Add("Tất cả");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cboTimDanToc.Items.Add(tb.Rows[i]["DanToc"].ToString());
            }
        }    */

        /*private void cboTimTonGiao_Click(object sender, EventArgs e)
        {
            cboTimTonGiao.SelectionStart = cboTimTonGiao.Text.Length;
            BUS_tblHocSinh busHs = new BUS_tblHocSinh();
            DataTable tb = busHs.getField("TonGiao");
            cboTimTonGiao.Items.Clear();
            cboTimTonGiao.Items.Add("Tất cả");
            for(int i = 0; i < tb.Rows.Count; i++)
            {
                cboTimTonGiao.Items.Add(tb.Rows[i]["TonGiao"].ToString());
            }
        }          */

        private void frmHocsinh_Load(object sender, EventArgs e)
        {
            DataTable tbl = busHS.getAllHocsinh();
            dgvHocSinh.DataSource = tbl;

        }

        private void txtTimMaHS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTimHo_TextChanged(object sender, EventArgs e)
        {
           
        }
        /* private void cboTimDanToc_TextChanged(object sender, EventArgs e)
         {
             if (cboTimDanToc.SelectedIndex != 0) _dangTimDanToc = true;
             else _dangTimDanToc = false;
             string dieukien = "";
             if (cboTimDanToc.SelectedIndex == 0) dieukien = "where DanToc like N'%'";
             else dieukien = "where DanToc like N'%" + cboTimDanToc.Text + "%'";
             if (_dangTimMa) dieukien += "AND MaHS like N'%" + txtMaHS.Text + "%'";
             if (_dangTimHo) dieukien += "AND Ho like N'%" + txtHo.Text + "%'";
             if (_dangTimMaLop)
             {
                 if (cboTimMaLop.SelectedIndex != 0) dieukien += "AND MaLop like N'%" + cboTimMaLop.Text + "%'";
             }
             if (_dangTimTonGiao)
             {
                 if (cboTimTonGiao.SelectedIndex != 0) dieukien += "AND TonGiao like N'%" + cboTimTonGiao.Text + "%'";
             }
             DataTable tbl = busHS.getHocsinh(dieukien);
             dgvHocSinh.DataSource = tbl;
         }     */
        /* private void cboTimTonGiao_TextChanged(object sender, EventArgs e)
         {
             if (cboTimTonGiao.SelectedIndex != 0) _dangTimTonGiao = true;
             else _dangTimTonGiao = false;
             string dieukien = "";
             if (cboTimTonGiao.SelectedIndex == 0) dieukien = "where TonGiao like N'%'";
             else dieukien = "where TonGiao like N'%" + cboTimTonGiao.Text + "%'";
             if (_dangTimMa) dieukien += "AND MaHS like N'%" + txtMaHS.Text + "%'";
             if (_dangTimHo) dieukien += "AND Ho like N'%" + txtHo.Text + "%'";
             if (_dangTimMaLop)
             {
                 if (cboTimMaLop.SelectedIndex != 0) dieukien += "AND MaLop like N'%" + cboTimMaLop.Text + "%'";
             }
             if (_dangTimDanToc)
             {
                 if (cboTimDanToc.SelectedIndex != 0) dieukien += "AND DanToc like N'%" + cboTimDanToc.Text + "%'";
             }
             DataTable tbl = busHS.getHocsinh(dieukien);
             dgvHocSinh.DataSource = tbl;
         }     */
        private void txtTimTenHS_Enter(object sender, EventArgs e)
        {
           
        }
        private void txtTimHoHS_Enter(object sender, EventArgs e)
        {
          
        }
        private void txtTimMaHS_Enter(object sender, EventArgs e)
        {
            
        }
        private void txtTimMaLop_Enter(object sender, EventArgs e)
        {
            
        }
        private void txtTimDanToc_Enter(object sender, EventArgs e)
        {
           
        }
        private void txtTimTonGiao_Enter(object sender, EventArgs e)
        {
          
        }

        private void txtTimTenHS_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cboTimMaLop_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtMaHS.Enabled = true;
            txtMaHS.Focus();
        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text != "")
            {
                if (themmoi == true)
                {
                    try
                    {
                        ck.MaHS = txtMaHS.Text;
                        ck.Ho = txtHo.Text;
                        ck.MaLop = cboMaLop.Text;
                        ck.Ten = txtTen.Text;
                        //ck.NgaySinh = dtpNgaySinh.Text;
                        ck.NgaySinh = dtpNgaySinh.Value.Date;
                        ck.TonGiao = cboTonGiao.Text;
                        ck.DanToc = cboDanToc.Text;
                        ck.DiaChi = txtDiaChi.Text;
                        ck.GT = cboGioitinh.Text;

                        busHS.addHocsinh(ck);
                        locktext();
                        hienthi();
                        MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    try
                    {
                        ck.MaHS = txtMaHS.Text;
                        ck.Ho = txtHo.Text;
                        ck.MaLop = cboMaLop.Text;
                        ck.Ten = txtTen.Text;
                        ck.NgaySinh = dtpNgaySinh.Value.Date;
                        ck.TonGiao = cboTonGiao.Text;
                        ck.DanToc = cboDanToc.Text;
                        ck.DiaChi = txtDiaChi.Text;
                        ck.GT = cboGioitinh.Text;

                        busHS.updateHocsinh(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                txtMaHS.Enabled = true;
                locktext();
                hienthi();
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtMaHS.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MaHS = txtMaHS.Text;

                    busHS.delHocsinh(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                    setnull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtMaHS.Enabled = false;
            txtTen.Focus();
        }

        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaHS.DataBindings.Clear();
                txtMaHS.DataBindings.Add("Text", dgvHocSinh.DataSource, "MaHS");
                txtHo.DataBindings.Clear();
                txtHo.DataBindings.Add("Text", dgvHocSinh.DataSource, "Ho");
                txtTen.DataBindings.Clear();
                txtTen.DataBindings.Add("Text", dgvHocSinh.DataSource, "Ten");
                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", dgvHocSinh.DataSource, "DiaChi");
                cboDanToc.DataBindings.Clear();
                cboDanToc.DataBindings.Add("Text", dgvHocSinh.DataSource, "DanToc");
                cboGioitinh.DataBindings.Clear();
                cboGioitinh.DataBindings.Add("Text", dgvHocSinh.DataSource, "GT");
                cboMaLop.DataBindings.Clear();
                cboMaLop.DataBindings.Add("Text", dgvHocSinh.DataSource, "MaLop");
                dtpNgaySinh.DataBindings.Clear();
                dtpNgaySinh.DataBindings.Add("Text", dgvHocSinh.DataSource, "NgaySinh");
            }
        }
    }
}