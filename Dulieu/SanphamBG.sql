USE [TinthanhNew]
GO

INSERT INTO [dbo].[ThanhphamBG]
           ([Ma]
           ,[Ten]
           ,[Donvi]
            
           ,[Ngungsd])
      select Ma,ten,donvi,Ngungsd from Tinthanh.dbo.Danhdiem where Left(ma,2)='BG' and ngungsd=0
GO

 Update ThanhphamBG set Ma= b.Mamoi from thanhphamBG a inner join
 (select Ma, 'BG'+format(Convert(int,substring(Ma,3,3)),'0000') as Mamoi from ThanhphamBG where len(Ma)=5) b on a.ma=b.ma
 Go

INSERT INTO [dbo].[KhuonBG]
           ([Ma]
           ,[Ten]
           
            
           ,[Ngungsd])
      select Ma,ten,Ngungsd from Tinthanh.dbo.Danhdiem where Left(ma,3)='KBG' and ngungsd=0
 
 

