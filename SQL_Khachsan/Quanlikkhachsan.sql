create table chucvu
(
STT int identity,
machucvu char(10) primary key,
tenchucvu nvarchar(50)
)
create table nhanvien
(
STT int identity,
manhanvien char(10) primary key,
tennhanvien nvarchar(50),
machucvu char(10) null,
constraint fk_nhanvien_chucvu foreign key(machucvu) references chucvu(machucvu),
ngaysinh datetime,
gioitinh nchar(10),
diachi nvarchar(50),
sodienthoai char(20)
)
create table khachhang(
STT int identity,
makhachhang char(10) primary key,
tenkhachhang nvarchar(50),
ngaysinh datetime,
gioitinh nchar(10),
diachi nvarchar(50),
sodienthoai char(20),
CMT char(20),
quoctich nvarchar(50)
)
create table  loaiphong
(
STT int identity,
maloaiphong char(10) primary key,
loaiphong nvarchar(50),
giaphong int,
)
create table phong
(
STT int identity,
maphong char(10) primary key,
maloaiphong char(10),
constraint fk_phong_loaiphong foreign key (maloaiphong) references loaiphong(maloaiphong),
tinhtrangphong nvarchar(50),
giaphong int,
)
create table loaithietbi
(
STT int identity,
maloaithietbi char(10) primary key,
tenloaithietbi nvarchar(50),
soluong int,
) 
create table danhsachthietbi
(
STT int identity,
mathietbi char(10) primary key,
tenthietbi nvarchar(50),
maloaithietbi char(10),
constraint fk_danhsachthietbi_loaithietbi foreign key(maloaithietbi) references loaithietbi(maloaithietbi),
giathietbi int,
tinhtrang nvarchar(50)
)
create table chitietsudungthietbi
(
maphong char(10)  references phong(maphong),
mathietbi char(10) references danhsachthietbi(mathietbi),
tenthietbi nvarchar(50),
primary key(maphong,mathietbi)
)
create table phieuthuephong
(
STT int identity,
maphieu char(10) primary key,
makhachhang char(10),
constraint fk_khachhang_phieuthuephong foreign key(makhachhang) references khachhang(makhachhang),
maphong char(10),
constraint fk_phieuthuephong_phong foreign key(maphong) references phong(maphong),
manhanvien char(10),
constraint fk_nhanvien_phieuthuephong foreign key(manhanvien) references nhanvien(manhanvien),
ngaydatphong datetime,
ngaydukientra datetime,
ngaytraphong datetime,
songuoio int,
)
create table dichvu
(
STT int identity,
madichvu char(10) primary key,
tendichvu nvarchar(50),
giadichvu int,
 )
 create table chitietdungdichvu
 (
 STT int identity,
 madichvu char(10) references dichvu(madichvu),
 maphieu char(10) references phieuthuephong(maphieu),
 tendichvu nvarchar(50),
 giadichvu int,
 primary key(madichvu,maphieu)
 )
 create table hoadon
 (
    STT int identity,
	mahoadon char(10),
	manhanvien char(10)  null,
	maphieu char(10)  references phieuthuephong(maphieu),
	makhachhang char(10)  null,
	giaphong int,
	giadichvu int,
	tongtien int,
	ngaythanhtoan datetime,
	constraint fk_hoadon_nhanvien foreign key(manhanvien) references nhanvien(manhanvien),
	primary key(mahoadon,maphieu)	
 )

 create table login
 (
 taikhoan nvarchar(50),
 matkhau varchar(50)
 )