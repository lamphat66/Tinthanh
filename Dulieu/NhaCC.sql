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
	maxno,ISO,Hoadon,ThanhtoanNH,VAT from tinthanh.dbo.Doituong where loaidt='CV'

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
           ,[PhanloaiId])


     Select left(isnull(Hoten,''),50),left(sodienthoai,30),left(email,50),chucvu,bophan,makh,chinhan,hoadondientu,quyetdinh,ngungsd,didong, left(diachi,50) ,phanloai,Phanloaiid from tinthanh.dbo.Nguoilienlac
	 where left(makh,2)='CV'


GO


