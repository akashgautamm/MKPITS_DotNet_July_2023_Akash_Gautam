create table Vendor_Groups(Group_Id int identity primary key,Group_Name varchar(20))
insert into Vendor_Groups values ('Ashok'),('Asian'),('Ayodhya'),('Ashwin')

create table Vendors(Vendor_Id int identity,Vendor_Name varchar(20),Vendor_Quantity int,
             Group_Id int not null constraint cs foreign key(Group_Id) references Vendor_Groups(Group_Id)
			 on delete cascade)
insert into Vendors Values('Amit',2,5)
insert into Vendors Values('Asram',4,5)
insert into Vendors Values('Akash',3,5)
insert into Vendors Values('Akash',3,4)
insert into Vendors Values('Akash',3,4)

delete from Vendor_Groups where Group_Id=4
select *from Vendors
select *from Vendor_Groups

