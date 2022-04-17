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


drop proc sp_product_order_quantity

select * from Orders

select * from [Order Details]

select * from Products

select * from Customers
