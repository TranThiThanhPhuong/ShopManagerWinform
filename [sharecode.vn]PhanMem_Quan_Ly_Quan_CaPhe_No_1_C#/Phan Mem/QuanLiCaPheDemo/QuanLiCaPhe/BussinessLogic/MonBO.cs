using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLiCaPhe.DataAccess;
using System.Data;

namespace QuanLiCaPhe.BussinessLogic
{
    class MonBO
    {
        DBAccess db = new DBAccess();
        public DataTable getMaMon()
        {
            string query = "Select MaMon from tblDSMon";
            return db.getDS(query);
        }
    }
}
