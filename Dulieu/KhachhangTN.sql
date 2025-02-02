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
           ,[Lienhe])
      
select Ma,ten,dienthoai,email,website,danghi ,isnull(left(diachi,100),''),TenNM from tinthanh.dbo.doituong where manhom='NKH13'

update khachhangtN set diachi=isnull(left(b.diachi,100),'') from khachhangTN a inner join tinthanh.dbo.Doituong b on a.ma=b.ma


 