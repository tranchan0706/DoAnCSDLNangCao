/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     4/15/2021 1:22:23 PM                         */
/*==============================================================*/
create database QL_TPKS
go
use QL_TPKS

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADON') and o.name = 'FK_HOADON_HD_PHIEU_PHIEUTHU')
alter table HOADON
   drop constraint FK_HOADON_HD_PHIEU_PHIEUTHU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOADONDV') and o.name = 'FK_HOADONDV_HDDV_PHIE_PHIEUTHU')
alter table HOADONDV
   drop constraint FK_HOADONDV_HDDV_PHIE_PHIEUTHU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAIPHONG') and o.name = 'FK_LOAIPHON_LP_CN_CHINHANH')
alter table LOAIPHONG
   drop constraint FK_LOAIPHON_LP_CN_CHINHANH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHANVIEN') and o.name = 'FK_NHANVIEN_REFERENCE_CHINHANH')
alter table NHANVIEN
   drop constraint FK_NHANVIEN_REFERENCE_CHINHANH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHIEUTHUE') and o.name = 'FK_PHIEUTHU_PHIEU_KH_KHACHHAN')
alter table PHIEUTHUE
   drop constraint FK_PHIEUTHU_PHIEU_KH_KHACHHAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONG') and o.name = 'FK_PHONG_P_LP_LOAIPHON')
alter table PHONG
   drop constraint FK_PHONG_P_LP_LOAIPHON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONGTB') and o.name = 'FK_PHONGTB_PTB_P_PHONG')
alter table PHONGTB
   drop constraint FK_PHONGTB_PTB_P_PHONG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONGTB') and o.name = 'FK_PHONGTB_PTB_TB_THIETBI')
alter table PHONGTB
   drop constraint FK_PHONGTB_PTB_TB_THIETBI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONGTHUE') and o.name = 'FK_PHONGTHU_PT_P_PHONG')
alter table PHONGTHUE
   drop constraint FK_PHONGTHU_PT_P_PHONG
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONGTHUE') and o.name = 'FK_PHONGTHU_PT_PHIEU_PHIEUTHU')
alter table PHONGTHUE
   drop constraint FK_PHONGTHU_PT_PHIEU_PHIEUTHU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUDUNGDV') and o.name = 'FK_SUDUNGDV_SDDV_DV_DICHVU')
alter table SUDUNGDV
   drop constraint FK_SUDUNGDV_SDDV_DV_DICHVU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUDUNGDV') and o.name = 'FK_SUDUNGDV_SDDV_HDDV_HOADONDV')
alter table SUDUNGDV
   drop constraint FK_SUDUNGDV_SDDV_HDDV_HOADONDV
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHINHANH')
            and   type = 'U')
   drop table CHINHANH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DICHVU')
            and   type = 'U')
   drop table DICHVU
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOADON')
            and   type = 'U')
   drop table HOADON
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOADONDV')
            and   type = 'U')
   drop table HOADONDV
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACHHANG')
            and   type = 'U')
   drop table KHACHHANG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAIPHONG')
            and   type = 'U')
   drop table LOAIPHONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEUTHUE')
            and   type = 'U')
   drop table PHIEUTHUE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONG')
            and   type = 'U')
   drop table PHONG
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONGTB')
            and   type = 'U')
   drop table PHONGTB
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONGTHUE')
            and   type = 'U')
   drop table PHONGTHUE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUDUNGDV')
            and   type = 'U')
   drop table SUDUNGDV
go

if exists (select 1
            from  sysobjects
           where  id = object_id('THIETBI')
            and   type = 'U')
   drop table THIETBI
go

/*==============================================================*/
/* Table: CHINHANH                                              */
/*==============================================================*/
create table CHINHANH (
   MACHINHANH           char(10)             not null,
   TENCHINHANH          nvarchar(50)         null,
   constraint PK_CHINHANH primary key nonclustered (MACHINHANH)
)
go

/*==============================================================*/
/* Table: DICHVU                                                */
/*==============================================================*/
create table DICHVU (
   MADV                 char(10)             not null,
   TENDV                nvarchar(50)         null,
   GIADV                int                  null,
   constraint PK_DICHVU primary key nonclustered (MADV)
)
go

/*==============================================================*/
/* Table: HOADON                                                */
/*==============================================================*/
create table HOADON (
   SOHD                 char(10)             not null,
   SOPT                 char(10)             null,
   NGAYTT               date                 null,
   SOTIEN               int                  null,
   constraint PK_HOADON primary key nonclustered (SOHD)
)
go

/*==============================================================*/
/* Table: HOADONDV                                              */
/*==============================================================*/
create table HOADONDV (
   MAHDDV               char(10)             not null,
   SOPT                 char(10)             null,
   SOTIENDV             int                  null,
   constraint PK_HOADONDV primary key nonclustered (MAHDDV)
)
go

/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
create table KHACHHANG (
   MAKH                 char(10)             not null,
   TENKH                nvarchar(50)         null,
   SDTKH                char(13)             null,
   DIACHI               nvarchar(100)        null,
   CMND                 char(10)             null,
   QUOCTICH             nvarchar(20)         null,
   constraint PK_KHACHHANG primary key nonclustered (MAKH)
)
go

