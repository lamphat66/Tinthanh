use TinthanhNew
Go

Insert into Donvi(ma,ten,Ngungsd)
select madv,tendv,0 from tinthanh.dbo.Donvi

Go

Insert into Loaidanhdiem(ma,ten)
select Ma,ten from tinthanh.dbo.Loaidd
go
Insert into Nhomdanhdiem (Ma,ten,Madd,ngungsd)
select Manhom,Tennhom,Loaidd,0 from tinthanh.dbo.Nhomdd where loaidd in(select ma from tinthanh.dbo.Loaidd)
go

Insert into Loaidoituong(ma,ten)
select Ma,ten from tinthanh.dbo.Loaidt
Go
Insert into Nhomdoituong(ma,ten,madt,Ngungsd)

select Manhom,Tennhom,Loaidt,0 from tinthanh.dbo.Nhomdt where loaidt in(select ma from tinthanh.dbo.Loaidt)


Insert into TinthanhNew.dbo.Danhmuc(ma,ten)
SELECT 
      [Ma]
      ,[Ten]
  FROM [TinthanhERP].[dbo].[Danhmuc]

  Insert Into DanhmucCTs(DanhmucId,Ten,Ngungsd,stt)
 
 
  select DanhmucId*100,Ten,0,0 from tinthanhERP.dbo.Danhmuc_CT
 
 go

 Insert into danhmuc_KT 
 select * from tinthanh.dbo.Danhmuc_KT


Insert into TieuchiKT
select * from tinthanh.dbo.tieuchiKT
go
Insert into TieuchiCT(Makt,Ten,TieuchiKTMa)
Select MAdm,b.Ten,Iddm from tinthanh.dbo.Tieuchi_CT a inner join Tinthanh.dbo.Danhmuc_KT b on a.Madm=b.ma
go
Insert into Khomay (Ma,ten,Loinhuan,Giakhuon,GiakhuonUSD,LoinhuanM,ngungsd)
select Ma,ten,LoinhuanMin,Giakhuon,GiakhuonUSD,Loinhuanmax,0 from tinthanh.dbo.Khomay where ma <>16