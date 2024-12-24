using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiCaPhe
{
    public partial class frmThemDVT : Form
    {
        public frmThemDVT()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDonViTinh.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLiNL FromQLNL = new frmQuanLiNL("");
            FromQLNL.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmQuanLiNL FromQLNL;
            FromQLNL = new frmQuanLiNL(txtDonViTinh.Text);
            FromQLNL.Show();
            this.Close();
        }
    }
}
