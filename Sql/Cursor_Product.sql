CREATE TABLE Product(Id int,Name varchar(20),Year int,Price bigint)
Insert into Product values(1,'Mouse',2022,200)
Insert into Product values(2,'Printer',2023,300)
Insert into Product values(3,'Monitor',2022,400)
Insert into Product values(4,'Cpu',2022,500)
Insert into Product values(5,'Keyboard',2023,600)
select * from Product

----------------------Cursor Query-------------------------
----------------DECLARE-----------------
DECLARE @name varchar(max),@price bigint;
DECLARE cursorth1 CURSOR for select Name,Price from Product;
-----------------OPEN-------------------
OPEN cursorth1;
-----------------FETCH------------------
FETCH NEXT FROM cursorth1 into @name,@price;
WHILE @@FETCH_STATUS=0 ---Condition ,Execute row by row ----
  BEGIN
    
	  PRINT  @name+CAST(@price as varchar);
	  FETCH NEXT FROM cursorth1 into @name,@price;
	  END;
	  CLOSE Cursorth1;
	  DEALLOCATE Cursorth1;
----------------------------------------------------------------------------------------------