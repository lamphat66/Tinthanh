USE [TinthanhNew]
GO

INSERT INTO [dbo].[KhachhangTN]
           ([Ma]
           ,[Ten]
           ,[Dienthoai]
           ,[Email]
           ,[Website]
           ,[Ngungsd]
          
           ,[Diachi]
           ,[Lienhe]
		   ,Macu)
      
select Ma,ten,dienthoai,email,website,danghi ,isnull(left(diachi,100),''),TenNM,Ma from tinthanh.dbo.doituong where manhom='NKH13' and danghi=0 

   Update KhachhangTN set ma=b.STT from KhachhangTN a inner join 
	  ( Select Ma,'TN'+format(Row_Number() OVER(ORDER BY id ASC),'0000') as STT from KhachhangTN ) b 
	  on a.ma=b.ma


 