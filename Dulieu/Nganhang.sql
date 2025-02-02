INSERT INTO [dbo].Nganhang
           ([Ma]
           ,[Ten]
           ,[Tentat]
                       
           ,[Ngungsd]
           
           ,[Diachi]
            
		   ,Macu)

      select Manh,Tennh,tentat,0,diachi,Manh from tinthanh.dbo.Nganhang where danghi=0 
	go   
	   
	    Update Nganhang set ma=b.STT from Nganhang a inner join 
	  ( Select Ma,'NH'+format(Row_Number() OVER(ORDER BY id ASC),'0000') as STT from Nganhang ) b 
	  on a.ma=b.ma