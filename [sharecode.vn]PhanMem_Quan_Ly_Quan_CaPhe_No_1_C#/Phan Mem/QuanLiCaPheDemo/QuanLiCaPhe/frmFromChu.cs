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
    public partial class frmFromChu : Form
    {
        UserBO us = new UserBO();
        public frmFromChu()
        {
            InitializeComponent();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmFormMenu frmMenu;
            frmMenu = new frmFormMenu();
            if (txtUser.Text == "" || txtPass.Text == "")
                MessageBox.Show("Bạn chưa nhập User hoặc PassWord", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (us.kiemTraLogin(txtUser.Text, txtPass.Text))
                {
                    frmMenu.Show();
                    txtPass.Text = "";
                    txtUser.Text = "";
                }
                else
                    MessageBox.Show("Sai User hoặc PassWord", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
