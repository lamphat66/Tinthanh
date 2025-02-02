


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
           ,[Dongia],ma)
           
     
 select madv,heso,trongluong,dongia,ma from tinthanh.dbo.donvisanpham  where  ma in( select ma from tinthanh.dbo.Danhdiem where left(ma,4)='TTMT' and ngungsd=0)