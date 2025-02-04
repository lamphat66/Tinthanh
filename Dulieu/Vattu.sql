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
		   ,kho
          )
	 select  masp,left(tensp,80),left(tentat,50),manhom,masp,ngungsd,donvi,trongluong,Tonmax,tonmin,quycach,matdo,tieuchiKT,xuatxu,NK ,''
	 from tinthanh.dbo.Vattu where left(masp,2)='VT'  and dongsp='NM'


	 update vattu set Ma='VT'+format(Cast(id as int),'000000') 
	  

INSERT INTO [dbo].[DonviVattu]
           ([Donvi]
           ,[Heso]
           ,[Trongluong]
           ,dongia
           ,[Ngungsd]
           ,VattuId
          )

		   select  madv, heso,a.trongluong,gianhap,0, b.id  from tinthanh.dbo.donvisanpham a inner join Vattu b on a.ma=b.ma  

 select  * from vattu
