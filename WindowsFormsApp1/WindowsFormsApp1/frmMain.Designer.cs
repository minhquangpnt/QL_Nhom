
namespace WindowsFormsApp1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDSDK = new System.Windows.Forms.Button();
            this.btnTV = new System.Windows.Forms.Button();
            this.btnSK = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.pbThoat = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pbThoat);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 643);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ NHÓM /CLB";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btnDSDK);
            this.groupBox1.Controls.Add(this.btnTV);
            this.groupBox1.Controls.Add(this.btnSK);
            this.groupBox1.Controls.Add(this.btnHD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(60, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 372);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnDSDK
            // 
            this.btnDSDK.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDSDK.Image = ((System.Drawing.Image)(resources.GetObject("btnDSDK.Image")));
            this.btnDSDK.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDSDK.Location = new System.Drawing.Point(705, 68);
            this.btnDSDK.Name = "btnDSDK";
            this.btnDSDK.Size = new System.Drawing.Size(159, 236);
            this.btnDSDK.TabIndex = 2;
            this.btnDSDK.Text = "Đăng ký";
            this.btnDSDK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDSDK.UseVisualStyleBackColor = false;
            this.btnDSDK.Click += new System.EventHandler(this.btnDSDK_Click);
            // 
            // btnTV
            // 
            this.btnTV.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTV.Image = ((System.Drawing.Image)(resources.GetObject("btnTV.Image")));
            this.btnTV.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTV.Location = new System.Drawing.Point(35, 68);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(163, 236);
            this.btnTV.TabIndex = 3;
            this.btnTV.Text = "Xem Thông tin Thành viên";
            this.btnTV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTV.UseVisualStyleBackColor = false;
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // btnSK
            // 
            this.btnSK.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSK.Image = ((System.Drawing.Image)(resources.GetObject("btnSK.Image")));
            this.btnSK.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSK.Location = new System.Drawing.Point(469, 68);
            this.btnSK.Name = "btnSK";
            this.btnSK.Size = new System.Drawing.Size(179, 236);
            this.btnSK.TabIndex = 4;
            this.btnSK.Text = "Sự Kiện";
            this.btnSK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSK.UseVisualStyleBackColor = false;
            this.btnSK.Click += new System.EventHandler(this.btnSK_Click);
            // 
            // btnHD
            // 
            this.btnHD.BackColor = System.Drawing.Color.PaleGreen;
            this.btnHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHD.Image = ((System.Drawing.Image)(resources.GetObject("btnHD.Image")));
            this.btnHD.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHD.Location = new System.Drawing.Point(247, 68);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(171, 236);
            this.btnHD.TabIndex = 5;
            this.btnHD.Text = "Danh sách hoạt động";
            this.btnHD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHD.UseVisualStyleBackColor = false;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // pbThoat
            // 
            this.pbThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbThoat.Image = ((System.Drawing.Image)(resources.GetObject("pbThoat.Image")));
            this.pbThoat.Location = new System.Drawing.Point(12, 12);
            this.pbThoat.Name = "pbThoat";
            this.pbThoat.Size = new System.Drawing.Size(60, 46);
            this.pbThoat.TabIndex = 4;
            this.pbThoat.TabStop = false;
            this.pbThoat.Click += new System.EventHandler(this.pbThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 506);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbThoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDSDK;
        private System.Windows.Forms.Button btnTV;
        private System.Windows.Forms.Button btnSK;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.PictureBox pbThoat;
    }
}

