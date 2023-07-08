
namespace WindowsFormsApp1
{
    partial class frmXuatDS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatDS));
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDSDK = new System.Windows.Forms.DataGridView();
            this.TenSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInDS = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pbThoat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(331, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 30);
            this.label8.TabIndex = 29;
            this.label8.Text = "In danh sách đăng ký";
            // 
            // dgvDSDK
            // 
            this.dgvDSDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSK,
            this.MaTV,
            this.TenTV,
            this.NgayBD});
            this.dgvDSDK.Location = new System.Drawing.Point(7, 89);
            this.dgvDSDK.Name = "dgvDSDK";
            this.dgvDSDK.RowHeadersWidth = 51;
            this.dgvDSDK.RowTemplate.Height = 24;
            this.dgvDSDK.Size = new System.Drawing.Size(907, 217);
            this.dgvDSDK.TabIndex = 49;
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
            // btnInDS
            // 
            this.btnInDS.BackColor = System.Drawing.Color.LightGreen;
            this.btnInDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnInDS.Image = ((System.Drawing.Image)(resources.GetObject("btnInDS.Image")));
            this.btnInDS.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInDS.Location = new System.Drawing.Point(293, 362);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(353, 189);
            this.btnInDS.TabIndex = 50;
            this.btnInDS.Text = "In danh sách ra file Excel";
            this.btnInDS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInDS.UseVisualStyleBackColor = false;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // pbThoat
            // 
            this.pbThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbThoat.Image = ((System.Drawing.Image)(resources.GetObject("pbThoat.Image")));
            this.pbThoat.Location = new System.Drawing.Point(25, 12);
            this.pbThoat.Name = "pbThoat";
            this.pbThoat.Size = new System.Drawing.Size(60, 46);
            this.pbThoat.TabIndex = 51;
            this.pbThoat.TabStop = false;
            this.pbThoat.Click += new System.EventHandler(this.pbThoat_Click);
            // 
            // frmXuatDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(926, 619);
            this.Controls.Add(this.pbThoat);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.dgvDSDK);
            this.Controls.Add(this.label8);
            this.Name = "frmXuatDS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InDS";
            this.Load += new System.EventHandler(this.frmXuatDS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDSDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pbThoat;
    }
}