using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiCaPhe
{
    public partial class frmReport_BanSDNhieu : Form
    {
        public frmReport_BanSDNhieu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBaoCao BaoCao = new frmBaoCao();
            BaoCao.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
                MessageBox.Show("Vui lòng nhập số lượng bàn bạn muốn xem");
            else
            {
                int i=int.Parse(txtSoLuong.Text);
                SqlConnection connect;
                connect = new SqlConnection(@"server=.\SQLEXPRESS; Database=QuanLiCaPhe;integrated security=true");
                connect.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                string query = "SELECT top "+i+" * FROM tblBanSDNhieu ORDER BY LuotSD DESC";
                SqlDataAdapter dscm = new SqlDataAdapter(query, connect);
                DSDoanhThu ds = new DSDoanhThu();
                dscm.Fill(ds, "tblBanSDNhieu");
                connect.Close();
                Report_BanSDNhieu objRpt = new Report_BanSDNhieu();
                objRpt.SetDataSource(ds.Tables[1]);
                crystalReportViewer_BanSDNhieu.ReportSource = objRpt;
                crystalReportViewer_BanSDNhieu.Refresh();
            }
        }
    }
}
