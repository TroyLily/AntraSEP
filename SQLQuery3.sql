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

select c.City, sum(ood.QuantityInOID) QuantityInCity
from Customers c join (
select o.CustomerID, o.OrderID, sum(od.Quantity) QuantityInOID
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

select p.ProductID, pqam.QuantitiesPerProduct, pqam.AvgPrice, c.City
from Customers c join Orders o on c.CustomerID = o.CustomerID join (
select top 5 od.ProductID, count(od.Quantity) QuantitiesPerProduct, 
	avg(od.UnitPrice * od.Quantity * (1 - od.Discount)) AvgPrice, max(od.OrderID) MaxOrderID
from [Order Details] od
group by od.ProductID
order by count(od.Quantity) desc) pqam on o.OrderID = pqam.MaxOrderID join Products p on pqam.ProductID = p.ProductID
 
select e.city
from Employees e
where e.City in (
select c.City
from Customers c
where c.CustomerID not in (select CustomerID from Orders))

select k.City
from (
select top 1 c.City
from Customers c join (
select o.CustomerID, o.OrderID, sum(od.Quantity) QuantityInOID
from Orders o join [Order Details] od on o.OrderID = od.OrderID
group by o.CustomerID, o.OrderID
) ood on c.CustomerID = ood.CustomerID
group by c.City
order by sum(ood.QuantityInOID) desc) k join (
select top 1 c.City
from Customers c join (
select o.CustomerID, count(o.OrderID) COID
from Orders o 
group by o.CustomerID
) oo on c.CustomerID = oo.CustomerID
group by c.City
order by sum(oo.COID) desc) kk on k.City = kk.City
group by k.City, kk.City
having k.City = kk.City

Find duplicate rows using ROW_NUMBER() function and use DELETE statement to remove the duplicate rows.