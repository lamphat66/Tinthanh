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
		   ,Ngaygiagoc
           ,[Ngaycapnhat]
          -- ,[HesoSP]
           ,[ROHS]
           ,[Baohanh]
          -- ,[Ghichhu]
           ,[Hoadon]
           ,[Users]
           ,[ChietkhauSP]
           ,[VAT]
         --  ,[HanNH]
		 )


		   select [MaDT]
           ,[Masp]
           ,[Donvi]
           ,[Ten]
           ,[Ten]
           ,[Giaban]
           ,[Chietkhau]
           ,[TienChietKhau]
           ,[Giacu]
		   ,Ngaygiagoc
           ,[NgayUpdate]
          -- ,[HesoSP]
           ,[ROHS]
           ,[Baohanh]
          -- ,[Ghichhu]
           ,[Hoadon]
           ,[Users]
           ,[ChietkhauSP]
           ,[VAT]
          -- ,[HanNH] 
		   from tinthanh.dbo.Tenspkh where madt in(Select ma from tinthanh.dbo.doituong where loaidt='CV') and isnull(ngungsd,0)=0 
    
GO

WITH DuplicateRows AS (
    SELECT *,
        ROW_NUMBER() OVER (PARTITION BY madt, Mavt ORDER BY id) AS RowNumber
    FROM BanggiaNCC
)
delete  FROM DuplicateRows
WHERE RowNumber > 1;

Update banggiaNCC set maVT=b.Ma from BanggiaNCC a inner join vattu b on a.Mavt=b.Macu 
Update BanggiaNCC set NhaCCId=c.Id,VattuId=b.Id from BanggiaNCC a inner join Vattu b on a.Mavt=b.Ma 
inner join Nhacungcap c on a.Madt=c.Ma


delete  from BanggiaNCC where mavt not in(Select Ma from Vattu)
delete  from BanggiaNCC where madt not in(Select Ma from Nhacungcap)

 