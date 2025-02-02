USE [TinthanhNew]
GO

INSERT INTO [dbo].[Thanhpham]
           ([Ma]
           ,[Ten]
           ,[Tentat]
           ,[Manhom]
           ,[Ngungsd]
          
           ,[Donvi]
           
           ,[Dai]
           ,[Rong]
           ,[Cao]
           ,[Trongluong]
           ,[Thetich]
           ,[Tonmax]
           ,[Tonmin]
           
           ,[Quycach]
            
           
           ,[Mabo]
           ,[Hesobo]
           ,[Titrong])
     
 select ma,left(ten,80),left(tentat,50),manhom,ngungsd,donvi,dai,rong,cao,trongluong,thetich,tonmax,tonmin,quycach ,null,null,matdo  
 from tinthanh.dbo.danhdiem  where loaidd='TP' and ngungsd=0  and manhom='S-EPS' and donvi='CAI'

 Go
 INSERT INTO [dbo].[Donvisanpham]
           ([Donvi]
           ,[Heso]
           ,[Trongluong]
           ,[Dongia],ma)
           
     
 select madv,heso,trongluong,dongia,ma from tinthanh.dbo.donvisanpham  where ma in(select Ma from thanhpham)




 