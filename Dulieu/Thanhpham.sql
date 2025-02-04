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
 
 --Mop tam
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

 

select		 [Ma]
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
            
           
           ,null
           ,null
           ,[Matdo] 
		    from tinthanh.dbo.Danhdiem where left(ma,4)='TTMT' and ngungsd=0

Go
 
 INSERT INTO [dbo].[Donvisanpham]
           ([Donvi]
           ,[Heso]
           ,[Trongluong]
           ,[Dongia],ThanhphamId)
           
     
 select madv,heso,a.trongluong,dongia,b.Id from tinthanh.dbo.donvisanpham a inner join Thanhpham b on a.Ma=b.Ma
 
   where a.ma in(select Ma from thanhpham)




 