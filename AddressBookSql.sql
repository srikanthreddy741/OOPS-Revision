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