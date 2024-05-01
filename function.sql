go 
create function AddKhach()
returns varchar(5)
as
begin
	declare @macu varchar(5), @mamoi varchar(5)
	set @macu= (select max(right(MaKH,3)) FROM KHACH)
	set @mamoi=@macu+1
	set @mamoi=concat('KH',right((replicate('0',3)+@mamoi),3))
	RETURN @mamoi
end 
----
go 
create function AddHangHoa()
returns varchar(5)
as
begin
	declare @mahhcu varchar(5), @mahhmoi varchar(5)
	set @mahhcu= (select max(right(MaHH,3)) FROM HANGHOA)
	set @mahhmoi=@mahhcu+1
	set @mahhmoi=concat('HH',right((replicate('0',3)+@mahhmoi),3))
	RETURN @mahhmoi
end 

PRINT DBO.ADDNHANVIEN()
---
go 
CREATE function AddMonAn()
returns varchar(5)
as
begin
	declare @mamoncu varchar(5), @mamonmoi varchar(5)
	set @mamoncu= (select max(right(MaMon,3)) FROM MONAN)
	set @mamonmoi=@mamoncu+1
	set @mamonmoi=concat('MM',right((replicate('0',3)+@mamonmoi),3))
	RETURN @mamonmoi
end 
print dbo.AddMonAn() 

--
go 
CREATE function AddNhanVien()
returns varchar(5)
as
begin
	declare @manvcu varchar(5), @manvmoi varchar(5)
	set @manvcu= (select max(right(MaNV,3)) FROM NHANVIEN)
	set @manvmoi=@manvcu+1
	set @manvmoi=concat('NV',right((replicate('0',3)+@manvmoi),3))
	RETURN @manvmoi
end 

print dbo.addnhanvien()

go 
alter function AddNhaCC()
returns varchar(6)
as
begin
	declare @mancccu varchar(6), @manccmoi varchar(6)
	set @mancccu= (select max(right(MaNCC,3)) FROM NHACC)
	set @manccmoi=@mancccu+1
	set @manccmoi=concat('NCC',right((replicate('0',3)+@manccmoi),3))
	RETURN @manccmoi
end 

print dbo.addnhacc() 

--
go 
CREATE function AddHDN()
returns varchar(6)
as
begin
	declare @hdncu varchar(6), @hdnmoi varchar(6)
	set @hdncu= (select max(right(MaHDN,3)) FROM HOADONNHAP)
	set @hdnmoi=@hdncu+1
	set @hdnmoi=concat('HDN',right((replicate('0',3)+@hdnmoi),3))
	RETURN @hdnmoi
end 

PRINT DBO.AddHDN()

--go 
CREATE function AddHDD()
returns varchar(6)
as
begin
	declare @hddcu varchar(6), @hddmoi varchar(6)
	set @hddcu= (select max(right(MaDDH,3)) FROM HOADONDAT)
	set @hddmoi=@hddcu+1
	set @hddmoi=concat('DDH',right((replicate('0',3)+@hddmoi),3))
	RETURN @hddmoi
end 

PRINT DBO.AddHDD()