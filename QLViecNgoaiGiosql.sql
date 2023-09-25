﻿create database QLViecNgoaiGio
on
(
	name = 'QLViecNgoaiGio_Data',
	filename = 'D:\DaiHoc\DatabaseQLViecNgoaiGio\QLViecNgoaiGio_Data.MDF'
)
log on
(
	name = 'QLViecNgoaiGio_Log',
	filename = 'D:\DaiHoc\DatabaseQLViecNgoaiGio\QLViecNgoaiGio_Log.LDF'
)
use QLViecNgoaiGio

create table DANGKY
(
	ID INT IDENTITY(1,1) NOT NULL CONSTRAINT pk_ID primary key(ID),
	TUNGAY DATE NULL,
	DENNGAY DATE NULL,
	TUGIO  NVARCHAR(10) NULL,
	DENGIO NVARCHAR(10) NULL,
	NGUOIDANGKY NVARCHAR(100) NULL,
	LYDO NVARCHAR(200) NULL
)

create table TaiKhoan
(
	MATAIKHOAN NVARCHAR(50) NOT NULL CONSTRAINT pk_MaTaiKhoan primary key(MATAIKHOAN),
	TENTAIKHOAN NVARCHAR(50) NOT NULL,
	MATKHAU NVARCHAR(50) NOT NULL,
	QUYEN INT NOT NULL,
	MOTAQUYEN NVARCHAR(50) NOT NULL,
)

DELETE FROM TaiKhoan
SELECT * FROM TaiKhoan
INSERT INTO TAIKHOAN VALUES ('TK01', 'minhhao', 'abc123', 0, N'Nhân viên VIP')
INSERT INTO TAIKHOAN VALUES ('TK02', 'ducduy', '123abc', 1, N'Nhân viên thường')
INSERT INTO TAIKHOAN VALUES ('TK03', 'duytung', '123abc', 1, N'Nhân viên thường')
INSERT INTO TAIKHOAN VALUES ('TK04', 'haominh', 'abc123', 0, N'Nhân viên VIP')

CREATE PROC SP_INSERT_DANGKY
	@TUNGAY DATE,
	@DENNGAY DATE,
	@TUGIO  NVARCHAR(10),
	@DENGIO NVARCHAR(10),
	@NGUOIDANGKY NVARCHAR(100),
	@LYDO NVARCHAR(200)
	AS
	INSERT INTO DangKy VALUES (@TUNGAY,@DENNGAY,@TUGIO,@DENGIO,@NGUOIDANGKY,@LYDO)
GO

EXEC SP_INSERT_DANGKY '2022-09-12', '2022-10-12', '13:00', '15:00', 'Chuong Minh Hao', 'Kiem tien dong hoc phi'
EXEC SP_INSERT_DANGKY '2022/10/20', '2022/11/20', '13:00', '20:00', 'Can Van Cuon', 'Kiem tien nuoi con'
EXEC SP_INSERT_DANGKY '11/02/2022', '12/02/2022', '13:00', '20:00', 'Da Thi Mo', 'Yeu thich cong viec'

SELECT * FROM DANGKY

SELECT NGUOIDANGKY FROM DANGKY
