		                             
								  --THIẾT BỊ
--THÊM

		alter proc themthietbi @mathietbi char(10),@tenthietbi nvarchar(50),@maloai char(10),@gia int
		as
		begin
		insert into danhsachthietbi(mathietbi,tenthietbi,maloaithietbi,giathietbi)
	    values(@mathietbi,@tenthietbi,@maloai,@gia)
		end
--SỬA
		alter proc suathietbi @mathietbi char(10),@gia int
		as
		begin
		update danhsachthietbi set giathietbi=@gia where mathietbi=@mathietbi
		end 
--XÓA
		alter proc xoathietbi @mathietbi char(10)
		as
		begin
		delete chitietsudungthietbi where mathietbi=@mathietbi
		delete danhsachthietbi where mathietbi=@mathietbi
		end
		xoathietbi 'tb18'
select *from thietbi
 
--THÊM CHI TIẾT DÙNG THIẾT BỊ
		
		create  proc themchitiet @maphong char(10),@mathietbi char(10),@tenthietbi nvarchar(50)
		as
		begin
		insert into chitietsudungthietbi values (@maphong,@mathietbi,@tenthietbi)
		update danhsachthietbi set tinhtrang=N'Đã sử dụng' where mathietbi=@mathietbi
		end
		themchitiet '302','tb02',N'Điều hòa đứng 1HP'
		select *from danhsachthietbi
		select *from chitietsudungthietbi
		select *from phong
--SỬA CHI TIẾT DÙNG THIẾT BỊ
		create proc suachitiet @maphong char(10),@mathietbi char(10),@tenthietbi nvarchar(50)
		as
		begin
		update chitietsudungthietbi set mathietbi=@mathietbi,tenthietbi=@tenthietbi where maphong=@maphong
		end
		suachitiet '201','tb03',N'Điều hòa treo tường 1HP'
select *from chitietsudungthietbi