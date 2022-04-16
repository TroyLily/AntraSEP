use Northwind
go

select e.City
from Employees e
union
select c.City
from Customers c

select distinct c.City
from Customers c
where c.City not in (select City from Employees)
--2-b.
select distinct c.City
from Customers c left join Employees e on c.city = e.City

select od.ProductID, count(od.Quantity) Quantities
from [Order Details] od
group by od.ProductID

select c.City, count(ood.QuantityInOID) QuantityInCity
from Customers c join (
select o.CustomerID, o.OrderID, count(od.Quantity) QuantityInOID
from Orders o join [Order Details] od on o.OrderID = od.OrderID
group by o.CustomerID, o.OrderID
) ood on c.CustomerID = ood.CustomerID
group by c.City

select City
from Customers
group by City
having count(city) > 1

select c.City
from Customers c join (
select o.CustomerID, o.OrderID, count(od.ProductID) NumOfProduct
from Orders o join [Order Details] od on o.OrderID = od.OrderID
group by o.CustomerID, o.OrderID
) ood on c.CustomerID = ood.CustomerID
group by c.City
having count(ood.NumOfProduct) > 1

select distinct c.ContactName
from Customers c join Orders o on c.CustomerID = o.CustomerID
where c.City != o.ShipCity


select *
from Customers

select *
from [Order Details]
order by OrderID

select *
from Orders
order by CustomerID