using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLiCaPhe.DataAccess;

namespace QuanLiCaPhe.BussinessLogic
{
    class CTHoaDonBO
    {
        DBAccess db = new DBAccess();
        public DataTable getCTHD()
        {
            string query = "Select * from tblCTHoaDon";
            return db.getDS(query);
        }

        public string layMaHD(int maOder)
        {
            return db.layMaHD(maOder);
        }

        public string layTenMon(string maMon)
        {
            return db.layTenMon(maMon);
        }

        public bool kiemTraMonHD(int maHD, string maMon)
        {
            return db.kiemTraTonTai12(maHD,maMon);
        }

        public string layDonGia(string maMon)
        {
            return db.layDonGiaMon(maMon);
        }

        public bool ThemCTHD(CTHoaDon ct)
        {
            string[] param = { "@MaHD","@MaMon", "@TenMon", "@SoLuong", "@DonGia", "@ThanhTien" };
            object[] values={ct.MaHD,ct.MaMon,ct.TenMon,ct.SoLuong,ct.DonGia,ct.ThanhTien};
            string query = "Insert into tblCTHoaDon(MaHD,MaMon,TenMon,SoLuong,DonGia,ThanhTien) values(@MaHD,@MaMon,@TenMon,@SoLuong,@DonGia,@ThanhTien)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool SuaCTHD(CTHoaDon ct)
        {
            string[] param = { "@MaHD","@MaMon","@SoLuong"};
            object[] values = {ct.MaHD, ct.MaMon,ct.SoLuong };
            string query = "Update tblCTHoaDon set SoLuong=@SoLuong where MaMon=@MaMon and MaHD=@MaHD";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        //public bool XoaCTHD(CTHoaDon ct)
        //{
        //    string[] param = { "@MaHD"};
        //    object [] values={ct.MaHD};
        //    string query = "Delete from tblCTHoaDon where MaHD=@MaHD";
        //    return db.ExecuteNonQueryPara(query, param, values);
        //}

        public bool XoaMon(CTHoaDon ct)
        {
            string[] param = { "@MaHD","@MaMon" };
            object[] values = { ct.MaHD,ct.MaMon };
            string query = "Delete from tblCTHoaDon where MaHD=@MaHD and MaMon=@MaMon";
            return db.ExecuteNonQueryPara(query, param, values);
        }
            
    }
}
