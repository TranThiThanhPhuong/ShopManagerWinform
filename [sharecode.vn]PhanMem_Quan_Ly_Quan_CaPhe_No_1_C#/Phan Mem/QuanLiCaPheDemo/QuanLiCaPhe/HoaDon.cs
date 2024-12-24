using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiCaPhe
{
    class HoaDon
    {
        private int maHD;
        private int maOder;
        private string maBan;
        private DateTime ngay;

        public int MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public int MaOder
        {
            get { return maOder; }
            set { maOder = value; }
        }

        public string MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }

        public DateTime Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }
    }
}
