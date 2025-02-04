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
		   and not (left(masp,2)='TI'or left(masp,4)='TTVC' )

go


--delete from BanggiaKH where left(masp,2)='TI'
--delete from BanggiaKH where left(masp,4)='TTVC' 
 
 WITH DuplicateRows AS (
    SELECT *,
        ROW_NUMBER() OVER (PARTITION BY makh, Masp ORDER BY id) AS RowNumber
    FROM BanggiaKH
)
delete  FROM DuplicateRows
WHERE RowNumber > 1;

Update BanggiaKH set KhachhangId=c.Id,SanphamId=b.Id from BanggiaKH a inner join Thanhpham b on a.Masp=b.Ma 
inner join Khachhang c on a.Makh=c.Ma


delete  from BanggiaKH where masp not in(Select Ma from Thanhpham)
delete  from BanggiaKH where makh not in(Select Ma from Khachhang)

 