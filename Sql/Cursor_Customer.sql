CREATE TABLE Customer(Custid int, Name varchar(20),Price bigint)
Insert into CUstomer values(1,'Mouse',200)
Insert into CUstomer values(2,'Printer',300)
Insert into CUstomer values(3,'Monitor',400)
Insert into CUstomer values(4,'Cpu',500)
Insert into CUstomer values(5,'Keyboard',600)
select * from Customer

-----------------------Select all table with cursor---------------------------------------
Declare @custid int,@name varchar(max),@price bigint;
Declare cursorth3 Cursor for select Custid,Name,Price from Customer 
open cursorth3
fetch next from cursorth3 into @custid,@name,@price 
while @@FETCH_STATUS=0 begin 
    print cast(@custid as varchar)+@name+cast(@price as varchar);
	Fetch next from cursorth3 into @custid,@name,@price 
	end;
   close cursorth3

   deallocate cursorth3
------------------------------------------------------------------------------------------
Declare @custid int,@name varchar(max),@price bigint;
Declare cursorth8 Cursor for select Custid,Name,Price  from Customer where Custid>3
open cursorth8
fetch next from cursorth8 into @custid,@name,@price print cast(@custid as varchar)+@name+cast(@price as varchar)
while @@FETCH_STATUS>0 
    begin 
   Fetch next from cursorth8 into @custid,@name,@price print cast(@custid as varchar)+@name+cast(@price as varchar); end;
   close cursorth8
   deallocate cursorth8
----------------------------------------------------------------------------------------
Declare @custid int,@name varchar(max),@price bigint;
Declare cursorth9 Cursor for select Custid,Name,Price  from Customer where Price>300
open cursorth9
fetch next from cursorth9 into @custid,@name,@price; 
while @@FETCH_STATUS=0 
    begin 
    print cast(@custid as varchar)+@name+cast(@price as varchar) 
	Fetch next from cursorth9 into @custid,@name,@price end;
   close cursorth9
   deallocate cursorth9