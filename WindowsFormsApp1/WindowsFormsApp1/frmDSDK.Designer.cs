
namespace WindowsFormsApp1
{
    partial class frmDSDK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSDK));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSDK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMATV = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnDK = new System.Windows.Forms.Button();
            this.INDS = new System.Windows.Forms.Button();
            this.TenSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.dgvDSDK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đăng ký";
            // 
            // dgvDSDK
            // 
            this.dgvDSDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSK,
            this.MaTV,
            this.TenTV,
            this.NgayBD});
            this.dgvDSDK.Location = new System.Drawing.Point(0, 26);
            this.dgvDSDK.Name = "dgvDSDK";
            this.dgvDSDK.RowHeadersWidth = 51;
            this.dgvDSDK.RowTemplate.Height = 24;
            this.dgvDSDK.Size = new System.Drawing.Size(898, 217);
            this.dgvDSDK.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sự kiện";
            // 
            // cboSK
            // 
            this.cboSK.FormattingEnabled = true;
            this.cboSK.Location = new System.Drawing.Point(95, 260);
            this.cboSK.Name = "cboSK";
            this.cboSK.Size = new System.Drawing.Size(300, 28);
            this.cboSK.TabIndex = 2;
            this.cboSK.SelectedIndexChanged += new System.EventHandler(this.cboSK_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(521, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày BD";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(639, 261);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(174, 27);
            this.dtpNgayBD.TabIndex = 3;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã TV";
            // 
            // txtMATV
            // 
            this.txtMATV.Location = new System.Drawing.Point(95, 322);
            this.txtMATV.Name = "txtMATV";
            this.txtMATV.Size = new System.Drawing.Size(300, 27);
            this.txtMATV.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(30, 476);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(150, 40);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(478, 476);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 40);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy đăng ký";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(713, 476);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 40);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(259, 476);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(150, 40);
            this.btnDK.TabIndex = 6;
            this.btnDK.Text = "Đăng ký";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // INDS
            // 
            this.INDS.Image = ((System.Drawing.Image)(resources.GetObject("INDS.Image")));
            this.INDS.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.INDS.Location = new System.Drawing.Point(639, 322);
            this.INDS.Name = "INDS";
            this.INDS.Size = new System.Drawing.Size(174, 102);
            this.INDS.TabIndex = 7;
            this.INDS.Text = "IN Danh Sách";
            this.INDS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.INDS.UseVisualStyleBackColor = true;
            this.INDS.Click += new System.EventHandler(this.INDS_Click_1);
            // 
            // TenSK
            // 
            this.TenSK.DataPropertyName = "TENSK";
            this.TenSK.HeaderText = "Tên sự kiện";
            this.TenSK.MinimumWidth = 6;
            this.TenSK.Name = "TenSK";
            this.TenSK.Width = 350;
            // 
            // MaTV
            // 
            this.MaTV.DataPropertyName = "MaTV";
            this.MaTV.HeaderText = "Mã TV";
            this.MaTV.MinimumWidth = 6;
            this.MaTV.Name = "MaTV";
            this.MaTV.Width = 125;
            // 
            // TenTV
            // 
            this.TenTV.DataPropertyName = "TENTV";
            this.TenTV.HeaderText = "Tên TV";
            this.TenTV.MinimumWidth = 6;
            this.TenTV.Name = "TenTV";
            this.TenTV.Width = 250;
            // 
            // NgayBD
            // 
            this.NgayBD.DataPropertyName = "NGAYBD";
            this.NgayBD.HeaderText = "Ngày BD";
            this.NgayBD.MinimumWidth = 6;
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.Width = 125;
            // 
            // frmDSDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 542);
            this.Controls.Add(this.INDS);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtMATV);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.cboSK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDSDK";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDSDK";
            this.Load += new System.EventHandler(this.frmDSDK_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMATV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Button INDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
    }
}