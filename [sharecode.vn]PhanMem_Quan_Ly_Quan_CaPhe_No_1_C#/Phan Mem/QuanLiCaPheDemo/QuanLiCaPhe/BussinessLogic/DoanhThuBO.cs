using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLiCaPhe.DataAccess;

namespace QuanLiCaPhe.BussinessLogic
{
    class DoanhThuBO
    {
        DBAccess db = new DBAccess();

        public bool kiemTraTonTaiDT(DateTime ngay)
        {
            return db.kiemTraTonTai13(ngay);
        }

        public string layDoanhThu(DateTime ngay)
        {
            return db.layDoanhThu(ngay);
        }

        public bool ThemDoanhThu(DoanhThu dt)
        {
            string[] param = { "@Ngay", "@DoanhThu" };
            object[] values = { dt.Ngay, dt.Tong };
            string query = "Insert into tblDoanhThu(Ngay,DoanhThu) values(@Ngay,@DoanhThu)";
            return db.ExecuteNonQueryPara(query, param, values);
        }
        public bool SuaDoanhThu(DoanhThu dt)
        {
            string[] param = { "@Ngay", "@DoanhThu" };
            object[] values = { dt.Ngay, dt.Tong };
            string query = "Update tblDoanhThu set DoanhThu=@DoanhThu where Ngay=@Ngay";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
