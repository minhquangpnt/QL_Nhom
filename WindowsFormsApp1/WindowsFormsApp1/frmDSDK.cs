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
    public partial class frmDSDK : Form
    {
        public frmDSDK()
        {
            InitializeComponent();
        }

        private void frmDSDK_Load(object sender, EventArgs e)
        {
            load_CBOSK();
            load_Data();
            if (Const.isadmin == 0)
            {
                INDS.Enabled = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            string mtv = txtMATV.Text;
            using (CLBDataContext db= new CLBDataContext())
            {
                if(mtv==null)
                {
                    load_Data();
                }
                else
                {
                    var data = db.DANGKies.Where(d => d.MaTV == mtv).Select(d => new
                    {
                        TENSK = d.SUKIEN.TenSK,
                        MATV = d.THANHVIEN.MaTV,
                        TENTV = d.THANHVIEN.TenTV,
                        NGAYBD = d.SUKIEN.NgayBD
                    });
                    dgvDSDK.DataSource = data;
                }
                
            }    
        }
        private void btnDK_Click(object sender, EventArgs e)
        {
            string mtv = txtMATV.Text;
            using (CLBDataContext db= new CLBDataContext())
            {
                if(mtv==null)
                {
                    MessageBox.Show("Bạn chưa nhập mã thành viên");
                    return;
                }
                else
                {
                    bool existsTV = db.THANHVIENs.Where(t => t.MaTV == mtv).Count() > 0;
                    bool existTV_DK = db.DANGKies.Where(d=>d.MaTV== mtv && d.MaSK==cboSK.SelectedValue.ToString()).Count() > 0;
                    bool ktDK = db.DANGKies.Where(d => d.MaTV == mtv && d.SUKIEN.NgayBD == dtpNgayBD.Value.Date).Count() == 1;
                    bool ktNgayBD = db.SUKIENs.Where(s => s.NgayBD.Value.Date < DateTime.Today 
                                                        && s.MaSK==cboSK.SelectedValue.ToString()).Count() > 0;
                    if (!existsTV)
                    {
                        MessageBox.Show("Thành viên không tồn tại!");
                        return;
                    }
                    if(existTV_DK)
                    {
                        MessageBox.Show("Thành viên này đã đăng ký rồi!");
                        return;
                    }
                    if (ktNgayBD)
                    {
                        MessageBox.Show("Sự kiện này đã diễn ra\n Bạn không thể đăng ký");
                        return;
                    }
                    if (ktDK)
                    {
                        MessageBox.Show("Bạn không thể đăng ký tham gia 2 sự kiện trong cùng 1 ngày");
                        return;
                    }
                   
                    
                        var xacnhan = MessageBox.Show("Bạn có muốn đăng ký sự kiện này?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                        if (xacnhan == DialogResult.Yes)
                        {
                            DANGKY newDK = new DANGKY();
                            newDK.MaSK = cboSK.SelectedValue.ToString();
                            newDK.MaTV = txtMATV.Text;
                            db.DANGKies.InsertOnSubmit(newDK);
                            db.SubmitChanges();
                        }
                    
                                      
                }
                load_Data();
            }    
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            string mtv = txtMATV.Text;
            using (CLBDataContext db= new CLBDataContext())
            {                
                if(mtv==null)
                {
                    MessageBox.Show("Bạn chưa nhập mã thành viên");
                    return;
                }
                DANGKY existsTVDK = db.DANGKies.Where(d => d.MaTV == mtv && d.MaSK == cboSK.SelectedValue.ToString()).FirstOrDefault();
                if(existsTVDK==null)
                {
                    MessageBox.Show("Thông tin không hợp lệ");
                    return;
                }
                else
                {
                    var xacnhan = MessageBox.Show("Bạn có hủy đăng ký sự kiện này!","Xác nhận", MessageBoxButtons.YesNo);
                    if(xacnhan==DialogResult.Yes)
                    {
                        db.DANGKies.DeleteOnSubmit(existsTVDK);
                    }                     
                }                
                db.SubmitChanges();
                load_Data();
            }    
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }

        
        private void load_CBOSK()
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                var data = db.SUKIENs.Select(s => s);
                cboSK.DataSource = data;
                cboSK.DisplayMember = "TenSK";
                cboSK.ValueMember = "MaSK";
            }
        }
        private void load_Data()
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                var data = from d in db.DANGKies
                           from s in db.SUKIENs
                           from t in db.THANHVIENs
                           where d.MaSK == s.MaSK 
                           && d.MaTV == t.MaTV 
                           && d.MaSK==cboSK.SelectedValue.ToString() 
                           
                           select new
                           {
                               TENSK = s.TenSK,
                               MaTV = t.MaTV,
                               TENTV = t.TenTV,
                               NGAYBD = s.NgayBD
                           };
                dgvDSDK.DataSource = data;
            }    
        }
        private void load_Data_Ngay()
        {
            using (CLBDataContext db = new CLBDataContext())
            {
                var data = from d in db.DANGKies
                           from s in db.SUKIENs
                           from t in db.THANHVIENs
                           where d.MaSK == s.MaSK
                                    && d.MaTV == t.MaTV
                                    && s.NgayBD == dtpNgayBD.Value.Date
                           select new
                           {
                               TENSK = s.TenSK,
                               MaTV  = t.MaTV,
                               TENTV = t.TenTV,
                               NGAYBD = s.NgayBD
                           };
                dgvDSDK.DataSource = data;
            }
        }
        private void cboSK_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_Data();
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            load_Data_Ngay();            
        }

        private void INDS_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmXuatDS fdk = new frmXuatDS();
            fdk.ShowDialog();
        }
    }
}
