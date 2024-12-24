namespace QuanLiCaPhe
{
    partial class frmReport_CTBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport_CTBanHang));
            this.cbMaMon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdXemTheoNgay = new System.Windows.Forms.RadioButton();
            this.rdXemTheoMaMon = new System.Windows.Forms.RadioButton();
            this.gbHinhThuc = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rdXemTheoCaHai = new System.Windows.Forms.RadioButton();
            this.crystalReportViewer_BH = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gbHinhThuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMaMon
            // 
            this.cbMaMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaMon.FormattingEnabled = true;
            this.cbMaMon.Location = new System.Drawing.Point(464, 145);
            this.cbMaMon.Name = "cbMaMon";
            this.cbMaMon.Size = new System.Drawing.Size(172, 26);
            this.cbMaMon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Món:";
            // 
            // rdXemTheoNgay
            // 
            this.rdXemTheoNgay.AutoSize = true;
            this.rdXemTheoNgay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdXemTheoNgay.Location = new System.Drawing.Point(25, 25);
            this.rdXemTheoNgay.Name = "rdXemTheoNgay";
            this.rdXemTheoNgay.Size = new System.Drawing.Size(148, 23);
            this.rdXemTheoNgay.TabIndex = 2;
            this.rdXemTheoNgay.TabStop = true;
            this.rdXemTheoNgay.Text = "Xem Theo Ngày";
            this.rdXemTheoNgay.UseVisualStyleBackColor = true;
            // 
            // rdXemTheoMaMon
            // 
            this.rdXemTheoMaMon.AutoSize = true;
            this.rdXemTheoMaMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdXemTheoMaMon.Location = new System.Drawing.Point(25, 54);
            this.rdXemTheoMaMon.Name = "rdXemTheoMaMon";
            this.rdXemTheoMaMon.Size = new System.Drawing.Size(167, 23);
            this.rdXemTheoMaMon.TabIndex = 3;
            this.rdXemTheoMaMon.TabStop = true;
            this.rdXemTheoMaMon.Text = "Xem Theo Mã Món";
            this.rdXemTheoMaMon.UseVisualStyleBackColor = true;
            // 
            // gbHinhThuc
            // 
            this.gbHinhThuc.BackColor = System.Drawing.Color.White;
            this.gbHinhThuc.Controls.Add(this.rdXemTheoCaHai);
            this.gbHinhThuc.Controls.Add(this.rdXemTheoNgay);
            this.gbHinhThuc.Controls.Add(this.rdXemTheoMaMon);
            this.gbHinhThuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHinhThuc.Location = new System.Drawing.Point(530, 12);
            this.gbHinhThuc.Name = "gbHinhThuc";
            this.gbHinhThuc.Size = new System.Drawing.Size(266, 119);
            this.gbHinhThuc.TabIndex = 4;
            this.gbHinhThuc.TabStop = false;
            this.gbHinhThuc.Text = "Chọn hình thức";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(668, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày:";
            // 
            // dtNgay
            // 
            this.dtNgay.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgay.Location = new System.Drawing.Point(742, 145);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 26);
            this.dtNgay.TabIndex = 6;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(813, 62);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(87, 37);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "XEM";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(925, 62);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 37);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rdXemTheoCaHai
            // 
            this.rdXemTheoCaHai.AutoSize = true;
            this.rdXemTheoCaHai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdXemTheoCaHai.Location = new System.Drawing.Point(25, 83);
            this.rdXemTheoCaHai.Name = "rdXemTheoCaHai";
            this.rdXemTheoCaHai.Size = new System.Drawing.Size(235, 23);
            this.rdXemTheoCaHai.TabIndex = 4;
            this.rdXemTheoCaHai.TabStop = true;
            this.rdXemTheoCaHai.Text = "Xem Theo Ngày Và Mã Món";
            this.rdXemTheoCaHai.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer_BH
            // 
            this.crystalReportViewer_BH.ActiveViewIndex = -1;
            this.crystalReportViewer_BH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_BH.Location = new System.Drawing.Point(1, 208);
            this.crystalReportViewer_BH.Name = "crystalReportViewer_BH";
            this.crystalReportViewer_BH.SelectionFormula = "";
            this.crystalReportViewer_BH.Size = new System.Drawing.Size(1360, 522);
            this.crystalReportViewer_BH.TabIndex = 9;
            this.crystalReportViewer_BH.ViewTimeSelectionFormula = "";
            // 
            // frmReport_CTBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.crystalReportViewer_BH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbHinhThuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMaMon);
            this.Name = "frmReport_CTBanHang";
            this.Text = "frmReport_CTBanHang";
            this.Load += new System.EventHandler(this.frmReport_CTBanHang_Load);
            this.gbHinhThuc.ResumeLayout(false);
            this.gbHinhThuc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdXemTheoNgay;
        private System.Windows.Forms.RadioButton rdXemTheoMaMon;
        private System.Windows.Forms.GroupBox gbHinhThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdXemTheoCaHai;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_BH;
    }
}