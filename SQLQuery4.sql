use Northwind
go

create view ViewProductOrder
as 
select ProductID, sum(Quantity) Quantity
from [Order Details]
group by ProductID

SELECT *
FROM ViewProductOrder

create proc sp_product_order_quantity
@id int = 0, 
@num int out
as
begin
select @num = count(OrderID)
from [Order Details]
where ProductID = @id
group by ProductID
end
begin
declare @qua int
exec sp_product_order_quantity 21, @qua out
print @qua
end 

create proc sp_product_order_city
@PName varchar(20), 
@CName varchar(20) out
as
begin 
select c.City
from Customers c join 
	(
	select top 5 o.CustomerID, sum(odd.OrdQu) AllQu
	from Orders o join 
		(
		select od.OrderID, sum(od.Quantity) OrdQu
		from [Order Details] od join 
			(
			select ProductID
			from Products p
			where p.ProductName = @PName
			) pp on od.ProductID = pp.ProductID
		group by od.OrderID
		) odd on o.OrderID = odd.OrderID
	group by o.CustomerID
	order by sum(odd.OrdQu)
	) oo on c.CustomerID = oo.CustomerID
end
begin
declare @CityName varchar(20)
exec sp_product_order_city Chai, @CityName out
print @CityName
end 

create table people_your_last_name(
PplId int, 
PplName varchar(20), 
CityId int
)
create table city_your_last_name(
CityId int, 
CityName varchar(20)
)
insert into people_your_last_name values (1, 'Aaron Rodgers', 2)
insert into people_your_last_name values (2, 'Russell Wilson', 1)
insert into people_your_last_name values (3, 'Jody Nelson', 2)
insert into city_your_last_name values (1, 'Seattle')
insert into city_your_last_name values (2, 'Green Bay')

update city_your_last_name 
set CityName = 'Madison'
where CityName = 'Seattle'

create view Packers_your_name
as
select p.PplName
from people_your_last_name p join city_your_last_name c on p.CityId = c.CityId
where c.CityName = 'Green Bay'

select *
from Packers_your_name

drop table people_your_last_name, city_your_last_name
drop view Packers_your_name


create table birthday_employees(
EName varchar(20)
)

create proc sp_birthday_employees
@EName varchar(20)
as
begin 
insert into birthday_employees values (@EName)
end

begin 
declare @EMName varchar(20)
select @EMName = e.LastName
from Employees e
where Month(e.BirthDate) = 2
exec sp_birthday_employees @EMName
end

drop table birthday_employees

CHECKSUM TABLE original_table, backup_table;