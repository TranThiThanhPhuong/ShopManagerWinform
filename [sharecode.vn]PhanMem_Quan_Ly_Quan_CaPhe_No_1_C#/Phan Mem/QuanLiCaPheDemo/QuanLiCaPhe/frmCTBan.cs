using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLiCaPhe.BussinessLogic;


namespace QuanLiCaPhe
{
    public partial class frmCTBan : Form
    {
        OderBO odBO = new OderBO();
        BanCoKhachBO bckBO = new BanCoKhachBO();
        CTOderBO ctBO = new CTOderBO();
        HoaDonBO hdBO = new HoaDonBO();
        CTHoaDonBO cthdBO = new CTHoaDonBO();
        DoanhThuBO dtBO = new DoanhThuBO();
        BanSDNhieuBO bsdBO = new BanSDNhieuBO();
        CTDoanhThuBO ctdtBO = new CTDoanhThuBO();

        public frmCTBan(string text)
        {
            InitializeComponent();
            txtMaBan.Text = text;
        }

        private Oder getOder()
        {
            Oder od = new Oder();
            int i=0;
            od.MaNV = cbMaNV.SelectedValue.ToString();
            od.MaBan = txtMaBan.Text;
            Int32.TryParse(txtMaOder.Text, out i);
            od.MaOder = i;
            od.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            return od;
        }

        private BanCoKhach getBanCoKhach()
        {
            BanCoKhach ban = new BanCoKhach();
            int i = 0;
            ban.MaBan = txtMaBan.Text;
            string soban = bckBO.laySoBan(txtMaBan.Text);
            Int32.TryParse(soban, out i);
            ban.SoBan = i;
            return ban;
        }

        private CTOder getCTOder()
        {
            CTOder ct=new CTOder();
            
            string maMon="";
            int i = 0;
            if (txtMonDaChon.Text == "Khoáng Lạt")
                maMon = "LK001";
            if (txtMonDaChon.Text == "Nước Chanh")
                maMon = "LK002";
            if (txtMonDaChon.Text == "Trà Gừng")
                maMon = "LK004";
            if (txtMonDaChon.Text == "Trà Lipton")
                maMon = "LK003";
            if (txtMonDaChon.Text == "Sữa Chua")
                maMon = "SUA01";
            if (txtMonDaChon.Text == "Sữa Tươi")
                maMon = "SUA02";
            if (txtMonDaChon.Text == "Sữa Yomot")
                maMon = "SUA03";
            if (txtMonDaChon.Text == "Sting Vàng")
                maMon = "NN001";
            if (txtMonDaChon.Text == "Sting Dâu")
                maMon = "NN002";
            if (txtMonDaChon.Text == "Pessi")
                maMon = "NN003";
            if (txtMonDaChon.Text == "Coca Cola")
                maMon = "NN004";
            if (txtMonDaChon.Text == "Seven Up")
                maMon = "NN005";
            if (txtMonDaChon.Text == "Revive")
                maMon = "NN006";
            if (txtMonDaChon.Text == "Trà Không Độ")
                maMon = "NN007";
            if (txtMonDaChon.Text == "C2")
                maMon = "NN008";
            if (txtMonDaChon.Text == "Cà Phê Đen")
                maMon = "CF001";
            if (txtMonDaChon.Text == "Cà Phê Sữa")
                maMon = "CF002";
            if (txtMonDaChon.Text == "Cà Phê Đen SG")
                maMon = "CF003";
            if (txtMonDaChon.Text == "Cà Phê Sữa SG")
                maMon = "CF004";
            if (txtMonDaChon.Text == "Bộc Xỉu")
                maMon = "CF005";
            if (txtMonDaChon.Text == "Thuốc Ngựa Điếu")
                maMon = "TL001";
            if (txtMonDaChon.Text == "Thuốc Ngựa Gói")
                maMon = "TL002";
            if (txtMonDaChon.Text == "Thuốc Marlboro Điếu")
                maMon = "TL003";
            if (txtMonDaChon.Text == "Thuốc Marlboro Gói")
                maMon = "TL004";
            ct.MaMon = maMon;
            i = int.Parse(txtMaOder.Text);
            ct.MaOder = i;
            string dvt = "";
            dvt = ctBO.layDVT(maMon);
            ct.MaBan = txtMaBan.Text;
            ct.DonViTinh = dvt;
            ct.SoLuong = 0;
            return ct;
        }

        private HoaDon getHD()
        {
            HoaDon hd=new HoaDon();
            hd.MaBan=txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text, out i);
            hd.MaOder = i;
            hd.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            return hd;
        }

