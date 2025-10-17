-- 1️⃣ Xóa database nếu đã tồn tại
IF EXISTS (SELECT * FROM sys.databases WHERE name = N'VanQuyVuong')
BEGIN
    USE master;
    ALTER DATABASE VanQuyVuong SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE VanQuyVuong;
END
GO

-- 2️⃣ Tạo mới database
CREATE DATABASE VanQuyVuong;
GO

-- 3️⃣ Sử dụng database mới
USE VanQuyVuong;
GO

-- 4️⃣ Tạo bảng student
CREATE TABLE student (
    Code CHAR(6) PRIMARY KEY,
    Name NVARCHAR(50),
    Class VARCHAR(10),
    Address NVARCHAR(100)
);
GO

-- 5️⃣ Thêm dữ liệu mẫu vào bảng student
INSERT INTO student VALUES
('S01', N'Văn Quý Vuong', 'XML03', N'Quảng Nam'),
('S02', N'Nguyễn Cửu Thành Đạt', 'XML03', N'Đà Nẵng'),
('S03', N'Lê Đức Văn Thư', 'XML02', N'Quảng Nam'),
('S04', N'Nguyễn Hữu Tuấn', 'XML02', N'Điện Bàn');
GO

-- 6️⃣ Kiểm tra dữ liệu
SELECT * FROM student;
