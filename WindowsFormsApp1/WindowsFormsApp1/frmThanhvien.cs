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
    public partial class frmThanhvien : Form
    {
        public frmThanhvien()
        {
            InitializeComponent();
        }
        
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }

        private void frmThanhvien_Load(object sender, EventArgs e)
        {
            load_Data();
            if(Const.isadmin==0)
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            using (CLBDataContext db= new CLBDataContext())
            {
                if (txtMATV.Text == null)
                {
                    load_Data();
                }
                else
                {
                    var timTV = db.THANHVIENs.Where(t => t.MaTV == txtMATV.Text).Select(t => new {
                        MATV = t.MaTV,
                        TENTV = t.TenTV,
                        NGSINH = t.NgaySinhTV,
                        DIACHI = t.DiaChiTV
                    });
                    dgvTV.DataSource = timTV;
                }
                
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                bool existsTV = db.THANHVIENs.Where(t => t.MaTV == txtMATV.Text).Count() > 0;
                if(existsTV)
                {
                    MessageBox.Show("Thành viên này đã tồn tại!");
                    return;
                }
                else
                {
                    THANHVIEN newTV = new THANHVIEN();
                    newTV.MaTV = txtMATV.Text;
                    newTV.TenTV = txtTENTV.Text;
                    newTV.DiaChiTV= txtDIACHI.Text;
                    newTV.NgaySinhTV = dtpNGSINH.Value.Date;
                    db.THANHVIENs.InsertOnSubmit(newTV);
                    db.SubmitChanges();
                }
                load_Data();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                if(txtMATV.Text==null)
                {
                    MessageBox.Show("Bạn chưa nhập mã thành viên");
                    return;
                }
                else
                {
                    THANHVIEN suaTV = db.THANHVIENs.Single(t => t.MaTV == txtMATV.Text);
                    suaTV.TenTV = txtTENTV.Text;
                    suaTV.DiaChiTV = txtDIACHI.Text;
                    suaTV.NgaySinhTV = dtpNGSINH.Value.Date;
                    db.SubmitChanges();
                }
                load_Data();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                THANHVIEN existsTV = db.THANHVIENs.Where(t => t.MaTV == txtMATV.Text).FirstOrDefault();
                if (existsTV==null)
                {
                    MessageBox.Show("Thành viên không tồn tại!");
                    return;
                }
                else
                {
                    DANGKY existsTVDK = db.DANGKies.Where(d => d.MaTV == txtMATV.Text).FirstOrDefault();
                    if(existsTVDK!=null)
                    {
                        MessageBox.Show("Thành viên đang có dăng ký sự kiện\n" +
                            "Bạn Không thể xóa thành viên này!");
                        return;
                    }
                    else
                    {
                        db.THANHVIENs.DeleteOnSubmit(existsTV);
                        db.SubmitChanges();
                    }
                }
                load_Data();
            }
        }
        private void load_Data()
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                var data = db.THANHVIENs.Select(t => new { 
                    MATV = t.MaTV,
                    TENTV = t.TenTV,
                    NGSINH= t.NgaySinhTV,
                    DIACHI= t.DiaChiTV
                });
                dgvTV.DataSource = data;
            }
            
        }

        private void dgvTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvTV.SelectedCells[0].OwningRow.Cells["MaTV"].Value;
            txtMATV.Text = data.ToString();
            var data1 = dgvTV.SelectedCells[0].OwningRow.Cells["TenTV"].Value;
            txtTENTV.Text = data1.ToString();
            var data2 = dgvTV.SelectedCells[0].OwningRow.Cells["DiaChiTV"].Value;
            txtDIACHI.Text = data2.ToString();
        }
    }
}
