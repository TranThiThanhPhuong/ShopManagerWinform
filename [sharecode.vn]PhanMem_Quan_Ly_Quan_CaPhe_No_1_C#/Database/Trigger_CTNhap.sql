CREATE TRIGGER SoLuongNL_Nhap_Insert ON  tblCTNhapNL FOR insert    
AS 
	update tblNguyenLieu
	set tblNguyenLieu.SoLuongCon=tblNguyenLieu.SoLuongCon + Inserted.SoLuong
	from tblNguyenLieu inner join Inserted on tblNguyenLieu.MaNL=Inserted.MaNL

GO

CREATE TRIGGER SoLuongNL_Nhap_Delete ON  tblCTNhapNL FOR delete    
AS 
	update tblNguyenLieu
	set tblNguyenLieu.SoLuongCon=tblNguyenLieu.SoLuongCon - deleted.SoLuong
	from tblNguyenLieu inner join deleted on tblNguyenLieu.MaNL=deleted.MaNL

GO

CREATE TRIGGER SoLuongNL_Nhap_Update ON  tblCTNhapNL FOR update    
AS 
	if update(SoLuong)
	update tblNguyenLieu
	set tblNguyenLieu.SoLuongCon=tblNguyenLieu.SoLuongCon + (inserted.SoLuong-deleted.SoLuong)
	from (deleted inner join inserted on deleted.MaNL=inserted.MaNL) inner join tblNguyenLieu on tblNguyenLieu.maNL=deleted.MaNL
