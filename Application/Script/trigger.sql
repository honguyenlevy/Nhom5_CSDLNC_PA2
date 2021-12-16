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

alter trigger trigger_PhiVanChuyen
on HOADON 
for insert, delete, update	as
begin
	if exists (select YeuCauGiao from HOADON where YeuCauGiao = N'Không') 
	begin
		update HoaDon 
		set PhiVanChuyen = 0
		where 
			exists (select * from deleted d	 where d.MaHD = HoaDon.MaHD) or
			exists (select * from inserted i where i.MaHD = HoaDon.MaHD) 
	end
	else
	begin
		update HoaDon 
		set PhiVanChuyen = 35000
		where 
			exists (select * from deleted d	 where d.MaHD = HoaDon.MaHD) or
			exists (select * from inserted i where i.MaHD = HoaDon.MaHD) 
	end
end
go

create trigger trigger_DonGia
on CT_PHIEUDATHANG
for insert, update, delete	as
begin
	if exists (select SoLuongDH from CT_PHIEUDATHANG where SoLuongDH < 0) 
	begin
		raiserror (N'Số lượng sản phẩm không hợp lệ', 10, 1)
		rollback transaction
	end

	if exists (select DonGia from CT_PHIEUDATHANG where DonGia < 0) 
	begin
		raiserror (N'Giá sản phẩm không hợp lệ', 10, 1)
		rollback transaction
	end

	update	CT_PHIEUDATHANG
	set DonGia = (select GiaSP from SANPHAM where SANPHAM.MaSP = ctpdh.MaSP) - 20000
	from inserted i, SANPHAM sp, CT_PHIEUDATHANG ctpdh
	where 
		sp.MaSP = i.MaSP and
		sp.MaSP = ctpdh.MaSP
end
go

delete from CT_HOADON where MaHD = 'HD000009' and MaSP = 'SP205768'
insert into	CT_HOADON(MaHD, MaSP, SoLuong, ThanhTien) values (N'HD000009', N'SP205768', 5, 0)

delete from HOADON where MaHD = 'HD000001'
insert into HOADON(MaHD, NgayMua, TongTien, YeuCauGiao, PhiVanChuyen, MaHTTT, MaNV, MaKH) values ('HD000001', '2020-05-19', 0, N'Không', 0, 'HTTT1', 'NV297717', 'KH150692')

delete from CT_PHIEUDATHANG where MaPDH = 'PDH000111' and MaSP = 'SP166908'
insert into CT_PHIEUDATHANG(MaPDH, MaSP, SoLuongDH, DonGia) values ('PDH000111', 'SP166908', 10, 0)

select * from SANPHAM where MaSP = 'SP166908'
select * from CT_PHIEUDATHANG where MaSP = 'SP166908'