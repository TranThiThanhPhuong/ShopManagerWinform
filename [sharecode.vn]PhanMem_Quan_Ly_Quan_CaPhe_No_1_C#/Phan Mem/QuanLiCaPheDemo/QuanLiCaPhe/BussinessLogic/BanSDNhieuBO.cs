using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLiCaPhe.DataAccess;

namespace QuanLiCaPhe.BussinessLogic
{
    class BanSDNhieuBO
    {
        DBAccess db = new DBAccess();

        public bool kiemTraTonTai(string maban)
        {
            return db.kiemTraTonTai15(maban);
        }

        public string laySoBan(string maBan)
        {
            return db.laySoBan(maBan);
        }

        public string layLuotSD(string maBan)
        {
            return db.layLuotSDBan(maBan);
        }

        public bool ThemBanSDNhieu(BanSDNhieu ban)
        {
            string[] param = { "@MaBan", "@SoBan","@LuotSD" };
            object[] values = { ban.MaBan, ban.SoBan,ban.LuotSD };
            string query = "Insert into tblBanSDNhieu(MaBan,SoBan,LuotSD) values(@MaBan,@SoBan,@LuotSD)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool SuaLuotSD(BanSDNhieu ban)
        {
            string[] param = { "@MaBan" ,"LuotSD"};
            object[] values = { ban.MaBan,ban.LuotSD };
            string query = "Update tblBanSDNhieu set LuotSD=@LuotSD where MaBan=@MaBan";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
