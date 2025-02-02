USE [TinthanhNew]
GO

INSERT INTO [dbo].[BanggiaNCC]
           ([MaDT]
           ,[MaVT]
           ,[Donvi]
           ,[TenVT]
           ,[TenNB]
           ,[Giaban]
           ,[Chietkhau]
           ,[TienChietKhau]
           ,[Giacu]
           ,[NgayUpdate]
           ,[HesoSP]
           ,[ROHS]
           ,[Baohanh]
           ,[Ghichhu]
           ,[Hoadon]
           ,[Users]
           ,[ChietkhauSP]
           ,[VAT]
           ,[HanNH])


		   select [MaDT]
           ,[Masp]
           ,[Donvi]
           ,[Ten]
           ,[Ten]
           ,[Giaban]
           ,[Chietkhau]
           ,[TienChietKhau]
           ,[Giacu]
           ,[NgayUpdate]
           ,[HesoSP]
           ,[ROHS]
           ,[Baohanh]
           ,[Ghichhu]
           ,[Hoadon]
           ,[Users]
           ,[ChietkhauSP]
           ,[VAT]
           ,[HanNH] 
		   from tinthanh.dbo.Tenspkh where madt in(Select ma from tinthanh.dbo.doituong where loaidt='CV') and isnull(ngungsd,0)=0 
    
GO

WITH DuplicateRows AS (
    SELECT *,
        ROW_NUMBER() OVER (PARTITION BY madt, Mavt ORDER BY id) AS RowNumber
    FROM BanggiaNCC
)
delete  FROM DuplicateRows
WHERE RowNumber > 1;
