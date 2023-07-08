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
    public partial class frmHoatdong : Form
    {
        public frmHoatdong()
        {
            InitializeComponent();
        }

        private void frmHoatdong_Load(object sender, EventArgs e)
        {
            load_Data();
            if (Const.isadmin == 0)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                bool existsHD = db.HOATDONGs.Where(t => t.MaHD == txtMAHD.Text).Count() > 0;
                if (existsHD)
                {
                    MessageBox.Show("Hoạt động này đã tồn tại!");
                    return;
                }
                else
                {
                    HOATDONG newHD = new HOATDONG();
                    newHD.MaHD = txtMAHD.Text;
                    newHD.TenHD = txtTENHD.Text;
                    
                    db.HOATDONGs.InsertOnSubmit(newHD);
                    db.SubmitChanges();
                }
                load_Data();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                if (txtMAHD.Text == null)
                {
                    MessageBox.Show("Bạn chưa nhập mã hoat động");
                    return;
                }
                else
                {
                    HOATDONG suaHD = db.HOATDONGs.Single(t => t.MaHD == txtMAHD.Text);
                    suaHD.TenHD = txtTENHD.Text;                    
                    db.SubmitChanges();
                }
                load_Data();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                HOATDONG existsHD = db.HOATDONGs.Where(t => t.MaHD == txtMAHD.Text).FirstOrDefault();
                if (existsHD == null)
                {
                    MessageBox.Show("Hoạt động không tồn tại!");
                    return;
                }
                else
                {
                    SUKIEN existsHDSK = db.SUKIENs.Where(s => s.MaHD == txtMAHD.Text).FirstOrDefault();
                    if (existsHDSK != null)
                    {
                        MessageBox.Show("Hoạt động này đang có sự kiện diễn ra\n" +
                            "Bạn Không thể xóa hoạt động này!");
                        return;
                    }
                    else
                    {
                        db.HOATDONGs.DeleteOnSubmit(existsHD);
                        db.SubmitChanges();
                    }
                }
                load_Data();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }
        private void load_Data()
        {
            using (CLBDataContext db= new CLBDataContext())
            {
                var data = db.HOATDONGs.Select(h => new
                {
                    MAHD = h.MaHD,
                    TENHD = h.TenHD
                });
                dgvHD.DataSource = data;
            }    
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvHD.SelectedCells[0].OwningRow.Cells["MaHD"].Value;
            txtMAHD.Text = data.ToString();
            var data1 = dgvHD.SelectedCells[0].OwningRow.Cells["TenHD"].Value;
            txtTENHD.Text = data1.ToString();
        }
    }
}
