create database ADB1_5_DATH2
go
------------------------------------------------------

create table CHINHANH 
(
	MaCN nvarchar(10),
	DiaChiCN nvarchar(150),
	SoDienThoai nvarchar(15)
	constraint PK_CHINHANH primary key (MaCN)
)

create table NHANVIEN 
(
	MaNV nvarchar(10),
	TenNV nvarchar(50),
	CMND nvarchar(15),
	DiaChi nvarchar(150),
	SoDienThoai nvarchar(15),
	Email nvarchar(50),
	MaCN nvarchar(10)
	constraint PK_NHANVIEN primary key (MaNV)
)

create table HTTHANHTOAN 
(
	MaHTTT nvarchar(10),
	TenHTTT nvarchar(50)
	constraint PK_HTTHANHTOAN primary key (MaHTTT)
)

create table KHACHHANG
(
	MaKH nvarchar(10),
	TenKH nvarchar(50),
	DiaChi nvarchar(150),
	SoDienThoai nvarchar(15),
	Email nvarchar(50)
	constraint PK_KHACHHANG primary key (MaKH)
)

create table HOADON
(
	MaHD nvarchar(10),
	NgayMua date,
	TongTien bigint,
	YeuCauGiao nvarchar(10),
	PhiVanChuyen bigint,
	MaHTTT nvarchar(10),
	MaNV nvarchar(10),
	MaKH nvarchar(10)
	constraint PK_HOADON primary key (MaHD)
)

create table NV_GIAOHANG 
(
	MaNVGH nvarchar(10),
	TenNVGH nvarchar(50),
	CMND nvarchar(15),
	DiaChi nvarchar(150),
	SoDienThoai nvarchar(15),
	Email nvarchar(50)
	constraint PK_NVGIAOHANG primary key (MaNVGH)
)

create table DONGH_KHACH
(
	MaDGHK nvarchar(10),
	DiaChiGiaoHang nvarchar(150),
	TinhTrangGiao nvarchar(50),
	MaHD nvarchar(10),
	MaNVGH nvarchar(10)
	constraint PK_DONGHKHACH primary key (MaDGHK)
)

create table NHACUNGCAP 
(
	MaNCC nvarchar(10),
	TenNCC nvarchar(50),
	DiaChiNCC nvarchar(150),
	SoDienThoai nvarchar(15)
	constraint PK_NHACUNGCAP primary key (MaNCC)
)

create table SANPHAM 
(
	MaSP nvarchar(10),
	TenSP nvarchar(50),
	GiaSP bigint,
	SoLuong int,
	MoTa nvarchar(150)
	constraint PK_SANPHAM primary key (MaSP)
)

create table CUNGCAP_SP 
(
	MaNCC nvarchar(10),
	MaSP nvarchar(10)
	constraint PK_CUNGCAPSP primary key (MaNCC, MaSP)
)

create table CT_HOADON 
(
	MaHD nvarchar(10),
	MaSP nvarchar(10),
	SoLuong int,
	ThanhTien bigint
	constraint PK_CTHOADON primary key (MaHD, MaSP)
)

create table PHIEUDATHANG 
(
	MaPDH nvarchar(10),
	NgayDatHang date,
	MaNCC nvarchar(10)
	constraint PK_PHIEUDATHANG primary key (MaPDH)
)

create table CT_PHIEUDATHANG 
(
	MaPDH nvarchar(10),
	MaSP nvarchar(10),
	SoLuongDH int,
	DonGia bigint
	constraint PK_CTPHIEUDATHANG primary key (MaPDH, MaSP)
)

create table PHIEUGIAOHANG 
(
	MaPGH nvarchar(10),
	NgayGiaoHang date,
	TongTien bigint,
	MaPDH nvarchar(10)
	constraint PK_PHIEUGIAOHANG primary key (MaPGH)
)

create table CT_PHIEUGIAOHANG 
(
	MaPGH nvarchar(10),
	MaSP nvarchar(10),
	SoLuongGH int,
	ThanhTien bigint
	constraint PK_CTPHIEUGIAOHANG primary key (MaPGH, MaSP)
)

alter table NHANVIEN add
	constraint FK_NHANVIEN_CHINHANH foreign key (MaCN) references CHINHANH (MaCN)

alter table HOADON add
	constraint FK_HOADON_NHANVIEN 		foreign key (MaNV) 	references NHANVIEN (MaNV),
	constraint FK_HOADON_HTTHANHTOAN	foreign key (MaHTTT) 	references HTTHANHTOAN (MaHTTT),
	constraint FK_HOADON_KHACHHANG 		foreign key (MaKH) 	references KHACHHANG (MaKH)

alter table DONGH_KHACH add
	constraint FK_DONGHKHACH_HOADON 	foreign key (MaHD) 	references HOADON (MaHD),
	constraint FK_DONGHKHACH_NVGIAOHANG 	foreign key (MaNVGH) 	references NV_GIAOHANG (MaNVGH)

alter table CUNGCAP_SP add
	constraint FK_CUNGCAPSP_NHACUNGCAP	foreign key (MaNCC) 	references NHACUNGCAP (MaNCC),
	constraint FK_CUNGCAPSP_SANPHAM 	foreign key (MaSP) 	references SANPHAM (MaSP)

alter table CT_HOADON add
	constraint FK_CTHOADON_HOADON 	foreign key (MaHD) 	references HOADON (MaHD),
	constraint FK_CTHOADON_SANPHAM  foreign key (MaSP) 	references SANPHAM (MaSP)

alter table CT_PHIEUDATHANG add
	constraint FK_CTPHIEUDATHANG_SANPHAM 		foreign key (MaSP) 	references SANPHAM (MaSP),
	constraint FK_CTPHIEUDATHANG_PHIEUDATHANG 	foreign key (MaPDH) 	references PHIEUDATHANG (MaPDH)

alter table CT_PHIEUGIAOHANG add
	constraint FK_CTPHIEUGIAOHANG_SANPHAM 		foreign key (MaSP) 	references SANPHAM (MaSP),
	constraint FK_CTPHIEUGIAOHANG_PHIEUGIAOHANG 	foreign key (MaPGH) 	references PHIEUGIAOHANG (MaPGH)

alter table PHIEUDATHANG add
	constraint FK_PHIEUDATHANG_NHACUNGCAP 	foreign key (MaNCC) 	references NHACUNGCAP (MaNCC)

alter table PHIEUGIAOHANG add
	constraint FK_PHIEUGIAOHANG_PHIEUDATHANG 	foreign key (MaPDH) 	references PHIEUDATHANG (MaPDH)
