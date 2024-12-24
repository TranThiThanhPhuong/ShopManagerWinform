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
    public partial class frmReport_CTBanHang : Form
    {
        MonBO monBO = new MonBO();
        public frmReport_CTBanHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBaoCao BaoCao = new frmBaoCao();
            BaoCao.Show();
        }

        private void frmReport_CTBanHang_Load(object sender, EventArgs e)
        {
            DataTable tableMaMon = new DataTable();
            tableMaMon = monBO.getMaMon();
            cbMaMon.DataSource = tableMaMon;
            cbMaMon.DisplayMember = "MaMon";
            cbMaMon.ValueMember = "MaMon";
            cbMaMon.SelectedIndex = 0;
            SqlConnection connect;
            connect = new SqlConnection(@"server=.\SQLEXPRESS; Database=QuanLiCaPhe;integrated security=true");
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            string query = "Select * from tblCTDoanhThu";
            SqlDataAdapter dscm = new SqlDataAdapter(query, connect);
            DSBangLuong ds = new DSBangLuong();
            dscm.Fill(ds, "tblCTDoanhThu");
            connect.Close();
            Report_CTBan objRpt = new Report_CTBan();
            objRpt.SetDataSource(ds.Tables[1]);
            crystalReportViewer_BH.ReportSource = objRpt;
            crystalReportViewer_BH.Refresh();        
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string query="";
            if (rdXemTheoNgay.Checked == true)
            {
                DateTime ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
                query="Select * from tblCTDoanhThu where Ngay='"+ngay+"'";
            }
            if (rdXemTheoMaMon.Checked == true)
            {
                string maMon = cbMaMon.SelectedValue.ToString();
                query = "Select * from tblCTDoanhThu where MaMon='" + maMon + "'";
            }
            if (rdXemTheoCaHai.Checked == true)
            {
                DateTime ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
                string maMon = cbMaMon.SelectedValue.ToString();
                query = "Select * from tblCTDoanhThu where MaMon='" + maMon + "' and Ngay='" + ngay + "'";
            }
            SqlConnection connect;
            connect = new SqlConnection(@"server=.\SQLEXPRESS; Database=QuanLiCaPhe;integrated security=true");
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter dscm = new SqlDataAdapter(query, connect);
            DSBangLuong ds = new DSBangLuong();
            dscm.Fill(ds, "tblCTDoanhThu");
            connect.Close();
            Report_CTBan objRpt = new Report_CTBan();
            objRpt.SetDataSource(ds.Tables[1]);
            crystalReportViewer_BH.ReportSource = objRpt;
            crystalReportViewer_BH.Refresh();        
        }
    }
}
