USE [TinthanhNew]
GO

INSERT INTO [dbo].[Nhacungcap]
           ([Ma]
           ,[Ten]
           ,[Tentat]
           ,[Manhom]
           ,[Msthue]
           ,[Dienthoai]
            
            
           ,[Ngungsd]
           
           ,[Diachi]
           ,[PTVanchuyen]
           ,[HanTT]
           ,[TileTT]
           ,[TheodoiCN]
           ,[Maxno]
           ,[ISO]
            
           ,[Hoadon]
           ,[ThanhtoanNH]
           ,[VAT])
    Select  Ma,left(Ten,80),left(Tentat,50),Manhom,masothue,dienthoai,  danghi,isnull(Left(diachi,100),''),PTGiaohang,HanTT,TileTT,TheodoiCn,
	maxno,ISO,Hoadon,ThanhtoanNH,VAT from tinthanh.dbo.Doituong where loaidt='CV' and danghi=0
	 
	go
	
	INSERT INTO [dbo].[LienlacNCC]
           ([Hoten]
           ,[Dienthoai]
           ,[Email]
           ,[Chucvu]
           ,[Bophan]
           ,[Ma]
           ,[Chinhanh]
           ,[EInvoice]
           ,[Quyetdinh]
           ,[Ngungsd]
           ,[Didong]
           ,[Diachi]
           ,[Phanloai]
           ,[PhanloaiId]
		   ,NhacungcapId)


     Select left(isnull(Hoten,''),50),left(sodienthoai,30),left(a.email,50),chucvu,bophan,makh,chinhan,hoadondientu,quyetdinh,
	 a.ngungsd,didong, left(a.diachi,50) ,phanloai,Phanloaiid ,b.Id
	 from tinthanh.dbo.Nguoilienlac a inner join nhacungcap b on a.makh=b.Ma
	 where left(makh,2)='CV'
	 

	 

GO


