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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (rdDoanhThu.Checked == true)
            {
                frmReport_DT DoanhThu = new frmReport_DT();
                this.Close();
                DoanhThu.Show();
            }
            else
                if (rdSLMonBan.Checked == true)
                {
                    frmReport_CTBanHang CTBanHang = new frmReport_CTBanHang();
                    this.Close();
                    CTBanHang.Show();
                }
                else
                    if (rdBanChonNhieu.Checked == true)
                    {
                        frmReport_BanSDNhieu BanSDNhieu = new frmReport_BanSDNhieu();
                        this.Close();
                        BanSDNhieu.Show();
                    }
                    else
                        MessageBox.Show("Vui lòng chọn hình thức báo cáo muốn xem");
        }
    }
}
