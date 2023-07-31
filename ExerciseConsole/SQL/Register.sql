create Table RegisterModels
(
Id int not null Primary key identity (1,1),
Firstname nvarchar (200) not null,
Lastname nvarchar (200) not null,
Age int not null,
Email nvarchar (300) not null,
Gender nvarchar (300) not null,
);

drop table RegisterModels

Alter procedure  inserts(@Firstname nvarchar (200),@Lastname nvarchar (200),@Age int,@Email nvarchar (300),@Gender nvarchar (300))
as
begin
 
 insert into RegisterModels(Firstname,Lastname,Age,Email,Gender) values (@Firstname,@Lastname,@Age,@Email,@Gender)


 end
 Exec inserts 'Ajay','Kumar',24,'ajay@123','Male'

 create procedure selects
 as
 begin

 select * from RegisterModels
 end

 Exec selects


alter procedure updates(@Id int,@Firstname nvarchar (200),@Lastname nvarchar (200),@Age int,@Email nvarchar (300),@Gender nvarchar (300))
 as
 begin
 update RegisterModels 
 set
 Firstname = @Firstname,
 Lastname =@Lastname,
 Age =@Age,
 Email =@Email,
 Gender =@Gender
 where
 Id=@Id
 end

 exec updates 1,'Ajay','Kumar',24,'Ajay@gmail.com','Male'


 
 
 create procedure deletes (@del nvarchar (200))
 as
 begin

 delete  from RegisterModels where Id = @del
 end

 exec deletes 1