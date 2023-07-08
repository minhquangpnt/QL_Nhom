using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection();
        string ketNoi = "Data Source=LAPTOP-SDLMECNT\\SQLEXPRESS;Initial Catalog=QLHOATDONG;Integrated Security=True";
        SqlCommand cmd;
        public frmLogin()
        {
            conn = new SqlConnection(ketNoi);
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "loginSP";
                cmd.Parameters.AddWithValue("@username", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                cmd.Connection = conn;
                string UserName = txtUser.Text;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                if (code == 0)
                {
                    MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmMain main = new frmMain();
                    Const.isadmin = code;
                    main.ShowDialog();

                }
                else if (code == 1)
                {
                    MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmMain main = new frmMain();
                    Const.isadmin = code;
                    main.ShowDialog();
                }
                else if (code == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Text = "";
                    txtUser.Text = "";
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Text = "";
                    txtUser.Text = "";
                    txtPassword.Focus();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
