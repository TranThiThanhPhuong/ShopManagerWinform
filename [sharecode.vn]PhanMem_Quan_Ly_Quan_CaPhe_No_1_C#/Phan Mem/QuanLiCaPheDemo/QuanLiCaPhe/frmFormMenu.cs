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
    public partial class frmFormMenu : Form
    {
        public frmFormMenu()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan;
            xacnhan = MessageBox.Show("Có chắc bạn muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacnhan == DialogResult.Yes)
                this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiPass frmDoiPass;
            frmDoiPass = new frmDoiPass();
            frmDoiPass.Show();
            this.Hide();
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNhapXuatNguyenLieu FromNhapXuatNL;
            FromNhapXuatNL = new frmNhapXuatNguyenLieu();
            FromNhapXuatNL.Show();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmChamCongNV FromChamCongNV;
            FromChamCongNV = new frmChamCongNV();
            FromChamCongNV.Show();
        }

        private void btnSoDoChinh_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSoDoChinh FromSoDoChinh;
            FromSoDoChinh = new frmSoDoChinh();
            FromSoDoChinh.Show();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuQuanLi FromQuanLi;
            FromQuanLi = new frmMenuQuanLi();
            FromQuanLi.Show();
        }
    }
}
