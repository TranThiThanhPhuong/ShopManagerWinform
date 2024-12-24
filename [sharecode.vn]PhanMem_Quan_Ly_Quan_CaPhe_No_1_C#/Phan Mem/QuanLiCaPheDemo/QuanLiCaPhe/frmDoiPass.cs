using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLiCaPhe.BussinessLogic;

namespace QuanLiCaPhe
{
    public partial class frmDoiPass : Form
    {
        UserBO userBO = new UserBO();
        
        public frmDoiPass()
        {
            InitializeComponent();
        }

        private User getDataUser()
        {
            User us = new User();
            us.MaUser = txtMaUser.Text;
            us.MatKhau = txtMatKhauMoi.Text;
            return us;
        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaUser.Text = "";
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtNhapLai.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFormMenu frmMenu;
            frmMenu = new frmFormMenu();
            frmMenu.Show();
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            User us = getDataUser();
            if (txtMaUser.Text == "" || txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtNhapLai.Text == "")
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if(userBO.kiemTraLogin( txtMaUser .Text,txtMatKhauCu.Text))
                    if (txtMatKhauMoi.Text != txtNhapLai.Text)
                        MessageBox.Show("Mật khẩu Nhập Lại không chính xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        if (userBO.doiPass(us))
                            MessageBox.Show("Đổi mật khẩu thành công!");
                        else
                            MessageBox.Show("Lỗi xảy ra!");
                else
                    MessageBox.Show("Mã User hoặc Mật Khẩu Cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmDoiPass_Load(object sender, EventArgs e)
        {

        }

    }
}
