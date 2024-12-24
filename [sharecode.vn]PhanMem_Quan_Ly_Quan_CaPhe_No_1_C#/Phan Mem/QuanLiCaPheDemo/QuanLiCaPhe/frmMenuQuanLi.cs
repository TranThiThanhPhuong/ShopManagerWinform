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
    public partial class frmMenuQuanLi : Form
    {
        public frmMenuQuanLi()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLiNV FromQuanLiNV;
            FromQuanLiNV = new frmQuanLiNV();
            FromQuanLiNV.Show();
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLiNL FromQuanLiNL;
            FromQuanLiNL = new frmQuanLiNL("");
            FromQuanLiNL.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFormMenu FromMenu;
            FromMenu =  new frmFormMenu();
            FromMenu.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBaoCao BaoCao = new frmBaoCao();
            BaoCao.Show();
        }
    }
}
