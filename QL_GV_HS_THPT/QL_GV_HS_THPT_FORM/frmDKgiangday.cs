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
    public partial class frmDKgiangday : Form
    {
        bool themmoi;
        BUS_tblGiangDay busHS = new BUS_tblGiangDay();
        EC_tblGiangday ck = new EC_tblGiangday();
        BUS_tblGiangDay gd = new BUS_tblGiangDay();
        KetNoiDB cn = new KetNoiDB();
        public frmDKgiangday()
        {
            InitializeComponent();
        }
        public void danhsachmagv()
        {
            cboMaGV.DataSource = gd.getMagv();
            cboMaGV.ValueMember = "MaGV";
        }
        public void danhsachmalop()
        {
            cboMaLop.DataSource = gd.getMalop();
            //cboMaLop.DisplayMember = "MaGV";
            cboMaLop.ValueMember = "MaLop";

        }
        public void setnull()
        {
            txtTiet.Text = "";
        }
        public void locktext()
        {
            cboMaGV.Enabled = false;
            cboMaLop.Enabled = false;
            txtTiet.Enabled = false;
            dtpNgayDay.Enabled = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLamMoiDuLieu.Enabled = true;
        }
        public void un_locktext()
        {
            cboMaLop.Enabled = true;
            cboMaGV.Enabled = true;
            txtTiet.Enabled = true;
            dtpNgayDay.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoiDuLieu.Enabled = false;
        }
        public void hienthi()
        {
            string sql = "SELECT  *  FROM tblGiangday";
            dgvHocSinh.DataSource = cn.getDatatable(sql);

            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            cboMaGV.Enabled = true;
            cboMaGV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMaGV.Text != "")
            {
                if (themmoi == true)
                {
                    try
                    {
                        ck.MaGV = cboMaGV.Text;
                        ck.MaLop = cboMaLop.Text;
                        ck.Tietday = txtTiet.Text;
                        ck.Ngayday = dtpNgayDay.Value.Date;
                        //ck.NgaySinh = dtpNgaySinh.Text;


                        busHS.addGiangday(ck);
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
                        ck.MaGV = cboMaGV.Text;
                        ck.MaLop = cboMaLop.Text;
                        ck.Tietday = txtTiet.Text;
                        ck.Ngayday = dtpNgayDay.Value.Date;

                        busHS.updateGiangday(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                cboMaLop.Enabled = true;
                locktext();
                hienthi();
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                cboMaLop.Focus();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            cboMaGV.Enabled = false;
            cboMaLop.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MaGV = cboMaGV.Text;

                    busHS.delGiangday(ck);
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

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cboMaGV.DataBindings.Clear();
                cboMaGV.DataBindings.Add("Text", dgvHocSinh.DataSource, "MaGV");
                cboMaLop.DataBindings.Clear();
                cboMaLop.DataBindings.Add("Text", dgvHocSinh.DataSource, "MaLop");
                txtTiet.DataBindings.Clear();
                txtTiet.DataBindings.Add("Text", dgvHocSinh.DataSource, "Tietday");
                dtpNgayDay.DataBindings.Clear();
                dtpNgayDay.DataBindings.Add("Text", dgvHocSinh.DataSource, "NgayDay");

            }
        }

        private void cboMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbThongTinHocSinh_Enter(object sender, EventArgs e)
        {

        }

        private void frmDKgiangday_Load(object sender, EventArgs e)
        {
            danhsachmagv();
            danhsachmalop();
        }
    }
}