create database ADB1_5_DATH2
go
use ADB1_5_DATH2
go
------------------------------------------------------

create table CHINHANH 
(
	MaCN int identity (1,1),
	DiaChiCN nvarchar(150),
	SoDienThoai char(15)
	constraint PK_CHINHANH primary key (MaCN)
)

create table NHANVIEN 
(
	MaNV int identity (1,1),
	TenNV nvarchar(50),
	CMND nvarchar(15),
	DiaChi nvarchar(150),
	SoDienThoai char(15),
	Email nvarchar(50),
	MaCN int
	constraint PK_NHANVIEN primary key (MaNV)
)

create table HTTHANHTOAN 
(
	MaHTTT int identity (1,1),
	TenHTTT nvarchar(50)
	constraint PK_HTTHANHTOAN primary key (MaHTTT)
)

create table KHACHHANG
(
	MaKH int identity (1,1),
	TenKH nvarchar(50),
	DiaChi nvarchar(150),
	SoDienThoai char(15),
	Email nvarchar(50)
	constraint PK_KHACHHANG primary key (MaKH)
)

create table HOADON
(
	MaHD int identity (1,1),
	NgayMua date,
	TongTien bigint,
	YeuCauGiao nvarchar(10),
	PhiVanChuyen bigint,
	MaHTTT int,
	MaNV int,
	MaKH int
	constraint PK_HOADON primary key (MaHD)
)

create table NV_GIAOHANG 
(
	MaNVGH int identity (1,1),
	TenNVGH nvarchar(50),
	CMND nvarchar(15),
	DiaChi nvarchar(150),
	SoDienThoai char(15),
	Email nvarchar(50)
	constraint PK_NVGIAOHANG primary key (MaNVGH)
)

create table DONGH_KHACH
(
	MaDGHK int identity (1,1),
	DiaChiGiaoHang nvarchar(150),
	TinhTrangGiao nvarchar(50),
	MaHD int,
	MaNVGH int
	constraint PK_DONGHKHACH primary key (MaDGHK)
)

create table NHACUNGCAP 
(
	MaNCC int identity (1,1),
	TenNCC nvarchar(50),
	DiaChiNCC nvarchar(150),
	SoDienThoai char(15)
	constraint PK_NHACUNGCAP primary key (MaNCC)
)

create table SANPHAM 
(
	MaSP int identity (1,1),
	TenSP nvarchar(50),
	GiaSP bigint,
	SoLuong int,
	MoTa nvarchar(150)
	constraint PK_SANPHAM primary key (MaSP)
)

create table CUNGCAP_SP 
(
	MaNCC int,
	MaSP int
	constraint PK_CUNGCAPSP primary key (MaNCC, MaSP)
)

create table CT_HOADON 
(
	MaHD int,
	MaSP int,
	SoLuong int,
	ThanhTien bigint
	constraint PK_CTHOADON primary key (MaHD, MaSP)
)

create table PHIEUDATHANG 
(
	MaPDH int identity (1,1),
	NgayDatHang date,
	MaNCC int
	constraint PK_PHIEUDATHANG primary key (MaPDH)
)

create table CT_PHIEUDATHANG 
(
	MaPDH int,
	MaSP int,
	SoLuongDH int,
	DonGia bigint
	constraint PK_CTPHIEUDATHANG primary key (MaPDH, MaSP)
)

create table PHIEUGIAOHANG 
(
	MaPGH int identity (1,1),
	NgayGiaoHang date,
	TongTien bigint,
	MaPDH int
	constraint PK_PHIEUGIAOHANG primary key (MaPGH)
)

create table CT_PHIEUGIAOHANG 
(
	MaPGH int,
	MaSP int,
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
