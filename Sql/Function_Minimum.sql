CREATE TABLE Product(ProductId int  , ProductName varchar(20),ProductQuantity int ,ProductPrice bigint)
Insert into Product values(1,'Mouse',2,200)
Insert into Product values(2,'Mouse',4,300)
Insert into Product values(1,'Keyboard',6,400)
Insert into Product values(3,'Cpu',8,500)
Insert into Product values(2,'Monitor',10,600)
Insert into Product values(4,'Keyboard',12,700)
select * from Product
drop table Product
--------------Minimum Query-------------
select ProductId,ProductName,ProductQuantity from Product where ProductQuantity=(select min(ProductQuantity)from Product)

--------------Maximum Query----------------
select ProductId, ProductName,ProductQuantity from Product where ProductQuantity =(select max(ProductQuantity) from Product)

--------------Having Price-----------------
select ProductName,Min(ProductPrice) as "Minimum Quantity"  from Product group by ProductName having min(ProductPrice)>300;

select ProductName, Max(ProductPrice) as "Maximum Quantity" from Product group by ProductName having max(ProductPrice)>300