        private CTHoaDon getCTHD()
        {
            CTHoaDon cthd = new CTHoaDon();
            CTOder ct=getCTOder();
            int i = 0;
            int maOder = int.Parse(txtMaOder.Text);
            Int32.TryParse(cthdBO.layMaHD(maOder), out i);
            cthd.MaHD = i;
            cthd.MaMon = ct.MaMon;
            cthd.TenMon = cthdBO.layTenMon(ct.MaMon);
            string soLuong = txtSoLuong.Text;
            int sl = 0;
            Int32.TryParse(soLuong, out sl);
            cthd.SoLuong = sl;
            string dg=cthdBO.layDonGia(cthd.MaMon);
            float j = 0;
            float.TryParse(dg, out j);
            cthd.DonGia = j;
            cthd.ThanhTien = cthd.SoLuong * cthd.DonGia;
            return cthd;
        }

        private DoanhThu getDoanhThu()
        {
            DoanhThu dt = new DoanhThu();
            dt.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            dt.Tong = 0;
            return dt;
        }

        private BanSDNhieu getBanSDNhieu()
        {
            BanSDNhieu bsd = new BanSDNhieu();
            bsd.MaBan = txtMaBan.Text;
            int i = 0;
            string soban = bsdBO.laySoBan(txtMaBan.Text);
            Int32.TryParse(soban, out i);
            bsd.SoBan = i;
            bsd.LuotSD = 0;
            return bsd;
        }

        private CTDoanhThu getCTDoanhThu()
        {
            CTDoanhThu ct = new CTDoanhThu();
            CTOder ctod=getCTOder();
            ct.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            ct.MaMon = ctod.MaMon;
            ct.SoLuong = 0;
            string dongia = ctdtBO.layDonGia(ct.MaMon);
            float i = 0;
            float.TryParse(dongia, out i);
            ct.TongTien = ct.SoLuong * i;
            return ct;
        }

        private void btnCaPhe_Click(object sender, EventArgs e)
        {
           gbCaPhe.Visible = true;
           gbLoaiKhac.Visible = false;
           gbNuocNgot.Visible = false;
           gbSua.Visible = false;
           gbThuocLa.Visible = false;
        }

        private void btnNuocNgot_Click(object sender, EventArgs e)
        {
            gbNuocNgot.Visible = true;
            gbCaPhe.Visible = false;
            gbLoaiKhac.Visible = false;
            gbSua.Visible = false;
            gbThuocLa.Visible = false;
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            gbThuocLa.Visible = true;
            gbCaPhe.Visible = false;
            gbLoaiKhac.Visible = false;
            gbNuocNgot.Visible = false;
            gbSua.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            gbSua.Visible = true;
            gbCaPhe.Visible = false;
            gbLoaiKhac.Visible = false;
            gbNuocNgot.Visible = false;
            gbThuocLa.Visible = false;
        }

        private void btnLoaiKhac_Click(object sender, EventArgs e)
        {
            gbLoaiKhac.Visible = true;
            gbCaPhe.Visible = false;
            gbSua.Visible = false;
            gbNuocNgot.Visible = false;
            gbThuocLa.Visible = false;
        }

        private void frmCTBan_Load(object sender, EventArgs e)
        {
            
            int i = 0;
            if (odBO.kiemTraTonTai1() == false)
                txtMaOder.Text = "1";
            else
                if (bckBO.kiemTraBanCoKhach(txtMaBan.Text)==false)
                {
                    i = odBO.layMaOder()+1;
                    txtMaOder.Text = i.ToString();
                }
            DataTable tableNV = new DataTable();
            tableNV = odBO.getMaNV();
            cbMaNV.DataSource = tableNV;
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.ValueMember = "MaNV";
            if (bckBO.kiemTraBanCoKhach(txtMaBan.Text))
            {                            
                binData1();
            }
            //else
            //    binData();
        }

        private void ClearBind()
        {
            dgCTOder.DataBindings.Clear();
        }

        private void ClearBind1()
        {
            txtMaOder.DataBindings.Clear();
        }

        private void binData1()
        {
            BindingSource bindSource = new BindingSource();
            string maBan = txtMaBan.Text;
            bindSource.DataSource = ctBO.getCTOder(maBan);
            ClearBind();
            dgCTOder.DataSource = bindSource;
            txtMaOder.DataBindings.Add("Text", bindSource, "MaOder");
        }

