use AdventureWorks2019
go

select count(*) NumberOfProduct
from Production.Product

select count(*) NumberOfProductSubcategory
from Production.Product pp inner join Production.ProductSubcategory pps on pp.ProductSubcategoryID = pps.ProductSubcategoryID

select pp.ProductSubcategoryID, count(pp.ProductSubcategoryID) CountedProducts
from Production.Product pp inner join Production.ProductSubcategory pps on pp.ProductSubcategoryID = pps.ProductSubcategoryID
where pp.ProductSubcategoryID is not null
group by pp.ProductSubcategoryID

select count(pp.ProductID) CountedProducts
from Production.Product pp left join Production.ProductSubcategory pps on pp.ProductSubcategoryID = pps.ProductSubcategoryID
where pp.ProductSubcategoryID is null

select sum(pp.Quantity) [sum of products quantity]
from Production.ProductInventory pp

select pp.ProductID, sum(pp.Quantity) TheSum
from Production.ProductInventory pp
where pp.LocationID = 40 and pp.Quantity < 100
group by pp.ProductID
order by pp.ProductID

select Shelf, ProductID, sum(Quantity) TheSum
from Production.ProductInventory 
where LocationID = 40 
group by ProductID, Shelf
having sum(Quantity) < 100

select ProductID, Shelf, avg(Quantity) TheAvg
from Production.ProductInventory
where LocationID = 10
group by ProductID, Shelf

select ProductID, Shelf, avg(Quantity) TheAvg
from Production.ProductInventory
group by ProductID, Shelf

select ProductID, Shelf, avg(Quantity) TheAvg
from Production.ProductInventory p
where p.Shelf != 'N/A'
group by ProductID, Shelf

--11
select Color, Class, count(ProductID) TheCount, avg(ListPrice) AvgPrice
from Production.Product
where Color is null or Class is null
group by Color, Class

select pc.Name Country, ps.Name Province
from Person.CountryRegion pc join Person.StateProvince ps on pc.CountryRegionCode = ps.CountryRegionCode

select pc.Name Country, ps.Name Province
from Person.CountryRegion pc join Person.StateProvince ps on pc.CountryRegionCode = ps.CountryRegionCode
where pc.name in ('Canada', 'Germany')

use Northwind
go

select distinct p.ProductName
from Products p join [Order Details] od on p.ProductID = od.ProductID join Orders o on o.OrderID = od.OrderID
order by p.ProductName

select top 5 o.ShipPostalCode [Zip Code]
from [Order Details] od join Orders o on o.OrderID = od.OrderID
group by o.ShipPostalCode
order by count(od.Quantity) desc

select top 5 o.ShipPostalCode [Zip Code]
from [Order Details] od join Orders o on o.OrderID = od.OrderID
where o.OrderDate >= '1997-01-01 00:00:00.000'
group by o.ShipPostalCode
order by count(od.Quantity) desc

select distinct c.City, count(c.City) [Number of customers]
from Customers c
group by c.City

select distinct c.City, count(c.City) [Number of customers]
from Customers c
group by c.City
having count(c.City) > 2

select distinct c.ContactName
from Customers c join Orders o on c.CustomerID = o.CustomerID
where o.OrderDate >= '1998-01-01 00:00:00.000'

select distinct c.ContactName, o.OrderDate
from Customers c join Orders o on c.CustomerID = o.CustomerID
order by o.OrderDate desc

select c.ContactName, sum(od.Quantity) Quantity
from Customers c join Orders o on c.CustomerID = o.CustomerID join [Order Details] od on o.OrderID = od.OrderID
group by c.ContactName

select c.CustomerID, sum(od.Quantity) Quantity
from Customers c join Orders o on c.CustomerID = o.CustomerID join [Order Details] od on o.OrderID = od.OrderID
group by c.CustomerID
having sum(od.Quantity) > 100

select su.CompanyName [Supplier Company Name], isnull(sh.CompanyName, 'N/A') [Shippers Company Name] 
from Shippers sh full join Suppliers su on sh.ShipperID = su.SupplierID

select p.ProductName, o.OrderDate
from Products p join [Order Details] od on p.ProductID = od.ProductID join Orders o on o.OrderID = od.OrderID

select e.FirstName + ' ' + e.LastName [Employee name], m.FirstName + ' ' + m.LastName [Employee name]
from Employees e join Employees m on e.Title = m.Title
where e.EmployeeID != m.EmployeeID

select e.FirstName
from Employees e left join Employees r on e.EmployeeID = r.ReportsTo
group by e.FirstName
having count(r.ReportsTo) > 2

select c.City, c.CompanyName [Name], c.ContactName [Contact Name], c.Relationship [Type]
from [Customer and Suppliers by City] c
