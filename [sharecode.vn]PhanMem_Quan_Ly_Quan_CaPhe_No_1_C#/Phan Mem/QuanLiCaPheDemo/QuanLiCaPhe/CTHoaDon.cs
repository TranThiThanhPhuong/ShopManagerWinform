using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiCaPhe
{
    class CTHoaDon
    {
        private int maHD;
        private string maMon;
        private string tenMon;
        private int soLuong;
        private float donGia;
        private float thanhTien;

        public int MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public string MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }

        public string TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    }
}