        private void binData()
        {
            BindingSource bindSource = new BindingSource();
            string maBan = txtMaBan.Text;
            bindSource.DataSource = ctBO.getCTOder(maBan);
            ClearBind();
            //txtMaOder.DataBindings.Add("Text", bindSource, "MaOder");
            dgCTOder.DataSource = bindSource;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmSoDoChinh SoDoChinh = new frmSoDoChinh();
            string maban = txtMaBan.Text;
            //FromSoDoChinh = new frmSoDoChinh();
            BanCoKhach bck = getBanCoKhach();
            Oder od = getOder();
            CTOder ctod = getCTOder();
            HoaDon hd = getHD();
            CTHoaDon cthd = getCTHD();
            BanSDNhieu bsd = getBanSDNhieu();
            bck.MaBan = txtMaBan.Text;
            int i = int.Parse(txtMaOder.Text);
            od.MaOder = i;
            hd.MaOder = i;
            string maHD = hdBO.layMaHD(i);
            int mahd = 0;
            Int32.TryParse(maHD, out mahd);
            string luotsd = bsdBO.layLuotSD(txtMaBan.Text);
            int lsd = 0;
            Int32.TryParse(luotsd, out lsd);
            if (ctBO.kiemTraGoiMon(i) == false)
            {
                hdBO.XoaHD(hd);
                bckBO.XoaBanCoKhach(bck);
                odBO.XoaOder(od);
                int luotsddung = lsd - 1;
                bsd.LuotSD = luotsddung;
                bsdBO.SuaLuotSD(bsd);
            }
            this.Close();
            SoDoChinh.Show();
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            Oder od = getOder();
            HoaDon hd=getHD();
            BanCoKhach ban = getBanCoKhach();
            BanSDNhieu bsd=getBanSDNhieu();
            if (bckBO.kiemTraBanCoKhach(ban.MaBan))
            {
                gbChonNhom.Visible = true;
            }
            else
            {
                if (odBO.ThemOder(od) == false || bckBO.ThemBanCoKhach(ban) == false)
                    MessageBox.Show("Không thể thực hiện gọi món");
                else
                {
                    gbChonNhom.Visible = true;
                }
                if (hdBO.ThemHD(hd) == false)
                    MessageBox.Show("Không thể thêm hóa đơn");
            }
            if (bsdBO.kiemTraTonTai(txtMaBan.Text) == false)
            {
                bsd.LuotSD = 1;
                bsdBO.ThemBanSDNhieu(bsd);
            }
            else
            {
                int i = int.Parse(txtMaOder.Text);
                if (ctBO.kiemTraGoiMon(i) == false)
                {
                    string luotsd = bsdBO.layLuotSD(txtMaBan.Text);
                    int lsd = 0;
                    Int32.TryParse(luotsd, out lsd);
                    int luotsddung = lsd + 1;
                    bsd.LuotSD = luotsddung;
                    bsdBO.SuaLuotSD(bsd);
                }
            }
        }

        private void btnKhoangLat_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text ="Khoáng Lạt";
            string maMon = "LK001";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if(ctBO.kiemTraMon(maMon,maBan,i)==false)
                if (ctBO.ThemCTOder(ct)== false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnNuocChanh_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Nước Chanh";
            string maMon = "LK002";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = false;
            CTOder ct = getCTOder();
            CTHoaDon cthd = getCTHD();
            DoanhThu dt = getDoanhThu();
            CTDoanhThu ctdt=getCTDoanhThu();
            int i = 0;
            i = int.Parse(txtSoLuong.Text);
            ct.SoLuong = i;
            cthd.SoLuong = i;
            dt.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            ctdt.Ngay = Convert.ToDateTime(dtNgay.Value.ToShortDateString());
            if (dtBO.kiemTraTonTaiDT(dt.Ngay) == false)
                dtBO.ThemDoanhThu(dt);
            if (ctdtBO.kiemTraTonTaiCTDT(ctdt.MaMon, ctdt.Ngay) == false)
            {
                ctdt.SoLuong = i;
                string dongia = ctdtBO.layDonGia(ctdt.MaMon);
                float dg = 0;
                float.TryParse(dongia, out dg);
                ctdt.TongTien = ctdt.SoLuong * dg;
                ctdtBO.ThemCTDoanhThu(ctdt);
            }

            if (cthdBO.kiemTraMonHD(cthd.MaHD, cthd.MaMon))
            {
                cthdBO.SuaCTHD(cthd);
                float dthu = 0;
                string doanhthu = dtBO.layDoanhThu(Convert.ToDateTime(dtNgay.Value.ToShortDateString()));
                float.TryParse(doanhthu, out dthu);
                dt.Tong = dthu + (cthd.SoLuong * cthd.DonGia);
                dtBO.SuaDoanhThu(dt);

                int slb = 0;
                string slban = ctdtBO.laySLBan(ct.MaMon);
                Int32.TryParse(slban, out slb);
                int slc = 0;
                string slcon = ctdtBO.laySLMonCu(ctdt.MaMon, txtMaBan.Text);
                Int32.TryParse(slcon, out i);
                ctdt.SoLuong = (slb + i) - slc;
                string dongia = ctdtBO.layDonGia(ctdt.MaMon);
                float dg = 0;
                float.TryParse(dongia, out dg);
                ctdt.TongTien = ctdt.SoLuong * dg;
                ctdtBO.SuaCTDoanhThu(ctdt);
            }
            else
            {
                if (cthdBO.ThemCTHD(cthd) == false)
                    MessageBox.Show("Không thể thêm chi tiết vào hóa đơn");
                float dthu = 0;
                string doanhthu = dtBO.layDoanhThu(Convert.ToDateTime(dtNgay.Value.ToShortDateString()));
                float.TryParse(doanhthu, out dthu);
                dt.Tong = dthu + (cthd.SoLuong * cthd.DonGia);
                dtBO.SuaDoanhThu(dt);

                int slb = 0;
                string slban = ctdtBO.laySLBan(ct.MaMon);
                Int32.TryParse(slban, out slb);
                ctdt.SoLuong = slb + i;
                string dongia = ctdtBO.layDonGia(ctdt.MaMon);
                float dg = 0;
                float.TryParse(dongia, out dg);
                ctdt.TongTien = ctdt.SoLuong * dg;
                ctdtBO.SuaCTDoanhThu(ctdt);
            }
            if (ctBO.NhapSoLuong(ct) == false)
                    MessageBox.Show("Không thể thêm số lượng");
            txtSoLuong.Text = "";
            binData();
        }

