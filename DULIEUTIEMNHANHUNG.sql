create database TiemnhaNhung
use TiemnhaNhung
go 


create table NHANVIEN
(
	MaNV varchar(5) primary key default dbo.AddNhanVien() , 
	TenNV nvarchar(50) ,
	SDT_NV varchar(10) , 
	ChucVu nvarchar(50) 
)

insert into NHANVIEN VALUES('NV001',N'Huỳnh Văn Công','0377606762',N'Chủ quán'),
							('NV002',N'Trần Văn Sâm','0502636147',N'Quản lí'),
							('NV003',N'Lại Thị Hoa','0883921061',N'Nhân viên'),
							('NV004',N'Lê Đoàn Thi','0913408412',N'Nhân viên'),
							('NV005',N'Trần Anh Đức','0977317445',N'Nhân viên')

create table MONAN 
(	
	MaMon varchar(5) primary key default dbo.AddMonAn() , 
	TenMon nvarchar(50) ,
	DVT nvarchar(50) ,
	DonGia_Mon int  
)

insert into MONAN values ('MM001',	N'Bánh que chấm kem',N'đĩa',	15000),
						('MM002',	N'Bánh tráng tép tỏi',	N'đĩa',	15000),
						('MM003',	N'Cá viên chiên mắn bơ tỏi/sốt thái'	,N'suất nhỏ',	50000),
						('MM004',	N'Cá viên chiên mắn bơ tỏi/ sốt thái',	N'suất lớn',	70000),
						('MM005',	N'Cá viên chiên mắn bơ tỏi/ sốt thái',	N'suất đặc biệt',	90000),
						('MM006',	N'Cá viên chiên',	N'đĩa',	20000),
						('MM007',	N'Nước chấm chân gà', 	N'chai 330ml',	50000),
						('MM008',	N'Ruốc hủ',	'300g',	50000),
						('MM009',	N'Ruốc thêm',	N'đĩa',	5000),
						('MM010',	N'Xoài non mắm ruốc',	N'đĩa',	25000),
						('MM011',	N'Xoài ruốc',	N'đĩa',	25000),
						('MM012',	N'Chân gà rút xương',	N'phần nhỏ',	55000),
						('MM013',	N'Chân gà rút xương',	N'phần lớn',	75000),
						('MM014',	N'Chân gà xương',	N'phần lớn',	55000),
						('MM015',	N'Chân gà xương',	N'phần nhỏ',	35000),
						('MM016',	N'Chân gà ủ muối',	N'phần lớn',	105000),
						('MM017',	N'Chân gà ủ muối',	N'phần nhỏ',	60000),
						('MM018',	N'Gà ủ muối thảo mộc',	N'1/2 con',	145000),
						('MM019',	N'Gà ủ muối thảo mộc',	N'con',	280000),
						('MM020',	N'Hồ lô chiên',	N'đĩa',	20000),
						('MM021',	N'Khoai lang kén',	N'phần',	20000),
						('MM022',	N'Nem chua rán',	N'phần',	30000),
						('MM023',	N'Ốc nhồi chiên'	,N'phần',	15000),
						('MM024',	N'Phô mai que',	N'phần',	18000),
						('MM025',	N'Tôm viên chiên',	N'phần',	20000),
						('MM026',	N'Xúc xích chiên',	N'phần',	10000),
						('MM027',	N'Coca cola',	N'chai', 	12000),
						('MM028',	N'Nước suối',	N'chai', 	6000),
						('MM029',	N'Sprite',	N'chai', 	12000),
						('MM030',	N'Trà cam dâu trân châu',	N'ly',	25000),
						('MM031',	N'Trà hoa quả',	N'ly',	25000),
						('MM032',	N'Trà mãng cầu',	N'ly',	25000),
						('MM033',	N'Trà ổi hồng trân châu',	N'ly',	25000),
						('MM034',	N'Trà sữa Socola',N'ly',	25000),
						('MM035',	N'Trà sữa thái xanh',	N'ly',	25000),
						('MM036',	N'Trà sữa truyền thống',	N'ly',	25000),
						('MM037',	N'Trà tắc thảo mộc',	N'ly',	25000),
						('MM038',	N'Trà tắc xí muội',	N'ly',	15000),
						('MM039',	N'Trà táo xanh trân châu',	N'ly',	25000),
						('MM040',	N'Trà thạch đào',	N'ly',	25000),
						('MM041',	N'Trà vải trân châu',	N'ly',	25000),
						('MM042',	N'Trà xoài dâu tây trân châu',	N'ly',	25000)

