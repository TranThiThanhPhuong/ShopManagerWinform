using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLiCaPhe.DataAccess;

namespace QuanLiCaPhe.BussinessLogic
{
    class OderBO
    {
        DBAccess db = new DBAccess();

        public DataTable getDSOder()
        {
            string query = "Select * from tblOder";
            return db.getDS(query);
        }

        public DataTable getDSOder(string maOder)
        {
            string query = "Select * from tblOder where MaOder='" + maOder + "'";
            return db.getDS(query);
        }

        public DataTable getMaNV()
        {
            string query = "Select MaNV from tblNhanVien where MaNV like 'NV%'";
            return db.getDS(query);
        }

        public string layMaBan(int soBan)
        {
            return db.layMaBan(soBan);
        }

        public int layMaOder()
        {
            int i = 0;
            i = db.layMaOder("tblOder", "MaOder");
            return i;
        }

        public bool kiemTraTonTai1()
        {
            return db.kiemTraTonTai1();
        }

        public bool ThemOder(Oder od)
        {
            string[] param = { "@MaBan", "@MaOder", "@MaNV", "@Ngay" };
            object[] values = { od.MaBan, od.MaOder, od.MaNV, od.Ngay };
            string query = "Insert into tblOder(MaOder, MaBan,MaNV,Ngay) values(@MaOder,@MaBan,@MaNV,@Ngay)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool XoaOder(Oder od)
        {
            string[] parem = { "@MaOder" };
            object[] values = { od.MaOder };
            string query = "Delete from tblOder where MaOder=@MaOder";
            return db.ExecuteNonQueryPara(query, parem, values);
        }

        public bool ChuyenBan(Oder od)
        {
            string[] param = { "@MaOder", "@MaBan" };
            object[] values = { od.MaOder, od.MaBan };
            string query = "Update tblOder set MaBan=@MaBan where MaOder=@MaOder";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
