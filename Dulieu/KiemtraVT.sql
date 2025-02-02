USE [TinthanhNew]
GO

INSERT INTO [dbo].[Danhmuc_KT]
           ([Ma]
           ,[Ten]
           ,[Chuanmuc]
           ,[Tansuat]
           ,[Phuongphap]
           ,[Thuchien]
           ,[Ngungsd])
  
    select [Ma]
           ,[Ten]
           ,[Chuanmuc]
           ,[Tansuat]
           ,[Phuongphap]
           ,[Thuchien],0 from tinthanh.dbo.Danhmuc_KT
GO


Insert into TieuchiKT
select * from Tinthanh.dbo.TieuchiKT
go

INSERT INTO [dbo].[TieuchiCT]
           ( 
           [MaKT]
           ,[Ten]
           ,[TieuchiKTMa])
      
	  Select Madm,b.Ten,IDDM from Tinthanh.dbo.Tieuchi_CT a inner join Danhmuc_KT b on a.Madm=b.Ma

