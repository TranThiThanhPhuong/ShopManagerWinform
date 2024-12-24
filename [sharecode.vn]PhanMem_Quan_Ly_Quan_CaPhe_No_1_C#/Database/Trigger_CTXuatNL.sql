CREATE TRIGGER SoLuongNL_Xuat_Insert ON  tblCTXuatNL FOR insert    
AS 
	update tblNguyenLieu
	set tblNguyenLieu.SoLuongCon=tblNguyenLieu.SoLuongCon - Inserted.SoLuong
	from tblNguyenLieu inner join Inserted on tblNguyenLieu.MaNL=Inserted.MaNL

GO

CREATE TRIGGER SoLuongNL_Xuat_Delete ON  tblCTXuatNL FOR delete    
AS 
	update tblNguyenLieu
	set tblNguyenLieu.SoLuongCon=tblNguyenLieu.SoLuongCon + deleted.SoLuong
	from tblNguyenLieu inner join deleted on tblNguyenLieu.MaNL=deleted.MaNL

GO

CREATE TRIGGER SoLuongNL_Xuat_Update ON  tblCTXuatNL FOR update    
AS 
	if update(SoLuong)
	update tblNguyenLieu
	set tblNguyenLieu.SoLuongCon=tblNguyenLieu.SoLuongCon - (inserted.SoLuong-deleted.SoLuong)
	from (deleted inner join inserted on deleted.MaNL=inserted.MaNL) inner join tblNguyenLieu on tblNguyenLieu.maNL=deleted.MaNL

