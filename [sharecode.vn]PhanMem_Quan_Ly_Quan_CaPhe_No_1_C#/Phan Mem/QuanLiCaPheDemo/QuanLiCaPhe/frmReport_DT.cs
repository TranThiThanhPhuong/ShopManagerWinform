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
    public partial class frmReport_DT : Form
    {
        public frmReport_DT()
        {
            InitializeComponent();
        }

        private void frmReport_DT_Load(object sender, EventArgs e)
        {
            SqlConnection connect;
            connect = new SqlConnection(@"server=.\SQLEXPRESS; Database=QuanLiCaPhe;integrated security=true");
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            string query = "SELECT * FROM tblDoanhThu";
            SqlDataAdapter dscm = new SqlDataAdapter(query, connect);
            DSDoanhThu ds = new DSDoanhThu();
            dscm.Fill(ds, "tblDoanhThu");
            connect.Close();
            Report_DT objRpt = new Report_DT();
            objRpt.SetDataSource(ds.Tables[1]);
            crystalReportViewer_DT.ReportSource = objRpt;
            crystalReportViewer_DT.Refresh();        
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmBaoCao BaoCao = new frmBaoCao();
            this.Close();
            BaoCao.Show();
        }
    }
}
