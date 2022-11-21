create database sqlpayroll

use sqlpayroll

create table  sqlpayroll
(
id int identity(1,1) primary key, 
name varchar(100) not null,
address varchar(100) not null,
email varchar(100) not null,
phonenumber varchar (10) not null,
pincode varchar(10) not null
)

insert into sqlpayroll values
('sri',3-48,'b@gmail.com',9000175741,503111)

insert into sqlpayroll values
('ram',5-48,'ram@gmail.com',8746175741,503101),
('reddy',5-48,'reddy@gmail.com',8746145839,503101),
('raju',5-48,'raju@gmail.com',9346175741,503101),
('rakesh',5-48,'rakesh@gmail.com',9746175741,503101)

select * from sqlpayroll

Alter table sqlpayroll add gender char(1)

update sqlpayroll set name='sri' where id=1
update sqlpayroll set gender='M' where name='sri' or name='ram';
update sqlpayroll set gender='M' where name='reddy';
update sqlpayroll set gender='M' where name ='raju' or name='rakesh'

Alter table sqlpayroll drop Column address
 alter table sqlpayroll add salary varchar(20);
 alter table sqlpayroll drop column salary
 alter table sqlpayroll add salary money
 update sqlpayroll set salary=24000 where name= 'sri'  or name= 'rakesh'
  update sqlpayroll set salary=44000 where name= 'reddy'  or name= 'raju'
 update sqlpayroll set salary=34000 where name= 'ram'  

 select sum(salary) from sqlpayroll group by gender
 select avg(salary) from sqlpayroll group by gender
 select min(salary) from sqlpayroll group by gender
 select max (salary) from sqlpayroll group by gender

select * from sqlpayroll

---stored procedure---
create proc spgetEmployee
AS
BEGIN
    Select name, gender  from sqlpayroll
END

spgetEmployee

Execute spgetEmployee
alter table sqlpayroll add department int
update sqlpayroll set department=1 where name= 'sri'
update sqlpayroll set department=2 where name= 'ram'
update sqlpayroll set department=1 where name= 'reddy'
update sqlpayroll set department=2 where name= 'rakesh'
update sqlpayroll set department=2 where name= 'raju'

select * from sqlpayroll

create proc spgetemployeebygenderanddepartment
@gender varchar(20),
@department int
as
begin
 select name,gender, department from sqlpayroll where gender=@gender and department=@department 
 end

 spgetemployeebygenderanddepartment 'm',1
 select * from sqlpayroll
 select * from tblsqlpayrollaudit
 
 alter trigger  tr_sqlpayroll_forinsert
 on sqlpayroll
 for insert
 as
 begin
       declare @id int
	   select @id =id from inserted
	   insert into tblsqlpayrollaudit
	   values('new employee with id =' +cast(@id as nvarchar(5)) + 'is added at' + cast(getdate() as nvarchar(20)))
 end

 insert into sqlpayroll values ('shirisha','shirish@gmail.com',7890536478,504321,'f',28000,1)

   ---string function---
  select '    hello world'
  select LTRIM('    hello world')

  select 'helloworld'
  select UPPER('helloworld')

  select  'wellcome to hello world'
  select reverse ('wellcome to hello world')

  select 'HELLO WORLD'
  select LOWER('HELLO WORLD')

  select 'wellcome to hello world'
  select substring('wellcome to hello world', 13,5)
 