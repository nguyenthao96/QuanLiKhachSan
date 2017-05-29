


		                  --NHÂN VIÊN
--THÊM
		create proc themnhanvien 
		@manhanvien char(10),
		@hoten nvarchar(50) ,
		@machucvu char(10)  ,
		@gioitinh nchar(10),
		@ngaysinh smalldatetime,
		@diachi nvarchar(50),
		@soDT char(15)
		as 
		begin 
		insert into nhanvien values (@manhanvien,@hoten,@machucvu,@ngaysinh,@gioitinh,@diachi,@soDT)
		end
		select *from nhanvien
--SỬA
		create proc suanhanvien
		@manhanvien char(10),@hoten nvarchar(50),@diachi nvarchar(50),@soDT char(15)
		as
		begin 
		update nhanvien
		set tennhanvien=@hoten,diachi=@diachi,sodienthoai=@soDT
		where manhanvien=@manhanvien
		end
--XÓA
		create proc xoanhanvien @manhanvien char(10)
		as
		begin
	    delete nhanvien where manhanvien=@manhanvien
	    end
		 select *from nhanvien

select *from chitietsudungthietbi
                                  ----KHÁCH HÀNG
--THÊM KHÁCH HÀNG
		alter proc themkhachhang @makhachhang char(10),@ten nvarchar(50),@ngaysinh datetime,@sdt char(20),@gioitinh nchar(10),@dc nvarchar(50),@cmt char(20),@quoctich nvarchar(50)
		as
		begin
		insert into khachhang(makhachhang,tenkhachhang,ngaysinh,gioitinh,diachi,sodienthoai,CMT,quoctich) 
		values(@makhachhang,@ten,@ngaysinh,@gioitinh,@dc,@sdt,@cmt,@quoctich)
		end
 --SỬA KHÁCH HÀNG
		create proc suakhachhang @makh char(10),@dc nvarchar(50),@ten nvarchar(50),@sdt char(20)
		as 
		begin 
		update khachhang set diachi=@dc,tenkhachhang=@ten,sodienthoai=@sdt where makhachhang=@makh
		end
--XÓA KHÁCH HÀNG
		create proc xoakhachhang @makh char(10)
		as
		begin
		delete phieuthuephong  where makhachhang=@makh
		delete hoadon where makhachhang=@makh
		delete khachhang where makhachhang=@makh
		end
		xoakhachhang 'kh04'
--XEM THÔNG TIN KHÁCH HÀNG
create proc xemkhachhang @ma char(10)
as
begin
select * from khachhang where makhachhang=@ma
end
select *from khachhang
select *from hoadon
select *from phieuthuephong
