USE [TinthanhNew]
GO

INSERT INTO [dbo].[Vattu]
           ([Ma]
           ,[Ten]
           ,[Tentat]
           ,[Manhom]
           ,[Macu]
           ,[Ngungsd]
			 ,[Donvi]
          ,trongluong
           ,[Tonmax]
           ,[Tonmin]
           ,[Quycach]
           
           ,titrong
           ,[TieuchiKT]
           ,[Xuatxu]
           ,[Nhapkhau]
          )
	 select  masp,left(tensp,80),left(tentat,50),manhom,masp,ngungsd,donvi,trongluong,Tonmax,tonmin,quycach,matdo,tieuchiKT,xuatxu,NK 
	 from tinthanh.dbo.Vattu where left(masp,2)='VT'  and dongsp='NM'


INSERT INTO [dbo].[DonviVattu]
           ([Donvi]
           ,[Heso]
           ,[Trongluong]
           ,dongia
           ,[Ngungsd]
           ,[Ma]
          )

		   select  madv, heso,trongluong,gianhap,0, ma  from tinthanh.dbo.donvisanpham where ma in (select ma from vattu)


