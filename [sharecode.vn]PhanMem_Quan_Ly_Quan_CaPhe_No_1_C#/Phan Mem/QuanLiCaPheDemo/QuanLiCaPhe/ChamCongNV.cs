using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiCaPhe
{
    class ChamCongNV
    {
        private string maNV;
        private string tenNV;
        private string caLam;
        private DateTime ngay;
        private float soGioLam;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public string CaLam
        {
            get { return caLam; }
            set { caLam = value; }
        }

        public DateTime NgayLam
        {
            get { return ngay; }
            set { ngay = value; }
        }

        public float SoGioLam
        {
            get { return soGioLam; }
            set { soGioLam = value; }
        }

    }
}
