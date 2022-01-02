use ADB1_5_DATH2
go

--Index

-- 1. Khách hàng có nhu cầu tìm kiếm giá sản phẩm thông qua tên sản phẩm
set statistics io on
set statistics time on
select GiaSP from SANPHAM where TenSP = N'Đầm bầu 665'

--CREATE NONCLUSTERED INDEX index_TenSP on SANPHAM(TenSP)


-- 2. Khách hàng xem tổng tiền của hóa đơn
set statistics io on
set statistics time on
select MaHD, TongTien from HOADON where MaHD = '10'

--CREATE INDEX index_MaHD on HOADON(MaHD)

-- 3. Khách hàng xem tình trạng đơn giao hàng
set statistics io on
set statistics time on
select MaDGHK, TinhTrangGiao from DONGH_KHACH where MaDGHK = '20'

--CREATE INDEX index_MaDGHK on DONGH_KHACH(MaDGHK)

-- 4. Khi nhân viên nhập hóa đơn, nhân viên sẽ tìm mã khách hàng thông qua Số điện thoại để nhập vào hóa đơn
set statistics io on
set statistics time on
select * from KHACHHANG where SoDienThoai = '09300157622'


CREATE INDEX index_SoDienThoai on KhachHang(SoDienThoai)

-- 5. Nhân viên giao hàng xem địa chỉ giao hàng của khách dựa trên mã đơn giao
set statistics io on
set statistics time on
select MaDGHK, DiaChiGiaoHang from DONGH_KHACH where MaDGHK = '14'


--CREATE INDEX index_MaDGHK on DONGH_KHACH(MaDGHK)

-- 6. Nhân viên xem số lượng tồn của của sản phẩm
set statistics io on
set statistics time on
select MaSP, TenSP, SoLuong from SANPHAM

--CREATE INDEX index_MaSP on SANPHAM(MaSP,TenSP,SoLuong)

-- 7. Quản trị xem các nhân viên ở chi nhánh “A”
set statistics io on
set statistics time on
select * from NHANVIEN where MaCN = '23727'

CREATE INDEX index_MaCN on NHANVIEN(MaCN)

-- 8. Quản trị xem các hóa đơn của ngày nào
set statistics io on
set statistics time on
select * from HOADON where NgayMua = '2021-05-07'

CREATE INDEX index_NGayMua on HoaDon(NgayMua)

-- 9.Quản trị xem các phiếu giao hàng của phiếu đặt hàng “A” 
set statistics io on
set statistics time on
select * from PHIEUGIAOHANG where MaPDH = '9298731'

CREATE INDEX index_MaPDH on PHIEUGIAOHANG(MaPDH)


--Đề xuất cải thiện hiệu quả truy xuất truy vấn
--1. Sử dụng SELECT những trường cần thiết thay vì SELECT 
set statistics io on
set statistics time on
SELECT MaNV, TenNV FROM NHANVIEN

--thay vì
set statistics io on
set statistics time on
SELECT * FROM NHANVIEN

--2. Sử dụng WHERE thay vì HAVING
--Ví dụ: Đếm số lượng hóa đơn bán trong ngày 2021-04-13
set statistics io on
set statistics time on
SELECT NgayMua, count(*) as 'soluongban'
from HOADON 
where NgayMua = '2021-04-13'
group by NgayMua

--thay vì
set statistics io on
set statistics time on
SELECT NgayMua, count(*) as 'soluongban'
from HOADON
group by NgayMua
having NgayMua = '2021-04-13'

--3. Sử dụng EXISTS thay cho IN đối với cơ sở dữ liệu lớn
set statistics io on
set statistics time on
SELECT *
FROM HOADON HD
WHERE EXISTS (
    SELECT *
    FROM KHACHHANG KH
    WHERE KH.MaKH = HD.MaKH
) 
--thay vì
set statistics io on
set statistics time on
SELECT *
FROM HOADON
WHERE MaKH IN (
    SELECT MaKH
    FROM KHACHHANG
)

--4. Các biểu thức không liên quan tới các cột để riêng một bên 
--thay vì để chung với các cột bởi chúng sẽ tính đi tính lại mỗi lần nạp một bản ghi vào để tính toán
set statistics io on
set statistics time on
SELECT MAHD, NgayMua
FROM HOADON
WHERE TongTien > 100000

--thay vì
set statistics io on
set statistics time on
SELECT MAHD, NgayMua
FROM HOADON
WHERE TongTien + 50000 > 150000

--5. Sử dụng Like hợp lý có dạng : LIKE 'V%' thay vì LIKE '%V%'
set statistics io on
set statistics time on
SELECT MaKH, TenKH 
FROM KHACHHANG 
WHERE TenKH LIKE N'Tú%'

--thay vì
set statistics io on
set statistics time on
SELECT MaKH, TenKH 
FROM KHACHHANG 
WHERE TenKH LIKE N'%Tú%'