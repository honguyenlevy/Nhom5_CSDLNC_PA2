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
select * from HOADON where MaHD = 2
select * from CT_HOADON where MaHD = 2
select * from SANPHAM where MaSP = 1
select * from SANPHAM where MaSP = 2
select * from SANPHAM where MaSP = 13568

insert into SANPHAM (TenSP, GiaSP) values (N'Hershey kisses', 13000)
insert into CT_HOADON(MaHD, MaSP, SoLuong) values (2, 13568, 15)

delete from CT_HOADON where MaHD = 2 and MaSP = 13568
delete from SANPHAM where MaSP = 13568

update CT_HOADON set SoLuong = 7 where MaHD = 2 and MaSP = 13568
update SANPHAM set GiaSP = -10000 where MaSP = 13568
