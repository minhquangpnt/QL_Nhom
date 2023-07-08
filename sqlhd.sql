create database QLHOATDONG
go 
use QLHOATDONG
go
set dateformat DMY
go
create table THANHVIEN
(
	MaTV char(10),
	TenTV nvarchar(50),
	DiaChiTV nvarchar(50),
	NgaySinhTV date,
	TenTK char(20) unique,
	MatKhau char(20),
	TYPE int,
	constraint PK_TV primary key(MaTV),
)
go
create table HOATDONG
(
	MaHD char(10) primary key,
	TenHD nvarchar(50),
)
go
create table SUKIEN
(
	MaSK char(10) primary key,
	TenSK nvarchar(50),
	DiaDiem nvarchar(50),
	NgayBD date,
	MaHD char(10),
	constraint FK_SK_HD foreign key(MaHD) references HOATDONG(MaHD)
)
go
create table DANGKY
(
	MaSK char(10),
	MaTV char(10),
	constraint PK_DK primary key(MaSK,MaTV),
	constraint FK_DK_TV foreign key(MaTV) references THANHVIEN(MaTV), 
	constraint FK_DK_SK foreign key(MaSK) references SUKIEN(MaSK)
)
go
insert into THANHVIEN
values('TV001',N'Nguyễn Văn Tuấn',N'001 Lê Trọng Tấn','01/01/2000','admin','admin',1),
		('TV002',N'Trần Minh Quang',N'002 Lê Trọng Tấn','02/02/2000','user02','1234',0),
		('TV003',N'Lê Đức Tuấn',N'120 Cách Mạng Tháng 8','03/03/2000','user03','1234',0),
		('TV004',N'Huỳnh Tuấn Anh',N'30/11 Âu Cơ','04/04/2000','user04','1234',0),
		('TV005',N'Huỳnh Ngọc Chi',N'20/2 Nguyễn Phúc Chu','05/05/2000','user05','1234',0)
go
insert into HOATDONG
values('MHX',N'Mùa hè xanh'),
		('HMND',N'Hiến máu nhân đạo'),
		('COVID',N'Tham gia phòng chống COVID'),
		('HTVC',N'Hỗ trợ tiêm vaccine'),
		('HTSV',N'Tham gia hỗ trợ sinh viên')
go
insert into SUKIEN
values('MHX_01',N'Mùa hè xanh Gia Định',N'Công viên Gia Định','28/12/2022','MHX'),
		('MHX_02',N'Mùa hè xanh Hốc Môn',N'Huyện Hóc Môn','29/12/2022','MHX'),
		('MHX_03',N'Mùa hè xanh Nhà Bè',N'Huyện Nhà bè','31/12/2022','MHX'),
		('HMND_01',N'Hiến máu tại trường ĐH',N'Trường ĐHCNTP TPHCM','21/01/2023','HMND'),
		('COVID_01',N'Phòng chống covid tại Phường Đông Hưng Thuận',N'Phường Tân Chánh Hiệp','31/12/2022','COVID'),
		('HTSV_01',N'Hõ trợ sinh viên quận Tân Phú',N'Ủy ban Quận Tân Phú','31/12/2022','HTSV'),
		('HTSV_02',N'Hỗ trợ sinh viên quận 12',N'Ủy ban quận 12','10/01/2023','HTSV')
go
insert into DANGKY
values('MHX_01','TV002'),
		('MHX_01','TV003'),
		('MHX_02','TV001'),
		('MHX_02','TV004'),
		('COVID_01','TV001'),
		('HTSV_01','TV005'),
		('HTSV_02','TV002')

		
---------------------------------------------------------------------------------------------------------
go
create proc loginSP
@username nvarchar(10),
@pass nvarchar(10)
as
begin 
	 if exists (select * from THANHVIEN where TenTK = @Username and MATKHAU = @pass and TYPE =1)
        select 1 as code -- admin
    else if exists (select * from THANHVIEN where TenTK= @Username and MATKHAU = @pass and TYPE = 0)
        select 0 as code -- thành viên
    else if exists(select * from THANHVIEN where TenTK = @Username and MATKHAU != @pass) 
        select 2 as code --sai mật khẩu
    else select 3 as code -- Không có tk
end
go


