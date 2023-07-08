using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmXuatDS : Form
    {
        public frmXuatDS()
        {
            InitializeComponent();
        }

        private void frmXuatDS_Load(object sender, EventArgs e)
        {
            load_Data();
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
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Danh sách đăng ký";

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        private void btnInDS_Click(object sender, EventArgs e)
        {
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ToExcel(dgvDSDK, saveFileDialog1.FileName);
                }
            }
        }

        private void pbThoat_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Bạn có muốn thoát in danh sách không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Hide();
                frmDSDK dk = new frmDSDK();
                dk.ShowDialog();
            }
        }
    }
}
