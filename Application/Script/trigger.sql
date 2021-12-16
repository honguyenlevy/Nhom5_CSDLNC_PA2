use ADB1_5_DATH2
go

update	CT_HOADON
set ThanhTien = SoLuong * (select GiaSP from SANPHAM where SANPHAM.MaSP = CT_HOADON.MaSP)

create trigger trigger_ThanhTien
on CT_HOADON
for insert, update, delete	as
if update (SoLuong)
begin
	if exists (select SoLuong from CT_HOADON where SoLuong < 0) 
	begin
		raiserror (N'Số lượng sản phẩm không hợp lệ', 10, 1)
		rollback transaction
	end

	if exists (select ThanhTien from CT_HOADON where ThanhTien < 0) 
	begin
		raiserror (N'Giá sản phẩm không hợp lệ', 10, 1)
		rollback transaction
	end

	update	CT_HOADON
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
	update HoaDon 
	set TongTien = (select sum(ThanhTien)
					from CT_HOADON
					where CT_HOADON.MaHD = HOADON.MaHD)	+ PhiVanChuyen
	where 
		exists (select * from deleted d	 where d.MaHD = HoaDon.MaHD) or
		exists (select * from inserted i where i.MaHD = HoaDon.MaHD) 
end
go

delete from CT_HOADON where MaHD = 'HD000009' and MaSP = 'SP205768'
insert into	CT_HOADON(MaHD, MaSP, SoLuong, ThanhTien) values (N'HD000009', N'SP205768', 5, 0)

select * from HOADON

select * from CT_HOADON

select * from SANPHAM