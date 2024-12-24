using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLiCaPhe.BussinessLogic;
using System.Data.SqlClient;

namespace QuanLiCaPhe
{
    public partial class frmReport_BL : Form
    {
        public frmReport_BL()
        {
            InitializeComponent();
        }

        private void frmReport_BL_Load(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int t= 0;
            string thang = cbThang.Text;
            Int32.TryParse(thang, out t);
            SqlConnection connect;
            connect = new SqlConnection(@"server=.\SQLEXPRESS; Database=QuanLiCaPhe;integrated security=true");
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            string query = "SELECT Thang,MaNV,TenNV,TongGioLam,MucLuong,TienLuong FROM tblBangLuong where Thang='" +t+ "'";
            SqlDataAdapter dscm = new SqlDataAdapter(query, connect);
            DSBangLuong ds = new DSBangLuong();
            dscm.Fill(ds, "tblBangLuong");
            connect.Close();
            Report_BL objRpt = new Report_BL();
            objRpt.SetDataSource(ds.Tables[1]);
            crystalReportViewer_BL.ReportSource = objRpt;
            crystalReportViewer_BL.Refresh();        
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLiNV QuanLiNV = new frmQuanLiNV();
            QuanLiNV.Show();
        }
    }
}
