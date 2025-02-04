USE [TinthanhNew]
GO

INSERT INTO [dbo].[Khachhang]
           ([Ma]
           ,[Ten]
           ,[Tentat]
           ,[Manhom]
           ,[Msthue]
           ,[Dienthoai]
           ,[Email]
           ,[Website]
           ,[Ngungsd]
            
          
            
           ,[Diachi]
          
           ,[Makv]
           ,[Soducongno]
           ,[Donhang]
           ,[Dagiao]
           ,[PTVanchuyen]
           ,[Lienhe]
           ,[Loaicn]
           ,[HanTT]
           ,[TileTT]
           ,[Ketu]
           ,[Songay]
           ,[TheodoiCN]
           ,[Maxno]
           ,[LinkNhaCC]
           ,[Hoadon]
           ,[Ingia]
           ,[ThanhtoanNH]
           ,[Congty]
           ,[Thuongxuyen]
           ,[VAT]
           ,[Macu])
    

Select   [Ma]
           ,[Ten]
           ,[Tentat]
           ,[Manhom]
           ,[Masothue]
           ,[Dienthoai]
           ,[Email]
           ,[Website]
           ,[Danghi]
     
           ,left([Diachi],100)
          
           ,0
           ,0
           ,0
           ,0
           ,PTGiaohang
           ,Tennm
           ,[Loaicn]
           ,[HanTT]
           ,[TileTT]
           ,[Ketu]
           ,[Songay]
           ,[TheodoiCN]
           ,[Maxno]
           ,''
           ,[Hoadon]
           ,[Ingia]
           ,[ThanhtoanNH]
           ,[Congty]
           ,KHTX
           ,[VAT]
           ,Ma

 from Tinthanh.dbo.Doituong where loaidt='KH' and danghi=0 and manhom not in('NKH13','NKH14')

GO

 INSERT INTO [dbo].[LienlacKH]
           ([Hoten]
           ,[Dienthoai]
           ,[Email]
           ,[Chucvu]
           ,[Bophan]
           ,Khachhangid
           ,[Chinhanh]
           ,[EInvoice]
           ,[Quyetdinh]
           ,[Ngungsd]
           ,[Didong]
           ,[Diachi]
           ,[Phanloai]
           ,[PhanloaiId])


     Select left(isnull(Hoten,''),50),left(sodienthoai,30),left(a.email,50),chucvu,bophan,b.id,chinhan,hoadondientu,quyetdinh,a.ngungsd,didong, left(a.diachi,50) ,phanloai,Phanloaiid
	  from tinthanh.dbo.Nguoilienlac a inner join khachhang b on a.makh=b.macu 
	 where left(makh,2)='KH'