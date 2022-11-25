create database Addressbook1

create Table AddressBook1
(
Id int primary key Identity(1,1),
FirstName varchar(100),
LastName varchar(100),
Email varchar(100),
Mobile varchar(100),
Address varchar(100),
City varchar(100),
State varchar(100),
Pincode varchar(100)
)

create procedure SpAddressBook
(
@FirstName varchar(150),
@LastName varchar(150),
@Email varchar(150),
@Mobile varchar(150),
@Address varchar(150),
@City varchar(150),
@State varchar(150),
@Pincode varchar(150)
)
as
begin
insert into AddressBook1 values(@FirstName,@LastName,@Email,@Mobile,@Address,@City,@State,@Pincode)
end

select * from Addressbook1

create procedure getAddressBook
as
begin
select * from Addressbook1
end

alter procedure UpdateAddressBook(
@Id int,
@FirstName varchar(100),
@LastName varchar(100),
@Email varchar(100),
@Mobile varchar(100),
@Address varchar(100),
@City varchar(100),
@State varchar(100),
@Pincode varchar(100)
)
as
begin
update AddressBook1 set FirstName=@FirstName, LastName=@LastName, Email=@Email, Mobile=@Mobile, Address=@Address, City=@City, State=@State, Pincode=@Pincode where Id=@Id;
end

create procedure DeleteAddressBook(
@Id int
)
as
begin
delete from AddressBook1 where Id=@Id;
end




create table UserRegister(
Id int primary key Identity(1,1),
FirstName varchar(255),
LastName varchar(255),
Email varchar(255),
Password varchar(255)
)

create procedure SpUserRegister(
@FirstName varchar(255),
@LastName varchar(255),
@Email varchar(255),
@Password varchar(255)
)
as
begin
insert into UserRegister values(@FirstName,@LastName,@Email,@Password)
end

create procedure SpUserselect(
@Email varchar(255)
)
as
begin
select * from UserRegister where Email=@Email;
end

create procedure SpUserPassword(
@password varchar(100)
)
as 
begin
select * from UserRegister where Password=@password;
end