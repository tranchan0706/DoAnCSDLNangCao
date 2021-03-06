drop Procedure [dbo].[sp_KiemTraDangNhap]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go
CREATE PROC [dbo].[sp_KiemTraDangNhap](@manv char(10),@mk char(20),@macn char(10))
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
