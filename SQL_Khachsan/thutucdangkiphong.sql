--Xem chi tiết thiết bị của phòng
		alter proc xemthietbi @maph char(10)
		as
		begin
		select *from chitietsudungthietbi where maphong=@maph
		end
		xemthietbi '801'
--Xem chi tiết khách hàng sử dụng dịch vụ
		create proc xemchitietdichvu @maphieu char(10)
		as
		begin
		select *from chitietdungdichvu where maphieu=@maphieu
		end
--PHIẾU ĐĂNG KÍ

--THÊM PHIẾU ĐĂNG KÍ

	   alter proc themphieu @maphieu char(10),@makhachhang char(10),@maphong char(10),@manhanvien char(10),
		@ngaydat datetime,@ngaydukien datetime,@ngaytra datetime,@songuoio int
		as
		begin
		insert into phieuthuephong(maphieu,makhachhang,maphong,manhanvien,ngaydatphong,ngaydukientra,ngaytraphong,songuoio)
	    values(@maphieu,@makhachhang,@maphong,@manhanvien,@ngaydat,@ngaydukien,@ngaytra,@songuoio)
		insert into chitietdungdichvu(madichvu,maphieu,giadichvu) values ('dv00',@maphieu,'0')
		update phong set tinhtrangphong=N'có người đặt' where maphong=@maphong
		end
		themphieu 'm07','kh07','702','nv04','2017/05/29','2017/06/03','2017/06/03','2'
		select *from chitietdungdichvu
		select * from phong
		select * from phieuthuephong
--SỬA PHIẾU ĐĂNG KÍ

		create proc suaphieu @maphieu char(10) ,@ngaytra datetime
		as
		begin
		update phieuthuephong set ngaytraphong=@ngaytra where maphieu=@maphieu
		end
--XÓA PHIẾU ĐĂNG KÍ

		alter proc xoaphieu @maphieu char(10),@maphong char(10)
		as
		begin
		delete hoadon where maphieu=@maphieu
		delete chitietdungdichvu where maphieu=@maphieu
		delete phieuthuephong where maphieu=@maphieu
		update phong set tinhtrangphong=N'trống' where maphong=@maphong
		end

		                          select *from phieuthuephong
								  select *from phong   
								  select *from hoadon    
								  select *from chitietdungdichvu
--PHÒNG
--THÊM PHÒNG
		create proc themphong @maphong char(10),@maloaiphong char(10),@tinhtrangphong nvarchar(50),@giaphong int
		as
		begin
		insert into phong(maphong,maloaiphong,tinhtrangphong,giaphong)
		values (@maphong,@maloaiphong,@tinhtrangphong,@giaphong)
		end
--SỬA PHÒNG
		create proc suaphong @maphong char(10),@giaphong int
		as
		begin
		update phong set giaphong=@giaphong where maphong=@maphong
		end
--XÓA PHÒNG
		alter proc xoaphong @maphong char(10),@mathietbi char(10)
		as
		begin
		delete chitietsudungthietbi where maphong=@maphong 
		delete phieuthuephong where maphong=@maphong
		delete phong where maphong=@maphong
		update danhsachthietbi set tinhtrang=N'Chưa sử dụng' where mathietbi=@mathietbi
		end
		
		
select *from chitietsudungthietbi
select *from phong
select *from danhsachthietbi
