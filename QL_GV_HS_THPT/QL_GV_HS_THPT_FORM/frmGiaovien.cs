using System;
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
    public partial class frmGiaovien : Form
    {
        private bool _dangTimMa = false;
        private bool _dangTimHo = false;
        private bool _dangTimTen = false;
        private bool _dangTimMaMon = false;

        private BUS_tblGiaovien busGV = new BUS_tblGiaovien();
        private EC_tblGiaovien ck = new EC_tblGiaovien();
        KetNoiDB cn = new KetNoiDB();
        private bool themmoi;
        public frmGiaovien()
        {
            InitializeComponent();
        }
        public void setnull()
        {
            txtMaGV.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtLuong.Text = "";
            txtSDT.Text = "";

        }
        public void locktext()
        {
            txtMaGV.Enabled = false;
            txtHo.Enabled = false;
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            cboMaMon.Enabled = false;
            cboGioiTinh.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtLuong.Enabled = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLamMoiDuLieu.Enabled = true;
        }
        public void un_locktext()
        {
            txtMaGV.Enabled = true;
            txtHo.Enabled = true;
            txtTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            cboMaMon.Enabled = true;
            cboGioiTinh.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtLuong.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoiDuLieu.Enabled = false;
        }
        public void hienthi()
        {
            string sql = "SELECT  *  FROM tblGiaoVien";
            dgvGiaoVien.DataSource = cn.getDatatable(sql);

            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void grbThongTinGiaoVien_Enter(object sender, EventArgs e)
        {

        }

        private void frmGiaovien_Load(object sender, EventArgs e)
        {
            DataTable tbl = busGV.getAllgiaovien();
            dgvGiaoVien.DataSource = tbl;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtMaGV.Enabled = true;
            txtMaGV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text != "")
            {
                if (themmoi == true)
                {
                    try
                    {
                        ck.MaGV = txtMaGV.Text;
                        ck.Ho = txtHo.Text;
                        ck.Ten = txtTen.Text;
                        ck.NgaySinh = dtpNgaySinh.Value.Date;
                        ck.MaMon = cboMaMon.Text;
                        ck.SDT = txtSDT.Text;
                        ck.DiaChi = txtDiaChi.Text;
                        ck.GT = cboGioiTinh.Text;
                        ck.Luong = txtLuong.Text;

                        busGV.addHocsinh(ck);
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
                        ck.MaGV = txtMaGV.Text;
                        ck.Ho = txtHo.Text;
                        ck.Ten = txtTen.Text;
                        ck.NgaySinh = dtpNgaySinh.Value.Date;
                        ck.MaMon = cboMaMon.Text;
                        ck.SDT = txtSDT.Text;
                        ck.DiaChi = txtDiaChi.Text;
                        ck.GT = cboGioiTinh.Text;
                        ck.Luong = txtLuong.Text;

                        busGV.updateHocsinh(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                txtMaGV.Enabled = true;
                locktext();
                hienthi();
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtMaGV.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MaGV = txtMaGV.Text;

                    busGV.delHocsinh(ck);
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
            txtMaGV.Enabled = false;
            txtTen.Focus();
        }

        private void dgvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaGV.DataBindings.Clear();
                txtMaGV.DataBindings.Add("Text", dgvGiaoVien.DataSource, "MaGV");
                txtHo.DataBindings.Clear();
                txtHo.DataBindings.Add("Text", dgvGiaoVien.DataSource, "Ho");
                txtTen.DataBindings.Clear();
                txtTen.DataBindings.Add("Text", dgvGiaoVien.DataSource, "Ten");
                txtDiaChi.DataBindings.Clear();
                txtDiaChi.DataBindings.Add("Text", dgvGiaoVien.DataSource, "DiaChi");
                txtSDT.DataBindings.Clear();
                txtSDT.DataBindings.Add("Text", dgvGiaoVien.DataSource, "SDT");
                txtLuong.DataBindings.Clear();
                txtLuong.DataBindings.Add("Text", dgvGiaoVien.DataSource, "Luong");
                cboMaMon.DataBindings.Clear();
                cboMaMon.DataBindings.Add("Text", dgvGiaoVien.DataSource, "MaMon");
                dtpNgaySinh.DataBindings.Clear();
                dtpNgaySinh.DataBindings.Add("Text", dgvGiaoVien.DataSource, "NgaySinh");
                cboGioiTinh.DataBindings.Clear();
                cboGioiTinh.DataBindings.Add("Text", dgvGiaoVien.DataSource, "GT");
            }
        }

        private void txtTimMaHS_Click(object sender, EventArgs e)
        {

            if (_dangTimMa)
            {
                txtTimMaHS.SelectionStart = txtTimMaHS.Text.Length;
            }
            else
            {
                txtTimMaHS.SelectAll();
            }
        }

        private void txtTimMaHS_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMaHS.Text != "") _dangTimMa = true;
            else _dangTimMa = false;
            string dieukien = "where MaHS like N'%" + txtTimMaHS.Text + "%'";
            if (_dangTimHo) dieukien += "AND Ho like N'%" + txtHo.Text + "%'";
            if (_dangTimTen) dieukien += "AND Ten like N'%" + txtTen.Text + "%'";
          
            DataTable tbl = busGV.getgiaovien(dieukien);
            dgvGiaoVien.DataSource = tbl;
        }
    }
}