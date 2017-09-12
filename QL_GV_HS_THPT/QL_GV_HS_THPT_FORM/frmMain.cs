using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GV_HS_THPT_FORM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            

        }

        private void nhậpHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

       

        private void btnHocsinh_Click(object sender, EventArgs e)
        {
            frmHocsinh frmHS = new frmHocsinh();
            
            frmHS.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            frmGiaovien frmGV = new frmGiaovien();

            frmGV.Show();
        }

        private void đăngKýGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnTkb_Click(object sender, EventArgs e)
        {
            frmDKgiangday frmGV = new frmDKgiangday();

            frmGV.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaikhoan frmGV = new frmTaikhoan();

            frmGV.Show();
        }
    }
}
