--DDl
create table Bikes
(
Modelid int not null primary key identity(1,1),
Models nvarchar(100)not null,
Price int not null,
color nvarchar(100) not null,
Mileage int not null,
Topspeed int not null,
);

drop table Bikes

select * from Bikes     

alter table Bikes
add Place nvarchar(200) null 
alter table Bikes
drop column Price



truncate table Bikes


           

--DML

select * from Bikes     
update Bikes set Models = 'Avter' where color ='Red'


insert into Bikes values('TVS',2000,'Red',65,120),
('Hero',1000,'Blue',55,100)

insert into Bikes values('Honda',2500,'Green',75,110)


update Bikes set Models = 'Avter' where color ='Red'

Delete Bikes where models='Honda'


select * from Bikes where
Models = 'TVS' and Color = 'red'

select * from Bikes where
Models = 'TVS' or Color = 'Yellow'

select * from Bikes where Price not in (2000,2500)

select * from Bikes where Price!=2000 and Price!=2500

select * from Bikes where Price in (1000)

select * from Bikes where Price between 1000 and 2100

select distinct *from Bikes

--asc/desc--
select *from Bikes
order by models Desc; 

--min/max

select Min (price) from Bikes


select *from Bikes
--sum--
select sum(price) as sum from Bikes


--avg--
select avg(price) as avg from Bikes 

--count--
select count (models) as count from bikes

--c# connection--

select * from Bikes     

insert into Bikes(Models,Price,Color) values ('Flio',3000,'Gold')

delete Bikes where models='flio'


--pk--

create table sales
(
salesid int not null primary key,
salesnumber int not null,
modelid int not null,
amount int not null
);

select * from sales

insert into sales values (1,1000,1,20000),
(2,250,3,30000),
(3,500,1,40000)

truncate table sales

drop table sales


select * from Bikes
select * from sales

--joins--
--inner joins--
select 
b.models,
b.Price,
b.Mileage,
ss.salesnumber,
ss.amount

from Bikes B inner join sales ss on b.modelid =ss.modelid

--left join--
select 
b.models,
b.Price,
b.Mileage,
ss.salesnumber,
ss.amount

from Bikes B left join sales ss on b.modelid =ss.modelid

--Rigth join--
select 
b.models,
b.Price,
b.Mileage,
ss.salesnumber,
ss.amount

from Bikes B Right join sales ss on b.modelid =ss.modelid

--outer join--
select 
b.models,
b.Price,
b.Mileage,
ss.salesnumber,
ss.amount

from Bikes B Full outer join sales ss on b.modelid =ss.modelid 

--group by--

create table RCB
(
Playersno int not null,
Names nvarchar(200) not null,
Age int  not null,
salary int not null,
Dept nvarchar(200) not null
);

select * from RCB
drop table rcb

insert into RCB  values (1,'Kholi',35,15,'Batting'),
(2,'ABD',37,15,'Batting'),
(3,'Kartick',37,5,'Batting'),
(4,'Fap du',38,8,'Batting'),
(5,'saraj',29,7,'Bowing'),
(6,'Halerwood',30,11,'Bowing'),
(7,'maxwel',31,14,'Batting')

select names from RCB order by salary desc

select names from RCB group by names 



--today--
create procedure  inserts(@models nvarchar (200),@Price int,@color nvarchar (200),@mileage int ,@Topspeed int)
as
begin
 
 insert into Bikes(models,Price,color,mileage,Topspeed) values (@models,@Price,@color,@mileage,@Topspeed)


 end
 Exec inserts @models,@Price,@color,@mileage,@Topspeed

 create procedure selects
 as
 begin

 select * from Bikes
 end

 Exec selects


 alter procedure updates(@color nvarchar (200),@mileage int)
 as
 begin
 update bikes 
 set
 Mileage = @mileage
 where
 color = @color
 end

 exec updates 'red',200


 
 
 create procedure d3delete (@del nvarchar (200))
 as
 begin

 delete  from bikes where models = @del
 end

 exec d3delete 'avter'

 select * from Bikes
select * from sales


