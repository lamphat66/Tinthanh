USE [Tinthanh]
GO

INSERT INTO tinthanhnew.dbo.[Phieuyeucau]
           ([Maphieu]
           ,[Ngaylap]
           ,[Ngaychungtu]
           ,[Makh]
           ,[Tenkh]
           ,[Ngaynhan1]
           ,[Nguoinhan1]
           ,[NgayVC1]
           ,[NguoiVC1]
           ,[NgayXL1]
           ,[NguoiXL1]
           ,[Ghichu]
           ,[Trangthai]
           ,[Ketluan]
           ,[CreateBy]
           ,[EditBy]
           ,[EditDate]
           ,[Diachi]
           ,[Dienthoai]
           ,[Lienhe]
            
           ,[Ngayhoanthanh])

    select Maphieu,Ngaylap,Ngaylap,Makh,tenkh ,ngaynhan1,Nguoinhan1,Ngayvc1,Nguoivc1,Ngayxl1,Nguoixl1,ghichu,trangthai ,ketluan,uname,uname,Ngaylap,diachi,dienthoai2,lienhe,'12/31/2099'
	 from  Phieuyeucau where year(Ngaylap)=2025
GO


INSERT INTO TinthanhNew.dbo.[Phieuyeucau_CT]
           ([Masp]
           ,[Tensp]
           ,[Donvi]
           ,[Soluong]
           ,[Khomay]
           ,[Ghichu]
           ,[Ketqua]
           ,[Loaisp]
           ,[Xuly]
           ,[Yeucau]
           ,[KhomayKH]
           ,[Socav]
           ,[SocavT]
           ,[Thoihan]
           ,[Tinhtrang]
           ,[YeucauT]
           ,[GiaSC]
           ,[SoluongDH]
           ,[Lanthang]
           ,[SoluongMin]
           ,[Nhomkhuon]
           ,[PhieuyeucauId])
     
	 select [Masp]
           ,[Tensp]
           ,[Donvi]
           ,[Soluong]
           ,[Khomay]
           ,a.[Ghichu]
           ,[Ketqua]
           ,a.[Loaisp]
           ,[Xuly]
           ,[Yeucau]
           ,[KhomayT]
           ,[Socav]
           ,[SocavT]
           ,a.[Thoihan]
           ,[Tinhtrang]
           ,[YeucauT]
           ,[GiaSC]
           ,[SoluongDH]
           ,[Lanthang]
           ,0
           ,0
		   ,b.id
            from  Phieuyeucau_CT a inner join  tinthanhnew.dbo.Phieuyeucau b on a.Maphieu=b.Maphieu 