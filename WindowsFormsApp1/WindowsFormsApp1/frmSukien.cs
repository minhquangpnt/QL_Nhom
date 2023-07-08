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
    public partial class frmSukien : Form
    {
        public frmSukien()
        {
            InitializeComponent();
        }

        private void frmSukien_Load(object sender, EventArgs e)
        {
            load_CBOHD();
            load_DataSK();
            if (Const.isadmin == 0)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }
        private void cboHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_DataSK();
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                bool existsSK = db.SUKIENs.Where(t => t.MaSK == txtMASK.Text).Count() > 0;
                if (existsSK)
                {
                    MessageBox.Show("Sự kiện này đã tồn tại!");
                    return;
                }
                else
                {
                    SUKIEN newSK = new SUKIEN();
                    newSK.MaSK = txtMASK.Text;
                    newSK.TenSK = txtTENSK.Text;
                    newSK.DiaDiem = txtDD.Text;
                    newSK.NgayBD = dtpNgayBD.Value.Date;
                    newSK.MaHD = cboHD.SelectedValue.ToString();

                    db.SUKIENs.InsertOnSubmit(newSK);
                    db.SubmitChanges();
                }
                load_DataSK();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                if (txtMASK.Text == null)
                {
                    MessageBox.Show("Bạn chưa nhập mã sự kiện");
                    return;
                }
                else
                {
                    SUKIEN suaSK = db.SUKIENs.Single(t => t.MaSK == txtMASK.Text);
                    suaSK.TenSK = txtTENSK.Text;
                    suaSK.DiaDiem = txtDD.Text;
                    suaSK.NgayBD = dtpNgayBD.Value.Date;
                    
                    db.SubmitChanges();
                }
                load_DataSK();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                SUKIEN existsSK = db.SUKIENs.Where(t => t.MaSK == txtMASK.Text).FirstOrDefault();
                if (existsSK == null)
                {
                    MessageBox.Show("Sự kiện không tồn tại!");
                    return;
                }
                else
                {
                    DANGKY existsDKSK = db.DANGKies.Where(d => d.MaSK == txtMASK.Text).FirstOrDefault();
                    if (existsDKSK != null)
                    {
                        MessageBox.Show("Sự kiện này đang diễn ra\n" +
                            "Bạn Không thể xóa hoạt động này!");
                        return;
                    }
                    else
                    {
                        db.SUKIENs.DeleteOnSubmit(existsSK);
                        db.SubmitChanges();
                    }
                }
                load_DataSK();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }
        private void load_CBOHD()
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                var data = db.HOATDONGs.Select(h => h);
                cboHD.DataSource = data;
                cboHD.DisplayMember = "TenHD";
                cboHD.ValueMember = "MaHD";
            }
        }
        private void load_DataSK()
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                var data = db.SUKIENs.Where(s => s.MaHD == cboHD.SelectedValue.ToString())
                    .Select(s => new
                    {
                        MASK = s.MaSK,
                        TENSK = s.TenSK,
                        DIADIEM = s.DiaDiem,
                        NGAYBD = s.NgayBD
                    });
                dgvSK.DataSource = data;
            }
        }

        private void dgvSK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvSK.SelectedCells[0].OwningRow.Cells["MaSK"].Value;
            txtMASK.Text = data.ToString();
            var data1 = dgvSK.SelectedCells[0].OwningRow.Cells["TenSK"].Value;
            txtTENSK.Text = data1.ToString();
            var data3 = dgvSK.SelectedCells[0].OwningRow.Cells["DiaDiem"].Value;
            txtDD.Text = data3.ToString();
        }
    }
}
