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
    public partial class frmSoDoChinh : Form
    {
        public frmSoDoChinh()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFormMenu FromMenu;
            FromMenu = new frmFormMenu();
            FromMenu.Show();
        }

        private void btnKhuA_Click(object sender, EventArgs e)
        {
            this.Close();
            frmKhuA FromKhuA;
            FromKhuA = new frmKhuA();
            FromKhuA.Show();
        }

        private void btnKhuB_Click(object sender, EventArgs e)
        {
            this.Close();
            frmKhuB FromKhuB;
            FromKhuB = new frmKhuB();
            FromKhuB.Show();
        }
    }
}