        private void btnTraGung_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Trà Gừng";
            string maMon = "LK004";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnTraLipton_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Trà Lipton";
            string maMon = "LK003";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnBoMon_Click(object sender, EventArgs e)
        {
            CTOder ct = getCTOder();
            CTHoaDon cthd = getCTHD();
            CTDoanhThu ctdt = getCTDoanhThu();
            if (txtMaMon.Text == "")
                MessageBox.Show("Vui lòng chọn món muốn bỏ!");
            else
            {
                string sl = ctBO.laySLMon(txtMaMon.Text, txtMaBan.Text);
                int i = 0;
                i = int.Parse(sl);
                int slc = int.Parse(txtSL.Text);
                if (i > 1)
                {
                    ct.SoLuong = slc - 1;
                    cthd.SoLuong = slc - 1;
                    ct.MaOder = int.Parse(txtMaOder.Text);
                    ct.MaMon = txtMaMon.Text;
                    cthd.MaMon = txtMaMon.Text;
                    if (ctBO.NhapSoLuong(ct) == false)
                        MessageBox.Show("Không thể bỏ món");
                    if (cthdBO.SuaCTHD(cthd) == false)
                        MessageBox.Show("Không thể bỏ món trong hóa đơn");
                }
                else
                {
                    ct.MaMon = txtMaMon.Text;
                    cthd.MaMon = txtMaMon.Text;
                    ct.MaBan = txtMaBan.Text;
                    if (ctBO.XoaMon(ct) && cthdBO.XoaMon(cthd))
                        MessageBox.Show("Đã xóa món");
                    else
                        MessageBox.Show("Không thể xóa món");
                }
            }
            ctdt.MaMon=txtMaMon.Text;
            int slb = 0;
            string slban = ctdtBO.laySLBan(ctdt.MaMon);
            Int32.TryParse(slban, out slb);
            ctdt.SoLuong = slb - 1;
            string dongia = ctdtBO.layDonGia(ctdt.MaMon);
            float dg = 0;
            float.TryParse(dongia, out dg);
            ctdt.TongTien = ctdt.SoLuong * dg;
            ctdtBO.SuaCTDoanhThu(ctdt);
            binData();

        }