create table HANGHOA 
(
	MaHH varchar(5) primary key default dbo.AddHangHoa(), 
	TenHang nvarchar(50) ,
	DVT nvarchar(50),
	GiaNhap int ,
	
)

insert into HANGHOA values('HH001',	N'Cá viên chiên','kg',45000),	
							('HH002',	N'Chân gà','kg',60000),
							('HH003',	N'Chân gà rút xương','kg',80000),		
							('HH004',	N'Nước suối','chai',	120000	),
							('HH005',	N'Coca cola','chai',	216000	),
							('HH006',	N'Sprite	','chai',216000	),
							('HH007',N'Bánh tráng','kg',30000),
							('HH008',	N'Khoai lang kén','kg'	,60000)	,
							('HH009',	N'Nem chua ',	'kg',	58000),
							('HH010',	N'Ốc',	'kg',	23000	)


create table KHACH
(
	MaKH varchar(5) primary key default dbo.AddKhach(),
	TenKH nvarchar(50) ,
	SDTKH varchar(10),
	DiaChiKH nvarchar(50)
)

insert into KHACH values('KH001',	N'Đỗ Lê Khanh',	'0399045303',	N'888 Đường Phan Đình Phùng, Đà Lạt'),
						('KH002',	N'Nguyễn Tường Nghi',	'0974738986',	N'456 Đường Trần Hưng Đạo, Hội An '),
						('KH003',	N'Đặng Phương Thảo',	'0914073388',	N'789 Đường Hùng Vương, Hải Phòng'),
						('KH004',	N'Đặng Hoàng Bảo Khanh',	'0368004603',	N'654 Đường Lê Duẩn, Sài Gòn'),
						('KH005',	N'Nguyễn Thị Hằng',	'0349745303',	N'777 Đường Lê Lai, Biên Hòa '),
						('KH006',	N'Lê Đoàn Thịnh',	'0984748086',	N'888 Đường Trần Phú, Nha Trang'),
						('KH007',	N'Nguyễn Thị Thanh Mai',	'0974072278',	N'123 Đường Lý Thường Kiệt, Quy Nhơn'),
						('KH008',	N'Nguyễn Thị Hoàng Diểm',	'0358334604',	N'456 Đường Nguyễn Huệ, Cần Thơ'), 
						('KH009',	N'Châu Thị Bích Phương',	'0385047309',	N'789 Đường Phan Đình Phùng,Đà Lạt '),
						('KH010',	N'Trương Vạn Sâm',	'0564738957',	N'999 Đường Trần Hưng Đạo, Hội An'), 
						('KH011',	N'Nguyễn Văn Phước', 	'0967773388',	N'654 Đường Hùng Vương, Hải Phòng'),  
						('KH012',	N'Nguyễn Thị Mùi',	'0368004642',	N'321 Đường Lê Duẩn, Sài Gòn '),
						('KH013',	N'Lê Văn Gia Bảo',	'0569775303',	N'111 Đường Hùng Vương, Hải Phòng '), 
						('KH014',	N'Phan Vũ Kiều',	'0524733786',	N'222 Đường Lê Duẩn, Sài Gòn  '),
						('KH015',	N'Trần Văn Đức',	'0774073238',	N'333 Đường Nguyễn Huệ, Cần Thơ'),
						('KH016',	N'Phan Thị Mộng Mơ',	'0798304784',	N'444 Đường Phan Đình Phùng, Đà Lạt '),
						('KH017',	N'Doãn Bá Sang',	'0879045655',	N'555 Đường Trần Hưng Đạo, Huế '),
						('KH018',	N'Trần Thị Hương Ly',	'0734898909',	N'666 Đường Trần Phú, Nha Trang'),
						('KH019',	N'Huỳnh Thế Sơn',	'0392671447',	N'777 Đường Lý Thường Kiệt, Quy Nhơn '),
						('KH020',	N'Lương Thị Diễm Quỳnh',	'0813144966',	N'888 Đường Lê Lợi, Thành phố Hồ Chí Minh'),
						('KH021',	N'Đậu Thúy Hoàng',	'0987626479',	N'999 Đường Hoàng Văn Thụ, Hà Nội '), 
						('KH022',	N'Lê Công Anh',	'0377247732',	N'123 Đường Lê Lai, Biên Hòa'   )

create table NHACC
(
	MaNCC varchar(6) primary key default dbo.AddNhaCC(),
	TenNCC nvarchar(50),
	SDT varchar(10) ,
	DiaChi nvarchar(50)
)