/*==============================================================*/
/* Table: LOAIPHONG                                             */
/*==============================================================*/
create table LOAIPHONG (
   MALOAIPHONG          char(10)             not null,
   GIAPHONG             int                  null,
   MACHINHANH           char(10)             null,
   constraint PK_LOAIPHONG primary key nonclustered (MALOAIPHONG)
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANV                 char(10)             not null,
   TENNV                nvarchar(50)         null,
   DIACHI               nvarchar(50)         null,
   SDT                  char(13)             null,
   TK                   char(20)             null,
   MK                   char(20)             null,
   MACHINHANH           char(10)             null,
   constraint PK_NHANVIEN primary key (MANV)
)
go

/*==============================================================*/
/* Table: PHIEUTHUE                                             */
/*==============================================================*/
create table PHIEUTHUE (
   SOPT                 char(10)             not null,
   MAKH                 char(10)             null,
   NGAYTHUE             date                 null,
   TIENCOC              int                  null,
   constraint PK_PHIEUTHUE primary key (SOPT)
)
go

/*==============================================================*/
/* Table: PHONG                                                 */
/*==============================================================*/
create table PHONG (
   MAPHONG              char(10)             not null,
   MALOAIPHONG          char(10)             null,
   TINHTRANG            nvarchar(50)         null,
   SDTPHONG             char(13)             null,
   constraint PK_PHONG primary key (MAPHONG)
)
go

/*==============================================================*/
/* Table: PHONGTB                                               */
/*==============================================================*/
create table PHONGTB (
   MATB                 char(10)             not null,
   MAPHONG              char(10)             not null,
   TINHTRANG            nvarchar(50)         null,
   GHICHU               nvarchar(100)        null,
   constraint PK_PHONGTB primary key (MATB, MAPHONG)
)
go

/*==============================================================*/
/* Table: PHONGTHUE                                             */
/*==============================================================*/
create table PHONGTHUE (
   SOPT                 char(10)             not null,
   MAPHONG              char(10)             not null,
   NGAYDEN              date                 null,
   NGAYDI               date                 null,
   constraint PK_PHONGTHUE primary key (SOPT, MAPHONG)
)
go

/*==============================================================*/
/* Table: SUDUNGDV                                              */
/*==============================================================*/
create table SUDUNGDV (
   MAHDDV               char(10)             not null,
   MADV                 char(10)             not null,
   SOLUONG              int                  null,
   constraint PK_SUDUNGDV primary key (MAHDDV, MADV)
)
go

/*==============================================================*/
/* Table: THIETBI                                               */
/*==============================================================*/
create table THIETBI (
   MATB                 char(10)             not null,
   TENTHIETBI           nvarchar(50)         null,
   MOTA                 nvarchar(50)         null,
   SOLUONG              int                  null,
   constraint PK_THIETBI primary key (MATB)
)
go

alter table HOADON
   add constraint FK_HOADON_HD_PHIEU_PHIEUTHU foreign key (SOPT)
      references PHIEUTHUE (SOPT)
go

alter table HOADONDV
   add constraint FK_HOADONDV_HDDV_PHIE_PHIEUTHU foreign key (SOPT)
      references PHIEUTHUE (SOPT)
go

alter table LOAIPHONG
   add constraint FK_LOAIPHON_LP_CN_CHINHANH foreign key (MACHINHANH)
      references CHINHANH (MACHINHANH)
go

alter table NHANVIEN
   add constraint FK_NHANVIEN_REFERENCE_CHINHANH foreign key (MACHINHANH)
      references CHINHANH (MACHINHANH)
go

alter table PHIEUTHUE
   add constraint FK_PHIEUTHU_PHIEU_KH_KHACHHAN foreign key (MAKH)
      references KHACHHANG (MAKH)
go

alter table PHONG
   add constraint FK_PHONG_P_LP_LOAIPHON foreign key (MALOAIPHONG)
      references LOAIPHONG (MALOAIPHONG)
go

alter table PHONGTB
   add constraint FK_PHONGTB_PTB_P_PHONG foreign key (MAPHONG)
      references PHONG (MAPHONG)
go

alter table PHONGTB
   add constraint FK_PHONGTB_PTB_TB_THIETBI foreign key (MATB)
      references THIETBI (MATB)
go

alter table PHONGTHUE
   add constraint FK_PHONGTHU_PT_P_PHONG foreign key (MAPHONG)
      references PHONG (MAPHONG)
go

alter table PHONGTHUE
   add constraint FK_PHONGTHU_PT_PHIEU_PHIEUTHU foreign key (SOPT)
      references PHIEUTHUE (SOPT)
go

alter table SUDUNGDV
   add constraint FK_SUDUNGDV_SDDV_DV_DICHVU foreign key (MADV)
      references DICHVU (MADV)
go

alter table SUDUNGDV
   add constraint FK_SUDUNGDV_SDDV_HDDV_HOADONDV foreign key (MAHDDV)
      references HOADONDV (MAHDDV)
go



