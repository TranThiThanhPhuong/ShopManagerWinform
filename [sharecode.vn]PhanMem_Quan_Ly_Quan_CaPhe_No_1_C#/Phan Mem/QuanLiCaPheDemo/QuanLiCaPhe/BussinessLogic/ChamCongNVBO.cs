using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLiCaPhe.DataAccess;

namespace QuanLiCaPhe.BussinessLogic
{
    class ChamCongNVBO
    {
        DBAccess db = new DBAccess();

        public DataTable getDSCCNV()
        {
            string query = "Select * from tblChamCongNV";
            return db.getDS(query);
        }

        //public DataTable getDSCCNV(string maNV)
        //{
        //    string query = "Select * from tblChamCongNV where Ngay='" +maNV + "'";
        //    return db.getDS(query);
        //}

        public string getTenNV(string maNV)
        {
            return db.layTenNV(maNV);
        }

        public bool kiemtraCCNV(string maNV,DateTime ngay,string caLam)
        {
            return db.kiemtontaiCCNV(maNV, ngay,caLam);
        }

        public bool ThemCC(ChamCongNV ccnv)
        {
            string[] param = { "@MaNV", "@TenNV", "@CaLam", "@Ngay", "@SoGioLam" };
            object[] values = { ccnv.MaNV, ccnv.TenNV,ccnv.CaLam , ccnv.NgayLam, ccnv.SoGioLam };
            string query = "Insert into tblChamCongNV(MaNV,TenNV,CaLam,Ngay,SoGioLam) values (@MaNV,@TenNV,@CaLam,@Ngay,@SoGioLam)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool SuaCC(ChamCongNV ccnv)
        {
            string[] param = { "@MaNV", "@CaLam", "@Ngay", "@SoGioLam" };
            object[] values = { ccnv.MaNV,ccnv.CaLam, ccnv.NgayLam, ccnv.SoGioLam };
            string query = "Update tblChamCongNV set SoGioLam=@SoGioLam where MaNV=@MaNV and CaLam=@CaLam and Ngay=@Ngay";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool XoaCC(ChamCongNV ccnv)
        {
            string[] param = { "@MaNV", "@TenNV", "@CaLam", "@Ngay", "@SoGioLam" };
            object[] values = { ccnv.MaNV, ccnv.TenNV,ccnv.CaLam, ccnv.NgayLam, ccnv.SoGioLam };
            string query = "Delete from tblChamCongNV where MaNV=@MaNV and TenNV=@TenNV and CaLam=@CaLam and Ngay=@Ngay";
            return db.ExecuteNonQueryPara(query, param, values);
        }

    }
}
    