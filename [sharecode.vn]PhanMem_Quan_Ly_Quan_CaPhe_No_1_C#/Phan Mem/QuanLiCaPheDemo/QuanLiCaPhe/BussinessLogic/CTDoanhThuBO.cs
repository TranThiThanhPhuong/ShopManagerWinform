using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLiCaPhe.DataAccess;

namespace QuanLiCaPhe.BussinessLogic
{
    class CTDoanhThuBO
    {
        DBAccess db = new DBAccess();
        
        public string layDonGia(string maMon)
        {
            return db.layDonGiaMon(maMon);
        }

        public string laySLBan(string maMon)
        {
            return db.laySLMonBan(maMon);
        }

        public bool kiemTraTonTaiCTDT(string maMon, DateTime ngay)
        {
            return db.kiemTraTonTai16(maMon, ngay);
        }

        public string laySLMonCu(string maMon, string maBan)
        {
            return db.laySLMon(maMon, maBan);
        }

        public bool kiemTraTonTaiOder(int maOder)
        {
            return db.kiemTraTonTai17(maOder);
        }

        public bool ThemCTDoanhThu(CTDoanhThu ct)
        {
            string[] param = { "@Ngay", "@MaMon", "SoLuongBan", "TongTien" };
            object[] values = { ct.Ngay, ct.MaMon, ct.SoLuong, ct.TongTien };
            string query = "Insert into tblCTDoanhThu(Ngay,MaMon,SoLuongBan,TongTien) values(@Ngay,@MaMon,@SoLuongBan,@TongTien)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool SuaCTDoanhThu(CTDoanhThu ct)
        {
            string[] param = { "@Ngay", "@MaMon", "SoLuongBan", "TongTien" };
            object[] values = { ct.Ngay, ct.MaMon, ct.SoLuong, ct.TongTien };
            string query = "Update tblCTDoanhThu set SoLuongBan=@SoLuongBan,TongTien=@TongTien where Ngay=@Ngay and MaMon=@MaMon";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
