using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiCaPhe
{
    class NXNguyenLieu
    {
        private int maPhieuXuat;
        private DateTime ngayXuat;
        private int  maPhieuNhap;
        private DateTime ngayNhap;
        private int tongTien;
        public int MaPhieuNhap
        {
            get { return maPhieuNhap; }
            set { maPhieuNhap = value; }
        }
        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        public int  MaPhieuXuat
        {
            get { return maPhieuXuat; }
            set { maPhieuXuat = value; }
        }
        public DateTime NgayXuat
        {
            get { return ngayXuat; }
            set { ngayXuat = value;}
        }
    }
}