        private void dgCTOder_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelect = e.RowIndex;
            txtMaMon.Text = dgCTOder.Rows[rowSelect].Cells[2].Value.ToString();
            txtSL.Text = dgCTOder.Rows[rowSelect].Cells[3].Value.ToString();
        }

        private void btnSuaChua_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Sữa Chua";
            string maMon = "SUA01";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnSuaTuoi_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Sữa Tươi";
            string maMon = "SUA02";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnSuaYomot_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Sữa Yomot";
            string maMon = "SUA03";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnStingVang_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Sting Vàng";
            string maMon = "NN001";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnStingDau_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Sting Dâu";
            string maMon = "NN002";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnPessi_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Pessi";
            string maMon = "NN003";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnCoCa_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Coca Cola";
            string maMon = "NN004";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnSevenUp_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Seven Up";
            string maMon = "NN005";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnRevive_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Revive";
            string maMon = "NN006";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnTraKhongDo_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Trà Không Độ";
            string maMon = "NN007";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "C2";
            string maMon = "NN008";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnCFDen_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Cà Phê Đen";
            string maMon = "CF001";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnCFSua_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Cà Phê Sữa";
            string maMon = "CF002";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnCFDenSG_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Cà Phê Đen SG";
            string maMon = "CF003";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnCFSuaSG_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Cà Phê Sữa SG";
            string maMon = "CF004";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnBocXiu_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Bộc Xỉu";
            string maMon = "CF005";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnNguaDieu_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Thuốc Ngựa Điếu";
            string maMon = "TL001";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnNguaGoi_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Thuốc Ngựa Gói";
            string maMon = "TL002";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnMarlDieu_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Thuốc Marlboro Điếu";
            string maMon = "TL003";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }

        private void btnMarlGoi_Click(object sender, EventArgs e)
        {
            gbSoLuong.Visible = true;
            txtMonDaChon.Text = "Thuốc Marlboro Gói";
            string maMon = "TL004";
            string maBan = txtMaBan.Text;
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            CTOder ct = getCTOder();
            if (ctBO.kiemTraMon(maMon, maBan,i) == false)
                if (ctBO.ThemCTOder(ct) == false)
                    MessageBox.Show("Không thể thêm món");
            binData();
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmReportHD report;
            report = new frmReportHD(txtMaOder.Text,txtMaBan.Text );
            report.Show();
            this.Close();
        }

        private void btnTinhTien_Click_1(object sender, EventArgs e)
        {          
            BanCoKhach bck = getBanCoKhach();
            Oder od = getOder();
            CTOder ctod = getCTOder();
            int i = 0;
            Int32.TryParse(txtMaOder.Text, out i);
            ctod.MaOder = i;
            gbChonNhom.Visible = false;
            btnHoaDon.Visible = true;
            bckBO.XoaBanCoKhach(bck);
            ctBO.XoaCTOder(ctod);    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtSoLuong.Text = "";
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            int i = 0;
            Int32.TryParse(txtMaOder.Text,out i);
            if (ctBO.kiemTraGoiMon(i)==false)
                MessageBox.Show("Bàn " + txtMaBan.Text + " chưa có khách nên không cần chuyển.");
            else
                gbChuyenBan.Visible = true;
        }

        private void btnOKChuyen_Click(object sender, EventArgs e)
        {
            BanCoKhach bck = getBanCoKhach();
            Oder od = getOder();
            CTOder ctod = getCTOder();
            HoaDon hd = getHD();
            int maod = 0;
            Int32.TryParse(txtMaOder.Text, out maod);
            int soban = 0;
            Int32.TryParse(txtBanChuyen.Text, out soban);
            string maban = odBO.layMaBan(soban);
            od.MaBan = maban;
            ctod.MaBan = maban;
            hd.MaBan = maban;
            bck.MaBan=txtMaBan.Text;
            bckBO.XoaBanCoKhach(bck);
            bck.MaBan=maban;
            if (bckBO.ThemBanCoKhach(bck) && odBO.ChuyenBan(od) && ctBO.ChuyenBan(ctod) && hdBO.ChuyenBan(hd))
                MessageBox.Show("Đã chuyển bàn");
            BanSDNhieu bsd1 = getBanSDNhieu();
            BanSDNhieu bsd2 = new BanSDNhieu();
            bsd2.MaBan = txtBanChuyen.Text;
            string soban2 = bsdBO.laySoBan(txtBanChuyen.Text);
            int sb2 = 0;
            Int32.TryParse(soban2, out sb2);
            bsd2.SoBan = sb2;
            string luotsd2 = bsdBO.layLuotSD(txtBanChuyen.Text);
            int lsd2 = 0;
            Int32.TryParse(luotsd2, out lsd2);
            int luotsddung2 = lsd2 + 1;
            bsd2.LuotSD = luotsddung2;
            bsdBO.SuaLuotSD(bsd2);

            string luotsd1 = bsdBO.layLuotSD(txtMaBan.Text);
            int lsd1 = 0;
            Int32.TryParse(luotsd1, out lsd1);
            int luotsddung1 = lsd1 + 1;
            bsd1.LuotSD = luotsddung1;
            bsdBO.SuaLuotSD(bsd1);
        }
    }
}
