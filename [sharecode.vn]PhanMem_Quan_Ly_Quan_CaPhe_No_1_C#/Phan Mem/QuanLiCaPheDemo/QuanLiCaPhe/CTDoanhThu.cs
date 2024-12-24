using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiCaPhe
{
    class CTDoanhThu
    {
        private DateTime ngay;
        private string maMon;
        private int soLuong;
        private float tongTien;

        public DateTime Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }

        public string MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public float TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
    }
}