insert into NHACC values('NCC001',	N'Nguyến Văn Linh',	'0367800645',		N'789 Đường Phan Đình Phùng, Đà Lạt'), 
						('NCC002',	N'Nguyễn Thị Xuân Trang'	,'0734898909',	N'999 Đường Trần Hưng Đạo, Hội An '),
						('NCC003',	N'Bùi Thị Thanh Xuân',	'0392671447',	N'654 Đường Hùng Vương, Hải Phòng  '),
						('NCC004',	N'Trương Hà Giang ',	'0813144966',	N'321 Đường Lê Duẩn, Sài Gòn '),
						('NCC005',	N'Quách Văn Quyền','0786902526',	N'111 Đường Hùng Vương, Hải Phòng' ) ,
						('NCC006',	N'Hoàng Thị Thanh','0339731021',	N'444 Đường Phan Đình Phùng, Đà Lạt ')


create table HOADONNHAP
(
	MaHDN varchar(6) primary key default dbo.AddHDN(), 
	Tongdon int ,
	NgayNH datetime,
	MaNV varchar(5) ,
	MaNCC varchar(6) , 
	foreign key (MaNV) references NHANVIEN,
	foreign key (MaNCC) references NhaCC
)

insert into HOADONNHAP VALUES	('HDN001',	1735000,'2023-01-20 07:35:19',	'NV001',	'NCC001'),
								('HDN002',	1092000,'2023-02-12 08:15:21',	'NV002',	'NCC002'),
								('HDN003',	764000,	'2023-03-13 07:55:11',	'NV003',	'NCC005'),
								('HDN004',	480000,	'2023-04-30 06:25:01',	'NV001',	'NCC006'),
								('HDN005',	556000,	'2023-05-15 08:32:03',	'NV005',	'NCC005'),
								('HDN006',	1494000,'2023-06-16 08:16:18',	'NV004',	'NCC003'),
								('HDN007',	1440000,'2023-07-27 07:30:52',	'NV001',	'NCC004'),
								('HDN008',	1152000,'2023-08-18 06:45:36',	'NV003',	'NCC001'),
								('HDN009',	636000,	'2023-09-29 08:05:02',	'NV002',	'NCC002'),
								('HDN010',	555000,	'2023-10-20 07:22:04',	'NV001',	'NCC003')

create table HOADONNHAPCHITIET
(
	MaHDN varchar(6) foreign key references HOADONNHAP(MaHDN),
	MaHH varchar(5) FOREIGN KEY REFERENCES HANGHOA(MaHH),
	SoLuongHang int,
	ThanhTien_NH int,
	Constraint PK_HOADONNHAPCHITIET Primary key(MaHH, MaHDN)
)

insert into HOADONNHAPCHITIET values ('HDN001',	'HH001',	3,	135000),
									('HDN001',	'HH002',	9,	540000),
									('HDN001',	'HH003',	5,	400000),
									('HDN001',	'HH004',	11,	1320000),
									('HDN002',	'HH005',	2,	432000),
									('HDN002',	'HH010',	4,	92000),
									('HDN003',	'HH007',	8,	240000),
									('HDN003',	'HH008',	4,	240000),
									('HDN003',	'HH001',	6,	270000),
									('HDN004',	'HH010',	2,	46000),
									('HDN004',	'HH006',	3,	648000),
									('HDN005',	'HH003',	1,	80000),
									('HDN005',	'HH005',	9,	1944000),
									('HDN005',	'HH004',	6,	720000),
									('HDN006',	'HH005',	2,	432000),
									('HDN006',	'HH009',	3,	174000),
									('HDN006',	'HH007',	1,	30000),
									('HDN006',	'HH008',	4,	240000),
									('HDN007',	'HH005',	1,	216000),
									('HDN007',	'HH010',	3,	69000),
									('HDN008',	'HH009',	4,	232000),
									('HDN008',	'HH002',	9,	540000),
									('HDN009',	'HH006',	2,	432000),
									('HDN009',	'HH004',	2,	240000),
									('HDN009',	'HH005',	4,	864000),
									('HDN010',	'HH003',	5,	400000),
									('HDN010',	'HH010',	5,	115000),
									('HDN010',	'HH004',	3,	360000),
									('HDN010',  'HH002',	7,	420000)

