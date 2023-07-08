
namespace WindowsFormsApp1
{
    partial class frmSukien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSukien));
            this.label1 = new System.Windows.Forms.Label();
            this.cboHD = new System.Windows.Forms.ComboBox();
            this.dgvSK = new System.Windows.Forms.DataGridView();
            this.MaSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMASK = new System.Windows.Forms.TextBox();
            this.txtTENSK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDD = new System.Windows.Forms.TextBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoạt động";
            // 
            // cboHD
            // 
            this.cboHD.FormattingEnabled = true;
            this.cboHD.Location = new System.Drawing.Point(117, 22);
            this.cboHD.Name = "cboHD";
            this.cboHD.Size = new System.Drawing.Size(315, 28);
            this.cboHD.TabIndex = 1;
            this.cboHD.SelectedIndexChanged += new System.EventHandler(this.cboHD_SelectedIndexChanged);
            // 
            // dgvSK
            // 
            this.dgvSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSK,
            this.TenSK,
            this.DiaDiem,
            this.NgayBD});
            this.dgvSK.Location = new System.Drawing.Point(0, 74);
            this.dgvSK.Name = "dgvSK";
            this.dgvSK.RowHeadersWidth = 51;
            this.dgvSK.RowTemplate.Height = 24;
            this.dgvSK.Size = new System.Drawing.Size(891, 178);
            this.dgvSK.TabIndex = 2;
            this.dgvSK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSK_CellClick);
            // 
            // MaSK
            // 
            this.MaSK.DataPropertyName = "MASK";
            this.MaSK.HeaderText = "Mã sự kiện";
            this.MaSK.MinimumWidth = 6;
            this.MaSK.Name = "MaSK";
            this.MaSK.Width = 125;
            // 
            // TenSK
            // 
            this.TenSK.DataPropertyName = "TENSK";
            this.TenSK.HeaderText = "Tên sự kiện";
            this.TenSK.MinimumWidth = 6;
            this.TenSK.Name = "TenSK";
            this.TenSK.Width = 280;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DIADIEM";
            this.DiaDiem.HeaderText = "Địa Điểm";
            this.DiaDiem.MinimumWidth = 6;
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.Width = 280;
            // 
            // NgayBD
            // 
            this.NgayBD.DataPropertyName = "NGAYBD";
            this.NgayBD.HeaderText = "Ngày bắt đầu";
            this.NgayBD.MinimumWidth = 6;
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sự kiện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sự kiện";
            // 
            // txtMASK
            // 
            this.txtMASK.Location = new System.Drawing.Point(117, 294);
            this.txtMASK.Name = "txtMASK";
            this.txtMASK.Size = new System.Drawing.Size(315, 27);
            this.txtMASK.TabIndex = 3;
            // 
            // txtTENSK
            // 
            this.txtTENSK.Location = new System.Drawing.Point(117, 338);
            this.txtTENSK.Name = "txtTENSK";
            this.txtTENSK.Size = new System.Drawing.Size(317, 27);
            this.txtTENSK.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(460, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày BD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(460, 301);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa điểm";
            // 
            // txtDD
            // 
            this.txtDD.Location = new System.Drawing.Point(552, 298);
            this.txtDD.Name = "txtDD";
            this.txtDD.Size = new System.Drawing.Size(317, 27);
            this.txtDD.TabIndex = 3;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(552, 340);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(317, 27);
            this.dtpNgayBD.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(46, 416);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(234, 416);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 40);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(416, 416);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(769, 416);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 40);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmSukien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(892, 483);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.txtDD);
            this.Controls.Add(this.txtTENSK);
            this.Controls.Add(this.txtMASK);
            this.Controls.Add(this.dgvSK);
            this.Controls.Add(this.cboHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSukien";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSukien";
            this.Load += new System.EventHandler(this.frmSukien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHD;
        private System.Windows.Forms.DataGridView dgvSK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMASK;
        private System.Windows.Forms.TextBox txtTENSK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDD;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
    }
}