USE [TinthanhNew]
GO

INSERT INTO [dbo].[Khuon]
           ([Ma]
           ,[Ten]
           ,[Manhom]
          
           ,[Trongluong]
           ,[Khomay]
           ,[SoCav]
           
           ,[Chuky]
           ,[TGlenkhuon]
           ,[TGxuongkhuon]
          
           ,[Ngungsd])
  
  select    [Ma]
           ,[Ten]
           
           ,[Manhom]
           
           ,[Trongluong]
           ,[Khomay]
           ,[SoCav]
            
           ,[Chuky]
           ,[TGlenkhuon]
           ,[TGxuongkhuon]
         
        
           ,[Ngungsd]
		   from Tinthanh.dbo.Khuon  

update Khuon set Makh=madt,tenKH=b.tenkh,Tilevon=Gopvon from khuon a inner join tinthanh.dbo.KhuonKH b on a.Ma=b.masp


INSERT INTO [dbo].[Khuon_CT]
           ([Masp]
           ,[TenSP]
           ,[Socav]
           ,[Donvi]
           ,[SPchinh]
           ,[DaiD]
           ,[DaiA]
           ,[RongD]
           ,[RongA]
           ,[CaoD]
           ,[CaoA]
           ,[Daint]
           ,[Rongnt]
           ,[Caont]
           ,[Daispd]
           ,[Daispa]
           ,[Rongspd]
           ,[Rongspa]
           ,[Caospa]
           ,[Makhuon]
           ,[Nhom]
           ,[Caospd])
		 
           

select	    [MaTP]
           ,[TenSP]
           ,[Socav]
           ,[Donvi]
           ,[SPchinh]
           ,[DaiD]
           ,[DaiA]
           ,[RongD]
           ,[RongA]
           ,[CaoD]
           ,[CaoA]
           ,[Daint]
           ,[Rongnt]
           ,[Caont]
           ,[Daispd]
           ,[Daispa]
           ,[Rongspd]
           ,[Rongspa]
           ,[Caospa]
           ,[Makhuon]
           ,[Nhom]
           ,[Caospd]
		  
            from Tinthanh.dbo.Khuon_CT where matp is not null

Update Khuon_CT set Tensp=b.Tensp from Khuon_CT  a inner join tinthanh.dbo.Thanhpham b on a.Masp=b.Masp

 

 