		alter proc tinhsongay @maphieu char(10),@mahoadon char(10)
		as
		begin
		select DATEDIFF(DAYOFYEAR,ngaydatphong,ngaytraphong)
		from phieuthuephong,hoadon where  phieuthuephong.maphieu=@maphieu and mahoadon=@mahoadon and hoadon.maphieu=phieuthuephong.maphieu
		end
tinhsongay 'mp01','hd01'

--THÊM HÓA ĐƠN
		alter proc themhoadon @mahd char(10),@manv char(10),@maphieu char(10),@makh char(10),@giadv int,@giaphong int ,@tongtien int,@ngaythanhtoan datetime
		as
		begin
		insert into hoadon(mahoadon,manhanvien,maphieu,makhachhang,giaphong,giadichvu,tongtien,ngaythanhtoan)
		values (@mahd,@manv,@maphieu,@makh,@giaphong,@giadv,@tongtien,@ngaythanhtoan)
		end
--XÓA HÓA ĐƠN
		create proc xoahoadon @mahoadon char(10)
		as
		begin
		delete hoadon where mahoadon=@mahoadon
		end
--SỬA HÓA ĐƠN
		create proc suahoadon @mahoadon char(10),@giadv int,@giaphong int,@tongtien int
		as
		begin
		update hoadon set giadichvu=@giadv,giaphong=@giaphong,tongtien=@tongtien where mahoadon=@mahoadon
		end
select *from hoadon
--XEM PHIẾU ĐĂNG KÍ
		create proc xemphieudk @maphieu char(10)
		as
		begin
		select *from phieuthuephong where maphieu=@maphieu
		end
