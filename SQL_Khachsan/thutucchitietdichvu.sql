--THÊM
		create proc themnguoidungdichvu @madichvu char(10),@maphieu char(10),@tendichvu nvarchar(50),@giadichvu int
		as
		begin
		insert into chitietdungdichvu(madichvu,maphieu,tendichvu,giadichvu)
		values (@madichvu,@maphieu,@tendichvu,@giadichvu)
		end
		themnguoidungdichvu 'dv04','mp01',N'Tổ chức tiệc cho nhóm 1-5 người','1500000'
		select *from dichvu
		select *from chitietdungdichvu
--SỬA
		create proc suanguoidungdichvu @madichvu char(10),@maphieu char(10),@tendichvu nvarchar(50),@giadichvu int
		as
		begin
		update chitietdungdichvu set madichvu=@madichvu,tendichvu=@tendichvu where maphieu=@maphieu
		end
