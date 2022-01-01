use ADB1_5_DATH2
go

--Index
--Khách hàng có nhu cầu tìm kiếm các sản phẩm thông qua tên sản phẩm 
-- Tần suất truy vấn: Trung bình 1000 lần/giờ
--					  Cao diểm 5000 lần/giờ
set statistics io on
set statistics time on
select * from SANPHAM where TenSP = N'Màn chụp'

CREATE INDEX index_TenSP on SANPHAM(TenSP)

--Khách hàng thường xuyên xem hóa đơn của mình
-- Tần suất truy vấn: Trung bình 50 lần/giờ
--					  Cao diểm 100 lần/giờ
set statistics io on
set statistics time on
select * from HOADON where NgayMua = '2021-04-13'

CREATE INDEX index_MaHD_NGayMua on HoaDon(MaHD, NgayMua)

--Khi nhân viên nhập hóa đơn, nhân viên sẽ tìm mã khách hàng thông qua Số điện thoại để nhập vào hóa đơn
-- Tần suất truy vấn: Trung bình 1000 lần/giờ
--					  Cao diểm 5000 lần/giờ
set statistics io on
set statistics time on
select * from KHACHHANG where SoDienThoai = '07624163634'


CREATE INDEX index_MaKH_SoDienThoai on KhachHang(MaKH, SoDienThoai)

--Xem tình trạng giao hàng của đơn hàng
-- Tần suất truy vấn: Trung bình 2000 lần/giờ
--					  Cao diểm 5000 lần/giờ
set statistics io on
set statistics time on
select * from DONGH_KHACH where MaHD = 'HD694638'

CREATE INDEX index_MaHD on DONGH_KHACH(MaHD)

--Xem hóa đơn của khách hàng nào
-- Tần suất truy vấn: Trung bình 100 lần/giờ
--					  Cao diểm 500 lần/giờ
set statistics io on
set statistics time on
select * from HOADON where MaHD = 'HD000009' and MaKH = 'KH150692'

CREATE INDEX index_MaHD_MaKH on HOADON(MaHD, MaKH)

--Xem số lượng tồn của sản phẩm
-- Tần suất truy vấn: Trung bình 10 lần/giờ
--					  Cao diểm 50 lần/giờ
set statistics io on
set statistics time on
select MaSP, TenSP, SoLuong from SANPHAM

CREATE INDEX index_MaSP_TenSP_SoLuong on SANPHAM(MaSP,TenSP,SoLuong)

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
