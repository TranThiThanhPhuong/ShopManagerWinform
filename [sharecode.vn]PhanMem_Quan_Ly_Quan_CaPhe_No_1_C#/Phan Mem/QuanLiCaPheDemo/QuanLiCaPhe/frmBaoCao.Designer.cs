namespace QuanLiCaPhe
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbHinhThuc = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdDoanhThu = new System.Windows.Forms.RadioButton();
            this.rdSLMonBan = new System.Windows.Forms.RadioButton();
            this.rdBanChonNhieu = new System.Windows.Forms.RadioButton();
            this.btnXem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbHinhThuc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1364, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // gbHinhThuc
            // 
            this.gbHinhThuc.Controls.Add(this.rdBanChonNhieu);
            this.gbHinhThuc.Controls.Add(this.rdSLMonBan);
            this.gbHinhThuc.Controls.Add(this.rdDoanhThu);
            this.gbHinhThuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHinhThuc.Location = new System.Drawing.Point(412, 210);
            this.gbHinhThuc.Name = "gbHinhThuc";
            this.gbHinhThuc.Size = new System.Drawing.Size(531, 206);
            this.gbHinhThuc.TabIndex = 9;
            this.gbHinhThuc.TabStop = false;
            this.gbHinhThuc.Text = "Chọn Hình Thức:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Location = new System.Drawing.Point(412, 443);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 78);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "DANH MỤC XEM BÁO CÁO";
            // 
            // rdDoanhThu
            // 
            this.rdDoanhThu.AutoSize = true;
            this.rdDoanhThu.Location = new System.Drawing.Point(48, 44);
            this.rdDoanhThu.Name = "rdDoanhThu";
            this.rdDoanhThu.Size = new System.Drawing.Size(112, 23);
            this.rdDoanhThu.TabIndex = 0;
            this.rdDoanhThu.TabStop = true;
            this.rdDoanhThu.Text = "Doanh Thu";
            this.rdDoanhThu.UseVisualStyleBackColor = true;
            // 
            // rdSLMonBan
            // 
            this.rdSLMonBan.AutoSize = true;
            this.rdSLMonBan.Location = new System.Drawing.Point(48, 99);
            this.rdSLMonBan.Name = "rdSLMonBan";
            this.rdSLMonBan.Size = new System.Drawing.Size(165, 23);
            this.rdSLMonBan.TabIndex = 1;
            this.rdSLMonBan.TabStop = true;
            this.rdSLMonBan.Text = "Chi Tiết Bán Hàng";
            this.rdSLMonBan.UseVisualStyleBackColor = true;
            // 
            // rdBanChonNhieu
            // 
            this.rdBanChonNhieu.AutoSize = true;
            this.rdBanChonNhieu.Location = new System.Drawing.Point(48, 150);
            this.rdBanChonNhieu.Name = "rdBanChonNhieu";
            this.rdBanChonNhieu.Size = new System.Drawing.Size(201, 23);
            this.rdBanChonNhieu.TabIndex = 2;
            this.rdBanChonNhieu.TabStop = true;
            this.rdBanChonNhieu.Text = "Bàn Được Chọn Nhiều";
            this.rdBanChonNhieu.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(60, 19);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(92, 43);
            this.btnXem.TabIndex = 0;
            this.btnXem.Text = "XEM";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(376, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "THOÁT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbHinhThuc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbHinhThuc.ResumeLayout(false);
            this.gbHinhThuc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbHinhThuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBanChonNhieu;
        private System.Windows.Forms.RadioButton rdSLMonBan;
        private System.Windows.Forms.RadioButton rdDoanhThu;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}