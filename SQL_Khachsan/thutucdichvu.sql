--THÊM
		create proc themdichvu @madichvu char(10),@tendichvu nvarchar(50),@giadichvu int
		as
		begin
		insert into dichvu(madichvu,tendichvu,giadichvu)
		values (@madichvu,@tendichvu,@giadichvu)
		end
		themdichvu'dv06',N'Bữa tối cho gia đình','1000000'
--SỬA
		alter  proc suadichvu @madichvu char(10),@giadichvu int,@tendichvu nvarchar(50)
		as
		begin
		update dichvu set giadichvu=@giadichvu,tendichvu=@tendichvu where madichvu=@madichvu
		end
		suadichvu 'dv06','1500000'
--XÓA
		create proc xoadichvu @madichvu char(10)
		as
		begin
		delete chitietdungdichvu where madichvu=@madichvu
		delete dichvu where madichvu=@madichvu
		end		
		xoadichvu 'dv06'
--XEM CHI TIẾT DỊCH VỤ
		create proc xemdichvu @maphieu char(10)
		as
		begin
		select *from chitietdungdichvu where maphieu=@maphieu
		end
		xemdichvu 'mp01'
select *from dichvu
--THÊM CHI TIẾT SỬ DỤNG DỊCH VỤ
		create proc themsudungdichvu @madichvu char(10),@maphieu char(10),@tendichvu nvarchar(50),@giadichvu int
		as
		begin
		insert into chitietdungdichvu(madichvu,maphieu,tendichvu,giadichvu)
		values (@madichvu,@maphieu,@tendichvu,@giadichvu)
		end
--SỬA CHI TIẾT SỬ DỤNG DỊCH VỤ
		create proc suasudungdichvu @madichvu char(10),@maphieu char(10),@tendichvu nvarchar(50),@giadichvu int
		as
		begin
		update chitietdungdichvu set madichvu=@madichvu,tendichvu=@tendichvu,giadichvu=@giadichvu where maphieu=@maphieu
		end
select *from phieuthuephong