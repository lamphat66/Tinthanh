INSERT INTO [dbo].Khuvuc
           ([Ma]
           ,[Ten]
         
		   ,Macu
		   ,Ngoainuoc)

      select Ma,ten,ma,0 from tinthanh.dbo.KhuvucDT 
	go   
	   
	    Update Khuvuc set ma=b.STT from Khuvuc a inner join 
	  ( Select Ma,'KV'+format(Row_Number() OVER(ORDER BY id ASC),'0000') as STT from Khuvuc ) b 
	  on a.ma=b.ma