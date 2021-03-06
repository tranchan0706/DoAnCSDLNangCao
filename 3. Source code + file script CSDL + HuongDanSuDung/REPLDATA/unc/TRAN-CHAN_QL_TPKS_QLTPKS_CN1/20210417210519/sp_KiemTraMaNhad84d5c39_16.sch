drop Procedure [dbo].[sp_KiemTraMaNhanVienTonTai]
go

SET QUOTED_IDENTIFIER ON
go
SET ANSI_NULLS ON
go
CREATE PROC [dbo].[sp_KiemTraMaNhanVienTonTai](@manv char(10))
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