create table HOADONDAT 
(
	MaDDH varchar(6) primary key default dbo.AddHDD(),
	NgayDat datetime,
	GhiChu nvarchar(100),
	TongDonDat int,
	GiamGia int,
	TongCong int,
	MaKH varchar(5),
	TrangThai bit,
	foreign key (MaKH) references KHACH
)
insert into HOADONDAT values	('DDH001','2023-01-14 14:30:30',N'Thêm ớt',60000,3000,57000,'KH001',1),
								('DDH002','2023-01-17 12:20:10',N'Không lấy dụng cụ ăn uống',125000,6250,11875,'KH002',0),
								('DDH003','2023-01-21 11:10:03',N'Nhiều thêm 2 đôi đũa',68000,3400,64600,'KH003',0),
								('DDH004','2023-02-12 10:05:30','',35000,1750,33250,'KH004',0),
								('DDH005','2023-02-08 09:10:35','',44000,2200,41800,'KH005',1),
								('DDH006','2023-02-10 16:01:01',N'Trà sữa bỏ đá riêng',20000,1000,41800,'KH006',1),
								('DDH007','2023-02-23 09:31:03','',75000,3750,71250,'KH007',1),
								('DDH008','2023-02-24 18:40:39','',15000,750,14250,'KH008',1),
								('DDH009','2023-03-02 17:05:50','',36000,1800,34200,'KH009',1),
								('DDH010','2023-03-23 19:31:59',N'Cho thêm đá',75000,3750,71250,'KH010',1),
								('DDH011','2023-04-24 08:30:47','',	150000,0,150000,'KH011',0),
								('DDH012','2023-04-29 14:50:32',N'Giao lúc 20h20p',40000,0,40000,'KH012',1),
								('DDH013','2023-04-30 20:12:32','',95000,0,95000,'KH013',1),
								('DDH014','2023-04-21 13:10:13','',100000,0,100000,'KH014',1),
								('DDH015','2023-05-12 21:38:54',N'Thêm trân châu đen',54000,0,54000,'KH015',1),
								('DDH016','2023-06-19 22:30:23','',20000,0,20000,'KH016',1),
								('DDH017','2023-07-03 17:54:12',N'Thêm lá chanh',20000,0,20000,'KH017',1),
								('DDH018','2023-07-06 11:40:52','',36000,0,36000,'KH018',0),
								('DDH019','2023-08-17 20:15:15','',25000,0,25000,'KH019',1),
								('DDH020','2023-08-22 19:19:28',N'Chặt gà miếng nhỏ',130000,0,130000,'KH020',1),
								('DDH021','2023-09-03 10:14:04',N'Chặt gà miếng to',365000,0,365000,'KH021',1),
								('DDH022','2023-10-14 17:09:08','',40000,0,40000,'KH022',1)

create table HOADONDATCHITIET
(
	MaDDH varchar(6) foreign key references HOADONDAT(MaDDH),
	MaMon varchar(5) FOREIGN KEY REFERENCES MONAN(MaMon),
	SoLuongMon int,
	ThanhTien_DH int,
	Constraint PK_HOADONDATCHITIET Primary key(MaMon, MaDDH)
	 
)

insert into HOADONDATCHITIET values('DDH001','MM001',	1,	15000),
									('DDH001','MM010',	1,	25000),
									('DDH001','MM005',	1,	20000),
									('DDH002','MM013',	2,	110000),
									('DDH002','MM001',	1,	15000),
									('DDH003','MM002',	1,	50000),
									('DDH003','MM023',	1,	18000),
									('DDH004','MM014',	1,	35000),
									('DDH005','MM024',	1,	20000),
									('DDH005','MM028',	2,	24000),
									('DDH006','MM019',	1,	20000),
									('DDH007','MM032',	3,	75000),
									('DDH008','MM001',	1,	15000),
									('DDH009','MM023',	2,	36000),
									('DDH010','MM010',	1,	25000),
									('DDH010','MM035',	2,	50000),
									('DDH011','MM015',	1,	105000),
									('DDH011','MM025',	2,	20000),
									('DDH011','MM038',	1,	25000),
									('DDH012','MM024',	2,	40000),
									('DDH013','MM042',	1,	25000),
									('DDH013','MM014',	2,	70000),
									('DDH014','MM002',	2,	100000),
									('DDH015','MM026',	2,24000),
									('DDH015','MM021',	1,	30000),
									('DDH016','MM019',	1,	20000),
									('DDH017','MM020',	1,20000),
									('DDH018','MM001',	2,	30000),
									('DDH018','MM027',	1,	6000),
									('DDH019','MM019',	1,	20000),
									('DDH019','MM008',	1,	5000),
									('DDH020','MM035',	2,	50000),
									('DDH020','MM021',	2,	60000),
									('DDH020','MM019',	1,	20000)



