SET DATEFORMAT DMY
insert into CHINHANH
values 
('CN01',N'HÀ NỘI'),
('CN02',N'SÀI GÒN'),
('CN03',N'SERVER');

insert into DICHVU
values 
('DV01',N'Tắm nóng',60000),
('DV02',N'Giặt đồ',50000),
('DV03',N'Vệ sinh phòng',40000);

insert into KHACHHANG
values 
('KH01',N'Trần Thái Chân','0815702622',N'Tân Phú','321724774',N'VN'),
('KH02',N'Nguyễn Hòa Trung Hiếu','082329254',N'Tân Bình','321756895',N'VN'),
('KH03',N'Nguyễn Thanh Quang','0854862562',N'Gò Vấp','321584625',N'VN'),
('KH04',N'Phan Tố Quyên','0896425683',N'Quận 10','321562103',N'VN');

insert into LOAIPHONG	
values 
('L11',90000,'CN01'),
('L12',80000,'CN01'),
('L13',80000,'CN01'),
('L21',90000,'CN02'),
('L22',80000,'CN02'),
('L23',80000,'CN02');

insert into PHONG	
values 
('HNP01','L11',N'Tốt','1'),
('HNP02','L13',N'Tốt','1'),
('HNP03','L11',N'Kém','2'),
('SGP02','L22',N'Kém','3'),
('SGP01','L21',N'Tốt','1');


insert into PHIEUTHUE	
values 
('PT01','KH01','28/3/2021',60000),
('PT02','KH02','14/2/2021',50000),
('PT03','KH01','25/1/2021',60000),
('PT04','KH03','14/3/2021',40000);

insert into PHONGTHUE	
values 
('PT01','HNP03','28/3/2021','30/3/2021'),
('PT01','HNP01','28/3/2021','30/3/2021'),
('PT01','HNP02','28/3/2021','31/3/2021'),
('PT02','SGP01','22/3/2021','25/3/2021'),
('PT03','SGP02','25/3/2021','31/3/2021');

insert into HOADON	
values
('HD01','PT01','30/3/2021',8080000),
('HD02','PT02','16/2/2021',1200000);

insert into HOADONDV	
values
('HDDV1','PT01',80000),
('HDDV2','PT02',50000);

insert into SUDUNGDV	
values
('HDDV1','DV01',80000),
('HDDV2','DV02',50000);

insert into THIETBI	
values
('TB01',N'Tivi',N'Samsung',98),
('TB02',N'Chăn ga',N'Hàn Quốc',87),
('TB03',N'Bàn là',N'Nhật bản',30);

insert into PHONGTB	
values
('TB01','HNP01',N'Samsung',98),
('TB02','HNP02',N'Hàn Quốc',87),
('TB03','SGP02',N'Nhật bản',30);

insert into NHANVIEN
values
('NV01',N'Trần Thái Chân',N'Tân Phú','0815702622','chan','123','CN01'),
('NV02',N'Phan Tố Quyên',N'Tân Bình','0855665415','quyen','124','CN02'),
('NV03',N'Nguyễn Thanh Quang',N'Gò Vấp','0815156156','quang','125','CN01'),
('NV04',N'Nguyễn Hòa Trung Hiếu',N'Bình Tân','0810216515','hieu','126','CN02');

insert into NHANVIEN
values
('ADMIN',N'Trần Thái Chân',N'Tân Phú','0815702622','chan','123','CN03');

GO
CREATE PROC sp_KiemTraMaNhanVienTonTai(@manv char(10))
AS
	BEGIN
	--kiểm tra mã nhân viên ở Server hiện tại
		IF EXISTS (SELECT 1 FROM DBO.NHANVIEN WHERE DBO.NHANVIEN.MANV = @manv)
		BEGIN
		RETURN 1;-- mã nhân viên tồn tại
		END
	--kiểm tra mã nhân viên ở Phân mảnh còn lại
		IF EXISTS (SELECT 1 FROM LINK.QL_TPKS.DBO.NHANVIEN NV WHERE NV.MANV =@manv)
		BEGIN	
			RETURN 1;-- mã nhân viên tồn tại
			END
			RETURN 0;--mã nhân viên chưa tồn tại
	END
go

CREATE PROC sp_KiemTraDangNhap(@manv char(10),@mk char(20),@macn char(10))
AS
	BEGIN
	--kiểm tra mã nhân viên ở Server hiện tại
		IF EXISTS (SELECT 1 FROM DBO.NHANVIEN WHERE DBO.NHANVIEN.MANV = @manv and DBO.NHANVIEN.MK=@mk and DBO.NHANVIEN.MACHINHANH=@macn)
		BEGIN
		RETURN 1;-- mã nhân viên tồn tại
		END
	--kiểm tra mã nhân viên ở Phân mảnh còn lại
		IF EXISTS (SELECT 1 FROM LINK.QL_TPKS.DBO.NHANVIEN NV WHERE NV.MANV = @manv and NV.MK=@mk and NV.MACHINHANH=@macn)
		BEGIN	
			RETURN 1;-- mã nhân viên tồn tại
			END
			RETURN 0;--mã nhân viên chưa tồn tại
	END
go
