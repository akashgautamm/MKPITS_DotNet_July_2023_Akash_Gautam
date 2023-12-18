create table Groups1(Sales_Id int identity primary key,Sales_Name varchar(20))
insert into Groups1 values('Amit')
insert into Groups1 values('Ajay')


create table Employe1(Emp_Id int identity Primary Key, Emp_Name varchar(20),
Sales_Id int not null constraint fk1 foreign key(Sales_Id) references Groups1(Sales_Id)on delete cascade)
insert into Employe1 values('Ashok',1)
insert into Employe1 values('Arjun',1)
insert into Employe1 values('Ashok',2)
insert into Employe1 values('Ashok',2)

select * from Groups1
select * from Employe1

delete from Groups1 where Sales_Id = 1;

delete from Groups1
delete from Employe1



