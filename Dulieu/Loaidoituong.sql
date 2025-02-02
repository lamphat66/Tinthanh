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
