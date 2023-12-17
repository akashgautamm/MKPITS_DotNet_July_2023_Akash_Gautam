create table Scientistt(Yearr int ,Subjectt varchar(20),Winner varchar(50),Country varchar(20),Category varchar(20))
insert into Scientistt values(1970,'Physics','Hannes Alfven','Sweden','scientist')
insert into Scientistt values(1970,'Physics','Louis Neel','France','scientist')
insert into Scientistt values(1972,'Chemistry','Luis Federico Leloir','France','scientist')
insert into Scientistt values(1970,'Physiology','Ulf von Euler','Sweden','scientist')
insert into Scientistt values(1973,'Physiology','Bernard Katz','Germony','scientist')
insert into Scientistt values(1971,'Economics','Paul Samuelson','Usa','scientist')
select Yearr,Subjectt,Winner from Scientistt where Yearr=1970
select Winner from Scientistt where Yearr=1971 
select Yearr,Subjectt from Scientistt where Winner='Bernard katz'


