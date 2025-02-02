USE [TinthanhNew]
GO

INSERT INTO [dbo].[BanggiaKH]
           ([Makh]
           ,[Masp]
           ,[Marieng]
           ,[Donvi]
           ,[TenSPKH]
           ,[TenSPTT]
           ,[Giaban]
           ,[Giabannt]
           ,[Giacu]
           ,[GiacuNT]
           ,[Trongluong]
           ,[Matdo]
           ,[Khomay]
           ,[SoCAV]
           ,[Users]
           ,[Ngaygiagoc]
           ,[Ngaycapnhat]
           ,[Giaao]
           ,[Giale]
           ,[Trangthai])
    
select     [Madt]
           ,[Masp]
           ,marieng
           ,[Donvi]
           ,[Ten]
           ,[Ten]
           ,[Giaban]
           ,[Giabannt]
           ,[Giacu]
           ,[GiacuNT]
           ,[Trongluong]
           ,[Matdo]
           ,[Khomay]
           ,[SoCAV]
           ,[Users]
           ,[Ngaygiagoc]
           ,[Ngayupdate]
           ,0
           ,[Giale]
           ,1 from tinthanh.dbo.Tenspkh where madt in(Select ma from tinthanh.dbo.doituong where loaidt='KH') and isnull(ngungsd,0)=0 

go


delete from BanggiaKH where left(masp,2)='TI'
delete from BanggiaKH where left(masp,4)='TTVC' 
 
 WITH DuplicateRows AS (
    SELECT *,
        ROW_NUMBER() OVER (PARTITION BY makh, Masp ORDER BY id) AS RowNumber
    FROM BanggiaKH
)
delete  FROM DuplicateRows
WHERE RowNumber > 1;