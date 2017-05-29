--Chức vụ
insert into chucvu(machucvu,tenchucvu)
values('cv01',N'Trưởng phòng'),
       ('cv02',N'Quản lí'),
	   ('cv03',N'Tiếp tân'),
	   ('cv04',N'Phục vụ'),
	   ('cv05',N'Bảo vệ')
--Loại phòng
insert into loaiphong(maloaiphong,loaiphong,giaphong)
values ('loai01',N'Thường đơn','300000'),
       ('loai02',N'Thường đôi','500000'),
	   ('loai03',N'Vip đơn','1000000'),
	   ('loai04',N'Vip đôi','1200000'),
	   ('loai05',N'Phòng gia đình','1500000'),
	   ('loai06',N'Phòng cao cấp','3000000')
--Loại thiết bị
insert into loaithietbi (maloaithietbi,tenloaithietbi,soluong)
values ('loai01',N'Điều hòa','20'),
       ('loai02',N'Tivi sony','10'),
	   ('loai03',N'Tủ lạnh','20'),
	   ('loai04',N'Máy hơi nước','10'),
	   ('loai05',N'Bộ sofa','15')
--nhân viên
insert into nhanvien(manhanvien,tennhanvien,machucvu,ngaysinh,gioitinh,diachi,sodienthoai)
values ('nv01',N'Bùi Văn Lâm','cv01','1979/02/14',N'Nam',N'Hà Nội','09878646264'),
        ('nv02',N'Nguyễn Phương Linh','cv02','1985/05/16',N'Nữ',N'Hà Nội','086543223644'),
		('nv03',N'Đỗ Thị Tuyết','cv03','1990/2/2',N'Nữ',N'Hà Nội','0952356759876'),
		('nv04',N'Nguyễn Văn Nam','cv03','1991/2/3',N'Nam',N'Hà Nội','09652345687'),
		('nv05',N'Nguyễn Ngọc Anh','cv03','1992/2/1',N'Nữ',N'Hà Nội','09987652367'),
		('nv06',N'Bùi Thu Huệ','cv03','1990/2/5',N'Nữ',N'Hà Nội','09876564436'),
		('nv08',N'Nguyễn Thúy Mai','cv03','1994/2/8',N'Nữ',N'Hà Nội','0987565432')
select * from nhanvien