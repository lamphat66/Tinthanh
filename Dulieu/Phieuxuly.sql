USE [Tinthanh]
GO

INSERT INTO Tinthanhnew.[dbo].[Phieuxuly]
           ([Maphieu]
           ,[Ngaylap]
           ,[Ngaychungtu]
           ,[Makh]
           ,[Tenkh]
           ,[Khomay]
           ,[Thoigiangc]
           ,[Trangthai]
           ,[CreateBy]
           ,[EditBy]
          
           ,[Ghichu]
           ,[Giakhuon]
           ,[Tenkhuon]
           ,[Logo]
           ,[SoCAV]
            
           
           ,[CopyFrom]
           
            )

    select Maphieu,Ngaylap,Ngaylap,Makh,tenkh ,Kichthuock,Thoigiangc,1,users,users,ghichu,Giakhuon,Tenkhuon,logo,Socav,Phieuyc 
	 
	 from   Phieuxlyc where year(Ngaylap) in(2022, 2023)
GO


INSERT INTO tinthanhnew.dbo.Phieuxuly_CT
          
		   ([PhieuxulyId]
           ,[Masp]
           ,[Tensp]
           ,[Thetich]
           ,[Titrong]
           ,[Trongluong]
           ,[Dai]
           ,[Rong]
           ,[Cao]
           ,[Socav],
		   Donvi
         )
          
     
	 select b.id,
	        [Masp]
           ,[Tensp]
           ,[Thetich]
           ,[Titrong]
           ,[Trongluong]
           ,[Dai]
           ,[Rong]
           ,[Cao]
		   ,a.socav
		   ,'CAI'
            
		    
		  
            from  Phieuxlyc_CT a inner join  tinthanhnew.dbo.Phieuxuly b on a.Maphieu=b.maphieu


			 