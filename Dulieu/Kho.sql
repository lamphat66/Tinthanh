USE [TinthanhNew]
GO

INSERT INTO [dbo].[Kho]
           ([Ma]
           ,[Ten]
           ,[Tentat]
           ,[Manhom]
            
           ,[Ngungsd]
           
           ,[Diachi]
           ,[Kho_ao]
           ,[vitri]
		   ,Macu)

      select Makho,Tenkho,tentat,Nhom ,0,diachi,0,0,Makho from tinthanh.dbo.Kho where danghi=0 
	   
	   delete From kho where ma in('KBLLQ005','KBNI0002','KBNI0003','KBQ80004','KBVGT001')
	    Update kho set ma=b.STT from kho a inner join 
	  ( Select Ma,'KB'+format(Row_Number() OVER(ORDER BY id ASC),'0000') as STT from Kho ) b 
	  on a.ma=b.ma
GO

 
