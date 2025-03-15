USE [TinthanhNew]
GO
 
INSERT INTO [dbo].[ThanhphamBG]
           ([Ma]
           ,[Ten]
           ,[Donvi]
            
           ,[Ngungsd],
		   Macu)
      select Ma,ten,donvi,Ngungsd,ma  from Tinthanh.dbo.Danhdiem where Left(ma,2)='BG' and ngungsd=0
GO

 Update ThanhphamBG set Ma= b.Mamoi from thanhphamBG a inner join
 (select Ma, 'BG'+format(Convert(int,substring(Ma,3,4)),'0000') as Mamoi from ThanhphamBG ) b on a.ma=b.ma
 Go

INSERT INTO [dbo].[KhuonBG]
           ([Ma]
           ,[Ten]
           
            
           ,[Ngungsd],
		   Macu)
      select Ma,ten,Ngungsd ,ma from Tinthanh.dbo.Danhdiem where Left(ma,3)='KBG' and ngungsd=0
 
 Update KhuonBG set Ma= b.Mamoi from KhuonBG a inner join
 (select Ma, 'KBG'+format(Convert(int,substring(Ma,4,3)),'0000') as Mamoi from KhuonBG) b on a.ma=b.ma

 