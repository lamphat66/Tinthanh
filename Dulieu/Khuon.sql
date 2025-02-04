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
		   from Tinthanh.dbo.Khuon  where Ngungsd=0

update Khuon set Makh=madt,tenKH=b.tenkh,Tilevon=Gopvon from khuon a inner join tinthanh.dbo.KhuonKH b on a.Ma=b.masp

update khuon set KhachhangId=b.Id from Khuon a inner join Khachhang b on a.Makh=b.Ma

delete from khuon where khachhangId =0

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
           ,KhuonId
           ,[Nhom]
           ,[Caospd])
		 
           

select	    [MaTP]
           ,[TenSP]
           ,a.[Socav]
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
           ,b.Id
           ,[Nhom]
           ,[Caospd]
		  
            from Tinthanh.dbo.Khuon_CT a inner join Khuon b on a.Makhuon=b.ma where matp is not null

 

 update khuon_CT set sanphamid=b.Id from Khuon_CT a inner join thanhpham b on a.masp=b.ma
 update khuon_CT set Tensp=b.ten from Khuon_CT a inner join Thanhpham b on a.Masp=b.ma
 delete From khuon_CT where SanphamId is null

  


 