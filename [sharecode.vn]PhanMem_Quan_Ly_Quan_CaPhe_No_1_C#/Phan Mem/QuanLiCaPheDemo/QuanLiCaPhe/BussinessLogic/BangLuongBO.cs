using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLiCaPhe.DataAccess;

namespace QuanLiCaPhe.BussinessLogic
{
    class BangLuongBO
    {
        DBAccess db = new DBAccess();

        public string layChucVu(string maNV)
        {
            return db.layChucVu(maNV);
        }

        public string layGioLam(string maNV, int thang)
        {
            return db.laySoGioLam(maNV, thang);
        }

        public bool kiemTraBangLuong(int thang, string maNV)
        {
            return db.kiemTraTonTai14(thang, maNV);
        }

        public bool ThemBangLuong(BangLuong bl)
        {
            string[] param = { "@Thang", "@MaNV", "@TenNV", "@TongGioLam", "@MucLuong", "@TienLuong" };
            object[] values = { bl.Thang, bl.MaNV, bl.TenNV, bl.TongGioLam, bl.MucLuong, bl.TienLuong };
            string query = "Insert into tblBangLuong(Thang,MaNV,TenNV,TongGioLam,MucLuong,TienLuong) values(@Thang,@MaNV,@TenNV,@TongGioLam,@MucLuong,@TienLuong)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool SuaBangLuong(BangLuong bl)
        {
            string[] param = { "@Thang", "@MaNV", "@TongGioLam","@TienLuong" };
            object[] values = { bl.Thang, bl.MaNV, bl.TongGioLam,bl.TienLuong };
            string query = "Update tblBangLuong set TongGioLam=@TongGioLam,TienLuong=@TienLuong where Thang=@Thang and MaNV=@MaNV";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
