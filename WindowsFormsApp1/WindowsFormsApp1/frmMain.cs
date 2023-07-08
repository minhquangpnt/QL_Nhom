using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThanhvien ftv = new frmThanhvien();
            ftv.ShowDialog();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoatdong fhd = new frmHoatdong();
            fhd.ShowDialog();
        }

        private void btnSK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSukien fsk = new frmSukien();
            fsk.ShowDialog();
        }

        private void btnDSDK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDSDK fdk = new frmDSDK();
            fdk.ShowDialog();
        }

        private void pbThoat_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Hide();
                frmLogin lg = new frmLogin();
                lg.ShowDialog();
            }
              
        }
    }
}
