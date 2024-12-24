using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLiCaPhe.DataAccess;

namespace QuanLiCaPhe.BussinessLogic
{
    class HoaDonBO
    {
        DBAccess db = new DBAccess();

        public DataTable getHoaDon()
        {
            string query = "Select * from tblHoaDon";
            return db.getDS(query);
        }

        public string layMaHD(int maOder)
        {
            return db.layMaHD(maOder);
        }

        public bool ThemHD(HoaDon hd)
        {
            string[] param = { "@MaOder", "@MaBan", "@Ngay" };
            object[] values = { hd.MaOder, hd.MaBan, hd.Ngay };
            string query = "Insert into tblHoaDon(MaOder,MaBan,Ngay) values(@MaOder,@MaBan,@Ngay)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool XoaHD(HoaDon hd)
        {
            string[] param = { "@MaOder" };
            object[] values = {hd.MaOder};
            string query = "Delete from tblHoaDon where MaOder=@MaOder";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool ChuyenBan(HoaDon hd)
        {
            string[] param = { "@MaOder", "@MaBan" };
            object[] values = { hd.MaOder, hd.MaBan };
            string query = "Update tblHoaDon set MaBan=@MaBan where MaOder=@MaOder";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
