
namespace WindowsFormsApp1
{
    partial class frmThanhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhvien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMATV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDIACHI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTENTV = new System.Windows.Forms.TextBox();
            this.dtpNGSINH = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.MaTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.dgvTV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(782, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thành viên";
            // 
            // dgvTV
            // 
            this.dgvTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTV,
            this.TenTV,
            this.Column3,
            this.DiaChiTV});
            this.dgvTV.Location = new System.Drawing.Point(0, 32);
            this.dgvTV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTV.Name = "dgvTV";
            this.dgvTV.RowHeadersWidth = 51;
            this.dgvTV.RowTemplate.Height = 24;
            this.dgvTV.Size = new System.Drawing.Size(782, 169);
            this.dgvTV.TabIndex = 0;
            this.dgvTV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã TV";
            // 
            // txtMATV
            // 
            this.txtMATV.Location = new System.Drawing.Point(85, 232);
            this.txtMATV.Name = "txtMATV";
            this.txtMATV.Size = new System.Drawing.Size(243, 27);
            this.txtMATV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên TV";
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.Location = new System.Drawing.Point(527, 292);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(243, 27);
            this.txtDIACHI.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(425, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa Chỉ";
            // 
            // txtTENTV
            // 
            this.txtTENTV.Location = new System.Drawing.Point(85, 288);
            this.txtTENTV.Name = "txtTENTV";
            this.txtTENTV.Size = new System.Drawing.Size(243, 27);
            this.txtTENTV.TabIndex = 2;
            // 
            // dtpNGSINH
            // 
            this.dtpNGSINH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNGSINH.Location = new System.Drawing.Point(527, 230);
            this.dtpNGSINH.Name = "dtpNGSINH";
            this.dtpNGSINH.Size = new System.Drawing.Size(243, 27);
            this.dtpNGSINH.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(425, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Sinh";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(16, 366);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 40);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(156, 366);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(293, 366);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Location = new System.Drawing.Point(670, 366);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 40);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(429, 366);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // MaTV
            // 
            this.MaTV.DataPropertyName = "MATV";
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
            this.TenTV.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NGSINH";
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // DiaChiTV
            // 
            this.DiaChiTV.DataPropertyName = "DIACHI";
            this.DiaChiTV.HeaderText = "Địa Chỉ";
            this.DiaChiTV.MinimumWidth = 6;
            this.DiaChiTV.Name = "DiaChiTV";
            this.DiaChiTV.Width = 225;
            // 
            // frmThanhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 426);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtpNGSINH);
            this.Controls.Add(this.txtDIACHI);
            this.Controls.Add(this.txtTENTV);
            this.Controls.Add(this.txtMATV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThanhvien";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThanhvien";
            this.Load += new System.EventHandler(this.frmThanhvien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMATV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDIACHI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTENTV;
        private System.Windows.Forms.DateTimePicker dtpNGSINH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiTV;
    }
}