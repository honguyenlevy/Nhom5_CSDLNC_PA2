use ADB1_5_DATH2
go
---------------------------------------------------------------------
create trigger trigger_ThanhTien_updateSL
on CT_HOADON
for insert, update, delete	as
if update (SoLuong)
begin
	if exists (select SoLuong from CT_HOADON where SoLuong < 0) 
	begin
		raiserror (N'Số lượng sản phẩm không hợp lệ', 10, 1)
		rollback transaction
	end

	update CT_HOADON
	set ThanhTien = cthd.SoLuong * (select GiaSP from SANPHAM where SANPHAM.MaSP = cthd.MaSP)
	from inserted i, SANPHAM sp, CT_HOADON cthd
	where 
		sp.MaSP = i.MaSP and
		sp.MaSP = cthd.MaSP
end
go
---------

create trigger trigger_ThanhTien_updateGia
on SANPHAM
for insert, update, delete	as
if update (GiaSP)
begin
	if exists (select GiaSP from SANPHAM where GiaSP < 0) 
	begin
		raiserror (N'Giá sản phẩm không hợp lệ', 10, 1)
		rollback transaction
	end

	update CT_HOADON
	set ThanhTien = cthd.SoLuong * (select GiaSP from SANPHAM where SANPHAM.MaSP = cthd.MaSP)
	from inserted i, SANPHAM sp, CT_HOADON cthd
	where 
		sp.MaSP = i.MaSP and
		sp.MaSP = cthd.MaSP
end
go
---------

create trigger trigger_TongTien
on CT_HOADON 
for insert, delete, update	as
begin
	update HOADON 
	set TongTien = (select sum(ThanhTien)
					from CT_HOADON
					where CT_HOADON.MaHD = HOADON.MaHD)	+ PhiVanChuyen
	where 
		exists (select * from deleted d	 where d.MaHD = HOADON.MaHD) or
		exists (select * from inserted i where i.MaHD = HOADON.MaHD) 
end
go

------------------------------------------------------------------------------
-- Test
select * from HOADON where MaHD = N'HD000009'
select * from CT_HOADON where MaHD = N'HD000009'
select * from SANPHAM where MaSP = N'sp1002'

insert into SANPHAM (MaSP, TenSP, GiaSP) values (N'sp1002', N'Hershey kisses', 13000)
insert into CT_HOADON(MaHD, MaSP, SoLuong) values (N'HD000009', N'sp1002', 15)

delete from CT_HOADON where MaHD = N'HD000009' and MaSP = N'sp1002'
delete from SANPHAM where MaSP = N'sp1002'

update CT_HOADON set SoLuong = 7 where MaHD = N'HD000009' and MaSP = N'sp1002'
update SANPHAM set GiaSP = -10000 where MaSP = N'sp1002'
