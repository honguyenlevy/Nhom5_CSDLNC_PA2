use ADB1_5_DATH2
go

--1. Khách hàng tìm kiếm các sản phẩm thông qua tên sản phẩm
CREATE OR ALTER PROCEDURE TIM_SP
(
	@TENSP NVARCHAR(50)
)
AS 
	BEGIN TRAN
		SELECT * FROM SANPHAM
		WHERE TenSP = @TENSP
	COMMIT TRAN
GO

--2. Khách hàng xem tổng tiền của hóa đơn theo mã hóa đơn
CREATE OR ALTER PROCEDURE KH_XEM_TONGTIEN
(
	@MaHD INT
)
AS 
	BEGIN TRAN
		SELECT TongTien FROM HOADON
		WHERE MaHD = @MaHD
	COMMIT TRAN
GO

--3. Khách hàng xem tình trạng đơn hàng của mình dựa trên mã giao hàng
CREATE OR ALTER PROCEDURE KH_XEM_TINHTRANGDONHANG
(
	@MANVGH INT
)
AS
	BEGIN TRAN
		SELECT TinhTrangGiao FROM DONGH_KHACH WHERE MaNVGH = @MANVGH
	COMMIT TRAN
GO

--4. Khi nhân viên lập hóa đơn, nhân viên sẽ tìm khách hàng thông qua số điện thoại để nhập vào hóa đơn
CREATE OR ALTER PROCEDURE NV_TIM_KH_THEO_SDT
(
	@SODIENTHOAI INT
)
AS
	BEGIN TRAN
		SELECT * FROM KHACHHANG WHERE SoDienThoai = @SODIENTHOAI
	COMMIT TRAN
GO

--5. Nhân viên giao hàng xem địa chỉ giao hàng của khách dựa trên mã đơn giao
CREATE OR ALTER PROCEDURE NVGH_XEM_DIACHIGIAOHANG
(
	@MANVGH INT
)
AS
	BEGIN TRAN
		SELECT DiaChiGiaoHang FROM DONGH_KHACH WHERE MaNVGH = @MANVGH
	COMMIT TRAN
GO

--6. Nhân viên xem số lượng tồn của sản phẩm theo mã sản phẩm
CREATE OR ALTER PROCEDURE XEM_SL_TON
(
	@MASP INT
)
AS 
	BEGIN TRAN
		SELECT SoLuong FROM SANPHAM WHERE MaSP = @MASP
	COMMIT TRAN
GO

--7. Quản trị xem các nhân viên theo mã chi nhánh
CREATE OR ALTER PROCEDURE QT_XEM_NV_THEO_MACN
(
	@MACN INT
)
AS 
	BEGIN TRAN
		SELECT * FROM NHANVIEN WHERE MaCN = @MACN
	COMMIT TRAN
GO

--8. Quản trị xem các hóa đơn của ngày mua hàng "01/01/2021"
CREATE OR ALTER PROCEDURE QT_XEM_HD_THEO_NGAY
(
	@NGAYMUA DATE
)
AS 
	BEGIN TRAN
		SELECT * FROM HOADON WHERE NgayMua = @NGAYMUA
	COMMIT TRAN
GO

--9. Quản trị xem các phiếu giao hàng theo mã phiếu đặt hàng
CREATE OR ALTER PROCEDURE QT_XEM_PGH_THEO_PDH
(
	@MAPDH INT
)
AS 
	BEGIN TRAN
		SELECT * FROM PHIEUGIAOHANG WHERE MaPDH = @MAPDH
	COMMIT TRAN
GO
