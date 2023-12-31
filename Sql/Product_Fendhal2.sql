CREATE TABLE TableProductGSTDetails (Product_Gst_ID int primary key,Gst_Detail_Name varchar(500),CGST decimal(10,2),SGST decimal(10,2),IGST decimal(10,2))
Insert into TableProductGSTDetails values(1,'Ashok',5,10,15)
Insert into TableProductGSTDetails values(2,'Jsw Steel',10,15,20)
Insert into TableProductGSTDetails values(3,'Oil',15,20,25)
Insert into TableProductGSTDetails values(4,'Gas',20,25,30)
Insert into TableProductGSTDetails values(5,'Petrol',25,30,35)


CREATE TABLE TableProductCategory (Product_Category_ID int primary key,Product_Type_Name varchar(20),Product_Gst_ID int, foreign key(Product_Gst_ID) references TableProductGSTDetails(Product_Gst_ID))
Insert into TableProductCategory values(11,'A type',1)
Insert into TableProductCategory values(12,'A type',1)
Insert into TableProductCategory values(13,'B type',2)
Insert into TableProductCategory values(14,'C type',3)
Insert into TableProductCategory values(15,'D type',4)
Insert into TableProductCategory values(16,'E type',5)
Insert into TableProductCategory values(17,'E type',5)


CREATE TABLE TableProduct(ProductID int primary key,ProductTypeID int,ProductName varchar(500))
Insert into TableProduct values(101,111,'Ashokkey')
Insert into TableProduct values(102,112,'Steel')
Insert into TableProduct values(103,113,'Sunfeast')
Insert into TableProduct values(104,114,'Hydrogen gas')
Insert into TableProduct values(105,115,'Bike Petrol')


CREATE TABLE TableInvoiceDetails(Invoice_Detail_Id int,Customer_Name varchar(500),Customer_Contact varchar(15),Product_Category_ID int,ProductID int,
Residential_Type_ID int,Invoice_Date datetime,Quantity decimal(10,2),Price decimal(10,2),CGST decimal(10,2),SGST decimal(10,2),IGST decimal(10,2),CGST_Value decimal(10,2),SGST_Value decimal(10,2),IGST_Value decimal(10,2),Total_Amount decimal(10,2),
foreign key(Product_Category_ID) references TableProductCategory (Product_Category_ID),foreign key(ProductID) references TableProduct (ProductID))
Insert into TableInvoiceDetails values(201,'Akash',9970758709,11,101,301,'2023-12-21',5,100,5,10,15,1,2,3,100)
Insert into TableInvoiceDetails values(202,'David',8878355282,11,101,302,'2023-12-22',6,800,5,10,15,1,2,6,200)
Insert into TableInvoiceDetails values(203,'Ashwin',7385067458,12,102,303,'2023-12-23',4,200,10,20,15,2,2,3,200)
Insert into TableInvoiceDetails values(204,'Yash',9753898259,13,103,304,'2023-12-24',2,100,15,20,25,5,6,5,500)
Insert into TableInvoiceDetails values(205,'Lucky',8007878390,14,104,305,'2023-12-25',9,500,20,25,30,8,9,3,600)
Insert into TableInvoiceDetails values(206,'Sujit',7385067458,15,105,306,'2023-12-26',5,300,25,30,35,2,3,5,700)
Insert into TableInvoiceDetails values(207,'Chetan',9860683859,15,105,307,'2023-12-27',7,200,25,30,35,2,6,3,800)


select * from TableProductGSTDetails
select * from TableProductCategory
select * from TableProduct
select * from TableInvoiceDetails