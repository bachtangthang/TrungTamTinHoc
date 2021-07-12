--LDC
create trigger trg_ISPASSED ON HOCVIEN_DANGKY_LOPCHUYENDE 
AFTER INSERT AS
BEGIN
	DECLARE @is_passed BIT;
	DECLARE @diem INT;

	SET @diem = ( SELECT inserted.Diem FROM inserted );

	IF (@diem >= 5)
	BEGIN
		SET @is_passed = 1;
	END
	ELSE
	BEGIN
		SET @is_passed = 0;
	END

	UPDATE HOCVIEN_DANGKY_LOPCHUYENDE
	SET is_Pass = @is_passed
	FROM HOCVIEN_DANGKY_LOPCHUYENDE
	JOIN inserted ON HOCVIEN_DANGKY_LOPCHUYENDE.ID_HocVien = inserted.ID_HocVien AND
	HOCVIEN_DANGKY_LOPCHUYENDE.ID_LopChuyenDe = inserted.ID_LopChuyenDe;
	
END
GO

create trigger trg_ISPASSED_UPDATE ON HOCVIEN_DANGKY_LOPCHUYENDE 
AFTER UPDATE AS
BEGIN
	DECLARE @is_passed BIT;
	DECLARE @diem INT;

	SET @diem = ( SELECT inserted.Diem FROM inserted );

	IF (@diem >= 5)
	BEGIN
		SET @is_passed = 1;
	END
	ELSE
	BEGIN
		SET @is_passed = 0;
	END

	UPDATE HOCVIEN_DANGKY_LOPCHUYENDE
	SET is_Pass = @is_passed
	FROM HOCVIEN_DANGKY_LOPCHUYENDE
	JOIN inserted ON HOCVIEN_DANGKY_LOPCHUYENDE.ID_HocVien = inserted.ID_HocVien AND
	HOCVIEN_DANGKY_LOPCHUYENDE.ID_LopChuyenDe = inserted.ID_LopChuyenDe;
	
END
GO

--LOPHOCPHAN
create trigger trg_ISPASSED_LPH ON HOCVIEN_DANGKY_LOPHOCPHAN
AFTER INSERT AS
BEGIN
	DECLARE @is_passed BIT;
	DECLARE @diem INT;

	SET @diem = ( SELECT inserted.Diem FROM inserted );

	IF (@diem >= 5)
	BEGIN
		SET @is_passed = 1;
	END
	ELSE
	BEGIN
		SET @is_passed = 0;
	END

	UPDATE HOCVIEN_DANGKY_LOPHOCPHAN
	SET is_Pass = @is_passed
	FROM HOCVIEN_DANGKY_LOPHOCPHAN
	JOIN inserted ON HOCVIEN_DANGKY_LOPHOCPHAN.ID_HocVien = inserted.ID_HocVien AND
	HOCVIEN_DANGKY_LOPHOCPHAN.ID_Lop = inserted.ID_Lop;
	
END
GO

create trigger trg_ISPASSED_UPDATE_LPH ON HOCVIEN_DANGKY_LOPHOCPHAN
AFTER UPDATE AS
BEGIN
	DECLARE @is_passed BIT;
	DECLARE @diem INT;

	SET @diem = ( SELECT inserted.Diem FROM inserted );

	IF (@diem >= 5)
	BEGIN
		SET @is_passed = 1;
	END
	ELSE
	BEGIN
		SET @is_passed = 0;
	END

	UPDATE HOCVIEN_DANGKY_LOPHOCPHAN
	SET is_Pass = @is_passed
	FROM HOCVIEN_DANGKY_LOPHOCPHAN
	JOIN inserted ON HOCVIEN_DANGKY_LOPHOCPHAN.ID_HocVien = inserted.ID_HocVien AND
	HOCVIEN_DANGKY_LOPHOCPHAN.ID_Lop = inserted.ID_Lop;
	
END
GO

--SI SO
create TRIGGER trg_SISO_LOPCHUYENDE_INSERT ON HOCVIEN_DANGKY_LOPCHUYENDE
AFTER INSERT, UPDATE AS
BEGIN
	update LOPCHUYENDE
	set SoLuong = (select count(*) from HOCVIEN_DANGKY_LOPCHUYENDE, inserted where HOCVIEN_DANGKY_LOPCHUYENDE.ID_LopChuyenDe = inserted.ID_LopChuyenDe)
	from LOPCHUYENDE
	join inserted on LOPCHUYENDE.ID_LopChuyenDe = inserted.ID_LopChuyenDe;
END
GO

create TRIGGER trg_SISO_LOPCHUYENDE_DELETE ON HOCVIEN_DANGKY_LOPCHUYENDE
AFTER DELETE AS
BEGIN
	update LOPCHUYENDE
	set SoLuong = (select count(*) from HOCVIEN_DANGKY_LOPCHUYENDE, deleted where HOCVIEN_DANGKY_LOPCHUYENDE.ID_LopChuyenDe = deleted.ID_LopChuyenDe)
	from LOPCHUYENDE
	join deleted on LOPCHUYENDE.ID_LopChuyenDe = deleted.ID_LopChuyenDe;
END
GO

create TRIGGER trg_SISO_LOPHOCPHAN_INSERT ON HOCVIEN_DANGKY_LOPHOCPHAN
AFTER INSERT, UPDATE AS
BEGIN
	update LOPHOCPHAN
	set SoLuong = (select count(*) from HOCVIEN_DANGKY_LOPHOCPHAN, inserted where HOCVIEN_DANGKY_LOPHOCPHAN.ID_Lop = inserted.ID_Lop)
	from LOPHOCPHAN
	join inserted on LOPHOCPHAN.ID_Lop = inserted.ID_Lop;
END
GO

create TRIGGER trg_SISO_LOPHOCPHAN_DELETE ON HOCVIEN_DANGKY_LOPHOCPHAN
AFTER DELETE AS
BEGIN
	update LOPHOCPHAN
	set SoLuong = (select count(*) from HOCVIEN_DANGKY_LOPHOCPHAN, deleted where HOCVIEN_DANGKY_LOPHOCPHAN.ID_Lop = deleted.ID_Lop)
	from LOPHOCPHAN
	join deleted on LOPHOCPHAN.ID_Lop = deleted.ID_Lop;
END
GO

CREATE TRIGGER trg_KiemTraIDLichThi
ON HOCVIEN_LICHTHI
FOR INSERT
AS
	DECLARE @IDLICHTHI INT
	SELECT @IDLICHTHI = ID_LICHTHI FROM INSERTED 
	DECLARE @IDHOCVIEN INT
	SELECT @IDHOCVIEN = ID_HOCVIEN FROM INSERTED
	IF((SELECT LT.ID_LOPHOCPHAN FROM LICHTHI LT WHERE LT.ID_LICHTHI=@IDLICHTHI)<>
	(SELECT HVDKHP.ID_LOP FROM HOCVIEN HV JOIN HOCVIEN_DANGKY_LOPHOCPHAN HVDKHP ON HVDKHP.ID_HOCVIEN=HV.ID WHERE HV.ID=@IDHOCVIEN))
			BEGIN
				PRINT('INVALID INFOR INSERTED!')
				ROLLBACK TRANSACTION
			END